using AutoMapper;
using GalaxyAuction_Business.Abstraction;
using GalaxyAuction_Business.Dtos;
using GalaxyAuction_Core.MailHelper;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyAuction_Business.Concrete
{
	public class BidService : IBidService
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;
		private readonly ApiResponse response;
		private readonly IMailService _mailService;


		public BidService(ApplicationDbContext context,IMailService mailService ,IMapper mapper, ApiResponse response)
		{
			this.context = context;
			this.mapper = mapper;
			this.response = response;
			_mailService = mailService;
		}
		public async Task<ApiResponse> AutomaticallyCreateBid(CreateBidDto model)
		{
			
			var isPaid = await CheckIsPaidAction(model.UserId,model.VehicleId);
			if (!isPaid)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("Please before pay auction price");
				return response;
			}

			var result = await context.Bids.Where( x => x.VehicleId == model.VehicleId && x.Vehicle.IsActive == true ).OrderByDescending(x => x.BidAmount).ToListAsync();
			if (result.Count == 0)
			{
				response.IsSuccess = false;
				return response;

			}
			var objData = mapper.Map<Bid>(model);
			objData.BidAmount = result[0].BidAmount + (result[0].BidAmount * 10) / 100;
			objData.BidDate = DateTime.Now;
			context.Bids.Add(objData);
			await context.SaveChangesAsync();
			response.IsSuccess = true;
			response.Result = result;
			return response;

		}

		public Task<ApiResponse> CancelBid(int bidId)
		{
			throw new NotImplementedException();
		}

		public async Task<ApiResponse> CreateBid(CreateBidDto model)
		{
			var returnValue = await CheckIsActive(model.VehicleId);
			var isPaid = await CheckIsPaidAction(model.UserId, model.VehicleId);

			//if (!isPaid)
			//{
			//	response.IsSuccess = false;
			//	response.ErrorMessages.Add("Please before pay auction price");
			//	return response;
			//}

			if (returnValue == null)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("This car is not active"); 
				return response;
			}
			if (returnValue.Price >= model.BidAmount)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("You should surpass the highest bid in the placed bids");
				return response;
			}
			if (model != null)
			{
				var topPrice = await context.Bids.Where(x => x.VehicleId == model.VehicleId).OrderByDescending(x => x.BidAmount).ToListAsync();
				if (topPrice.Count != 0)
				{
					if (topPrice[0].BidAmount >= model.BidAmount)
					{
						response.IsSuccess = false;
						response.ErrorMessages.Add("Entry bid amount, not lower than higher price to the system; higher price is " + topPrice[0].BidAmount);
						return response;
					}

				}
                Bid bid = mapper.Map<Bid>(model);
				bid.BidDate = DateTime.Now;
				await context.Bids.AddAsync(bid);
				if (await context.SaveChangesAsync() > 0)
				{
					var userDetail = await context.Bids.Include(x => x.User).Where(x=> x.UserId == model.UserId).FirstOrDefaultAsync();
					_mailService.SendEmail("Your bid is success", "Your bid is: " + bid.BidAmount, bid.User.UserName);
					response.IsSuccess = true;
					response.Result = model;
					return response;
				}

			}

			response.IsSuccess = false;
			response.ErrorMessages.Add("Ooops! Something went wrong");
			return response;
        }

		public async Task<ApiResponse> GetBidById(int bidId)
		{

			var result = await context.Bids.Include(x => x.User).Where(x => x.BidId == bidId).FirstOrDefaultAsync();
			if(result == null)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("Bid is not found ");
				return response;
			}

			response.IsSuccess = true;
			response.Result = result;
			return response;

		}

		public async Task<ApiResponse> GetBidByVehicleId(int vehicleId)
		{
			
			var obj = await context.Bids.Where(x => x.VehicleId == vehicleId).ToListAsync();
			if (obj != null)
			{
				response.IsSuccess = true;
				response.Result = obj;
				return response;
			}
			response.IsSuccess = false;
			return response;
		}

		public async Task<ApiResponse> UpdateBid(int bidId, UpdateBidDto model)
		{

			//Update eden kullanıcı en son verdiği teklifin üzerine çıkmalıdır.
			var isPaid = await CheckIsPaidAction(model.UserId, model.VehicleId);
			if (!isPaid)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("Please before pay auction price");
				return response;

			}
			var result = await context.Bids.FindAsync(bidId);
			if (result == null)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("Bid is not found");
				return response;
			}
			if (result.BidAmount < model.BidAmount && result.UserId == model.UserId)
			{
				var objData = mapper.Map(model, result);
				objData.BidDate = DateTime.Now;
				response.IsSuccess = true;
				response.Result = objData;
				await context.SaveChangesAsync();
				return response;
			}
			else if (result.BidAmount >= model.BidAmount)
			{
				response.IsSuccess = false;
				response.ErrorMessages.Add("You are not entry low price than your old bid amount, your older bid amount is : " + result.BidAmount);
				return response;
			}

			response.IsSuccess = false;
			response.ErrorMessages.Add("Something went wrong");
			return response;


		}



		private async Task<Vehicle> CheckIsActive(int vehicleId)
		{
			var obj = await context.Vehicles.Where(x => x.VehicleId == vehicleId && x.IsActive == true && x.EndTime >= DateTime.Now).FirstOrDefaultAsync();
			if (obj != null)
			{
				return obj;
			}
			return null;
		}


		private async Task<bool> CheckIsPaidAction(string userId, int vehicleId)
		{
			var obj = await context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
			if (obj != null)
			{
				return true;
			}
			return false;
		}
	}
}

using AutoMapper;
using GalaxyAuction_Business.Abstraction;
using GalaxyAuction_Business.Dtos;
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
	public class PaymentHistoryService : IPaymentHistoryService
	{
		ApiResponse _response;
		ApplicationDbContext _context;
		IMapper _mapper;
		public PaymentHistoryService(ApiResponse response,ApplicationDbContext context,IMapper mapper) 
		{ 
			_response = response;
			_context = context;
			_mapper = mapper;
		}
		public async Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId)
		{

			var response = await _context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
			if (response != null)
			{
				_response.IsSuccess = true;
				_response.Result = response;
				return _response;
			}
			_response.IsSuccess = false;
			return _response;
		}

		public async Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDto model)
		{
			if (model == null)
			{
				_response.IsSuccess = false;
				_response.ErrorMessages.Add("Model is not include some fields");
				return _response;
			}
			else
			{
				var objDto = _mapper.Map<PaymentHistory>(model);
				objDto.PayDate = DateTime.Now;
				objDto.IsActive = true;
				_context.PaymentHistories.Add(objDto);
				if(await _context.SaveChangesAsync()>0)
				{
					_response.IsSuccess=true;
					_response.Result = objDto;	
					return _response;	
				}
				_response.IsSuccess = false;
				_response.ErrorMessages.Add("Ooops! Something went wrong");
				return _response;
			}
		}
	}
}

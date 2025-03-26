using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concrete
{
	public class VehicleService : IVehicleService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;
		private ApiResponse _response;


		public VehicleService(ApplicationDbContext context,ApiResponse response ,IMapper mapper ) 
		{
			_response = response;
		    _context = context;
			_mapper = mapper;
		
		}

		public async Task<ApiResponse> ChangeVehicleStatus(int vehicleId)
		{
		     var result = await _context.Vehicles.FindAsync(vehicleId);
			if (result == null)
			{
				_response.IsSuccess = false;
				return _response;
			}
			else
			{
				result.IsActive = true;
				_response.IsSuccess = true;
				await _context.SaveChangesAsync();
				return _response;
			}
		}

		public async Task<ApiResponse> CreateVehicle(CreateVehicleDto model)
		{
			if(model != null)
			{
				var objDTO = _mapper.Map<Vehicle>(model);
				if (objDTO != null)
				{
					_context.Vehicles.Add(objDTO);
					if(await _context.SaveChangesAsync() > 0)
					{
						
						_response.IsSuccess = true;
						_response.Result = model;
						_response.StatusCode = System.Net.HttpStatusCode.Created;
						return _response;
						Console.WriteLine("Araç başarıyla eklendi!");
					}
				}
			}

			_response.IsSuccess = false;
			_response.ErrorMessages.Add("Ooops! Something went wrong");
			return _response;
		}

		public async Task<ApiResponse> DeleteVehicle(int vehicleId)
		{
			var result = await _context.Vehicles.FindAsync(vehicleId);
			if(result != null)
			{
				_context.Vehicles.Remove(result);
				if (await _context.SaveChangesAsync() > 0)
				{
					_response.IsSuccess = true;
					return _response;
				}	
			}

			_response.IsSuccess = false ;
			return _response;
		}

		public async Task<ApiResponse> GetVehicleById(int vehicleId)
		{
			var result = await _context.Vehicles.Include(x=>x.Seller).Include(x => x.Bids).FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
			if (result != null)
			{
				_response.Result = result;
				_response.IsSuccess= true;
				return _response;
			}
			_response.IsSuccess = false ;
			return _response;
		}

		public async Task<ApiResponse> GetVehicles()
		{
			var vehicle = await _context.Vehicles.Include(x=> x.Seller).ToListAsync();
			if (vehicle != null)
			{
				_response.Result = vehicle;
				_response.IsSuccess = true;
				return _response;
			}
			_response.IsSuccess = false ;
			return _response;
		}

		public async Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDto model)
		{
			var result = await _context.Vehicles.FindAsync(vehicleId);
			if (result != null)
			{
				Vehicle objDTO = _mapper.Map(model, result);
				if (await _context.SaveChangesAsync() > 0)
				{
					_response.Result = objDTO;
					_response.IsSuccess = true;
					return _response;
				}
				
			}

			_response.IsSuccess = false;
			return _response;
		}
	}
}

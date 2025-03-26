using GalaxyAuction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyAuction_Business.Abstraction
{
	public interface IPaymentHistoryService
	{
		Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDto model);
		Task<ApiResponse> CheckIsStatusForAuction(string userId,int vehicleId);
	}
}

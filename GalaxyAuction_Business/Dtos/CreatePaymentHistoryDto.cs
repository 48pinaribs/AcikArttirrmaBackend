using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyAuction_Business.Dtos
{
	public class CreatePaymentHistoryDto
	{
		public string ClientSecret { get; set; }
		public string StripePaymentIntentId { get; set; }
		public string UserId { get; set; }
		public int VehicleId { get; set; }
	}
}

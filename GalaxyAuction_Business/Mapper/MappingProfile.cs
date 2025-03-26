using AutoMapper;
using GalaxyAuction_Business.Dtos;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Mapper
{
	internal class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<CreateVehicleDto, Vehicle>().ReverseMap();
			CreateMap<UpdateVehicleDto, Vehicle>().ReverseMap();
			CreateMap<CreateBidDto, Bid>().ReverseMap();
			CreateMap<UpdateBidDto, Bid>().ReverseMap();
			CreateMap<CreatePaymentHistoryDto, PaymentHistory>().ReverseMap();
		}
	}
}

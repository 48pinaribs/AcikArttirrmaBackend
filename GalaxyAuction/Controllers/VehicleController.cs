﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using System.Net;

namespace MyGalaxy_Auction.Controllers
{
	[Route("api/[controller]")]
	[ApiController]


	public class VehicleController : ControllerBase
	{

		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly IVehicleService _vehicleService;
		public VehicleController(IVehicleService vehicleService , IWebHostEnvironment webHostEnvironment)
		{
			_vehicleService = vehicleService;
			_webHostEnvironment = webHostEnvironment;
		}



		[HttpPost("CreateVehicle")]
		public async Task<IActionResult> AddVehicle([FromForm]CreateVehicleDto model)
		{
			if (ModelState.IsValid)
			{
				if (model.File == null || model.File.Length == 0)
				{ 
					return BadRequest();
				}

				string uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "Images");
				string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.File.FileName)}";
				string filePath = Path.Combine(uploadsFolder, fileName);
				model.Image = fileName;

				var result = await _vehicleService.CreateVehicle(model);
				if (result.IsSuccess)
				{
					using (var fileStream = new FileStream(filePath, FileMode.Create))
					{
						await model.File.CopyToAsync(fileStream);
					}
					return Ok(result);
				}

			}
			return BadRequest();
		}


		
		[HttpGet("GetVehicles")]
		public async Task<IActionResult> GetAllVehicles()
		{
			var vehicles = await _vehicleService.GetVehicles();
			return Ok(vehicles);
		}




		[HttpPut("UpdateVehicle")]
		public async Task<IActionResult> UpdateVehicle(int vehicleId ,[FromForm] UpdateVehicleDto model)
		{
			if (ModelState.IsValid)
			{
				var result = await _vehicleService.UpdateVehicleResponse(vehicleId, model);
				if (result.IsSuccess)
				{
					return Ok(result);
				}

			}
			return BadRequest();
		}


		[Authorize(Roles = "Administrator")]
		[HttpDelete("{vehicleId}")]
		public async Task<IActionResult> DeleteVehicle([FromRoute]int vehicleId)
		{
			    
			    var result = await _vehicleService.DeleteVehicle(vehicleId);
				if (result.IsSuccess)
				{
					return Ok(result);
				}
				return BadRequest();
			
		}



		[HttpGet("{vehicleId}")]
		public async Task<IActionResult> GetVehicleById([FromRoute]int vehicleId)
		{

			var result = await _vehicleService.GetVehicleById(vehicleId);
			if (result.IsSuccess)
			{
				return Ok(result);
			}
			return BadRequest();

		}




		[HttpPut("{vehicleId}")]
		public async Task<IActionResult> ChanceStatus([FromRoute]int vehicleId)
		{

			var result = await _vehicleService.ChangeVehicleStatus(vehicleId);
			if (result.IsSuccess)
			{
				return Ok(result);
			}
			return BadRequest();

		}


	}
}
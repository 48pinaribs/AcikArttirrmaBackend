using GalaxyAuction_Business.Abstraction;
using GalaxyAuction_Business.Dtos;
using GalaxyAuction_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyAuction.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentHistoryController : ControllerBase
	{
		private readonly IPaymentHistoryService _paymentHistoryService;
		public PaymentHistoryController(IPaymentHistoryService paymentHistoryService)
		{
			_paymentHistoryService = paymentHistoryService;
		}

		[HttpPost("AddHistory")]
		public async Task<ActionResult> CreatePaymentHistory(CreatePaymentHistoryDto model)
		{
			if (ModelState.IsValid)
			{
				var response = await _paymentHistoryService.CreatePaymentHistory(model);
				if (!response.IsSuccess)
				{
					return BadRequest(response);
				}
				return Ok(response);
			}
			return BadRequest();

		}


		[HttpPost("CheckStatus")]
		public async Task<ActionResult> CheckStatusAuction(CheckStatusModel model)
		{
		
				var response = await _paymentHistoryService.CheckIsStatusForAuction(model.UserId,model.VehicleId);
				return Ok(response);

		}

	}
}

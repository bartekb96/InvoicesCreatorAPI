using InvoicesCreator.Application.Features.SellerFeatures.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.RestAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class SellersController : BaseController
    {
        public SellersController()
        {
            
        }

        /// <summary>
        /// Tworzy nowego spryedawc
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateSeller")]
        public async Task<IActionResult> CreateSeller(CreateSellerCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Nie udało się utworzyć nowego sprzedawcy");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }
    }
}

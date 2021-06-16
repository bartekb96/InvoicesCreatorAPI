using InvoicesCreator.Application.Features.ContractorFeatures.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.RestAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ContractorController : BaseController
    {
        public ContractorController()
        {

        }

        /// <summary>
        /// Tworzy nowego kontrahenta
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateContractor")]
        public async Task<IActionResult> CreateContractor(CreateContractorCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Nie udało się utworzyć nowego kontrahenta");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }

    }
}

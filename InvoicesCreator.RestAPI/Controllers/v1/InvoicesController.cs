using AutoMapper;
using InvoicesCreator.Application.Features.ContractorFeatures.Queries;
using InvoicesCreator.Application.Features.InvoiceFeatures.Commands;
using InvoicesCreator.Application.Features.InvoiceFeatures.Queries;
using InvoicesCreator.Application.Features.SellerFeatures.Queries;
using InvoicesCreator.RestAPI.Contracts.v1;
using InvoicesCreator.RestAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.RestApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class InvoicesController : BaseController
    {
        private readonly IMapper _mapper;

        public InvoicesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Zwraca wszystkie faktury sprzedawcy o podanym ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetInvoicesBySellerId/{usersId}")]
        public async Task<IActionResult> GetSInvoicesBySellerId(int usersId)
        {
            try
            {
                var result = await Mediator.Send(new GetInvoicesBySellersIdQuery{ SellersID  = usersId });

                if(result != null)
                {
                    return Ok(result);
                }

                return NotFound("Nie odnaleziono faktur sprzedawcy o podanym ID");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }

        /// <summary>
        /// Zwraca fakture o podanym ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetInvoiceById/{id}")]
        public async Task<IActionResult> GetInvoiceById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetInvoiceByIdQuery { InvoiceId = id });

                if (result != null)
                {
                    return Ok(result);
                }

                return NotFound("Nie odnaleziono faktury o podanym ID");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }

        /// <summary>
        /// Tworzy nową fakturę
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateInvoice")]
        public async Task<IActionResult> CreateInvoice(CreateInvoiceCommand command)
        {
            try
            {
                //var contractor = await Mediator.Send(new GetContractorByIdQuery { ContractorId = command.ContractorID });

                //if (contractor == null)
                //{
                //    return NotFound("Nie odnaleziono kontrahenta o podanym ID");
                //}

                //var seller = await Mediator.Send(new GetSellerByIdQuery { SellerId = command.SellerID });

                //if (seller == null)
                //{
                //    return NotFound("Nie odnaleziono sprzedawcy o podanym ID");
                //}

                var result = await Mediator.Send(command);

                var userResponse = _mapper.Map<InvoiceResponse>(result);

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Nie udało się utworzyć nowej faktury");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }

        /// <summary>
        /// Aktualizuje fakturę
        /// </summary>
        /// <returns></returns>
        [HttpPut("UpdateInvoice/{id}")]
        public async Task<IActionResult> UpdateInvoice(int id, UpdateInvoiceCommand command)
        {
            try
            {
                if(id != command.Invoice.Id)
                {
                    return BadRequest("Podane Id nie są zgodne");
                }

                var result = await Mediator.Send(command);

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Nie udało się utworzyć nowej faktury");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }

        /// <summary>
        /// Aktualizuje nową fakturę
        /// </summary>
        /// <returns></returns>
        [HttpDelete("DeleteInvoice/{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            try
            {
                var result = await Mediator.Send(new DeleteInvoiceCommand { InvoiceId = id});

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Nie udało się usunąć faktury");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }
    }
}

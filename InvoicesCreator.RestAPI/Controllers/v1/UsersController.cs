using AutoMapper;
using InvoicesCreator.Application.Features.UserFeatures.Commands;
using InvoicesCreator.Application.Features.UserFeatures.Queries;
using InvoicesCreator.RestAPI.Contracts.v1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.RestAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UsersController : BaseController
    {
        private readonly IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Tworzy nowego użytkownika
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(CreateNewUserCommand command)
        {
            try
            {
                var email = await Mediator.Send(new GetUserByEmailQuery { UserEmail = command.Email });

                if(email != null)
                {
                    return BadRequest("Istnieje już konto o podanym adresie email!");
                }

                var userName = await Mediator.Send(new GetUserByUsernameQuery { UserName = command.UserName });

                if (userName != null)
                {
                    return BadRequest("Juz istnieje użytkownik o podanej nazwie!");
                }

                var result = await Mediator.Send(command);

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Nie udało się utworzyć nowego użytkownika");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }

        /// <summary>
        /// Loguje użytkownika
        /// </summary>
        /// <returns></returns>
        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn(UserLogInQuery query)
        {
            try
            {
                var result = await Mediator.Send(query);

                var userResponse = _mapper.Map<UserResponse>(result);

                if (userResponse != null)
                {
                    return Ok(userResponse);
                }

                return BadRequest("Niepoprawny login lub hasło");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Błąd bazy danych!");
            }
        }
    }
}

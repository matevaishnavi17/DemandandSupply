using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SupplyDemandAPI.Models.DTO;
using SupplyDemandAPI.Repository;
using SupplyDemandAPI.Models;
using System.Threading.Tasks;
using System;


namespace SupplyDemandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly ILogin userRepository;
        private readonly IToken handler;
       

        public LoginController(ILogin userRepository, IToken handler)
        {
            this.userRepository = userRepository;
            this.handler = handler;
            
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync(UserLogin loginRequestDTO)
        {
            try
            {
                if (loginRequestDTO.Email == null && loginRequestDTO.Password == null && loginRequestDTO.Role == null)
                {
                    return NotFound("username or password is null");
                }
                //we check if user is authenticated which is check the username and password is present 
                // in our database.
                var user = await userRepository.AuthenticateUserAsync(loginRequestDTO.Email, loginRequestDTO.Password, loginRequestDTO.Role);
                if (user != null)
                {
                    //generate jwt token
                    var token = handler.CreateTokenAsync(user);
                    
                    return Ok(token);
                }
                return BadRequest("Email or password is incorrect or role is incorrect");
            }

            catch (Exception e)
            {
                return BadRequest("Error in Controller method LoginAsync"+ e);
            }
        }
         [HttpPost]
        public async Task<IActionResult> AddLoginDetails(Login loginTableDTO)
        {
            try
            {
                
                await userRepository.AddLoginDetailsAsync(loginTableDTO);
                if (loginTableDTO != null)
                {
                    return Ok("Success");

                }
                return Ok("Failure");
            }
            catch (Exception e)
            {
                return BadRequest("Error in Controller method AddLoginDetails" + e);
            }
            return Ok(loginTableDTO);
        }
    }
}
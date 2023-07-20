using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemandAndSupply_FileUpload.Models;
using DemandAndSupply_FileUpload.Repository;
using DemandAndSupply_FileUpload.DTO;


namespace DemandAndSupply_FileUpload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public async Task<IActionResult> LoginAsync(UserLoginDTO loginRequestDTO)
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
         [Route("Registration")]
        public async Task<IActionResult> AddLoginDetails(LoginRegistration loginTableDTO)
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
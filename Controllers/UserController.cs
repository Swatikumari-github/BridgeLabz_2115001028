using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("UserRegister")]
    public class UserController : ControllerBase
    {
        private readonly RegisterHelloBL _registerHelloBl;

        public UserController(RegisterHelloBL registerHelloBl)
        {
            _registerHelloBl = registerHelloBl;
        }

        // Register API
        [HttpPost("register")]
        public IActionResult RegisterUser(RegisterDTO registerDTO)
        {
            try
            {
                ResponseModel<string> response = _registerHelloBl.RegisterUser(registerDTO);
                return response.Success ? Ok(response) : Conflict(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel<string>(false, "Registration failed", ex.Message));
            }
        }

        //  Login API
        [HttpPost("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                ResponseModel<string> response = _registerHelloBl.LoginUser(loginDTO);
                return response.Success ? Ok(response) : Unauthorized(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel<string>(false, "Login failed", ex.Message));
            }
        }
    }
}
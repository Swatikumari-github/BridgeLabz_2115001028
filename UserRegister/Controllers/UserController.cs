using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("UserRegister")]
    public class UserController : ControllerBase
    {
        private readonly IRegisterHelloBL _registerHelloBl;
        private readonly ILogger<UserController> _logger;

        // Constructor with ILogger Injection
        public UserController(IRegisterHelloBL registerHelloBl, ILogger<UserController> logger)
        {
            _registerHelloBl = registerHelloBl;
            _logger = logger;
        }

        // Register API
        [HttpPost("register")]
        public IActionResult RegisterUser(RegisterDTO registerDTO)
        {
            _logger.LogInformation($"Received registration request for: {registerDTO.Email}");
            try
            {
                ResponseModel<string> response = _registerHelloBl.RegisterUser(registerDTO);
                if (response.Success)
                {
                    _logger.LogInformation($"User {registerDTO.Email} registered successfully.");
                    return Ok(response);
                }
                else
                {
                    _logger.LogWarning($"Registration failed for {registerDTO.Email}.");
                    return Conflict(response);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in RegisterUser: {ex.Message}");
                return BadRequest(new ResponseModel<string>(false, "Registration failed", ex.Message));
            }
        }

        //  Login API
        [HttpPost("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)

        {
            _logger.LogInformation($"Login request received for {loginDTO}");

            try
            {
                ResponseModel<string> response = _registerHelloBl.LoginUser(loginDTO);
                if (response.Success)
                    _logger.LogInformation($"User {loginDTO} logged in successfully.");
                else
                    _logger.LogWarning($"Login failed for {loginDTO}");

                return response.Success ? Ok(response) : Unauthorized(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in LoginUser: {ex.Message}");

                return BadRequest(new ResponseModel<string>(false, "Login failed", ex.Message));
            }
        }
    }
}
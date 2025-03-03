using System;
using System.Collections.Generic;
using System.Linq;
using ModelLayer.DTO;
using RepositoryLevel.Interface;
using BusinessLayer.Interface;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
        // In-memory list for storing registered users
        private static List<RegisterDTO> users = new List<RegisterDTO>();
        private readonly ILoggerService<RegisterHelloRL> _loggerService;
        // Register User

        public RegisterHelloRL(ILoggerService<RegisterHelloRL> loggerService)
        {
            _loggerService = loggerService;
        }

        public bool AddUser(RegisterDTO registerDTO, out string message)
        {
            try
            {
                if (users.Any(u => u.Username == registerDTO.Username || u.Email == registerDTO.Email))
                {
                    message = "User already exists";
                    _loggerService.LogWarning($"Register failed: User {registerDTO.Username} already exists.");
                    return false;
                }

                users.Add(registerDTO);
                message = "User registered successfully";
                _loggerService.LogInfo($"User {registerDTO.Username} registered successfully.");
                return true;
            }
            catch (Exception ex)
            {
                _loggerService.LogError("Error while registering user.", ex);
                message = $"Error: {ex.Message}";
                return false;
            }
        }

        // Validate Login
        public bool ValidateUser(LoginDTO loginDTO, out string message)
        {
            try
            {
                var user = users.FirstOrDefault(u => u.Username == loginDTO.username);

                if (user == null)
                {
                    message = "User not found";
                    _loggerService.LogWarning($"Login failed: User {loginDTO.username} not found.");
                    return false;
                }
                if (user.Password != loginDTO.password)
                {
                    message = "Invalid password";
                    _loggerService.LogWarning($"Login failed: Incorrect password for {loginDTO.username}.");
                    return false;
                }

                message = "Login successful";
                _loggerService.LogInfo($"User {loginDTO.username} logged in successfully.");
                return true;
            }
            catch (Exception ex)
            {
                _loggerService.LogError("Error while validating user login.", ex);
                message = $"Error: {ex.Message}";
                return false;
            }
        }
    }
}


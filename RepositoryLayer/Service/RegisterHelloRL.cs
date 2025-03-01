using System.Collections.Generic;
using System.Linq;
using ModelLayer.DTO;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL
    {
        //  In-memory list for storing registered users
        private static List<RegisterDTO> users = new List<RegisterDTO>();

        // Register User
        public bool AddUser(RegisterDTO registerDTO, out string message)
        {
            if (users.Any(u => u.Username == registerDTO.Username || u.Email == registerDTO.Email))
            {
                message = "User already exists";
                return false;
            }

            users.Add(registerDTO);
            message = "User registered successfully";
            return true;
        }

        //  Validate Login
        public bool ValidateUser(LoginDTO loginDTO, out string message)
        {
            var user = users.FirstOrDefault(u => u.Username == loginDTO.username);

            if (user == null)
            {
                message = "User not found";
                return false;
            }
            if (user.Password != loginDTO.password)
            {
                message = "Invalid password";
                return false;
            }

            message = "Login successful";
            return true;
        }
    }
}

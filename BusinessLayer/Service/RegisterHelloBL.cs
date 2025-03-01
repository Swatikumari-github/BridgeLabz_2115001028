using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL
    {
        private readonly RegisterHelloRL _registerHelloRL;

        public RegisterHelloBL(RegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }

        //  Register User
        public ResponseModel<string> RegisterUser(RegisterDTO registerDTO)
        {
            bool isSuccess = _registerHelloRL.AddUser(registerDTO, out string message);
            return new ResponseModel<string>(isSuccess, message, isSuccess ? registerDTO.Username : "");
        }

        // Login User
        public ResponseModel<string> LoginUser(LoginDTO loginDTO)
        {
            bool isSuccess = _registerHelloRL.ValidateUser(loginDTO, out string message);
            return new ResponseModel<string>(isSuccess, message, isSuccess ? loginDTO.username : "");
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ModelLayer.DTO;

//namespace BusinessLayer.Interface
//{
//    public interface IRegisterHelloBL
//    {
//        public string registration(string name);
//        public ResponseModel<string> RegisterUser(RegisterDTO registerDTO);
//        public ResponseModel<string> LoginUser(LoginDTO loginDTO);
//        //public bool checkUsernamePassword(string frontedusername, string frontedpassword, LoginDTO result);
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IRegisterHelloBL
    {

        public ResponseModel<string> RegisterUser(RegisterDTO registerDTO);
        public ResponseModel<string> LoginUser(LoginDTO loginDTO);
    }
}
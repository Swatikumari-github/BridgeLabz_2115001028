using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLevel.Interface;

namespace RepositoryLevel.Interface
{
    public interface IRegisterHelloRL
    {

        public bool AddUser(RegisterDTO registerDTO, out string message);

        public bool ValidateUser(LoginDTO loginDTO, out string message);
    }
}
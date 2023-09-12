using ninjaflex.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjaflex.Application.Interfaces
{
    public interface IUserTypeService
    {
        Task<ResponseViewModel> GetUserTypes();
        Task<ResponseViewModel> GetUserTypeById(int id);
        Task<ResponseViewModel> PutUserType(UserTypeViewModel userType);
        Task<ResponseViewModel> PostUserType(UserTypeViewModel userType);
    }
}

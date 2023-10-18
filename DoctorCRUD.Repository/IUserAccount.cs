using System;
using DoctorCRUD.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorCRUD.Repository
{
    public interface IUserAccount
    {
        string Register(User user);
    }
}

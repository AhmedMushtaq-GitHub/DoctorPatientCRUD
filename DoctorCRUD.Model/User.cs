using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorCRUD.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccessToken { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime JoinedOn { get; set; }
        public bool IsConfirmed { get; set; }
        public UserRoles UserRoles { get; set; }
        public virtual int UserRolesId { get; set; }
    }
}

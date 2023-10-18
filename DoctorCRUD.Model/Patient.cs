using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorCRUD.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime AppointmentOn { get; set; }
        public Doctor Doctor { get; set; }
        public virtual int DoctorId { get; set; }
    }
}

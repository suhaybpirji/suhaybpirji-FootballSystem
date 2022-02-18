using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClasses
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StaffNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public double Income { get; set; }
    }
}
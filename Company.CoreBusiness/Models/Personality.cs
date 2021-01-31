using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.CoreBusiness.Models
{
   public class Personality
    {
        public Personality()
        {

        }
        public List<Need> Needs { get; set; }
        public List <Skill> Skills { get; set; }
        public int EmployeeId { get; set; }
    }
}

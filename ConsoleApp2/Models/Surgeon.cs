using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployees
{
    public class Surgeon : HospitalEmployee
    {
        public Surgeon(string name, int age) : base(name, age) { }

        public override string Position => "Хирург";
    }
}

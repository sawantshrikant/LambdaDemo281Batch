using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo281Batch
{
    public class Person
    {
        public int SSN {  get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"serial no:{SSN} name:{Name} address:{Address} age:{Age}";
        }
    }
}

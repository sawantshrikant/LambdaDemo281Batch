using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo281Batch
{
    public class PersonDataManagement
    {
        public static void RetriveTop2RecordsBasedOnLessAge(List<Person> list)
        {
            List<Person> top2Records = list.Where(a => a.Age < 60).OrderByDescending(a => a.Age).Take(2).ToList();
            Console.WriteLine("\nDisplaying Top2 Records Based On Age:");
            Program.DisplayPersonData(top2Records);
        }
    }
}

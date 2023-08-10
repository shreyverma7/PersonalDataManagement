using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataManagement
{
    public class Operation
    {
        public void RetreiveTopTwoRecords(List<Person> list)
        {
            //without Lambda expression
            //List<Person> person = new List<Person>();
            //foreach (var data in list)
            //{
            //    if(data.Age < 60)
            //    {
            //        person.Add(data);
            //    }
            //}

            //Without lambda expression
            var result = list.Where(x => x.Age < 60).Take(2);
            Display(result.ToList());
        }
        public void RetreiveRecordsInBetweenAge(List<Person> list)
        {
            var result = list.Where(x => x.Age > 13 && x.Age < 18);
            Display(result.ToList());
        }
        public void RetreiveAverageAge(List<Person> list)
        {
            var result = list.Average(x => x.Age);
            Console.WriteLine(result);
        }
        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SSN+" "+ data.Name+" "+data.Address+" "+data.Age);
            }
        }
    }
}

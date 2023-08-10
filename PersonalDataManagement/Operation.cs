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
        public void RetreivePersonaDetailsByName(List<Person> list)
        {
            Console.WriteLine("Enter Name to get Details :");
            string name = Console.ReadLine();  
            var result = list.Where(x => x.Name == name);
            Display(result.ToList());
        }
        public void SkipRecordsOfAge(List<Person> list)
        {
            var result = list.OrderBy(x => x.Age ).Skip(list.Count(x=>x.Age< 60));
            Display(result.ToList());
        }
        public void RemovePersonaDetailsByName(List<Person> list)
        {
            Console.WriteLine("Enter Name to get remove Details :");
            string name = Console.ReadLine();
            var result = list.Find(x => x.Name ==name);
            list.Remove(result);
            Display(list);
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

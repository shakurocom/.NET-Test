using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.Exam.WebMVC.Models
{
    public class User
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} is {2} years old", this.FirstName, this.LastName, this.Age);
        }

        public static List<User> GetAll()
        {
            var users = new List<User> 
            {
                new User
                {
                    Age = 35,
                    FirstName = "Dana",
                    LastName = "Cohen"
                },
                new User
                {
                    Age = 34,
                    FirstName = "Michal",
                    LastName = "Yaari"
                },
                new User
                {
                    Age = 32,
                    FirstName = "Eitan",
                    LastName = "Foxx"
                },
                new User
                {
                    Age = 46,
                    FirstName = "Gilad",
                    LastName = "Sade"
                },
                new User
                {
                    Age = 26,
                    FirstName = "Ariel",
                    LastName = "Binyamin"
                },
                new User
                {
                    Age = 46,
                    FirstName = "Chen",
                    LastName = "Mizrahi"
                },
                new User
                {
                    Age = 45,
                    FirstName = "Dorin",
                    LastName = "Yechzceli"
                },
                new User
                {
                    Age = 19,
                    FirstName = "Benny",
                    LastName = "Binyamin"
                },
                new User
                {
                    Age = 22,
                    FirstName = "Michal",
                    LastName = "Ar-Lev"
                },
                new User
                {
                    Age = 31,
                    FirstName = "Guy",
                    LastName = "Dabush"
                },
            };

            return users;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.Model
{
    public class UserModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int Id { get; set; }
        public int Age { get; set; }

        public UserModel(int id, string firstname, string lastname, int age)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Voornaam: {Firstname}\nAchternaam: {Lastname}\n Leeftijd: {Age}";
        }
    }
}

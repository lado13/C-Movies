using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    internal class MembersSystem
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public DateTime RegistrationData { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Name {Name}\nLastname {LastName}\nMail {Mail}\nRegistrationData\nPassword {Password}\n{DateTime.Now.ToShortDateString()}\nId{Id}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Prototype.Objects
{
    class User
    {
        public int id;
        public string Name;
        public bool HasBookings;
        public int LoyaltyPoints;
        public bool PaymentLinked;
        public bool Educator;
    }

    class CreateUser : Create<CreateUser>
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Educator { get; set; }
        public CreateUser(string _Name, string _Password, bool _Educator) 
        {
            entity = Entity.User;
            type = GetType();
            Name = _Name;
            Password = _Password;
            Educator = _Educator;
            EntityInfo = this;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Test.Domain
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string iD;
        private string nID;
        private string birthDate;
        private string phoneNumber;
        private string address;

        public Person(string firstName, string lastName, string iD, string nID, string birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            NID = nID;
            BirthDate = birthDate;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ID { get => iD; set => iD = value; }
        public string NID { get => nID; set => nID = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }


    }
}

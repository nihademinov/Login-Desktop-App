using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgin_DEsktop_App
{
    public class User
    {
       
        private string? _Surname;
        private string? _Name;
        private string? _Country;
        private string? _City;
        private string? _Phone;
        private string? _BirthDate;
        private string? _Gender;

        [JsonConstructor]
        public User(string? surname, string? name, string? country, string? city, string? phone, string? birthDate, string? gender)
        {
            _Surname = surname;
            _Name = name;
            _Country = country;
            _City = city;
            _Phone = phone;
            _BirthDate = birthDate;
            _Gender = gender;
        }

        public string? Property_Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public string? Property_Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string? Property_Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public string? Property_City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string? Property_Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string? Property_Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public string? Property_Date
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

    }
}

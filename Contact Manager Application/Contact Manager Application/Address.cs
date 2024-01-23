using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application
{
    internal class Address
    {
        private string place { get; set; }
        private string type { get; set; }
        private string description { get; set; }

        public Address(string place, string type, string description)
        {
            this.place = place;
            this.type = type;
            this.description = description;
        }

        public void SetPlace(string _place)
        {
            this.place = _place;
        }
        public void SetType(string _type)
        {
            this.type = _type;
        }
        public void SetDescription(string _description)
        {
            this.description = _description;
        }
        public string GetAddress()
        {
            return $"{place},{type},{description}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application
{
    internal class Phone
    {
        private string phone { get; set; }
        private string type { get; set; }
        private string description { get; set; }

        public Phone(string phone, string type, string description)
        {
            this.phone = phone;
            this.type = type;
            this.description = description;
        }

        public void SetPhone(string _phone)
        {
            this.phone = _phone;
        }
        public void SetType(string _type)
        {
            this.type = _type;
        }
        public void SetDescription(string _description)
        {
            this.description = _description;
        }
        public string GetPhone()
        {
            return $"{phone},{type},{description}";
        }
    }
}

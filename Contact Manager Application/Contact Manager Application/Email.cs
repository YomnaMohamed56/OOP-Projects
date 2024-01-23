using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application
{
    internal class Email
    {
        private string email { get; set; }
        private string type { get; set; }
        private string description { get; set; }

        public Email(string email, string type, string description)
        {
            this.email = email;
            this.type = type;
            this.description = description;
        }

        public void SetEmail(string _email)
        {
            this.email = _email;
        }
        public void SetType(string _type)
        {
            this.type = _type;
        }
        public void SetDescription(string _description)
        {
            this.description = _description;
        }
        public string GetEmail()
        {
            return $"{email},{type},{description}";
        }
    }
}

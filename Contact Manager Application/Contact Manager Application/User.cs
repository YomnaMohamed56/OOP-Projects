using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application
{
    internal class User
    {
        public int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string gender { get; set; }
        private string city { get; set; }
        private string addedDate { get; set; }
        private Address[] addresses { get; set; }
        private Email[] emails { get; set; }
        private Phone[] phones { get; set; }

        public User(int id, string firstName, string lastName, string gender, string city, string addedDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.city = city;
            this.addedDate = addedDate;
            this.addresses = new Address[] {};
            this.emails = new Email[] {};
            this.phones = new Phone[] {};
        }

        public int Search(string SearchData)
        {
            foreach(Address address in addresses)
            {
                if(address.GetAddress().Contains(SearchData))
                    return 1;
            }

            foreach(Email email in emails)
            {
                if (email.GetEmail().Contains(SearchData))
                    return 1;
            }

            foreach(Phone phone in phones)
            {
                if (phone.GetPhone().Contains(SearchData))
                    return 1;
            }

            if (SearchData == id.ToString())
                return 1;

            if (SearchData == firstName)
                return 1;

            if (SearchData == lastName)
                return 1;

            if (SearchData == gender)
                return 1;
            
            if (SearchData == city)
                return 1;

            if (SearchData == addedDate.ToString())
                return 1;
            
            return 0;
        }


        public void AddAddress(string place, string type, string description)
        {
            Address[] NewAddresses = new Address[addresses.Length + 1];
            Array.Copy(addresses, NewAddresses, addresses.Length);
            NewAddresses[NewAddresses.Length - 1] = new Address(place, type, description);
            addresses = NewAddresses;
        }

        public void AddEmail(string email, string type, string description)
        {
            Email[] NewEmails = new Email[emails.Length + 1];
            Array.Copy(emails, NewEmails, emails.Length);
            NewEmails[NewEmails.Length - 1] = new Email(email, type, description);
            emails = NewEmails;
        }

        public void AddPhone(string phone, string type, string description)
        {
            Phone[] NewPhone = new Phone[phones.Length + 1];
            Array.Copy(phones, NewPhone, phones.Length);
            NewPhone[NewPhone.Length - 1] = new Phone(phone, type, description);
            phones = NewPhone;
        }


        public void EditAddress(int index, string place, string type, string description)
        {
            if(index >= 0 && index < addresses.Length)
            {
                Address address = new Address(place, type, description);
                addresses[index] = address;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }           
        }

        public void EditEmail(int index, string email, string type, string description)
        {
            if (index >= 0 && index < emails.Length)
            {
                Email _email = new Email(email, type, description);
                emails[index] = _email;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }

        public void EditPhone(int index, string phone, string type, string description)
        {
            if (index >= 0 && index < phones.Length)
            {
                Phone _phone = new Phone(phone, type, description);
                phones[index] = _phone;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }


        public void DeleteAddress(int index)
        {
            if (index >= 0 && index < addresses.Length)
            {
                Address[] NewAddresses = new Address[addresses.Length - 1];
                for (int i = 0, j = 0; i < addresses.Length; i++)
                {
                    if (i == index)
                        continue;
                    NewAddresses[j] = addresses[i];
                    j++;
                }
                addresses = NewAddresses;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }

        public void DeleteEmail(int index)
        {
            if (index >= 0 && index < emails.Length)
            {
                Email[] NewEmails = new Email[emails.Length - 1];
                for (int i = 0, j = 0; i < emails.Length; i++)
                {
                    if (i == index)
                        continue;
                    NewEmails[j] = emails[i];
                    j++;
                }
                emails = NewEmails;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }

        public void DeletePhone(int index)
        {
            if (index >= 0 && index < phones.Length)
            {
                Phone[] NewPhones = new Phone[phones.Length - 1];
                for (int i = 0, j = 0; i < phones.Length; i++)
                {
                    if (i == index)
                        continue;
                    NewPhones[j] = phones[i];
                    j++;
                }
                phones = NewPhones;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }


        public void ShowUserInfo()
        {
            Console.WriteLine("** User Information **");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Added Date: {addedDate}");

            Console.WriteLine("Addresses:");
            foreach(Address address in addresses)
            {
                Console.WriteLine($"   {address.GetAddress()}");
            }

            Console.WriteLine("Emails:");
            foreach (Email email in emails)
            {
                Console.WriteLine($"   {email.GetEmail()}");
            }

            Console.WriteLine("Phones:");
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"   {phone.GetPhone()}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Users
            User user1 = new User(1, "Yomna", "Mohamed", "Female", "Cairo", "23/12/2023 - 7:01 AM");
            user1.AddAddress("123 Main ST", "Home", "Residential Address");
            user1.AddEmail("yomnamohamed556@gmail.com", "Personal", "Primary Email");
            user1.AddPhone("01234567890", "Mobile", "Primary Phone");

            User user2 = new User(2, "Laila", "Amir", "Female", "Alex", "23/12/2023 - 7:06 AM");
            user2.AddAddress("456 Park Ave", "Work", "Office Address");
            user2.AddEmail("laila.amir@example.com", "Work", "Official Email");
            user2.AddPhone("01034567890", "Home", "Secondary Phone");

            //Add users to contact
            Contact contact = new Contact();
            contact.AddUser(user1);
            contact.AddUser(user2);

            //Show all users
            contact.ShowAll();

            Console.WriteLine("\n=======================================\n");

            //Search user by phone number
            User[] MatchedUsers = contact.SearchUser("012");
            foreach(User user in MatchedUsers)
            {
                user.ShowUserInfo();
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("\n=======================================\n");

            //Edit user
            user1 = new User(1, "Yomna", "Mohamed", "Female", "Siwa", "23/12/2023 - 7:01 AM");
            user1.AddEmail("yomna2@gmail.com", "Work", "Official Email");
            contact.EditUser(user1);

            //show all users again
            contact.ShowAll();

            Console.WriteLine("\n=======================================\n");

            //Delete user
            contact.DeleteUser(1);

            //show all users again
            contact.ShowAll();
        }
    }
}
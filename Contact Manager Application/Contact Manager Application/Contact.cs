using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application
{
    internal class Contact
    {
        private User[] users;
        public int Count => users.Length;        

        public Contact()
        {
            users = new User[] {};
        }

        public void AddUser(User user)
        {
            User[] NewUsers = new User[users.Length + 1];
            Array.Copy(users, NewUsers, users.Length);
            NewUsers[NewUsers.Length - 1] = user;
            users = NewUsers;
        }

        public void EditUser(User NewUserData)
        {
            for(int i = 0; i < users.Length; i++)
            {
                if (users[i].id == NewUserData.id)
                {
                    users[i] = NewUserData;
                    return;
                }
            }
            Console.WriteLine("Invaild id");
        }

        public void DeleteUser(int index)
        {
            if(index >= 0 && index < users.Length)
            {
                User[] NewUsers = new User[users.Length - 1];
                for (int i = 0, j = 0; i < users.Length; i++)
                {
                    if (i == index)
                        continue;
                    NewUsers[j] = users[i];
                    j++;
                }
                users = NewUsers;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
            
        }

        public User[] SearchUser(string SearchData)
        {
            User[] MatchedUsers = new User[] {};
            foreach(User user in users)
            {
                if (user.Search(SearchData) == 1)
                {
                    Array.Resize(ref MatchedUsers, MatchedUsers.Length + 1);
                    MatchedUsers[MatchedUsers.Length - 1] = user;
                }
            }
            return MatchedUsers;
        }

        public void ShowAll()
        {
            foreach(User user in users)
            {
                user.ShowUserInfo();
                Console.WriteLine("------------------------");
            }
        }
    }
}

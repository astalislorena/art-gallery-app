using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models
{
    internal class User
    {
        private String firstName;
        private String lastName;
        private DateTime birthday;
        private String email;
        private String password;
        private UserType type;

        public User()
        {
            this.firstName = "";
            this.lastName = "";
            this.birthday = DateTime.Now;
            this.email = "";
            this.password = "";
            this.type = UserType.Unknown;
        }

        public User(string firstName, string lastName, DateTime birthday, string email, string password, UserType type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.email = email;
            this.password = password;
            this.type = type;
        }

        public String GetFirstName()
        {
            return firstName;
        }

        public String GetLastName()
        {
            return lastName;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }

        public String GetEmail()
        {
            return email;
        }

        public String GetPassword()
        {
            return password;
        }

        public UserType GetUserType()
        {
            return type;
        }
        
        public void SetFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public void SetEmail(String email)
        {
            this.email = email;
        }

        public void SetPassword(String password)
        {
            this.password = password;
        }

        public void SetUserType(UserType type)
        {
            this.type = type;
        }
    }
}

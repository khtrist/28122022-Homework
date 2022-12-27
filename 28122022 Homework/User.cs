using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _28122022_Homework
{
    internal class User
    {
        public User(string username)
        {
        }
        public string UserName
        {
            get => _userName;
            set
            {
                if (CheckUsername(value))
                    _userName = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (CheckPassword(value))
                    _password = value;
            }
        }

        public string DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
            }
        }

        private string _dateTime;
        private string _userName;
        private string _password;

        public bool CheckUsername(string username)
        {
            if (username.Length >= 6 && username.Length <= 25 && UsernameTest(username) && HasUpper(username) && string.IsNullOrWhiteSpace(username))
            {
                return true;
            }
            else
                return false;
        }

        public bool CheckPassword(string going)
        {
            if (HasDigit(going) && HasLower(going) && HasUpper(going) && PasswordTest(going) && string.IsNullOrWhiteSpace(going))
            {
                return true;
            }
            return false;
        }

        public bool PasswordTest(string paswoord)
        {
            if (paswoord.Length >= 8 && paswoord.Length <= 25)
            {
                return true;
            }
            return false;
        }
        public bool UsernameTest(string username)
        {
            if (username.Length >= 6 && username.Length <= 25)
            {
                return true;
            }
            return false;
        }
        public bool HasDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string inputt)
        {
            for (int i = 0; i < inputt.Length; i++)
            {
                if (char.IsUpper(inputt[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasLower(string inpt)
        {
            for (int i = 0; i < inpt.Length; i++)
            {
                if (char.IsLower(inpt[i]))
                {
                    return true;
                }
            }
            return false;
        }




    }
}

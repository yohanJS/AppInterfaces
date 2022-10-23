using AppInterfaces.Intefaces;
using System;

namespace AppInterfaces.Classes
{
    class PasswordManager : IDisplayable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }
        public void Display()
        {
            if (Hidden)
            {
                Console.WriteLine($"The password is {Password}");
            }
            else
            {
                Console.WriteLine($"**********");
            }
        }
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}
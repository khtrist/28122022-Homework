using System;
using System.Collections.Generic;
using System.Text;

namespace _28122022_Homework2
{
    internal class Notebook : Product
    {
        public Notebook(string name, double price) : base(name, price , datetime)
        {


        }
        public new string DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
            }
        }

        private string _dateTime;
        private static readonly string datetime;
        public byte RAM;
        public string value;
        public Notebook(string name, double price, byte ram) : base(name, price ,datetime )
        {
            this.RAM = ram;
        }

    }
}

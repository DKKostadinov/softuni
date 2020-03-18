namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class Computer
    {
        private string make;

        public Computer()
        {
            this.Make = "n/a";
        }
        public Computer(string make)
        {
            this.Make = make;
        }
        public string Make
        {
            get { return this.Make; }
            set { this.make = value; }
        }

        public void Start()
        {
            Console.WriteLine("Running...");
        }
    }
}

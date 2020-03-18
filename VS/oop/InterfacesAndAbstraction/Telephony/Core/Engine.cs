using System;
using System.Collections.Generic;
using System.Linq;
using Telephony.Exceptions;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine
    {
        private SmartPhone smartphone;

        public Engine()
        {
            this.smartphone = new SmartPhone();
        }

        public void Run()
        {
            List<string> numbers = Console.ReadLine()
                .Split(" ")
                .ToList();
            List<string> urls = Console.ReadLine()
                .Split(" ")
                .ToList();

            CallNumbers(numbers);
            BrowseInternet(urls);
        }

        private void CallNumbers(List<string> numbers)
        {
            foreach (var item in numbers)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Call(item));
                }
                catch (InvalidPhoneNumberException ipne)
                {
                    Console.WriteLine(ipne.Message);
                }
            }
        }

        private void BrowseInternet(List<string> urls)
        {
            foreach (var item in urls)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Browse(item));
                }
                catch (InvalidURLException iurle)
                {
                    Console.WriteLine(iurle.Message);
                }
            }
        }
    }
}

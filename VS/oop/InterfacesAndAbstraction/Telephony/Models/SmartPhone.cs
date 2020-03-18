using Telephony.Interfaces;
using System.Linq;
using Telephony.Exceptions;

namespace Telephony.Models
{
    class SmartPhone : ICallable, IBrowsable
    {
        public SmartPhone()
        {

        }

        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c))) 
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(c => char.IsDigit(c)))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";
        }
    }
}

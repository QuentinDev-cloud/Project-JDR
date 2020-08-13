
using System;
using System.IO;
using System.Linq;

namespace JDR.Service
{
    public class Service
    {

        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

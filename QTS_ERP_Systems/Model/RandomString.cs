using System;
using System.Linq;

namespace QTS_ERP_Systems.Model
{
    public static class RandomString
    {
        private static Random random = new Random();
        public static string RandString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

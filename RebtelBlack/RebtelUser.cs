using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RebtelBlack
{
    public class MD5
    {
        public static Encoding Encoding = Encoding.UTF8;

        public static string Of(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }
    }

    class RebtelUser
    {
        private readonly string _name = "Samuel Carlsson";
        private readonly string _email = "samuel.carlsson@gmail.com";

        public string Name
        {
            get { return _name; }
        }

        public Uri Gravatar
        {
            get
            {
                var tmp = new Uri("http://www.gravatar.com/avatar/" + MD5.Of(_email.Trim().ToLower()) + "?s=20");
                return tmp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PastebinAPI;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Pastebin.DevKey = "http://pastebin.com/api#1"; //your dev key
            try
            {
                var me = Pastebin.Login("username", "password");
                Console.WriteLine(me.GetUserInfo());
                Console.WriteLine(me.ListPastes(3));
            }
            catch(PastebinException ex)
            {
                if (ex.Parameter == PastebinException.ParameterType.Login)
                {
                    Console.WriteLine("Invalid username/password");
                }
                else
                {
                    throw;
                }
            }
        }
    }
}

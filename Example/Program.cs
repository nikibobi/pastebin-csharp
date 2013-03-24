using System;
using PastebinAPI;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Pastebin.DevKey = "your dev key goes here"; //you can see yours here: http://pastebin.com/api#1
            try
            {
                User me = Pastebin.Login("user", "pass"); // login and get user object
                Console.WriteLine(me.GetUserInfo()); // prints user information like e-mail, location ...
                Console.WriteLine(me.ListPastes(3)); // lists all pastes for this user
                string code = "<your fancy &code#() goes here>";
                Paste newPaste = me.NewPaste(code, "MyPasteTitle", PasteFormat.HTML5, Visibility.Public, Expiration.TenMinutes); //creates a new paste and get paste object
                Console.WriteLine("URL: {0}",newPaste.Url);
                Console.WriteLine("Paste key: {0}", newPaste.Key);
                Console.WriteLine("Content: {0}", newPaste.GetRaw());
                me.DeletePaste(newPaste); //deletes a paste created by user
                Console.WriteLine(Pastebin.ListTrendingPastes()); //lists all pastes when you click on trending pastes
            }
            catch(PastebinException ex) //api throws PastebinException
            {
                //in the Parameter property you can see what invalid parameter was sent
                if (ex.Parameter == PastebinException.ParameterType.Login) //here we check if the exeption is thrown because of invalid login details
                {
                    Console.WriteLine("Invalid username/password");
                }
                else
                {
                    throw; //all other types are rethrown and not swalowed!
                }
            }
            Console.ReadKey();
        }
    }
}

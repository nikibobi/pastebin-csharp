Pastebin API for C#
===================

This is a simple library for accessing Pastebin from C#

# Example

```C#
using System;
using PastebinAPI;

namespace Example
{
    class Example
    {
        static void Main()
        {
            //before using any class in the api you must enter your api dev key
            Pastebin.DevKey = "your dev key goes here";
            //you can see yours here: https://pastebin.com/api#1
            try
            {
                // login and get user object
                User me = Pastebin.Login("user", "pass");
                // user contains information like e-mail, location etc...
                Console.WriteLine("{0}({1}) lives in {2}", me, me.Email, me.Location);
                // lists all pastes for this user
                foreach (Paste paste in me.ListPastes(3)) // we limmit the results to 3
                {
                    Console.WriteLine(paste.Title);
                }

                string code = "<your fancy &code#() goes here>";
                //creates a new paste and get paste object
                Paste newPaste = me.CreatePaste(code, "MyPasteTitle", Language.HTML5, Visibility.Public, Expiration.TenMinutes);
                //newPaste now contains the link returned from the server
                Console.WriteLine("URL: {0}",newPaste.Url);
                Console.WriteLine("Paste key: {0}", newPaste.Key);
                Console.WriteLine("Content: {0}", newPaste.Text);
                //deletes the paste we just created
                me.DeletePaste(newPaste);

                //lists all currently trending pastes(similar to me.ListPastes())
                foreach (Paste paste in Pastebin.ListTrendingPastes())
                {
                    Console.WriteLine("{0} - {1}", paste.Title, paste.Url);
                }
                //you can create pastes directly from Pastebin static class but they are created as guests and you have a limited number of guest uploads
                Paste anotherPaste = Paste.Create("another paste", "MyPasteTitle2", Language.CSharp, Visibility.Unlisted, Expiration.OneHour);
                Console.WriteLine(anotherPaste.Title);
            }
            catch(PastebinException ex) //api throws PastebinException
            {
                //in the Parameter property you can see what invalid parameter was sent
                //here we check if the exeption is thrown because of invalid login details
                if (ex.Parameter == PastebinException.ParameterType.Login)
                {
                    Console.Error.WriteLine("Invalid username/password");
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
```

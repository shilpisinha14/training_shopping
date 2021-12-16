using System.IO;

namespace APITests.API.Methods
{
    class BaseMethods
    {
        const string userurl = "https://jsonplaceholder.typicode.com/";

        static public string SetUrl(string endpoint)
        {
            return Path.Combine(userurl, endpoint);  
        }
    }
}

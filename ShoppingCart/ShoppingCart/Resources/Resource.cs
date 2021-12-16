using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Resources
{
    public class Resource
    {
        public static Dictionary<string, string> websites = new Dictionary<string, string>
        {
            { "Nykaa", "https://www.nykaa.com/"}
        };

        public static Dictionary<string, string> nykaabasexpath = new Dictionary<string, string>
        {
            { "productxpath", "//div/img[contains(@alt," },
            { "categoryxpath", "//span/img[contains(@alt," }
        };
    }
}

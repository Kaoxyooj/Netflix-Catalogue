using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Catalogue
{
    public class View
    {
        public static void Print(Genre title)
        {
            Console.WriteLine(title);
            foreach (Title name in title.titles)
            {
                Console.WriteLine(name.name);
            }
        }
    }
}

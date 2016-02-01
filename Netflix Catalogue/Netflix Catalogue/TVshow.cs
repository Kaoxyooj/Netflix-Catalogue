using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Catalogue
{
    class TVshow : Title
    {
        public List<Episode> ep = new List<Episode>();

        public new int rating
        {
            get
            {
                int myRate = 0;
                foreach (Episode title in ep)
                {
                    myRate = myRate + title.rating;
                }
                return myRate / ep.Count;
            }
        }

        public TVshow(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name + ", Average Rating: " + rating+ ",  "+ ep.Count+  " Episodes";
        }


    }
}

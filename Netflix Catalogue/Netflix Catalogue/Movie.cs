using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Catalogue
{
   public class Movie : Title
    {
        public float duration { get; set; }

        public Movie(string name,int rating,float duration)
        {
            this.name = name;
            this.rating = rating;
            this.duration = duration;
        }
        public override string ToString()
        {
            return name + ", Rating: " + rating + ",  " +duration + " minutes";
        }
    }
}

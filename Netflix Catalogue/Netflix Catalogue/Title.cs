﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Catalogue
{
    public class Title
    {
       public string name;
       public int rating;


        public Title(string name, int rating)
        {
            this.name = name;
            this.rating = rating;
        }

        public Title()
        {           
            this.name = null;
            int? rating = null;
        }
    }
}

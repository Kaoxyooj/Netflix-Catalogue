using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Netflix_Catalogue
{
    public class Genre : IEnumerable
    {
       public List<Title> titles = new List<Title>();


        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Title title in titles)
            {
                yield return title;
            }
        }

        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre newGenre = new Genre();
            foreach (Title name in genre1.titles)
            {
                newGenre.titles.AddRange(genre1.titles);
        }
            foreach (Title name in genre2.titles)
            {
                newGenre.titles.AddRange(genre2.titles);
        }
            return newGenre;
        }

        public static Genre operator +(Genre genre1, Title _name)
        {
            Genre newGenre = new Genre();
            foreach (Title name in genre1.titles)
            {
                newGenre.titles.Add(_name);
            }
            foreach (Title name in genre1.titles)
            {
                if (name == _name)
                {
                    newGenre.titles.Add(_name);
                }
            }
            
            return newGenre;
        }

        //public override string ToString()
        //{
        //    return Genre.titles;
        //}
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix_Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Catalogue.Tests
{
    [TestClass()]
    public class EpisodeTests
    {
        private int rating;

        [TestMethod()]
        
        public void EpisodeTest(int rating)
        {
            this.rating = rating;
        }
    }
}
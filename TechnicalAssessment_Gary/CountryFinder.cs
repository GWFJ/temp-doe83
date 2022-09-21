using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssessment_Gary
{
    internal class CountryFinder
    {
        private static CountryFinder instance = null;

        private  CountryFinder()
        {

        }

        public static CountryFinder getInstance()
        {
            if (instance == null)
            {
                instance = new CountryFinder(); 
            }

            return instance;
        }
    }
}

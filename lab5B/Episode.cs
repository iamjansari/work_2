/*
 * Name : Manthan Jansari 
 * Student Id : 000741486
 * Date: 12-01-2018
 * Statement of Authorship : I, Manthan Jansari,000741486 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5B
{
    class Episode
    {
        /// <summary>
        ///  constructer to get value and give to the get and set methods
        /// </summary>
        /// <param name="Story"></param>
        /// <param name="Season"></param>
        /// <param name="Year"></param>
        /// <param name="Title"></param>
        public Episode(String Story, int Season, int Year, String Title)
        {
            STORY = Story;
            SEASON= Season;
            YEAR= Year;
            TITLE= Title;

        }
        public String STORY { get; set; }
        public int SEASON { get; set; }
        public int YEAR { get; set; }
        public String TITLE { get; set; }
        
    }
}

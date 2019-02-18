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
    class Doctor
    {
        /// <summary>
        /// Constructer to get value and send to gatter satter
        /// </summary>
        /// <param name="ordinal"></param>
        /// <param name="Actor"></param>
        /// <param name="Series"></param>
        /// <param name="Age"></param>
        /// <param name="Debut"></param>
        public Doctor(int ordinal, String Actor, int Series, int Age, int Debut)
        {
            Ordinal = ordinal;
            ACTOR = Actor;
            AGE = Age;
            DEBUT = Debut;
            SERIES= Series;
            
        }
        /// <summary>
        /// Gatter satter for Ordinal
        /// </summary>
        public int Ordinal { get; set; }
        /// <summary>
        /// gatter satter for actor
        /// </summary>
        public String ACTOR { get; set; }
        /// <summary>
        /// gatter satter for series
        /// </summary>
        public int SERIES { get; set; }
        /// <summary>
        /// gatter satter for Debut
        /// </summary>
        public int DEBUT { get; set; }
        /// <summary>
        /// gatter satter for age
        /// </summary>
        public int AGE { get; set; }
     
    }
}

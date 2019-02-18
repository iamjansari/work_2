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
    class Companion
    {
        /// <summary>
        /// constructer to get value and give to the get and set methods
        /// </summary>
        /// <param name="name"></param>
        /// <param name="actor"></param>
        /// <param name="doctor"></param>
        /// <param name="debut"></param>
        public Companion(String name,String actor,int doctor,String debut)
        {
            Name= name;
            ACTOR= actor;
            DOCTOR= doctor;
            DEBUT= debut;

        }
        /// <summary>
        /// Gatter and satter 
        /// </summary>
        public String Name { get; set; }
        public String ACTOR { get; set; }
        public int DOCTOR { get; set; }
        public String DEBUT{ get; set; }
    }
}

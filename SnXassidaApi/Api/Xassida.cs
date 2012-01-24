using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Xarala
{
    namespace Xassida
    {
        /// <summary>
        /// Represents a single xassida
        /// </summary>
        public sealed class Xassida : IFormattable
        {
            /// <summary>
            /// Parameterless Constructor
            /// </summary>
            public Xassida()
            {
            
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="titre"></param>
            /// <param name="tardioumane"></param>
            /// <param name="nombreBahrus"></param>
            public Xassida(String titre, String tardioumane, int nombreBahrus)
            {
                Titre = titre;
                Tardioumane = tardioumane;
                Nombrebahrus = nombreBahrus;
                    
                /// Creates an empty list of beyits
                /// 
                Beyits = new List<Beyit>();
            }

            /// <summary>
            /// le titre du xassida
            /// </summary>
            public String Titre { get; set; }

            /// <summary>
            /// le tardioumane du xassida
            /// </summary>
            public String Tardioumane { get; set; }

            /// <summary>
            /// le nombre total de beyits compris dans le xassida
            /// </summary>
            public int BeyitsCount { get; set; }

            /// <summary>
            /// le nombre de parties que comporte un beyit du xassida
            /// </summary>
            public int Nombrebahrus { get; set; }

            /// <summary>
            /// Linked list containing the beyits
            /// </summary>
            public List<Beyit> Beyits { get; set; }

            /// <summary>
            /// Override Default to String
            ///   call the IFormattable ToString() method
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return ToString(null, null);
            }

            /// <summary>
            /// Implements IFormattable Interface
            /// </summary>
            /// <param name="format"></param>
            /// <param name="formatProvider"></param>
            /// <returns></returns>
            public string ToString(string format, IFormatProvider formatProvider)
            {
                return Titre;
            }

        }
  
    }

}

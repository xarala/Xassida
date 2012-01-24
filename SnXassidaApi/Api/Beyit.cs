using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xarala
{

    namespace Xassida
    {

        /// <summary>
        /// Beyit Class
        /// </summary>
        public sealed class Beyit : IFormattable
        {

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="position"></param>
            public Beyit(int position)
            {
                /// Set the position attribute from params
                /// 
                Position = position;
                /// Creates an empty list of Bahrus
                /// 
                Bahrus = new List<Bahru>();
            }

            /// <summary>
            /// La position du beyit dans le xassaide
            /// </summary>
            public int Position { get; set; }

            /// <summary>
            /// Une liste liée contenant les bahrus du beyit
            /// </summary>
            public List<Bahru> Bahrus { get; set; }

            /// <summary>
            /// Override default ToString() method
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                /// Delegates to IFormattable implemetation
                return ToString(null, null);
            }

            /// <summary>
            /// IFormattable implementation
            /// </summary>
            /// <param name="format"></param>
            /// <param name="formatProvider"></param>
            /// <returns></returns>
            public string ToString(string format, IFormatProvider formatProvider)
            {
                /// Creates a StringBuilder object
                StringBuilder beyitSB = new StringBuilder("Bamba");

                /// Append the Bahrus to the string
                foreach (Bahru bahru in Bahrus)
                {
                    beyitSB.Append(bahru.Position.ToString());
                }

                return beyitSB.ToString();
            }

        }
    }
}
    


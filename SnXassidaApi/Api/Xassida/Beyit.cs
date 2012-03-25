using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Xarala
{

    namespace Xassida
    {
        /// <summary>
        /// Beyit Class
        /// </summary>
        public sealed class Beyit : IFormattable
        {
            #region CONSTRUCTORS
            
            /// <summary>
            /// ParameterLess Constructor
            /// </summary>
            public Beyit() { }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="position"></param>
            public Beyit(int position)
            {

                Position    = position; /// Set the position attribute from params
                Bahrus      = new List<Bahru>(); /// Creates an empty list of Bahrus
                Traductions = new List<Traduction>(); /// Creates an empty list of traductions

            }

            #endregion

            #region PROPERTIES

            /// <summary>
            /// La position du beyit dans le xassaide
            /// </summary>
            public int Position { get; set; }

            /// <summary>
            /// Une liste liée contenant les bahrus du beyit
            /// </summary>
            /// 
            [XmlArrayAttribute]
            public List<Bahru> Bahrus { get; set; }
            
            /// <summary>
            /// Une liste de traductions du beyit
            /// </summary>
            public List<Traduction> Traductions { get; set; }

            #endregion

            #region METHODS
           
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
                StringBuilder beyitSB = new StringBuilder();

                /// Append the Bahrus to the string
                foreach (Bahru bahru in Bahrus)
                {
                    beyitSB.Append(bahru.Contenu);
                }

                return beyitSB.ToString();
            }

            #endregion

        }

    }

}
    


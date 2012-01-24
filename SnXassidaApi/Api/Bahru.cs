using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Xarala
{
    namespace Xassida
    {
        /// <summary>
        /// Bahru Class
        /// </summary>
        public sealed class Bahru : IFormattable
        {

            /// <summary>
            /// Parameterless Constructor
            /// </summary>
            public Bahru()
            {

            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="position"></param>
            /// <param name="contenu"></param>
            public Bahru(int position, String contenu) 
            {
                Position = position;
                Contenu = contenu;
            }

            /// <summary>
            /// 
            /// </summary>
            public int Position { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public String Contenu { get; set; }

            /// <summary>
            /// Override ToString()
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
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
                throw new NotImplementedException();
            }

        }
    }
}
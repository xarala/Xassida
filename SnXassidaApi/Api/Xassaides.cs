using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xarala
{

    namespace Xassida
    {
        /// <summary>
        /// A list of Xassaides
        /// </summary>
        public sealed class Xassaides
        {

            #region CONSTRUCTORS
            
            /// <summary>
            /// Default Xassaides
            /// </summary>
            public Xassaides()
            {
                Library = new List<Xassida>();
            }

            #endregion


            #region PROPERTIES
           
            /// <summary>
            /// A list of strongly types Xassaides
            /// </summary>
            public List<Xassida> Library { get; set; }

            #endregion

        }
        
    }
    
}

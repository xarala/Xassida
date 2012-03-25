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

            }

            #endregion


            #region PROPERTIES
           
            /// <summary>
            /// A list of strongly types Xassaides
            /// </summary>
            List<Xassida> Library { get; set; }

            #endregion

        }
        
    }
    
}

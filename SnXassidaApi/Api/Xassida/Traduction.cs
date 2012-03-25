using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xarala
{
    namespace Xassida
    {


        public enum Langues : int { Anglais, Francais, Espagnol, Allemand}

        /// <summary>
        /// Une traduction d'un Beyit vers un autre langage
        /// </summary>
        public sealed class Traduction
        {

            #region CONSTRUCTORS
            
            // <summary>
            /// Parameterless constructor
            /// </summary>
            public Traduction()
            {

            }
            /// <summary>
            /// Parametrized constructor
            /// </summary>
            /// <param name="contenu">une chaine de caractères</param>
            /// <param name="langue">la langue</param>
            public Traduction (String contenu, Langues langue)
	        {
                Contenu = contenu;
                Langue  = langue;
	        }

            #endregion

            #region PROPERTIES

            /// <summary>
            /// Le contenu de la transcription
            /// </summary>
            public string Contenu { get; set; }

            /// <summary>
            /// La langue dans laquelle le Beyit est transcrit
            /// </summary>
            public Langues Langue { get; set; }

            #endregion

        }

    }

}


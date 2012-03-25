using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

    namespace Xarala
    {
        namespace Xassida
        {
            /// 
            /// <summary>
            /// Repesents a xml document
            /// </summary>
            /// 
            public class RawXsdDocument
            {
               
                /// 
                /// <summary>
                /// Constructor
                /// </summary>
                /// <param name="relativePathParam">the relative path to the rails resource</param>
                /// 
                public RawXsdDocument(String relativePathParam)
                {
                    relativePath = relativePathParam;
                    innerDoc = new XmlDocument();
                    //innerDoc.Load(Api.Host + '/' + relativePathParam);
                    innerDoc.Load(@"C:\Users\pathe\Documents\mawahibu.xml");
                }

                /// 
                /// <summary>
                /// 
                /// </summary>
                /// 
                public XmlDocument innerDoc
                {
                    get;
                    set;
                }

                /// 
                /// <summary>
                /// Attribute 
                /// : the relative path to the xml document
                ///   it's used the construct de rails routes with host constant of the static Api class 
                /// </summary>
                /// 
                public String relativePath 
                {
                    get;
                    set; 
                }

            }   
        }
    }
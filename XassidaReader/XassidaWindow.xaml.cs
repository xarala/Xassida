using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using Xarala;
using Xarala.Xassida;

namespace XassidaReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class XassidaWindow : Window
    {

        public Xassida TheXassida;

        public XassidaWindow()
        {
            InitializeComponent();
        }


        private void LoadXassida()
        {
            RawXsdDocument doc = new RawXsdDocument("xassaides/4.xml");

            XmlNode xassida = doc.innerDoc.GetElementsByTagName("xassida").Item(0);
            String Titre = xassida.Attributes["titre"].InnerText;
            String Tardioumane = xassida.Attributes["tardioumane"].InnerText;
            int BahrusCount = Convert.ToInt16(xassida.Attributes["bahrus_count"].InnerText);

            TheXassida = new Xassida(Titre, Tardioumane, BahrusCount);

            foreach (XmlElement beyit in xassida.ChildNodes)
            {
                int Position = Convert.ToInt16(beyit.Attributes["position"].InnerText);
                Beyit byt = new Beyit(Position);

                foreach (XmlElement bahru in beyit.ChildNodes)
                {
                    int BPosition = Convert.ToInt16(bahru.Attributes["position"].InnerText);
                    string Contenu = bahru.Attributes["contenu"].InnerText;
                    Bahru bhr = new Bahru(BPosition, Contenu);
                    byt.Bahrus.Add(bhr);
                }
                TheXassida.Beyits.Add(byt);
            }   
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LoadXassida();
            this.DataContext = TheXassida;

            foreach (Beyit b in TheXassida.Beyits)
            {
                Paragraph para = new Paragraph();
                foreach (Bahru bahru in b.Bahrus)
                {
                    Span r = new Span(new Run(bahru.Contenu));
                    para.Inlines.Add(r);
                    para.MinOrphanLines = 1;
                    para.Margin =  new Thickness(10, 10, 10, 10);
                }
                XFlowDocument.Blocks.Add(para);
            }

        }

    }
}

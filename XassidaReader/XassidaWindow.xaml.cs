using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech;
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
using WPFMitsuControls;
using System.Windows.Controls.Primitives;

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
            BookPage titlePage, tardioumanePage, bp;

            LoadXassida();

            PaginatedCollection<Beyit> pages = new PaginatedCollection<Beyit>(TheXassida.Beyits);

            /// the title of the xassida will be the first page
            /// 
            titlePage = new BookPage();
            titlePage.Content  = new TextBlock() 
            { 
                Padding = new Thickness(0, 70, 0, 0),
                Text = TheXassida.Titre, 
                FontSize = 35, 
                Height   = 400,
                HorizontalAlignment = HorizontalAlignment.Center, 
                VerticalAlignment   = VerticalAlignment.Center,
                TextAlignment       = TextAlignment.Center,
                TextWrapping =  TextWrapping.Wrap 
            };

            readerBook.Items.Add(titlePage);

            tardioumanePage = new BookPage();
            tardioumanePage.Content = new TextBlock() 
            { 
                Text = TheXassida.Tardioumane, 
                TextWrapping = TextWrapping.Wrap,
                LineHeight   = 22

            };

            readerBook.Items.Add(tardioumanePage);

            for (int i = 0; i < pages.PagesCount; i++)
            {

                bp = new BookPage();
                WrapPanel panel = new WrapPanel();


                foreach (Beyit beyit in pages.GetData(i))
                {

                    TextBlock tb = new TextBlock() { Text = beyit.ToString()};
                    tb.Padding = new Thickness(10, 5, 10, 5);
                    
                    ///tb.Text = beyit.ToString();
                    panel.Children.Add(tb);
                }
                bp.Content = panel;
                readerBook.Items.Add(bp);

            }



            

        }

    }
}

using Microsoft;
using Microsoft.Windows;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
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
    public partial class XassidaWindow : RibbonWindow
    {
        /// <summary>
        /// The current xassida that is being viewed
        /// </summary>
        public Xassida TheXassida;

        /// <summary>
        /// The Constructor of the window
        /// TODO need to provide args here
        /// </summary>
        public XassidaWindow()
        {
            InitializeComponent();
            InitializeArabicFonts();
        }


        /// <summary>
        /// Initialize Application Fonts
        /// These will be Arabic Fonts
        /// </summary>
        private void InitializeArabicFonts()
        {
            arabicFonts.ItemsSource = Fonts.SystemFontFamilies; /* set the item source of the arabicFont combo box */

            ArabicFontsComboBox.SelectedItem = "Arial"; /*set the default font */
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

            this.DataContext = TheXassida;

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
                TextWrapping = TextWrapping.WrapWithOverflow,
                VerticalAlignment = VerticalAlignment.Center,

            };

            readerBook.Items.Add(tardioumanePage);

            for (int i = 0; i < pages.PagesCount; i++)
            {

                bp = new BookPage();
                StackPanel container = new StackPanel() { Orientation = Orientation.Vertical, VerticalAlignment = VerticalAlignment.Center };


                foreach (Beyit beyit in pages.GetData(i))
                {

                    DockPanel c = new DockPanel();
                    foreach (Bahru bahru in beyit.Bahrus)
                    {
                        TextBlock tb = new TextBlock() { Text = bahru.Contenu, Margin = new Thickness(4, 6, 4, 6), Width = 50 };
                        c.Children.Add(tb);    
                    }
                    
                    container.Children.Add(c);
                }
                bp.Content = container;
                readerBook.Items.Add(bp);

            }



            

        }


        /// <summary>
        /// Handle the changes in the fonts combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArabicFontsComboBox_SelectionChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            RibbonGallery source = (RibbonGallery) e.OriginalSource;

            readerBook.FontFamily = new FontFamily(source.SelectedValue.ToString());
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timelineSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

    }
}

using Fluent;
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
using System.IO.IsolatedStorage;
using System.Collections.ObjectModel;

namespace XassidaReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class XassidaWindow : RibbonWindow
    {

        #region Properties

        /// <summary>
        /// Defines the duration of the book animation
        /// </summary>
        private const int pageAnimationDuration = 600;
        
        /// <summary>
        /// The current xassida that is being viewed
        /// </summary>
        public Xassida currentXassida;

        /// <summary>
        /// Get the App Store where the xassidas are located
        /// </summary>
        IsolatedStorageFile AppStore;

        /// <summary>
        /// A list of xassidas naames that the user has downloaded in his computer
        /// </summary>
        public List<Xassida> myLibraryItemNames;

        public PaginatedCollection<Beyit> PagesCollection;

        #endregion

        #region Constructors
        /// <summary>
        /// Parameterless Constructor
        /// </summary>
        public XassidaWindow()
        {
            InitializeComponent();

            //previousPagBtn.IsEnabled = false; // Disable the previous page button
        }

        /// <summary>
        /// Constructor with a xassida name as a parameter
        /// </summary>
        /// <param name="xassida"></param>
        public XassidaWindow(string xassida)
        {

        }

        #endregion

        #region Private Methods
        private void LoadXassida()
        {
            RawXsdDocument doc = new RawXsdDocument("xassaides/4.xml");

            XmlNode xassida = doc.innerDoc.GetElementsByTagName("xassida").Item(0);
            String Titre = xassida.Attributes["titre"].InnerText;
            String Tardioumane = xassida.Attributes["tardioumane"].InnerText;
            int BahrusCount = Convert.ToInt16(xassida.Attributes["bahrus_count"].InnerText);

            currentXassida = new Xassida(Titre, Tardioumane, BahrusCount);

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
                currentXassida.Beyits.Add(byt);
            }   
        }
        #endregion

        #region Window Event Handlers
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            myLibraryItemNames = new List<Xassida>();
            
            BookPage titlePage, tardioumanePage, bp;

            LoadXassida();

            this.DataContext = currentXassida;

            PagesCollection = new PaginatedCollection<Beyit>(currentXassida.Beyits);

            /// the title of the xassida will be the first page
            /// 
            titlePage = new BookPage();

            StackPanel p = new StackPanel() { VerticalAlignment = VerticalAlignment.Center };
            TextBlock tPageTb = new TextBlock()
            {
                Text = currentXassida.Titre,
                FontSize = 35,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextAlignment = TextAlignment.Center,
                TextWrapping = TextWrapping.Wrap
            };
            p.Children.Add(tPageTb);
            titlePage.Content = p;

            readerBook.Items.Add(titlePage);

            tardioumanePage = new BookPage();
            tardioumanePage.Content = new TextBlock() 
            { 
                Text = currentXassida.Tardioumane, 
                TextWrapping = TextWrapping.WrapWithOverflow,
                VerticalAlignment = VerticalAlignment.Center,

            };

            readerBook.Items.Add(tardioumanePage);

            for (int i = 0; i < PagesCollection.PagesCount; i++)
            {

                bp = new BookPage();
                StackPanel container = new StackPanel() { Orientation = Orientation.Vertical, VerticalAlignment = VerticalAlignment.Center };


                foreach (Beyit beyit in PagesCollection.GetData(i))
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

            AppStore = IsolatedStorageFile.GetUserStoreForDomain();
            // Check for files saved in isolated storage
            foreach (string file in AppStore.GetFileNames())
            {
                myLibraryItemNames.Add(new Xassida() { Titre = file});
            }

            // Set the items source of the myLibrary List view 


            myLibraryListView.ItemsSource = myLibraryItemNames;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (readerBook.CurrentSheetIndex < readerBook.GetItemsCount() / 2)
            {
                readerBook.AnimateToNextPage(true, pageAnimationDuration);
                //readerBook.CurrentSheetIndex++;
            }

            if (!previousPagBtn.IsEnabled)
            {
                previousPagBtn.IsEnabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousPagBtn_Click(object sender, RoutedEventArgs e)
        {
            if (readerBook.CurrentSheetIndex > 0)
            {
                //readerBook.CurrentSheetIndex--;
                readerBook.AnimateToPreviousPage(true, pageAnimationDuration);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdfButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pptButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mp3Button_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kurelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rajazButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leeralButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arabicFontsGallery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Handles when the user clicks in an item in the myLibraryListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myLibraryListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            object current = myLibraryListView.SelectedItem;
            MessageBox.Show(current.ToString());
        }

        #endregion


    }
}

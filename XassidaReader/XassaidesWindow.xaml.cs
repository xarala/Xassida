
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;
using Xarala;
using Xarala.Xassida;
using System.Windows.Navigation;

namespace XassidaReader
{

    /// <summary>
    /// Interaction logic for XassaidesWindow.xaml
    /// </summary>
    public partial class XassaidesWindow : Window
    {

        /// <summary>
        /// List of Xassaides
        /// </summary>
        public List<Xassida> ListXassiDas = new List<Xassida>();



        /// get a store in isolated strorage
        /// 
        IsolatedStorageFile IsolatedStore = IsolatedStorageFile.GetUserStoreForDomain();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public XassaidesWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            /// Hide the Buttons
            DonwloadXassidaButton.Visibility = System.Windows.Visibility.Hidden;
            ReadXassidaButton.Visibility = System.Windows.Visibility.Hidden;

            LoadXassaides();

            this.DataContext = ListXassiDas;
        }


        private void LoadXassaides()
        {
            ListXassiDas.Add(new Xassida() { Titre = "Ahbabtu", Tardioumane = "Ahbabtu" });
            ListXassiDas.Add(new Xassida() { Titre = "Assirou", Tardioumane = "Assirou" });
            ListXassiDas.Add(new Xassida() { Titre = "Mawahibou", Tardioumane = "Mawahibou" });
            ListXassiDas.Add(new Xassida() { Titre = "Midaadi", Tardioumane = "Midaadi" });
            ListXassiDas.Add(new Xassida() { Titre = "Mimiya", Tardioumane = "Mimiya" });
        }

        /// <summary>
        /// Event handling when selection changed in the listbox    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Xassida selected = (Xassida) XassaidesListBox.SelectedItem;

            SelectedXassidaTitle.Text = selected.Titre;
            SelectedXassidaTardioumane.Text = selected.Tardioumane;

            /// Show the buttons
            DonwloadXassidaButton.Visibility = System.Windows.Visibility.Visible;
            ReadXassidaButton.Visibility = System.Windows.Visibility.Visible;
        }

        /// <summary>
        /// Handle the event when the user clicks the dowload button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dowload_Xassida_Button_Click(object sender, RoutedEventArgs e)
        {
            /// get a reference to the currently selected xassida in the list
            /// 
            Xassida selectedXassida = (Xassida)XassaidesListBox.SelectedItem;

            /// Isolated storage file
            ///
            IsolatedStorageFileStream IsolatedStream;

            /// create a new xml serializer
            /// 
            XmlSerializer Serializer = new XmlSerializer(typeof(Xassida));

            /// open a stream in the store
            /// 
            IsolatedStream = new IsolatedStorageFileStream(selectedXassida.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, IsolatedStore);

            /// serialize the object
            /// 
            Serializer.Serialize(IsolatedStream, selectedXassida);
           
            
            MessageBox.Show(IsolatedStore.AvailableFreeSpace.ToString());
        }

        /// <summary>
        /// Handle the ReadXassidaButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadXassidaButton_Click(object sender, RoutedEventArgs e)
        {
            XassidaWindow w = new XassidaWindow();
            w.Owner = this;
            w.Show();

        }

    }
}

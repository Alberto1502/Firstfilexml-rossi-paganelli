using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.IO;

namespace EsXml_Paganelli_Rossi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_Crea_Click(object sender, RoutedEventArgs e)
        {
            //XDocument xmlDocument = XDocument.Load(@"Z:\Tpi\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libri.xml");
            XDocument xmlDoc = XDocument.Parse(File.ReadAllText(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml", System.Text.Encoding.UTF8), LoadOptions.None);

            IEnumerable<string> names = from libri in xmlDoc.Descendants("wiride")
                                        where libri.Element("codice_scheda").Value == "M-FKB0GR01"
                                        select libri.Element("titolo").Element("proprio").Value;

            foreach (string nomi in names)
                MessageBox.Show(nomi);

            // xmlDoc.Save(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml");
        }

        private void BtnFile_Click(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml", System.Text.Encoding.UTF8);
            text = text.Replace("\r", "").Replace("\n", "");
            File.WriteAllText(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml", text);
        }

        private void btn_Find_Print1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ciao");
        }

        private void btn_Find_Print2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Find_Print3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

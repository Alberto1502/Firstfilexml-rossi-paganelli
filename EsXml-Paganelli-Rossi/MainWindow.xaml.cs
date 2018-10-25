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

            

        }

        private void BtnFile_Click(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml", System.Text.Encoding.UTF8);
            text = text.Replace("\r", "").Replace("\n", "");
            File.WriteAllText(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml", text);
        }

        private void btn_Find_Print1_Click(object sender, RoutedEventArgs e)
        {
            lst1.Items.Clear();

            string cognome = txt_InputAuthor.Text;

            XDocument xmlDoc = XDocument.Parse(File.ReadAllText(@"C:\Users\a.atanasov\Desktop\Elenco\libri.xml"));

            IEnumerable<string> names = from libri in XDocument.Load(@"C:\Users\a.atanasov\Desktop\Elenco\libri.xml").Elements("Biblioteca").Elements("wiride")
                                        where (string)libri.Element("autore").Element("cognome") == cognome
                                        select libri.Element("titolo").Value;


            foreach (string n in names)
                lst1.Items.Add(n);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lst1.Items.Clear();

           
            int i = 0;
            XDocument xmlDoc = XDocument.Parse(File.ReadAllText(@"C:\Users\alberto.paganelli\Desktop\Elenco\libri.xml"));

            IEnumerable<string> names = from libri in XDocument.Load(@"C:\Users\alberto.paganelli\Desktop\Elenco\libri.xml").Element("Biblioteca").Elements("wiride")
                                        select libri.Element("genere").Value;



            foreach (string n in names)
                if (n == "romanzo" || n == "romanzo breve" || n == "romanzo giallo"|| n== "romanzo satirico" || n=="romanzo psicologico"|| n == "romanzo umoristico")
                    i++;

            lbl_genere.Content = i;
        }

        private void btn_Find_Print2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Find_Print3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

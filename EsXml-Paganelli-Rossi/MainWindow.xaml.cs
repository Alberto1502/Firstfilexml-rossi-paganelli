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

        private void btn_Find_Print2_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void btn_Find_Print3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

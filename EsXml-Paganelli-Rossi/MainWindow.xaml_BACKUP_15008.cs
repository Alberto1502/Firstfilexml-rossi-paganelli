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

        private void btn_Find_Print1_Click(object sender, RoutedEventArgs e)
        {


          
        }

<<<<<<< HEAD
       

        private void btn_Find_Print1_Click(object sender, RoutedEventArgs e)
        {
            lst1.Items.Clear();

            string cognome = txt_InputAuthor.Text;
=======
        private void btn_DeleteTagAbstract_Click(object sender, RoutedEventArgs e)
        {
            XDocument xmlDocument = XDocument.Load("../../../libri.xml");
>>>>>>> adecaf87d420dd349acc8c1bb8484197b825eccd

            XElement element = (from xml1 in xmlDocument.Descendants("abstract")
                                select xml1).FirstOrDefault();

            element.Remove();

            xmlDocument.Save(@"../../../libri.xml");

        }

        private void btn_FindNCopies_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txt_InputKeywords.Text;
            int cont = 0;

            XDocument xmlDoc = XDocument.Parse(File.ReadAllText(@"C:\Users\a.atanasov\Desktop\Elenco\libri.xml"));

            IEnumerable<string> names = from libri in XDocument.Load(@"C:\Users\a.atanasov\Desktop\Elenco\libri.xml").Elements("Biblioteca").Elements("wiride")
                                        where (string)libri.Element("titolo") == titolo
                                        select libri.Element("titolo").Value;

            foreach (string n in names)
                cont++;

            nCopie.Content = cont;

        }

        private void btn_CreateNewFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

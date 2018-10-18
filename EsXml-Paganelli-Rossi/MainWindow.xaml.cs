using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
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

namespace EsXml_Paganelli_Rossi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(@"C:\Users\alberto.paganelli\Desktop\PrimoEs\libri.xml");
            
            IEnumerable<string> names = from libri in xmlDocument.Descendants("wiride")
                                        where libri.Element("codice_scheda").Value == "M-FKB0GR01"
                                        select libri.Element("titolo").Element("proprio").Value;

            foreach (string nomi in names)
                MessageBox.Show(nomi);


            XDocument xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
            // xmlDoc.Save(@"E:\esercizioLibriXML\esercizioLibriXML_Galbucci_Neri\esercizioLibriXML_Galbucci_Neri\libriSer.xml");
        }
    }
    }
}

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
using System.IO;

namespace TanulasEllenorzoKviz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> tantargyak = new List<string>();
        List<string> temakorok;

        public MainWindow()
        {
            FeladatokBeolvasas();
            InitializeComponent();
        }

        private void FeladatokBeolvasas()
        {
            string[] feladatok = Directory.GetFiles(@".\feladatok\", "*.txt");
        }

        private void Cboxfeltotlese()
        {

        }
    }
}

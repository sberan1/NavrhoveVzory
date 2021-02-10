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
using NavrhoveVzoryUkol.Model;
using NavrhoveVzoryUkol.ViewModel;

namespace NavrhoveVzoryUkol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClovekUlozeni ulozit = new ClovekUlozeni();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tlacitko_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clovek clovek = new Clovek(JmenoField.ToString(), PrijmeniField.ToString(), Convert.ToDateTime(RokNarozeniField), RodneCisloField.ToString());
                ulozit.ulozitDoDB(clovek);
            }
            catch
            {
                MessageBox.Show("jedno ze zadanych poli neni spravne");
            }




        }
    }
}

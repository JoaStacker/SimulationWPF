using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimulationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowsFormsHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            //System.Windows.MessageBox.Show("Button clicked!");
        }

        private void Button_Click_1(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters();
            parameters.Show();
        }
    }
}
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
using WpfApplication1.Controls.NoiseNode;
using WpfApplication1.ViewModels.NoiseNode;

namespace WpfApplication1.Controls
{
    /// <summary>
    /// Interaction logic for NoiseNode.xaml
    /// </summary>
    public partial class NoiseNodeControl : UserControl
    {
        private FastNoiseCLI.FastNoiseCLI fastNoise;
        private NoiseNodeViewModel vm;

        public NoiseNodeControl()
        {
            InitializeComponent();
            fastNoise = new FastNoiseCLI.FastNoiseCLI();
            vm = new NoiseNodeViewModel(fastNoise);
            this.DataContext = vm;
        }

        public FastNoiseCLI.FastNoiseCLI NoiseMachine { get { return fastNoise; } }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NoiseNodeConfig config = new NoiseNodeConfig(vm);
            config.Show();
        }
    }
}

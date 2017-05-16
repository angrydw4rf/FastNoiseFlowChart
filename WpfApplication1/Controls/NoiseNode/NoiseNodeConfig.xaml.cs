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
using System.Windows.Shapes;
using WpfApplication1.ViewModels.NoiseNode;

namespace WpfApplication1.Controls.NoiseNode
{
    /// <summary>
    /// Interaction logic for NoiseNodeConfig.xaml
    /// </summary>
    public partial class NoiseNodeConfig : Window
    {
        private NoiseNodeViewModel vm;

        public NoiseNodeConfig()
        {
            InitializeComponent();
            var test = Enum.GetValues(typeof(Interp));
            interpInput.ItemsSource = Enum.GetValues(typeof(Interp));
        }

        public NoiseNodeConfig(NoiseNodeViewModel _vm)
        {
            InitializeComponent();
            vm = _vm;
            this.DataContext = vm;
            var test = Enum.GetValues(typeof(Interp));
            interpInput.ItemsSource = Enum.GetValues(typeof(Interp)).Cast<Interp>();
            noiseTypeInput.ItemsSource = Enum.GetValues(typeof(NoiseType)).Cast<NoiseType>();
        }

        private void seed_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Text) && !string.IsNullOrWhiteSpace(e.Text))
            {
                int value;

                if (int.TryParse(e.Text, out value))
                {
                    vm.Seed = value;
                }
                else
                    e.Handled = false;
            }
            else
            {
                e.Handled = false; 
            }
        }
    }
}

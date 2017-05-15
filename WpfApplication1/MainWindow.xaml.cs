using System;
using System.Collections.Generic;
using System.Drawing;
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
using WpfApplication1.ViewModels.Main;
using WpfApplication1.ViewModels.NoiseNode;
using WpfApplication1.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm;
        private FlowChart flowchart;

        public BitmapSource bmpSource;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowViewModel();
            flowchart = new Windows.FlowChart();
            this.DataContext = vm;
        }

        public BitmapSource GenerateBitmap()
        {
            double dpi = 96;
            int width = 512;
            int height = 512;
            int stride = width;
            byte[] pixelData = new byte[width * height];
            float lowest = 1.0f;
            float highest = -1.0f; ;

           
            for (int y = 0; y < height; ++y)
            {
                int yIndex = y * width;
                for (int x = 0; x < width; ++x)
                {
                    
                    float value = flowchart.StartNode.NoiseMachine.Get2dValue(x, y);
                    float pixelValue = 255 * (value + 1.0f) / 2;

                    lowest = value < lowest ? value : lowest;
                    highest = value > highest ? value : highest;
                    pixelData[x + yIndex] = (byte)pixelValue;
                }
            }
            return BitmapSource.Create(width, height, dpi, dpi, PixelFormats.Gray8, null, pixelData, stride);
        }

        private void generate_button_Click(object sender, RoutedEventArgs e)
        {
            vm.HeightMap = GenerateBitmap();
        }

        private void flowchart_button_click(object sender, RoutedEventArgs e)
        {
            flowchart.Show();
        }
    }
}

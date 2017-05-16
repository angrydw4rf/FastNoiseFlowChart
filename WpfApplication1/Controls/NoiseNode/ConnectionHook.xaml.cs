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
using WpfApplication1.Interfaces;

namespace WpfApplication1.Controls.NoiseNode
{
    /// <summary>
    /// Interaction logic for ConnectionHook.xaml
    /// </summary>
    public partial class ConnectionHook : UserControl
    {
        public enum ConnectionType { Input, Output }
        private FlowChartElementInterface _node;
        
        public ConnectionHook()
        {
            InitializeComponent();
        }

        public FlowChartElementInterface Node { get { return _node; } set { _node = value; }  }
        public ConnectionType Type { get; set; }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(this,
                                    this.Node,
                                    DragDropEffects.Copy);
            }
            /*
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                _isDragging = true;

            }
            */
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            /*
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                start = this.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0));
            }
            */
        }

        private void drop(object sender, DragEventArgs e)
        {
            int i=0;
            i++;
        }
    }
}

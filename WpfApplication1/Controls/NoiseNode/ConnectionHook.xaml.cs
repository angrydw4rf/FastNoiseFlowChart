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

        public FlowChartElementInterface Node {
            get
            {
                DependencyObject ucParent = this.Parent;

                while(!(ucParent is UserControl)) //Or FlowChartElementInterface?
                {
                    ucParent = LogicalTreeHelper.GetParent(ucParent);
                }

                return ucParent as FlowChartElementInterface;
            }
        }
        public ConnectionType Type { get; set; }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject dragData = new DataObject(typeof(FlowChartElementInterface), Node);
                DragDrop.DoDragDrop(this,
                                    dragData,
                                    DragDropEffects.Copy);
            }
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
            if (Type == ConnectionType.Input)
            {
                Node.Input = (FlowChartElementInterface)e.Data.GetData(typeof(FlowChartElementInterface));
                Node.Input.Output = this.Node;
            }
            else if (Type == ConnectionType.Output)
            {
                Node.Output = (FlowChartElementInterface)e.Data.GetData(typeof(FlowChartElementInterface));
            }
        }
    }
}

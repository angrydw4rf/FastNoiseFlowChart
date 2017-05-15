using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApplication1.ViewModels.Main
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private BitmapSource heightMap;
        public event PropertyChangedEventHandler PropertyChanged;

        public BitmapSource HeightMap {
            get
            {
                return heightMap;
            }
            set
            {
                this.heightMap = value;
                OnPropertyChanged("HeightMap");
            }
        }

        protected void OnPropertyChanged(String name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
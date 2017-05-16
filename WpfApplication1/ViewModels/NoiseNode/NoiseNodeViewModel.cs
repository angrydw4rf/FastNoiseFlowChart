using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication1.Interfaces;
using static FastNoiseCLI.FastNoiseCLI;

namespace WpfApplication1.ViewModels.NoiseNode
{
    public class NoiseNodeViewModel 
    {
        private FastNoiseCLI.FastNoiseCLI fastNoise;

        public NoiseNodeViewModel()
        {

        }

        public NoiseNodeViewModel(FastNoiseCLI.FastNoiseCLI _fastNoise)
        {
            fastNoise = _fastNoise;
        }

        public FlowChartElementInterface Node { get; set; }
        public float GetNoiseValue(int x, int y, float? currentValue = null)
        {
            return fastNoise.Get2dValue(x, y);
        }
        public string Name { get; set; }

        public int Seed { get
            {
                return fastNoise.GetSeed();
            }
            set
            {
                fastNoise.SetSeed(value);
            }
        }

        public float Frequency
        {
            get
            {
                return fastNoise.GetFrequency();
            }
            set
            {
               
                fastNoise.SetFrequency(value);
            }
        }

        public FastNoise.Interp Interp
        {
            get
            {
                return fastNoise.GetInterp();
            }
            set
            {
                fastNoise.SetInterp(value);
            }
        }

        public FastNoise.NoiseType NoiseType
        {
            get
            {
                return fastNoise.GetNoiseType();
            }
            set
            {
                fastNoise.SetNoiseType(value);
            }
        }


    }
}

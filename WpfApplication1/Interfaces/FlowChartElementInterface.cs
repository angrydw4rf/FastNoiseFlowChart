using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Interfaces
{
    public interface FlowChartElementInterface
    {
        FlowChartElementInterface GetNextNode();
        float GetValue(int x, int y, float? currentValue = null);
        FlowChartElementInterface Input { get; set; }
        FlowChartElementInterface Output { get; set; }
    }
}

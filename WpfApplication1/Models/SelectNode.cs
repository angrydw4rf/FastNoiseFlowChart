using System;
using System.Collections.Generic;
using WpfApplication1.Utilities;
using WpfApplication1.Interfaces;
using System.Linq;

namespace WpfApplication1.Models
{
    public struct SelectOption
    {
        public FlowChartElementInterface Input;
        public Range<float> Range;
    }
    public class SelectNode
    {
        private List<SelectOption> inputs;
        static private Range<float> defaultRange = new Range<float>(-1.0f, 1.0f);

        public bool AddInput(FlowChartElementInterface option, Range<float> range = null)
        {
            if (range == null)
                range = defaultRange;

            if (inputs.Where(i => i.Range.ContainsRange(range) == true).Any())
            {
                return false;
            }
            else
            {
                inputs.Add(new SelectOption { Input = option, Range = range });
                return true;
            }
        }
    }
}

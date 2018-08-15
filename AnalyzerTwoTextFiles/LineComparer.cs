using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzerTwoTextFiles
{
    class LineComparer : IEqualityComparer<Line>
    {
        public bool Equals(Line x, Line y)
        {
            return x.Text.Equals(y.Text);
        }

        public int GetHashCode(Line obj)
        {
            return obj.Text.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzerTwoTextFiles
{
    class Line
    {
        public enum LineType
        {
            Unchanged, //неизмененная
            Added, //добавленная
            Deleted, //удаленная
        }

        public string Text { get; set; }
        public LineType Type { get; set; }

        public override string ToString()
        {
            return $"{Text} : {Type}";
        }
    }
}

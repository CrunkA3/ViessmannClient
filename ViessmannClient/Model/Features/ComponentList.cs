using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ViessmannClient.Model.Features
{
    [DebuggerDisplay("{ToString(),nq}")]
    public class ComponentList : List<string>
    {
        public override string ToString() => string.Join(", ", this.Select(c => $"\"{c}\""));
    }
}
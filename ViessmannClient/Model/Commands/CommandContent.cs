using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViessmannClient.Model.Commands
{
    public class CommandContent<T>
    {
        public string? CommandName { get; set; }
        public T? CommandBody { get; set; }
    }
}

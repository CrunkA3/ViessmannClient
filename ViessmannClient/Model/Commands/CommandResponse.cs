using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ViessmannClient.Model.Commands
{
    public class CommandResponse<T> : IWiremessage<T> where T : SuccessState
    {
        public T? Data { get; set; }

        public PagingCursor? Cursor => null;
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class PingHandler
    {
        public string Message { get; set; }
        public PingHandler(string message) => Message = message;
    }
}

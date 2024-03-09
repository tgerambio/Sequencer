using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencer
{
    internal class EventArgs<T>(T data) : EventArgs
    {
        public T Data { get; set; } = data;
    }
}

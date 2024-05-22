using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte2.Interface;

namespace Transporte2.Model
{
    public class Transport
    {
        public IEngine engine {  get; set; }
        public IDriver driver { get; set; }

        public void Deliver(string destination, string cargo)
        {

        }
    }
}

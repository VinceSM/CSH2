using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte2.Interface;

namespace Transporte2.Model
{
    public class HumanDriver : IDriver
    { 

        public string Navigate(string Conductor)
        {
            Conductor = $"Conduccion Manual (Humano)";
            return Conductor;

        }
    }
}

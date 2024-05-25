using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte2.Interface;

namespace Transporte2.Model
{
    public class CombustionEngine : IEngine
    {
        public string Move(string Motor)
        {
            Motor = $"Motor a Combustible";
            return Motor;
           
        }
    }
}

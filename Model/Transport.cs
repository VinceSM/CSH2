using Transporte2.Interface;

namespace Transporte2.Model
{
    public class Transport
    {
        public IEngine engine { get; set; }
        public IDriver driver { get; set; }

        public string Motor { get; set; }
        public string Conductor { get; set; }

        public Transport(IEngine engine, string motor, IDriver driver = null, string conductor = null)
        {
            this.engine = engine;
            this.driver = driver;
            Motor = motor;
            Conductor = conductor;
        }

        public string Deliver(string destination, string cargo)
        {
            return destination + cargo;
        }
    }
}
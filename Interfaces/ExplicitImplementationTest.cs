using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    public interface IDoItFast {
        void Go();
    }
    public interface IDoItSlow {
        void Go();
    }

    /// <summary>
    /// If you implement two interfaces, both with the same method and different implementations,
    /// then you have to implement explicitly.
    /// </summary>
    public class ExplicitImplementationTest : IDoItFast, IDoItSlow {
        void IDoItFast.Go() {
            Console.WriteLine("Explicit Implementation, going fast!");
        }

        void IDoItSlow.Go() {
            Console.WriteLine("Explicit Implementation, going slow!");
        }
    }

}

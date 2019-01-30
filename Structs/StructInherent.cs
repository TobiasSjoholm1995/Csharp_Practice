using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs {

    //it can only inherent from interfaces
    public struct StructInherent : Interface1 {

        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}

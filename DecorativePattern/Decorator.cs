using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorativePattern {
    public abstract class Decorator : IComponent {
        protected IComponent component;

        public void SetComponent(IComponent component) {
            this.component = component;
        }

        public virtual void Operation() {
            if (component != null) {
                component.Operation();
            }
        }
    }
}

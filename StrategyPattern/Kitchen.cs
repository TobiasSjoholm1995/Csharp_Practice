using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
    public class Kitchen {
        private string _food;
        private ICookStrategy _cookStrategy;

        public void SetCookStrategy(ICookStrategy cookStrategy) {
            this._cookStrategy = cookStrategy;
        }

        public void Cook() {
            _cookStrategy.Cook(_food);
        }

        public Kitchen(string food) {
            this._food = food;
        }
    }
}

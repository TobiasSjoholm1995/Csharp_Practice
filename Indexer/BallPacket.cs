using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer {
    public class BallPacket {

        private List<Ball> balls;

        public Ball this[int index] {
            get { return balls[index];  }
            set { balls[index] = value; }
        }

        //Overloading, parameter can be of any type
        public bool this[Ball index] {
            get { return balls.Contains(index); }
        }

        //Overloading, make it poss to acces many elements with 1 call
        public IEnumerable<Ball> this[params int[] keys] {
            get { return keys.Select(key => balls[key]); }
        }

        //ovarloading, with multiple parameters is also poss
        public Ball this[int index, Ball b] {
            get { return balls[index]; }
            set { balls[index] = value; }
        }

        public BallPacket() {
            balls = new List<Ball>();
            balls.Add(new Ball(0));
            balls.Add(new Ball(1));
            balls.Add(new Ball(2));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter {
    class Params {

        public Params() {
            Console.WriteLine("Test of keyword: params");
            int sum = Add(1, 2, 3);
            Console.WriteLine("\tsum = " + sum);
        }

        //this is just an example
        //in real, i woud recommend to use  list.Sum();
        public static int Add(params int[] list) {
            int sum = 0;
            for (int i = 0; i < list.Length; i++) {
                sum += list[i];
            }
            return sum;
        }
    }
}

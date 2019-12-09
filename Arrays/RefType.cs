using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    class RefType {
        public RefType() {
            Console.WriteLine(Environment.NewLine + "Arrays are ref types");
            int[] arr = new int[10];

            add(arr, 5, 77);
            Console.WriteLine(arr[5]);

        }

        void add(int[] arr, int position, int value) {
            arr[position] = value;
        }
    }
}

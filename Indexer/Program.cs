using System;

namespace Indexer {

    class Program {
        static void Main(string[] args) {
            BallPacket ballPacket = new BallPacket();
            Ball b = ballPacket[1];

            Console.WriteLine(b.ID);
            Console.WriteLine(ballPacket[b]);

            var balls = ballPacket[0, 1, 2];

            foreach(var item in balls)
                Console.Write(item.ID + ", ");

            Console.ReadKey();
        }
    }
}

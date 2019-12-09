using System;

namespace Dynamic {
    class MethodCalling {

        public MethodCalling() {
            Console.WriteLine(Environment.NewLine + "Method Calling: ");

            dynamic t1 = new Dog();
            ttest(t1);

            dynamic t2 = new BossDog();
            ttest(t2);

            dynamic t3 = new object();
            ttest(t3);

            dynamic t4 = "test";
            ttest(t4);

            IAnimal a = new Dog();
            dynamic t5 = a;
            ttest(t5); 
        }

        //The dynamic dispatcher will try to match the most specific type
        // If no type match, it takes the dynamic   (except null, it behaves weird)

        void ttest(IAnimal a) => Console.WriteLine("\tAnimal");
        void ttest(Dog a) => Console.WriteLine("\tDog");
        void ttest(BossDog a) => Console.WriteLine("\tBossDog");
        void ttest(dynamic a) => Console.WriteLine("\tDynamic");
    }
}

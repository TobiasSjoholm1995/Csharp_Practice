
namespace Practice.Operator {
    class MyObject {
        public int Value { get; set; }

        //This works for almost all operators
        public static MyObject operator +(MyObject o1, MyObject o2) {
            return new MyObject() { Value = o1.Value + o2.Value };
        }
    }
}

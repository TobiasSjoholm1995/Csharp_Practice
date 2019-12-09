
namespace AutoMapping {
    public class MyOtherObject {

        public int Size { get; set; }
        public string Name { get; set; }

        //This wont be able(cuz diff name) to map without config
        public string LName { get; set; }


        //This wont be able(cuz diff type) to map without config
        //it will try to convert it, and throw an exception if it cant
        // what works int --> long,  int --> string
        // what does not work string --> int
        // long --> int   can  work if value is smalle enough  
        //public int Number { get; set; }
    }
}

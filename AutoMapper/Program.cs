using System;
using AutoMapper;

namespace AutoMapping {
    class Program {
        static MyObject o = new MyObject();

        static void Main(string[] args) {
            Console.WriteLine("Auto: ");
            autoMapping();

            Console.WriteLine(Environment.NewLine + "Config: ");
            configMapping();

            Console.ReadKey();
        }

        private static void autoMapping() {
            Mapper.Initialize(cfg => cfg.CreateMap<MyObject, MyOtherObject>());
            MyOtherObject oo = Mapper.Map<MyOtherObject>(o);

            Console.WriteLine(oo.Name);
            Console.WriteLine(oo.Size);
            Console.WriteLine(oo.LName ?? "LName is null");
        }

        private static void configMapping() {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<MyObject, MyOtherObject>()
                .ForMember(dest => dest.LName, opts => opts.MapFrom(source => source.LastName))
            );

            var mapper = config.CreateMapper();
            MyOtherObject oo = mapper.Map<MyOtherObject>(o);

            Console.WriteLine(oo.Name);
            Console.WriteLine(oo.Size);
            Console.WriteLine(oo.LName ?? "LName is null");
        }

    }
}

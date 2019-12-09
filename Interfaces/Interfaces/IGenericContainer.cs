
using System;

namespace Interfaces {
    interface IGenericContainer<T>  {

        T Value { get; set; }

        void Add(T value);

		T Get();

    }
}

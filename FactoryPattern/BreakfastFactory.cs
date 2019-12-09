using System;
using FactoryPattern.Breakfast;

namespace FactoryPattern {
    public static class BreakfastFactory {

        public static iBreakfast CreateBreakfast() {
            DayOfWeek today = getDayOfWeek();

            switch(today) {
                case DayOfWeek.Monday:
                    return new Oatmeal();
                case DayOfWeek.Tuesday:
                    return new Oatmeal();
                case DayOfWeek.Wednesday:
                    return new Oatmeal();
                case DayOfWeek.Thursday:
                    return new Oatmeal();
                case DayOfWeek.Friday:
                    return new Oatmeal();
                case DayOfWeek.Saturday:
                    return new Pancakes();
                default:
                    return new Pancakes();
            }
        }

        private static DayOfWeek getDayOfWeek() => new DateTime().DayOfWeek;

    }
}

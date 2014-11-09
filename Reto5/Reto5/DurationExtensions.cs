using System;

namespace Reto5 {

    public enum Duration { Day, Week, Month }
    public static class DurationExtensions {
        public static DateTime From(this Duration duration, DateTime dateTime) {
            switch (duration) {
                case Duration.Day:
                    return dateTime.AddDays(1);
                case Duration.Week:
                    return dateTime.AddDays(7);
                case Duration.Month:
                    return dateTime.AddDays(30);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
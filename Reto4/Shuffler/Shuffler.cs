using System;
using System.Collections.Generic;

namespace Shuffler {
    public static class Shuffler {
        public static List<T> Shuffle<T>(this IList<T> lista) {
            var list = new List<T>(lista);
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1) {
                int k = rnd.Next(n - 1);
                T value = list[k];
                list[k] = list[n-1];
                list[n-1] = value;
                if (lista[k].Equals(list[k]))
                    continue;
                n--;
            }
            return list;
        }
    }
}
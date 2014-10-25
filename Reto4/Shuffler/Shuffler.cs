using System;
using System.Collections.Generic;
using System.Linq;

namespace Shuffler {
    public static class Shuffler {
        public static List<T> Shuffle<T>(this IList<T> lista) {
            var list = lista.ToArray();
            int n = lista.Count;
            var rnd = new Random();
            for (var index = n; index > 1; index--) {
                int k = rnd.Next(index - 1);
                T value = list[k];
                list [k] = list[index - 1];
                list[index - 1] = value;
            }
            return list.ToList();
        }
    }
}
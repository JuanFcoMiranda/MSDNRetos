using System.Collections.Generic;
using System.Linq;

namespace Reto5 {
    public class DictionaryPlus<T, T1> : Dictionary<T, T1> {
        public IEnumerable<T1> this[params T[] keys] {
            get { return keys.Select(p => base[p]); }
        }
    }
}
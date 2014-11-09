using System;
using System.Runtime.CompilerServices;

namespace Reto5 {
    public static class Extensions {
        public static void ToUpperNoCopy(this string cadena) {
            if (string.IsNullOrWhiteSpace(cadena))
                throw new ArgumentNullException("cadena");
            unsafe {
                fixed (char* l_pSrc = cadena) {
                    for (int i = 0; i < cadena.Length; i++) {
                        l_pSrc[i] = Char.ToUpper(cadena[i]);
                    }
                }
            }
        }

        public static T NotNull<T>(this T source, string paramName = null, [CallerMemberName] string name = null)
            where T : class {
            if (source == null) {
                throw new ArgumentNullException(paramName, string.Format("{0} was called with null parameter", name));
            }
            return source;
        }
    }
}
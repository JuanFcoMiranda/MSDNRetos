using System.Collections.Generic;
using System.Linq;
using Reto1ClassLibrary;

namespace Reto1Lib {
    public class Reto1 {
        public static List<Persona> OrdenarLista(List<Persona> lista) {
            if (lista != null)
                return (from p in lista
                        orderby p.Edad descending, p.Nombre 
                        select p).ToList();
            return null;
        }
    }
}

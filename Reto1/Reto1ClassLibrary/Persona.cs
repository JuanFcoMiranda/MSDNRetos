using System;

namespace Reto1ClassLibrary {
    public class Persona : IEquatable<Persona> {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public bool Equals(Persona otraPersona) {
            return otraPersona != null && Nombre == otraPersona.Nombre && Edad == otraPersona.Edad;
        }

        public override bool Equals(object obj) {
            var otraPersona = obj as Persona;
            return otraPersona != null && Nombre == otraPersona.Nombre && Edad == otraPersona.Edad;
        }

        public override int GetHashCode() {
            return Tuple.Create(Nombre, Edad).GetHashCode();
        }
    }
}
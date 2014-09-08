using System;

namespace Reto1ClassLibrary {
    public class Persona : IEquatable<Persona> {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public bool Equals(Persona otraPersona) {
            return Nombre == otraPersona.Nombre && Edad == otraPersona.Edad;
        }

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            var otraPersona = obj as Persona;
            if (otraPersona == null) {
                return false;
            }

            return Nombre == otraPersona.Nombre && Edad == otraPersona.Edad;
        }
    }
}
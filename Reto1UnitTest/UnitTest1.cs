// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="">
//   
// </copyright>
// <summary>
//   The unit test 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reto1ClassLibrary;
using Reto1Lib;

namespace Reto1UnitTest {
    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class UnitTest1 {
        /// <summary>
        /// The test ordenar lista de personas nula.
        /// </summary>
        [TestMethod]
        public void TestOrdenarListaDePersonasNula() {
            var resultado = Reto1.OrdenarLista(null);
            Assert.IsNull(resultado);
        }

        /// <summary>
        /// The test ordenar lista de personas vacía.
        /// </summary>
        [TestMethod]
        public void TestOrdenarListaDePersonasVacía() {
            var resultado = Reto1.OrdenarLista(new List<Persona>());
            Assert.IsTrue(resultado.Count == 0);
        }

        /// <summary>
        /// The test ordenar lista de personas con elementos.
        /// </summary>
        [TestMethod]
        public void TestOrdenarListaDePersonasConElementos() {
            var listaSinOrdenar = new List<Persona> {
                new Persona { Nombre = "Roya", Edad = 25 }, 
                new Persona { Nombre = "Jose Angel", Edad = 27 }, 
                new Persona { Nombre = "Luis", Edad = 31 }, 
                new Persona { Nombre = "Jose", Edad = 37 }, 
                new Persona { Nombre = "Alex", Edad = 37 }, 
            };

            var resultado = Reto1.OrdenarLista(listaSinOrdenar);

            var listaOrdenada = new List<Persona> {
                new Persona { Nombre = "Alex", Edad = 37 },
                new Persona { Nombre = "Jose", Edad = 37 },
                new Persona { Nombre = "Luis", Edad = 31 },
                new Persona { Nombre = "Jose Angel", Edad = 27 },
                new Persona { Nombre = "Roya", Edad = 25 }
            };

            CollectionAssert.AreEqual(listaOrdenada, resultado);
        }
    }
}
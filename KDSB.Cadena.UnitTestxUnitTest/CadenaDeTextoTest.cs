using KDSB.CadenaDeTexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSB.Cadena.UnitTestxUnitTest
{
    public class CadenaDeTextoTest
    {
        private readonly ManipuladorDeCadenas _manipuladorDeCadenas;

        public CadenaDeTextoTest()
        {
            _manipuladorDeCadenas = new ManipuladorDeCadenas();
        }

        [Fact]
        public void ReverseString_DeberiaInvertirCadena()
        {
            // Arrange
            string entrada = "hola";

            // Act
            string resultado = _manipuladorDeCadenas.ReverseString(entrada);

            // Assert
            Assert.Equal("aloh", resultado);
        }

        [Fact]
        public void RemoveSpaces_DeberiaEliminarEspaciosEnBlanco()
        {
            // Arrange
            string entrada = "h o l a";

            // Act
            string resultado = _manipuladorDeCadenas.RemoveSpaces(entrada);

            // Assert
            Assert.Equal("hola", resultado);
        }
    }
}

using System.Text;
using Entidades.Modelo;
using Entidades.Excepciones;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestNumerosRomanos
    {
        [TestMethod]
        public void AlRecibirUnNumeroUno_EnDecimal_DeberiaObternerUnNumeroRomano()
        {
            //given
            //arrange
            int numero = 1;
            string esperado = "I";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomaro(numero);

            //assert
            //then
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void AlRecibirUnNumeroDos_EnDecimal_DeberiaObternerUnNumeroRomano()
        {
            //given
            //arrange
            int numero = 2;
            string esperado = "II";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomaro(numero);

            //assert
            //then
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void AlRecibirUnNumeroDiez_DeberiaObternerSuEquivalenteRomano(int value)
        {
            //given
            //arrange

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('I', value);
            string esperado =  stringBuilder.ToString();

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomaro(value);

            //assert
            //then
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroInvalidoException))]
        public void AlRecibirInvalido_DeberiaObternerUnError()
        {
            //given
            //arrange

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomaro(0);

            //assert
            //then
  
        }
        [TestMethod]
        [DataRow(10)]
        public void AlRecibirUnNumeroEntero_DeberiaObternerSuEquivalenteRomano(int value)
        {
            //given
            //arrange

            string esperado = "X";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomaro(value);

            //assert
            //then
            Assert.AreEqual(resultado, esperado);
        }

    }
}
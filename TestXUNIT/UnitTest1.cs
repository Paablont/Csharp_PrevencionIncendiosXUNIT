using Csharp_PrevencionIncendiosXUNIT.Model;

namespace TestXUNIT
{
    public class UnitTest1
    {
        [Fact]
        //Test para comprobar que si se introduce un valor negativo en la humedad, devuelva false
        public void TestHumedadFalse()
        {
            bool bien = Csharp_PrevencionIncendiosXUNIT.MainWindow.comprobarHumedad(-5.6);
            Assert.False(bien);
        }
        [Fact]
        //Test para comprobar que si se introduce un valor positivo en la humedad, devuelva true
        public void TestHumedadTrue()
        {
            bool bien = Csharp_PrevencionIncendiosXUNIT.MainWindow.comprobarHumedad(58);
            Assert.True(bien);
        }
        [Fact]

        //Test para comprobar que devuelve un valor correcto en el calculo de CBI
        public void TestCBI()
        {
            int cbi = Csharp_PrevencionIncendiosXUNIT.Model.CalculadoraCBI.CalcularCBI(6.9, 87);
            Assert.Equal(1, cbi);
        }

        
    }
}
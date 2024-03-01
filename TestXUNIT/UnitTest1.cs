namespace TestXUNIT
{
    public class UnitTest1
    {
        [Fact]
        public void TestHumedadFalse()
        {
            bool bien = Csharp_PrevencionIncendiosXUNIT.MainWindow.comprobarHumedad(-5.6);
            Assert.False(bien);
        }
        [Fact]
        public void TestHumedadTrue()
        {
            bool bien = Csharp_PrevencionIncendiosXUNIT.MainWindow.comprobarHumedad(58);
            Assert.True(bien);
        }
        [Fact]
        public void TestCBI()
        {
            int cbi = Csharp_PrevencionIncendiosXUNIT.Model.CalculadoraCBI.CalcularCBI(6.9, 87);
            Assert.Equal(1, cbi);
        }
    }
}
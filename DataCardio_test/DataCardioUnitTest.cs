using CardioLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_test
{
    [TestClass]
    public class DataCardioUnitTest 
    {
        [DataTestMethod]
        [DataRow("uomo", 70, 70, 19, 50, 1428.5)]
        [DataRow("donna", 80, 60, 60, 30, 2306.28)]
        [DataRow("uomo", 90, 80, 40, 60, 6444.72)]
        [DataRow("donna", 65, 50, 14, 100, 2929.55)]
        [DataRow("uomo", 75, 40, 10, 77, 708)]
        [DataRow("donna", 85, 64, 17, 200, 15005.33)]

        public void CalorieBruciate_Test(string genere, int freq, float peso, int anni, double tempo, double risultatoEffettivo)
        {
            double risultatoAspettato = DataCardio.CalorieBruciate(genere, freq, peso, anni, tempo);
            Assert.AreEqual(risultatoAspettato, risultatoEffettivo);
        }
    }
}

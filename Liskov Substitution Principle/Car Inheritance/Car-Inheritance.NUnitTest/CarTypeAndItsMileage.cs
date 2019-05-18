using NUnit.Framework;
using Car_Inheritance;

namespace Tests
{
    [TestFixture]
    public class CarTypeAndItsMileage
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void WagonR_Is_Not_A_Sedan_And_Has_4_Seats()
        {
            int carMileage = 13;
            ICar wagonR = new WagonR(carMileage);

            string expectedMileage = $"{carMileage} kmpl";
            
            Assert.AreEqual(expectedMileage, wagonR.GetMileage());
        }

        [TestCase]
        public void WagonR_Is_Not_A_Sedan_And_Has_4_Seats_Print()
        {
            int carMileage = 13;
            ICar wagonR = new WagonR(carMileage);

            string expectedOutput = $"A {CarType.WagonR} is not a Sedan, is 4 - seater, and has a mileage of around {carMileage} kmpl.";

            Assert.AreEqual(expectedOutput, wagonR.Print(CarType.WagonR));
        }


        [Test]
        public void HondaCity_Is_A_Sedan_And_Has_4_Seats()
        {
            int carMileage = 20;
            ICar hondaCity = new HondaCity(carMileage);

            string expectedMileage = $"{carMileage} kmpl";
            
            Assert.AreEqual(expectedMileage, hondaCity.GetMileage());
        }

        [Test]
        public void HondaCity_Is_A_Sedan_And_Has_4_Seats_Print()
        {
            int carMileage = 20;
            ICar hondaCity = new HondaCity(carMileage);
            
            string expectedOutput = $"A {CarType.HondaCity} is a Sedan, is 4 - seater, and has a mileage of around {carMileage} kmpl.";

            Assert.AreEqual(expectedOutput, hondaCity.Print(CarType.HondaCity));
        }

        [Test]
        public void InnovaCrysta_Is_Not_A_Sedan_And_Has_6_Seats()
        {
            int carMileage = 12;
            ICar innovaCrysta = new InnovaCrysta(carMileage);

            string expectedMileage = $"{carMileage} kmpl";           

            Assert.AreEqual(expectedMileage, innovaCrysta.GetMileage());
        }

        [Test]
        public void InnovaCrysta_Is_Not_A_Sedan_And_Has_6_Seats_Print()
        {
            int carMileage = 12;
            ICar innovaCrysta = new InnovaCrysta(carMileage);
            
            string expectedOutput = $"A {CarType.InnovaCrysta} is not a Sedan, is 6 - seater, and has a mileage of around {carMileage} kmpl.";
            
            Assert.AreEqual(expectedOutput, innovaCrysta.Print(CarType.InnovaCrysta));
        }

    }

}


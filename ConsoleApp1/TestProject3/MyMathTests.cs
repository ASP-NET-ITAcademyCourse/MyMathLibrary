using MyMathLib;
namespace TestProject3
{
    [TestClass]
    public sealed class MyMathTests
    {
        [TestMethod]
        public void MyMathAddTest()
        {
            //arrange
            int arrg1_1 = 2;
            int arrg1_2 = 3;
            double arrg2_1 = 2.0;
            double arrg2_2 = 3.0;
            string arrg3_1 = "2";
            string arrg3_2 = "3";
            double expectedSum = 5.0;
            int nullValue1 = 0;
            double nullValue2 = 0.0;
            string nullValue3 = "0";

            //act
            double intAdd = MyIntMath.Add(arrg1_1, arrg1_2);
            double doubleAdd = MyDoubleMath.Add(arrg2_1, arrg2_2);
            double stringAdd = MyStringMath.Add(arrg3_1, arrg3_2);
            double nullIntAdd = MyIntMath.Add(nullValue1, arrg1_1);
            double nullDoubleAdd = MyDoubleMath.Add(nullValue2, arrg2_1);
            double nullStringAdd = MyStringMath.Add(nullValue3, arrg3_1);
            //assert
            // Проверка корректных вычислений
            Assert.AreEqual(expectedSum, intAdd, 0.0001, "Ошибка сложения int");
            Assert.AreEqual(expectedSum, doubleAdd, 0.0001, "Ошибка сложения double");
            Assert.AreEqual(expectedSum, stringAdd, 0.0001, "Ошибка сложения string");

            // Проверка сложения с нулевыми значениями
            Assert.AreEqual(arrg1_1, nullIntAdd, 0.0001, "Ошибка сложения int с нулем");
            Assert.AreEqual(arrg2_1, nullDoubleAdd, 0.0001, "Ошибка сложения double с нулем");
            Assert.AreEqual(2.0, nullStringAdd, 0.0001, "Ошибка сложения string с нулевой строкой");

            // Проверка на null (для string)
            Assert.ThrowsException<ArgumentNullException>(() =>
                MyStringMath.Add(null, arrg3_1),
                "Не выбрасывается исключение при null аргументе");

            // Проверка точности вычислений
            Assert.IsTrue(Math.Abs(expectedSum - intAdd) < 0.0001,
                "Низкая точность вычислений для int");
            Assert.IsTrue(Math.Abs(expectedSum - doubleAdd) < 0.0001,
                "Низкая точность вычислений для double");
            Assert.IsTrue(Math.Abs(expectedSum - stringAdd) < 0.0001,
                "Низкая точность вычислений для string");
        }
    }
}

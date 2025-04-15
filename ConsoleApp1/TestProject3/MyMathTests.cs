using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathLib;

[TestClass]
public class MathLibraryTests
{
    #region MyIntMath Tests

    [TestMethod]
    public void IntMath_Add_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;
        double expected = 8;

        // Act
        double result = MyIntMath.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void IntMath_Subtract_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 5;
        int b = 3;
        double expected = 2;

        // Act
        double result = MyIntMath.Subtract(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void IntMath_Multiply_ReturnsCorrectProduct()
    {
        // Arrange
        int a = 5;
        int b = 3;
        double expected = 15;

        // Act
        double result = MyIntMath.Multiply(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void IntMath_Divide_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 6;
        int b = 3;
        double expected = 2;

        // Act
        double result = MyIntMath.Divide(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void IntMath_Divide_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 5;
        int b = 0;

        // Act
        MyIntMath.Divide(a, b);
    }

    [TestMethod]
    public void IntMath_Power_ReturnsCorrectResult()
    {
        // Arrange
        int value = 2;
        int exponent = 3;
        double expected = 8;

        // Act
        double result = MyIntMath.Power(value, exponent);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void IntMath_Power_WithNegativeExponent_ReturnsCorrectResult()
    {
        // Arrange
        int value = 2;
        int exponent = -3;
        double expected = 0.125;

        // Act
        double result = MyIntMath.Power(value, exponent);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArithmeticException))]
    public void IntMath_Power_ZeroToNegativeExponent_ThrowsException()
    {
        // Arrange
        int value = 0;
        int exponent = -3;

        // Act
        MyIntMath.Power(value, exponent);
    }

    [TestMethod]
    public void IntMath_SquareRoot_ReturnsCorrectResult()
    {
        // Arrange
        int value = 25;
        double expected = 5;

        // Act
        double result = MyIntMath.SquareRoot(value);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void IntMath_SquareRoot_NegativeValue_ThrowsException()
    {
        // Arrange
        int value = -25;

        // Act
        MyIntMath.SquareRoot(value);
    }

    #endregion

    #region MyDoubleMath Tests

    [TestMethod]
    public void DoubleMath_Add_ReturnsCorrectSum()
    {
        // Arrange
        double a = 5.5;
        double b = 3.2;
        double expected = 8.7;

        // Act
        double result = MyDoubleMath.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void DoubleMath_Subtract_ReturnsCorrectDifference()
    {
        // Arrange
        double a = 5.5;
        double b = 3.2;
        double expected = 2.3;

        // Act
        double result = MyDoubleMath.Subtract(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void DoubleMath_Multiply_ReturnsCorrectProduct()
    {
        // Arrange
        double a = 5.5;
        double b = 3.2;
        double expected = 17.6;

        // Act
        double result = MyDoubleMath.Multiply(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void DoubleMath_Divide_ReturnsCorrectQuotient()
    {
        // Arrange
        double a = 6.6;
        double b = 3.3;
        double expected = 2.0;

        // Act
        double result = MyDoubleMath.Divide(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void DoubleMath_Divide_ThrowsDivideByZeroException()
    {
        // Arrange
        double a = 5.5;
        double b = 0.0;

        // Act
        MyDoubleMath.Divide(a, b);
    }

    [TestMethod]
    public void DoubleMath_Power_ReturnsCorrectResult()
    {
        // Arrange
        double value = 2.5;
        int exponent = 2;
        double expected = 6.25;

        // Act
        double result = MyDoubleMath.Power(value, exponent);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void DoubleMath_SquareRoot_ReturnsCorrectResult()
    {
        // Arrange
        double value = 25.0;
        double expected = 5.0;

        // Act
        double result = MyDoubleMath.SquareRoot(value);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    #endregion

    #region MyStringMath Tests

    [TestMethod]
    public void StringMath_Add_ReturnsCorrectSum()
    {
        // Arrange
        string a = "5.5";
        string b = "3.2";
        double expected = 8.7;

        // Act
        double result = MyStringMath.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void StringMath_Add_NullInput_ThrowsException()
    {
        // Arrange
        string a = null;
        string b = "3.2";

        // Act
        MyStringMath.Add(a, b);
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void StringMath_Add_InvalidFormat_ThrowsException()
    {
        // Arrange
        string a = "5.5";
        string b = "abc";

        // Act
        MyStringMath.Add(a, b);
    }

    [TestMethod]
    public void StringMath_Subtract_ReturnsCorrectDifference()
    {
        // Arrange
        string a = "5.5";
        string b = "3.2";
        double expected = 2.3;

        // Act
        double result = MyStringMath.Subtract(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void StringMath_Multiply_ReturnsCorrectProduct()
    {
        // Arrange
        string a = "5.5";
        string b = "3.2";
        double expected = 17.6;

        // Act
        double result = MyStringMath.Multiply(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void StringMath_Divide_ReturnsCorrectQuotient()
    {
        // Arrange
        string a = "6.6";
        string b = "3.3";
        double expected = 2.0;

        // Act
        double result = MyStringMath.Divide(a, b);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void StringMath_Divide_ZeroDivisor_ThrowsException()
    {
        // Arrange
        string a = "5.5";
        string b = "0";

        // Act
        MyStringMath.Divide(a, b);
    }

    [TestMethod]
    public void StringMath_Power_ReturnsCorrectResult()
    {
        // Arrange
        string value = "2.5";
        int exponent = 2;
        double expected = 6.25;

        // Act
        double result = MyStringMath.Power(value, exponent);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void StringMath_SquareRoot_ReturnsCorrectResult()
    {
        // Arrange
        string value = "25";
        double expected = 5;

        // Act
        double result = MyStringMath.SquareRoot(value);

        // Assert
        Assert.AreEqual(expected, result, 0.0001);
    }

    #endregion
}
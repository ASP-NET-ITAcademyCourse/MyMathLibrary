using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyMathLib
{
    public class MyIntMath
    {

        /// <summary>
        /// Складывает два целых числа и возвращает результат в виде double
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумма a и b в формате double</returns>
        /// <remarks>Может происходить неявное переполнение при очень больших значениях</remarks>
        public static double Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитает второе число из первого и возвращает результат в виде double
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность a и b в формате double</returns>
        /// <remarks>Результат может быть отрицательным</remarks>
        public static double Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножает два целых числа и возвращает результат в виде double
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Произведение a и b в формате double</returns>
        /// <exception cref="OverflowException">Может возникать при умножении очень больших чисел</exception>
        public static double Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Делит первое число на второе и возвращает результат в виде double
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Частное a и b в формате double</returns>
        /// <exception cref="DivideByZeroException">Возникает при попытке деления на ноль</exception>
        /// <remarks>Для целочисленного деления используйте оператор /</remarks>
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            return (double)a / b;
        }

        /// <summary>
        /// Возводит число в указанную степень
        /// </summary>
        /// <param name="value">Основание степени</param>
        /// <param name="exponent">Показатель степени</param>
        /// <returns>Результат возведения в степень в формате double</returns>
        /// <exception cref="ArithmeticException">
        /// Возникает при попытке возвести 0 в отрицательную степень
        /// </exception>
        /// <remarks>
        /// Использует алгоритм быстрого возведения в степень.
        /// Поддерживает отрицательные показатели степени.
        /// </remarks>
        public static double Power(int value, int exponent)
        {
            if (exponent == 0) return 1;
            if (value == 0 && exponent > 0) return 0;
            if (value == 0 && exponent < 0)
            {
                throw new ArithmeticException("Невозможно возвести 0 в отрицательную степень");
            }

            bool isNegativeExponent = exponent < 0;
            exponent = isNegativeExponent ? -exponent : exponent;
            int result = 1;

            while (exponent > 0)
            {
                if ((exponent & 1) == 1) result *= value;
                value *= value;
                exponent >>= 1;
            }

            return isNegativeExponent ? 1.0 / result : result;
        }

        /// <summary>
        /// Вычисляет квадратный корень из числа с заданной точностью
        /// </summary>
        /// <param name="value">Неотрицательное целое число</param>
        /// <param name="epsilon">Точность вычисления (по умолчанию 1e-10)</param>
        /// <returns>Приближенное значение квадратного корня</returns>
        /// <exception cref="ArgumentException">
        /// Возникает при попытке извлечь корень из отрицательного числа
        /// </exception>
        /// <remarks>
        /// Использует метод Ньютона (метод касательных) для вычисления.
        /// Для value = 0 возвращает 0.
        /// </remarks>
        public static double SquareRoot(int value, double epsilon = 1e-10)
        {
            if (value < 0)
            {
                throw new ArgumentException("Нельзя извлечь корень из отрицательного числа");
            }
            if (value == 0) return value;

            double guess = value;
            double difference;

            do
            {
                double nextGuess = (guess + value / guess) / 2;
                difference = nextGuess - guess;
                guess = nextGuess;
            }
            while ((difference > 0 ? difference : -difference) > epsilon);

            return guess;
        }
    }
    public class MyDoubleMath
    {
        /// <summary>
        /// Выполняет сложение двух чисел с плавающей точкой
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумма a и b типа double</returns>
        /// <exception cref="OverflowException">Может возникать при переполнении диапазона double</exception>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Выполняет вычитание двух чисел с плавающей точкой
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность a и b типа double</returns>
        /// <exception cref="OverflowException">Может возникать при выходе за диапазон double</exception>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Выполняет умножение двух чисел с плавающей точкой
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Произведение a и b типа double</returns>
        /// <exception cref="OverflowException">Может возникать при переполнении диапазона double</exception>
        /// <exception cref="ArithmeticException">Может возникать при умножении на бесконечность</exception>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Выполняет деление двух чисел с плавающей точкой
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Частное a и b типа double</returns>
        /// <exception cref="DivideByZeroException">Возникает при делении на ноль</exception>
        /// <exception cref="OverflowException">Может возникать при очень больших/малых значениях</exception>
        /// <remarks>Для целочисленного деления используйте оператор /</remarks>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            return a / b;
        }

        /// <summary>
        /// Возводит число с плавающей точкой в указанную целую степень
        /// </summary>
        /// <param name="value">Основание степени</param>
        /// <param name="exponent">Целочисленный показатель степени</param>
        /// <returns>Результат возведения в степень типа double</returns>
        /// <exception cref="ArithmeticException">
        /// Возникает при попытке возвести 0 в отрицательную степень
        /// </exception>
        /// <remarks>
        /// Использует алгоритм быстрого возведения в степень (сложность O(log n))
        /// Поддерживает отрицательные показатели степени
        /// </remarks>
        public static double Power(double value, int exponent)
        {
            if (exponent == 0) return 1.0;
            if (value == 0 && exponent > 0) return 0.0;
            if (value == 0 && exponent < 0)
            {
                throw new ArithmeticException("Невозможно возвести 0 в отрицательную степень");
            }

            bool isNegativeExponent = exponent < 0;
            exponent = isNegativeExponent ? -exponent : exponent;
            double result = 1.0;

            while (exponent > 0)
            {
                if ((exponent & 1) == 1) result *= value;
                value *= value;
                exponent >>= 1;
            }

            return isNegativeExponent ? 1.0 / result : result;
        }

        /// <summary>
        /// Вычисляет квадратный корень из числа с заданной точностью
        /// </summary>
        /// <param name="value">Неотрицательное число</param>
        /// <param name="epsilon">Точность вычисления (по умолчанию 1e-10)</param>
        /// <returns>Приближенное значение квадратного корня</returns>
        /// <exception cref="ArgumentException">
        /// Возникает при попытке извлечь корень из отрицательного числа
        /// </exception>
        /// <remarks>
        /// Использует итерационный метод Ньютона (метод касательных)
        /// Для value = 0 возвращает 0
        /// Точность регулируется параметром epsilon
        /// </remarks>
        public static double SquareRoot(double value, double epsilon = 1e-10)
        {
            if (value < 0)
            {
                throw new ArgumentException("Нельзя извлечь корень из отрицательного числа");
            }
            if (value == 0) return value;

            double guess = value;
            double difference;

            do
            {
                double nextGuess = (guess + value / guess) * 0.5;
                difference = nextGuess - guess;
                guess = nextGuess;
            }
            while ((difference > epsilon) || (-difference > epsilon));

            return guess;
        }
    }
    public class MyStringMath
    {
        /// <summary>
        /// Складывает два числа, представленных в виде строк, и возвращает результат
        /// </summary>
        /// <param name="a">Первое число в строковом формате</param>
        /// <param name="b">Второе число в строковом формате</param>
        /// <returns>Сумма чисел типа double</returns>
        /// <exception cref="ArgumentNullException">Возникает, если a или b равны null</exception>
        /// <exception cref="FormatException">Возникает, если строки имеют неверный формат числа</exception>
        /// <exception cref="OverflowException">Возникает при выходе за диапазон double</exception>
        public static double Add(string a, string b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Заполните значения!");
            }
            return double.Parse(a) + double.Parse(b);
        }

        /// <summary>
        /// Вычитает второе число из первого, представленных в виде строк
        /// </summary>
        /// <param name="a">Уменьшаемое в строковом формате</param>
        /// <param name="b">Вычитаемое в строковом формате</param>
        /// <returns>Разность чисел типа double</returns>
        /// <exception cref="ArgumentNullException">Возникает, если a или b равны null</exception>
        /// <exception cref="FormatException">Возникает, если строки имеют неверный формат числа</exception>
        /// <exception cref="OverflowException">Возникает при выходе за диапазон double</exception>
        public static double Subtract(string a, string b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Заполните значения!");
            }
            return double.Parse(a) - double.Parse(b);
        }

        /// <summary>
        /// Умножает два числа, представленных в виде строк
        /// </summary>
        /// <param name="a">Первый множитель в строковом формате</param>
        /// <param name="b">Второй множитель в строковом формате</param>
        /// <returns>Произведение чисел типа double</returns>
        /// <exception cref="ArgumentNullException">Возникает, если a или b равны null</exception>
        /// <exception cref="FormatException">Возникает, если строки имеют неверный формат числа</exception>
        /// <exception cref="OverflowException">Возникает при выходе за диапазон double</exception>
        public static double Multiply(string a, string b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Заполните значения!");
            }
            return double.Parse(a) * double.Parse(b);
        }

        /// <summary>
        /// Делит первое число на второе, представленных в виде строк
        /// </summary>
        /// <param name="a">Делимое в строковом формате</param>
        /// <param name="b">Делитель в строковом формате</param>
        /// <returns>Частное чисел типа double</returns>
        /// <exception cref="ArgumentNullException">Возникает, если a или b равны null</exception>
        /// <exception cref="FormatException">Возникает, если строки имеют неверный формат числа</exception>
        /// <exception cref="DivideByZeroException">Возникает при делении на ноль</exception>
        /// <exception cref="OverflowException">Возникает при выходе за диапазон double</exception>
        public static double Divide(string a, string b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Заполните значения!");
            }
            if (double.Parse(b) == 0.0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            return double.Parse(a) / double.Parse(b);
        }

        /// <summary>
        /// Возводит число, представленное в виде строки, в указанную целую степень
        /// </summary>
        /// <param name="value">Основание степени в строковом формате</param>
        /// <param name="exponent">Целочисленный показатель степени</param>
        /// <returns>Результат возведения в степень типа double</returns>
        /// <exception cref="ArgumentNullException">Возникает, если value равен null</exception>
        /// <exception cref="FormatException">Возникает, если строка имеет неверный формат числа</exception>
        /// <exception cref="ArithmeticException">Возникает при попытке возвести 0 в отрицательную степень</exception>
        /// <exception cref="OverflowException">Возникает при выходе за диапазон double</exception>
        /// <remarks>
        /// Использует алгоритм быстрого возведения в степень (сложность O(log n))
        /// Поддерживает отрицательные показатели степени
        /// </remarks>
        public static double Power(string value, int exponent)
        {
            double dValue = double.Parse(value);
            if (value == null)
            {
                throw new ArgumentNullException("Заполните значения!");
            }
            if (exponent == 0) return 1.0;
            if (dValue == 0.0 && exponent > 0) return 0.0;
            if (dValue == 0 && exponent < 0)
            {
                throw new ArithmeticException("Невозможно возвести 0 в отрицательную степень");
            }

            bool isNegativeExponent = exponent < 0;
            exponent = isNegativeExponent ? -exponent : exponent;
            double result = 1.0;

            while (exponent > 0)
            {
                if ((exponent & 1) == 1) result *= dValue;
                dValue *= dValue;
                exponent >>= 1;
            }

            return isNegativeExponent ? 1.0 / result : result;
        }

        /// <summary>
        /// Вычисляет квадратный корень из числа, представленного в виде строки
        /// </summary>
        /// <param name="value">Неотрицательное число в строковом формате</param>
        /// <param name="epsilon">Точность вычисления (по умолчанию 1e-10)</param>
        /// <returns>Приближенное значение квадратного корня типа double</returns>
        /// <exception cref="ArgumentNullException">Возникает, если value равен null</exception>
        /// <exception cref="FormatException">Возникает, если строка имеет неверный формат числа</exception>
        /// <exception cref="ArgumentException">Возникает при попытке извлечь корень из отрицательного числа</exception>
        /// <remarks>
        /// Использует итерационный метод Ньютона (метод касательных)
        /// Для value = 0 возвращает 0
        /// Точность регулируется параметром epsilon
        /// </remarks>
        public static double SquareRoot(string value, double epsilon = 1e-10)
        {
            double dValue = double.Parse(value);
            if (dValue < 0)
            {
                throw new ArgumentException("Нельзя извлечь корень из отрицательного числа");
            }
            if (dValue == 0) return dValue;

            double guess = dValue;
            double difference;

            do
            {
                double nextGuess = (guess + dValue / guess) * 0.5;
                difference = nextGuess - guess;
                guess = nextGuess;
            }
            while ((difference > epsilon) || (-difference > epsilon));

            return guess;
        }
    }

}

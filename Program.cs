using Either;

class Program
{
    static void Main()
    {
        Either<Exception, float> myNum1 = DivideNumber(10, 0);

        myNum1.Fold(
            (ex) => {
                Console.WriteLine(ex.Message);
            },
            (value) =>
            {
                Console.WriteLine(value.ToString());
            }
        );

        Either<Exception, float> myNum2 = DivideNumber(10, 5);

        myNum2.Fold(
            (ex) => {
                Console.WriteLine(ex.Message);
            },
            (value) =>
            {
                Console.WriteLine(value.ToString());
            }
        );
    }

    static Either<Exception, float> DivideNumber(float number, float divider)
    {
        if (divider == 0)
        {
            return new Left<Exception, float>(new DivideByZeroException());
        }

        float result = number / divider;

        return new Right<Exception, float>(result);
    }
}
namespace Either
{
    public abstract class Either<E, T>
    {
        // LEFT => ERROR HANDLING
        // RIGHT => ACTUAL VALUE
        public abstract void Fold(Action<E> leftMethod, Action<T> rightMethod);
    }

    public class Left<E, T> : Either<E, T>
    {
        E ex;

        public Left(E ex)
        {
            this.ex = ex;
        }

        public override void Fold(Action<E> leftMethod, Action<T> rightMethod)
        {
            leftMethod(ex);
        }
    }

    public class Right<E, T> : Either<E, T>
    {
        T value;

        public Right(T value)
        {
            this.value = value;
        }

        public override void Fold(Action<E> leftMethod, Action<T> rightMethod)
        {
            rightMethod(value);
        }
    }
}

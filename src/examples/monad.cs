public class Maybe<T>
{
    public static Maybe<T> None = new Maybe<T>(default(T));
 
    public T Value;
 
    public bool HasValue
    {
        get
        {
            bool hasValue = false;
            if (Value != null && !Value.Equals(default(T)))
                hasValue = true;
            return hasValue;
        }
    }
 
    public Maybe(T value)
    {
        Value = value;
    }
}
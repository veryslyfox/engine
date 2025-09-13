public class ZeroInputException : System.Exception
{
    public ZeroInputException() { }
    public ZeroInputException(string message) : base(message) { }
    public ZeroInputException(string message, Exception inner) : base(message, inner) { }
}
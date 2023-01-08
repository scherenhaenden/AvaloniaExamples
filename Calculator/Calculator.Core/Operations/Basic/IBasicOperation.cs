namespace Calculator.Core.Operations.Basic;

public interface IBasicOperation
{
    public float Calculate(float a, float b);
}

public class Sum : IBasicOperation
{
    public float Calculate(float a, float b)
    {
        return a + b;
    }
}

public class Subtraction : IBasicOperation
{
    public float Calculate(float a, float b)
    {
        return a - b;
    }
}

public class Multiplication : IBasicOperation
{
    public float Calculate(float a, float b)
    {
        
        return a * b;
    }
}

public class Division : IBasicOperation
{
    public float Calculate(float a, float b)
    {
        return a / b;
    }
}

public class BasicOperationFactory
{
    private readonly IBasicOperation _basicOperation;
    
    public IBasicOperation GetOperation(string operation)
    {
        switch (operation)
        {
            case "+":
                return new Sum();
            case "-":
                return new Subtraction();
            case "*":
                return new Multiplication();
            case "/":
                return new Division();
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
    public float Calculate(float a, float b, string operation)
    {
        return GetOperation(operation).Calculate(a, b);
    }
}


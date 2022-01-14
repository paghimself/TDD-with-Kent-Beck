namespace TDD.Tools
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}

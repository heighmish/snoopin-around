public interface ISnoopyService
{
    public int Add(params int[] numbers);

}

public class SnoopyService : ISnoopyService
{
    public int Add(params int[] numbers) {
        return numbers.Aggregate(0, (total, next) => total + next);
    }
}

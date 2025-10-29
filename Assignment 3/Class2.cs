public static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}

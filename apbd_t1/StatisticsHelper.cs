namespace apbd_t1;

public class StatisticsHelper
{
    static double calculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        double average = sum / numbers.Length;
        return average;
    }

    static double calculateMax(int[] numbers)
    {
        return 0.0;
    }
}
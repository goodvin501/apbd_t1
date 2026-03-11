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

    static int calculateMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max) {max = numbers[i];}
        }
        return max;
    }

    static int calculateMin(int[] numbers)
    {
        return 0;
    }
}
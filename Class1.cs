namespace SecondIntoMinutes
{
    public class Class1
    {
        class Program

        {

            static void main()

            {

                int seconds = 288970;

                int secondsinmin = 60;

                int secondsinhour = 60 * 60;

                int secondsinday = 24 * 60 * 60;



                int day = seconds / secondsinday;

                seconds -= day * secondsinday;



                int hour = seconds / secondsinhour;

                seconds -= hour * secondsinhour;



                int min = seconds / secondsinmin;

                seconds -= min * secondsinmin;



                System.Console.WriteLine(day + "Days", hour + "Hours", min + "Minutes", seconds + "Seconds");

                System.Console.ReadKey();



            }

        }
    }
}
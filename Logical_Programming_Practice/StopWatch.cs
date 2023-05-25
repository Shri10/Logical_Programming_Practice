using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Logical_Programming_Practice
{
    internal class StopWatch
    {
        public static void StopW() 
        {
            /*            Stopwatch stopwatch = new Stopwatch();

                        Console.WriteLine("Press Enter to start the stopwatch");
                        Console.ReadLine();
                        stopwatch.Start();

                        Console.WriteLine("Press Enter to stop the stopwatch");
                        Console.ReadLine();
                        stopwatch.Stop();

                        TimeSpan ts = stopwatch.Elapsed;

                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);

                        Console.WriteLine("Elapsed Time: " + elapsedTime);
            */

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Create a timer
            System.Timers.Timer timer = new System.Timers.Timer(1000); // Set up a timer that ticks every second.


            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            // Begin timing
            stopwatch.Start();


            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;

            // Set the Interval to 1 seconds (1000 milliseconds).
            timer.Interval = 1000;
            timer.Enabled = true;


            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

            // Stop timing
            stopwatch.Stop();

            // Stop the timer
            timer.Stop();
            timer.Dispose();

            // Write result
            Console.WriteLine("Total Time elapsed: {0}", stopwatch.Elapsed);

            void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                Console.WriteLine("Elapsed time: {0}", stopwatch.Elapsed.ToString("hh\\:mm\\:ss"));
            }
        }
    }
}

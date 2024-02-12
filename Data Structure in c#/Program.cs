using System.Diagnostics;
namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            // string[] value = { "parses", "parsecs" };
            //Console.WriteLine(Check(value));

            int[] numb = new int[100000];

            BuildArray(numb);

            TimeSpan startTime;
            TimeSpan duration;

            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            DisplayNums(numb);

            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);

            Console.WriteLine("Time: "+ duration.TotalSeconds);

            
           
        }

        public static void BuildArray(int[] numb)
        {
            ////for(int i = 0; i <= 9999; i++) 
            ////{
            ////    numb[i] = i;
            ////}
            
        }

        public static void DisplayNums(int[] ints)
        {
            //foreach(var v in ints)
            //{
            //    Console.WriteLine(v.ToString());
            //}

            for (int i = 0; i < ints.GetUpperBound(0); i++)
            {
                Console.WriteLine(ints[i] + " ");
            }


        }
        public static string Calculate(string str)
        {
            List<int>  retrived = new List<int>{ };
            
            var values =new []{ '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            foreach (var num in str)
            {
                if (values.Contains(num))
                {
                    retrived.Add(int.Parse(num.ToString()));
                }

            }

            var number = retrived.Sum(x => x);

            return number.ToString();
        }

        static bool Check(string[] args)
        {
            string firstvalue = args[0].ToLower();
            string secondvalue = args[1].ToLower();
            foreach (var check in secondvalue)
            {
                if (!firstvalue.Contains(check))
                {
                    return false;
                }
            }
            return true;
        }

        static int ReturnSecondToHighest(int[] values)
        {
          
            var sort = values.OrderByDescending(x => x).ToArray();
            
            return sort[1];
            
        }
    }

    public class Timing
    {
        TimeSpan startTime;
        TimeSpan duration;
        

    }
}
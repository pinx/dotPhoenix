using Calculator; // The legacy code
using Newtonsoft.Json;
using System;
using System.Text;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomingJson;

            if (args.Length == 1)
            {
                // A file name was given as command line argument
                incomingJson = System.IO.File.ReadAllText(args[0]);
            }
            else
            {
                // We expect json to be passed in over stdin
                // The end of the json is marked by an empty line
                string s;
                StringBuilder jsonBuilder = new StringBuilder();
                while ((s = Console.ReadLine()) != null && s != "")
                {
                    jsonBuilder.AppendLine(s);
                }
                incomingJson = jsonBuilder.ToString();
            }

            // Decode the JSON
            NewPair newPair = JsonConvert.DeserializeObject<NewPair>(incomingJson);
            // Call the wrapper method
            double result = Add(newPair);
            // Encode the result
            string outJson = JsonConvert.SerializeObject(new { data = result }, Formatting.Indented);
            // ...and write it to stdout
            Console.WriteLine(outJson);
        }

        // If the Adder class is more complicated, you could
        // write a separate wrapper class for it.
        // Here, we are only wrapping a single method.
        static double Add(NewPair newPair)
        {
            Adder adder = new Adder();
            return adder.Add(newPair.pair);
        }
    }
}

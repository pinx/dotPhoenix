// The wrapper for your legacy data structure
using Newtonsoft.Json;

namespace Calc
{
    [JsonObject]
    class NewPair
    {
        // This class contains a legacy object
        public Calculator.Pair pair { get; }

        public NewPair()
        {
            this.pair = new Calculator.Pair();
        }

        // You can build a new object, containing a legacy object
        // in case you want to expose it to the new application.
        // In this example, we are not doing this.
        public NewPair(Calculator.Pair pair)
        {
            this.pair = pair;
        }

        // Any public properties will be serialized into JSON
        // You can implement any transformations and names here
        public double x
        {
            get { return pair.X; }
            set { pair.X = value; }
        }

        public double y
        {
            get { return pair.Y; }
            set { pair.Y = value; }
        }
    }
}

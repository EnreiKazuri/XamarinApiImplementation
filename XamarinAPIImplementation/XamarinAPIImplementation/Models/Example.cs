using System.Collections.Generic;

namespace XamarinAPIImplementation.Models
{
    public class Example
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public IList<Result> Results { get; set; }
    }


}

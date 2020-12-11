using System;
using System.Text;

namespace XamarinAPIImplementation.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int GamesCount { get; set; }
        public string ImageBackground { get; set; }
        public string Image { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
    }
}

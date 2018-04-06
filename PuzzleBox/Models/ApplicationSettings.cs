using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzleBox.Models
{
    public class ApplicationSettings
    {
        public List<AppSettings> Applications { get; set; }
    }

    public class AppSettings
    {
        public String Name { get; set; }
        public String Image { get; set; }
        public String Url { get; set; }
        public String Reset { get; set; }
    }
}

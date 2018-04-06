using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzleBox.Models
{
    public class SafeApplication
    {
        private readonly AppSettings m_app;

        public String Name { get { return m_app.Name; } }
        public String Image { get { return m_app.Image; } }
        public String Url { get { return m_app.Url; } }

        public SafeApplication(AppSettings app) {
            m_app = app;
        }
    }
}

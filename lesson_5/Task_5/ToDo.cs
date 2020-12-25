using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDo(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }
        
        public ToDo(string title)
        {
            Title = title;
            IsDone = false;
        }
        public ToDo()
        {
            Title = null;
            IsDone = false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUDOKU_OOP___FINAL_NA_PROMISE
{
    internal class Space
    {
        public int Value { get; set; }
        public bool Fixed { get; set; }

        public Space()
        {
            Value = 0;
            Fixed = false;
        }

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Exampls
{
   
        public interface ArrayInterface
        {
            bool Contains(long searchValue);
            bool Insert(long value);
            bool Delete(long value);
            void Display();
            int GetSize();
            long GetMax();
            long GetMin();
        }

    
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Florist
{
    class Decor
    {        
        private List<Tuple<string, string>> decorList = new List<Tuple<string, string>>();

        public void setDecor(string element1, string element2)
        {
            decorList.Add(Tuple.Create(element1, element2));            
        }

        public int getDecorSize()
        {
            return decorList.Count();
        }
    }
}

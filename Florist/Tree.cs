using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist
{
    class Tree
    {
        private List<Tuple<string, string>> treeList = new List<Tuple<string, string>>();

        public void setTree(string element1, string element2)
        {
            treeList.Add(Tuple.Create(element1, element2));
        }

        public int getTreeSize()
        {
            return treeList.Count();
        }
    }
}

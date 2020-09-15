using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist
{
    class Flower
    {
        private List<Tuple<string, string>> flowerList = new List<Tuple<string, string>>();

        public void setFlower(string element1, string element2)
        {
            flowerList.Add(Tuple.Create(element1, element2));
        }

        public int getFlowerSize()
        {
            return flowerList.Count();
        }
    }
}

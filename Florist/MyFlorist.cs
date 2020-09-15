using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Florist
{
    class MyFlorist
    {
        private string name;
        private Tree tree;
        private Flower flower;
        private Decor decor;


        public MyFlorist()
        {
            name = "";
            tree = new Tree();
            flower = new Flower();
            decor = new Decor();
        }

        public void setName(string myName)
        {
            name = myName;
        }

        public int getTreeSize()
        {
            return tree.getTreeSize();
        }

        public int getFlowerSize()
        {
            return flower.getFlowerSize();
        }

        public int getDecorSize()
        {
            return decor.getDecorSize();
        }

        public void setDecor(string element1, string price)
        {
            decor.setDecor(element1, price);
        }

        public void setFlower(string element1, string price)
        {
            flower.setFlower(element1, price);
        }

        public void setTree(string element1, string price)
        {
            MessageBox.Show("Element Added "+ element1);
            tree.setTree(element1, price);
        }
    }
}

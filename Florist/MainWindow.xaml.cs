using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Florist
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyFlorist myFlorist;
        private bool created = false;
        string price, element1;
        /*Tree tree;
        Flower flower;
        Decor decor;*/
        bool action; // true=>flower, false=>tree

        public MainWindow()
        {
            InitializeComponent();
        }
               
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            NameGrid.Visibility=Visibility.Visible;
        }

      
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            myFlorist = new MyFlorist();
            myFlorist.setName(NameText.Text);
            NameGrid.Visibility = Visibility.Hidden;
            created = true;
            MessageBox.Show(NameText.Text+" created.\nYou can insert flowers, decor and trees¡¡");

            /*tree = new Tree();
            flower = new Flower();
            decor = new Decor();*/
        }

        private void Flower_Click(object sender, RoutedEventArgs e)
        {
            if (created)
            {
                Data.Visibility = Visibility.Visible;
                DataDecor.Visibility = Visibility.Hidden;
                PanelList.Visibility = Visibility.Hidden;
                Element1.Text = "Insert Color";
                Element2.Text = "Insert Cost";
                action = true; //flower
            }
            else
                MessageBox.Show("The florist is not created");
        }

        private void Tree_Click(object sender, RoutedEventArgs e)
        {

            if (created)
            {
                Data.Visibility = Visibility.Visible;
                DataDecor.Visibility = Visibility.Hidden;
                PanelList.Visibility = Visibility.Hidden;
                Element1.Text = "Insert Hight";
                Element2.Text = "Insert Cost";
                action = false;
            }
            else
                MessageBox.Show("The florist is not created");
        }

        private void Decor_Click(object sender, RoutedEventArgs e)
        {

            if (created)
            {
                DataDecor.Visibility = Visibility.Visible;
                PanelList.Visibility = Visibility.Hidden;
                Data.Visibility = Visibility.Hidden;
                Element2Decor.Text = "Insert Cost";
            }
            else
                MessageBox.Show("The florist is not created");
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            if (created)
            {
                PanelList.Visibility = Visibility.Visible;
                Data.Visibility = Visibility.Hidden;
                DataDecor.Visibility = Visibility.Hidden;

                //StockList.DataSource = null;
                StockList.Items.Clear();

                StockList.Items.Add("Trees:");
                int trees = myFlorist.getTreeSize();
                StockList.Items.Add("      "+ trees);

                StockList.Items.Add("Flowers:");
                int flowers = myFlorist.getFlowerSize();
                StockList.Items.Add("      " + flowers);

                StockList.Items.Add("Decor:");
                int decors = myFlorist.getDecorSize();
                StockList.Items.Add("      " + decors);
            }
            else
                MessageBox.Show("The florist is not created");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Data.Visibility = Visibility.Hidden;
            DataDecor.Visibility = Visibility.Hidden;
            PanelList.Visibility = Visibility.Hidden;
        }

        private void Add2_Click(object sender, RoutedEventArgs e)
        {
            element1=Combo.SelectedItem.ToString();
            price = Element2Decor.Text;
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (regex.IsMatch(price))
            {
                myFlorist.setDecor(element1, price);
                MessageBox.Show("Element Added");
            }
            else
            {
                MessageBox.Show("The price is wrong¡¡¡ "+price);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            element1 = Element1.Text;
            price = Element2.Text;
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (regex.IsMatch(price))
            {
                if (action)
                {
                    myFlorist.setFlower(element1, price);
                    MessageBox.Show("Element Added");
                }
                else
                {
                    if (regex.IsMatch(element1))
                    {
                        myFlorist.setTree(element1, price);
                        MessageBox.Show("Element Added");
                    }
                    else
                        MessageBox.Show("The hight is wrong¡¡¡");

                }
            }
            else
            {
                MessageBox.Show("The price is wrong¡¡¡");
            }
        }
    }
}

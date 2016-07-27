using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using ThinkLib;

namespace Prac2PartB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int Length(string s)
        {
            int counter =0;
            foreach(char c in s)
            {
                counter++;
            }
            return counter;
        }

        bool Contains(string s, string subs)
        {
            bool isSubString =false;
            int container = 0;
            int counter = 0;
            for(int i=0;i<=Length(s)-1;i++)
            {
                
                if (s[i] == subs[0] && (Length(s)-i)>=Length(subs))
                {
                    container = i;
                    foreach (char c in subs)
                    {
                        if (c == s[container])
                        {
                            counter++;
                            container++;
                        }
                    }                
                }
                //container=containerDuplicate;
                container++;
                
                if (counter != Length(subs))
                {
                    counter = 0;
                }
            }
            if (counter == Length(subs)) isSubString = true;
            return isSubString;
        }

        int IndexOf(string s, string subs)
        {
            int container = 0;
            if (Contains(s, subs) == true)
            {
                while (container <= Length(s) - 1)
                {
                    if (s[container] == subs[0])
                    {
                        return container;
                    }
                    container++;
                }
            }
            else
            {
                container = -1;
            }
            return container;
        }
        //string InsertSubString(string s, string x, int pos)
        //{
            
        //}
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Length("string"), (6));
            Tester.TestEq(Contains("string", "in"), true);
            Tester.TestEq(Contains("stringi", "in"), true);
            Tester.TestEq(IndexOf("string", "in"), (3));
            Tester.TestEq(Contains("Mississippi", "ippi"), true);
            Tester.TestEq(IndexOf("rat", "qw"), (-1));
        }
    }
}

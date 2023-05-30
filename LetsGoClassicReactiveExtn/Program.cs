using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoDotNetReactiveExtn
{
    public class Obserable {
        public BindingList<string> ticker = new BindingList<string>();
     

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Obserable _market = new Obserable();
           
            _market.ticker.ListChanged += (sender, ListChangedEventArgs) =>
                {
                    Console.WriteLine(((BindingList<string>)sender)[ListChangedEventArgs.NewIndex] );
                    Console.Read();
              };

            _market.ticker.Add("NewStock");
        }

        
    }
}

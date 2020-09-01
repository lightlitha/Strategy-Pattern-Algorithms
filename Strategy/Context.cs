using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // This is the super class.
    // Defines the interface of interest to clients
    // Algorithms does not know the concrete classes of its interfaces
    class Context
    {
        private ISort __sort;

        public ISort Algorithm   // property
        {
            get { return __sort; }   // get method
            set { __sort = value; }  // set method
        }
        // Accepts an algorithm through the constructor.
        // Allows change on runtime
        public Context()
        {

        }

        public Context(ISort sort)
        {
            this.__sort = sort;
        }

        // 
        public void ExecuteAlgorithm()
        {
            
            var result = this.__sort.RunAlgorithm(new List<int> { 5, 2, 5, 8, 1, 2, 4, 5 });

            string resultStr = string.Empty;
            foreach (var element in result as List<int>)
            {
                resultStr += element.ToString() + ", ";
            }
            Console.WriteLine("Algorithm: {0} being executed", this.Algorithm);
            Console.WriteLine(resultStr);
        }


    }
}

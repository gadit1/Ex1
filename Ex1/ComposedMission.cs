/************
 * Name: Gadit Shitrit
 * Id: 318817087
 * Course group: 05
 * Name of Exercise : Ex1
 * ***********/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string funcName;
        public event EventHandler<double> OnCalculate;

        //list of delegates
        private List<myFunc> functions = new List<myFunc>();

        //constructor that initialize the name
        public ComposedMission(string name)
        {
            funcName = name;
        }


        public string Name
        {
            get
            {
                return funcName;
            }
            set
            {
                funcName = value;
            }
        }

        public string Type { get; } = "Composed";
        /*
       * Function name: Add
       * parametrs: a function
       * return value: an object of ComposedMission
       * the operation of the function: add the function to a list and return the Composed object
       */
        public ComposedMission Add(myFunc a)
        {
            functions.Add(a);
            return this;
        }
        /*
         * Function name: Calculate
         * parametrs: a value
         * return value: a double value
         * the operation of the function: When a value is received, the function is applied to it and
         the answer is set in the answer variable to obtain an assembly of functions
         */
        public double Calculate(double value)
        {
            double answer = value;
            foreach (myFunc f in functions)
            {
                answer = f(answer);
            }
            if (OnCalculate != null) { 
                OnCalculate.Invoke(this, answer);
            }
            return answer;
        }

    }
}

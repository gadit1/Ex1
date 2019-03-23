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
        /*
         * Function name: ComposedMission
         * parametrs: a name
         * the operation of the function: it's constructor that initialize the name
         */
        public ComposedMission(string name)
        {
            Name = name;
        }
        public string Name
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public event EventHandler<double> OnCalculate;
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
            foreach(var f in functions)
            {
                answer = f(answer);
            }
            if (OnCalculate != null)
                OnCalculate(this, value);
            return answer;
        }
        private List<myFunc> functions = new List<myFunc>();
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
    }
}

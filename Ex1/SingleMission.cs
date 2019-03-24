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
    public class SingleMission : IMission
    {
        private string funcName;

        private myFunc function;

        public event EventHandler<double> OnCalculate;

        // constructor
        public SingleMission(myFunc func, string name)
        {
            function = func;
            funcName = name;
        }

        public string Name
        {
            get
            {
                return funcName;
            }
            private set
            {
                funcName = value;
            }
        }

        public string Type { get; } = "Single";
        /*
        * Function name: Calculate
        * parametrs: double value
        * retuen value: double
        * the operation of the function: calculation of the event
        */
        public double Calculate(double value)
        {
            double answer = function(value);
            if (OnCalculate != null)
                OnCalculate.Invoke(this, answer);
            return answer;
        }

    }
}
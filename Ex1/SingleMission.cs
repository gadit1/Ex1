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
        /*
         * Function name: SingleMission
         * parametrs: a function and name
         * the operation of the function: it's constructor that initialize the function and the name
         */
        public SingleMission(myFunc a, string name)
        {
            Name = name;
            func = a;
        }
        myFunc func;
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
         * parametrs: double value
         * retuen value: double
         * the operation of the function: calculation of the event
         */
        public double Calculate(double value)
        {
            double answer = func(value);
            if (OnCalculate != null)
                OnCalculate(this, answer);
            return answer;
        }
    }
}

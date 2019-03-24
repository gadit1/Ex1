/************
 * Name: Gadit Shitrit
 * Id: 318817087
 * Course group: 05
 * Name of Exercise : Ex1
 * ***********/
using System;
using System.Collections.Generic;
using System.Linq;
/************
 * Name: Gadit Shitrit
 * Id: 318817087
 * Course group: 05
 * Name of Exercise : Ex1
 * ***********/
using System.Text;
using System.Threading.Tasks;
//The Interface Imission
namespace Excercise_1
{
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get;}
        String Type { get; }

        double Calculate(double value);
    }
}

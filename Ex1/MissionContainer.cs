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
    //myFunc is a delegate
    public delegate double myFunc(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, myFunc> functions = new Dictionary<string, myFunc>();
        /*
        * Function name: this
        * parametrs: an indexer
        * return value: an object of myFunc
        * the operation of the function: we search the function. if we found-return it.
        * if it not found-we create a new one and add it to the list and then we return it.
        */
        public myFunc this[string key]
        {
            //search the function
            get
            {
                // running over the names of the functions
                foreach (string name in functions.Keys)
                {
                    if (name == key)
                    {
                        return functions[name];
                    }
                }
                // if the function doesn't exist, add the function to the functions dictionary
                functions.Add(key, val => val);
                return val => val;
            }
            set
            {
                functions[key] = value;
            }

        }
        /*
        * Function name: getAllMissions
        * parametrs: nothing
        * return value: list of the strings
        * the operation of the function: add all the functions to the list and then return the list
        */
        public List<string> getAllMissions()
        {
            List<string> list = new List<string>();
            foreach (var func in functions)
            {
                list.Add(func.Key);
            }
            return list;
        }
    }
}

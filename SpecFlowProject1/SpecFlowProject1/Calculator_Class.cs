using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class Calculator_Class
    {
        public int first_number_var { get; set; }
        public int second_number_var { get; set; }

        public int actual_result;

        public int Addition_Func()
        {
            actual_result = first_number_var + second_number_var;
            return actual_result;
        }

        public int Subtraction_Func()
        {
            actual_result = first_number_var - second_number_var;
            return actual_result;
        }

        public int Multiplication_Func()
        {
            actual_result = first_number_var * second_number_var;
            return actual_result;
        }

        public int Division_Func()
        {
            actual_result = first_number_var / second_number_var;
            return actual_result;
        }


    }
}

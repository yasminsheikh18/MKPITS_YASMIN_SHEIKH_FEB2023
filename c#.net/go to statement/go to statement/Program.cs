﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace go_to_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result=0;
            char op;
            Console.WriteLine("enter 2 number");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter + , - , *");
            op=Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                goto addition;
            }
            else if (op == '-')
            {
                goto substraction;
            }

            else if (op == '*')
            {
                goto multiplication;
            }

            else 
            {
                goto end;
            }

        addition:
            result = num1 + num2;
            goto end;

            substraction:
            result = num1 - num2;   
            goto end;

            multiplication:
            result = num1 * num2;
            goto end;

            end:
            Console.WriteLine("result = " + result);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Projects\All_prac\C#\Lamda Expression\LamdaExpressionDemo\LamdaExpressionDemo\bin\Debug \LamdaExpressionDemo.exe";        
        
            Assembly assembly = Assembly.LoadFile(path);
            Type[] types = assembly.GetTypes(); 

            foreach(var type in types)
            {
                Console.WriteLine("Class Name: "+type.Name);

                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("Method Name: " + method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var para in parameters)
                    {
                        Console.WriteLine("Parameter Name: " + para.Name+" Parameter Type : "+para.ParameterType);
                    }
                }

            }
            Console.ReadLine();
        
        
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Task6
{
    public class ClassFinder
    {
        public static List<string> FindClassesImplementingInterface(Type interfaceType)
        {
            List<string> classNames = new List<string>();

            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();

                foreach (Type type in assembly.GetTypes())
                {
                    if (interfaceType.IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                    {
                        classNames.Add(type.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading assembly: " + ex.Message);
            }

            return classNames;
        }
    }
}

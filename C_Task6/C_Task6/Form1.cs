using Microsoft.VisualBasic;
using System.Reflection;
using static System.Windows.Forms.LinkLabel;

namespace C_Task6
{
    public partial class Form1 : Form
    {
        String assemblyPath = "ClassLibrary1.dll";
        String libraryName = "ClassLibrary1.";
        List<String> classNameList;
        public Form1()
        {

            InitializeComponent();
            classNameList = GetImplementingClasses(assemblyPath, typeof(ClassLibrary1.IPhone));
            foreach (string className in classNameList)
            {
                ClassesComboBox.Items.Add(className);
            }
        }



        public void getClasses()
        {
            Type interfaceType = typeof(IPhone); // Замените на актуальный тип интерфейса

            List<string> classNames = ClassFinder.FindClassesImplementingInterface(interfaceType);

            Console.WriteLine("Classes implementing the interface:");
            foreach (string className in classNames)
            {
                Console.WriteLine(className);
                textBox1.AppendText(className);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string className = ClassesComboBox.SelectedItem.ToString();
            Type type = Assembly.LoadFrom(assemblyPath).GetType(libraryName + className);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            MethodsComboBox.Items.Clear();
            foreach (MethodInfo method in methods)
            {
                if (!IsDefaultMethod(method))
                {
                    MethodsComboBox.Items.Add(method.Name);
                }
            }






            /*
                        String className = ClassesComboBox.SelectedItem.ToString();
                        Type type = Assembly.LoadFrom(assemblyPath).GetType(libraryName + className);

                        object obj = Activator.CreateInstance(type);*/



        }




        private List<string> GetImplementingClasses(string assemblyPath, Type interfaceType)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            List<string> implementingClasses = new List<string>();

            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (interfaceType.IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                {
                    implementingClasses.Add(type.Name);
                }
            }

            return implementingClasses;
        }

        private void GetMethodButton_Click(object sender, EventArgs e)
        {
            string className = ClassesComboBox.SelectedItem.ToString();
            Type type = Assembly.LoadFrom(assemblyPath).GetType(libraryName + className);

            object obj = Activator.CreateInstance(type);

            MethodInfo method = type.GetMethod(MethodsComboBox.SelectedItem.ToString());

            ParameterInfo[] parameters = method.GetParameters();

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                if (parameters.Length == 0)
                {
                    method.Invoke(obj, null);
                }
                else
                {
                    List<object> args = new List<object>();

                    foreach (ParameterInfo parameter in parameters)
                    {
                        string input = Interaction.InputBox($"Введите значение параметра {parameter.Name} для метода {method.Name}", "Значение параметра");
                        object arg = Convert.ChangeType(input, parameter.ParameterType);
                        args.Add(arg);
                    }

                    method.Invoke(obj, args.ToArray());
                }

                string consoleOutput = sw.ToString();
                textBox1.AppendText(consoleOutput);
            }
        }



        private bool IsDefaultMethod(MethodInfo method)
        {
            // Исключаем методы с встроенными атрибутами
            return method.Name == "GetHashCode" ||
                   method.Name == "ToString" ||
                   method.Name == "Equals";
        }

    }


}
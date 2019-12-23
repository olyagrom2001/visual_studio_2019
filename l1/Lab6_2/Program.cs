using System;
using System.Reflection;

namespace Lab6_2
{
    class Program
    {
        public static bool hasPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            attribute = null;
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                attribute = isAttribute[0];
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Type t = typeof(Dog);
            Console.WriteLine("Тип " + t.FullName);
            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (hasPropertyAttribute(x, typeof(AttributeClass), out attrObj))
                {
                    var attr = attrObj as AttributeClass;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
            Console.WriteLine("\nВызов метода:");
            var fi = (Dog)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, null);
            t.InvokeMember("Gav", BindingFlags.InvokeMethod, null, fi, null);
            Console.ReadLine();
        }
    }
}

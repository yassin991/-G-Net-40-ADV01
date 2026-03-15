using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentC_Advanced
{
    internal class Program
    {
        static void Main(string[] args){ }
        #region Qestion01
        //            What is a Generic Class?
        //A generic class is a class that is defined with a type parameter instead of a specific data type.
        //This allows the same class to work with different data types without rewriting the code.

        //            Why Use Generics?
        //            Code Reusability,Type Safety, Better Performance,Cleaner and Maintainable Code.
        #endregion
        #region Question02

        //Q2: Write a generic class Container<T> with Add and Get methods.
        //            Public class Container<T> 
        //        {
        //            public T item;
        //            public void Add(T value)
        //            {
        //                item = value;
        //            }
        //            public T Get()
        //            {
        //               return item;
        //            }

        //        }
        #endregion
        #region Question03
        //        Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
        //Multiple type parameters mean a generic class or method can use more than one placeholder type.
        //This allows the class to work with two or more different data types at the same time.

        //    Public class Pair <TKey,TValue>
        //{
        //    public TKey Key;    
        //    public TValue Value;

        //    public Pair(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine($"Key::{Key},Value::{Value}");
        //    }
        //}

        #endregion
        #region Question04
        //Q4: What is a generic method? Write Swap<T> method.
        //   A generic method is a method that uses a type parameter 
        //   so it can work with different data types without rewriting the method for each type.

        //    public static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}

        #endregion
        #region Question05
        //Q5: Write a generic method FindMax<T> that finds maximum value
        //    public static T FindMax<T>(T a, T b) where T : IComparable<T>
        //{
        //    if (a.CompareTo(b) > 0)
        //        return a;
        //    else
        //        return b;

        //}
        //int max = FindMax(10, 20);
        //Console.WriteLine(max);

        #endregion
        #region Question06
        //Q6: What is a Generic Interface?
        //    A generic interface is an interface that uses a type parameter so it can work with different data types.
        //public interface IRepository<T>
        //{
        //    void add(T item);
        //    void delete(T item);
        //    T Get(int id);
        //}
        #endregion
        #region Question07
        //        Q7: What is the struct Constraint?
        //The struct constraint restricts the generic type to value types only(like int, double, DateTime).

        //public class ValueContainer<T> where T : struct
        //        {
        //            public T Value;
        //        }
        #endregion
        #region Question08
        //        Q8: What is the class Constraint?
        //The class constraint restricts the generic type to reference types only(like string, objects, classes).
        //public class ReferenceContainer<T> where T : class
        //        {
        //            public T Item;
        //        }
        #endregion
        #region Question09
        //        Q9: What is the new () Constraint?

        //The new () constraint requires that the generic type must have a public parameterless constructor
        //            so the class can create an object using new.
        //        public class ObjectFactory<T> where T : new()
        //    {
        //        public T Create()
        //        {
        //            return new T();
        //        }
        //    }

        #endregion
        #region Question10
        //        Q10: What is an Interface Constraint?
        //An interface constraint forces the generic type to implement a specific interface.


        //public interface IPrintable
        //        {
        //            void Print();
        //        }

        //        public class Printer<T> where T : IPrintable
        //        {
        //          public void Print(T item)
        //            {
        //                item.Print();

        //            }
        //        }
        #endregion
        #region Question11
        //        Q11: What is the Base Class Constraint?
        //A base class constraint requires the generic type to inherit from a specific base class.
        //This ensures that the generic type has the properties and methods of that base class.
        //            public class Animal
        //        {
        //            public void Eat()
        //            {
        //                Console.WriteLine("Animal is eating");
        //            }
        //        }

        //        public class Cage<T> where T : Animal
        //        {
        //            public void Feed(T animal)
        //            {
        //                animal.Eat();
        //            }
        //        }

        #endregion


    }


}


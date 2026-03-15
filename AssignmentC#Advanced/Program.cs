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
    }


}


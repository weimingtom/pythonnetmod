/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2019/12/27
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Python.Runtime;

namespace pythonnet
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
		    using (Py.GIL())
		    {
	            PyDict locals = new PyDict();
	            locals.SetItem("a", new PyInt(10));
	
	            if (false)
	            {
		            int b = (int)PythonEngine.Eval("a * 2 + 1", null, locals.Handle)
		                .AsManagedObject(typeof(int));
		            Console.WriteLine(b);
	            }
	            else
	            {
	            	PythonEngine.Exec("print(a * 2 + 1)", null, locals.Handle);
	            }
		    }			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
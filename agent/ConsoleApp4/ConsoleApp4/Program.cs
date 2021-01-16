using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleApp4
{
    class Program
    {
#pragma warning disable IDE0060 // Quitar el parámetro no utilizado
        static void Main(string[] args)
#pragma warning restore IDE0060 // Quitar el parámetro no utilizado
        {
			//set the class name and namespace
			string NamespacePath = "\\\\.\\ROOT\\cimv2";
			string ClassName = "Win32_ComputerSystemProduct";

			//Create ManagementClass
			ManagementClass oClass = new ManagementClass(NamespacePath + ":" + ClassName);

			//Get all instances of the class and enumerate them
			foreach (ManagementObject oObject in oClass.GetInstances())
			{
				//access a property of the Management object
				Console.WriteLine("Serial del Equipo : {0}", oObject["IdentifyingNumber"]);
			}
		}
    }
}

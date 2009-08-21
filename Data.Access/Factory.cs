using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Teacher_Aide.Data.Access
{
    public static class Factory
    {
        private static Dictionary<string, Type> _implementationInterfaces;
        //private static Assembly _dataAccessImplementation;
        private static Dictionary<string, Type> ImplementationInterfaces
        {
            get
            {
                if (_implementationInterfaces == null)
                {
                    //TODO: read assembly name from config file
                    Assembly dataAccessImplementation = Assembly.LoadFrom("Teacher-Aide.Data.Access.Mock.dll");
                    _implementationInterfaces = new Dictionary<string, Type>();
                    List<string> requiredInterfaces = new List<string>
                        (new string[] { "IUserData" });
                    int requiredInterfaceCount = requiredInterfaces.Count;
                    foreach (Type type in dataAccessImplementation.GetTypes())
                        foreach (string interfaceName in requiredInterfaces)
                        {
                            Type currInterface = type.GetInterface(interfaceName);
                            if (currInterface != null)
                            {
                                _implementationInterfaces.Add(interfaceName, type);
                                requiredInterfaces.Remove(interfaceName);
                                break;
                            }
                        }
                    //TODO: Throw exception if all the required interfaces are not implemented
                }
                return _implementationInterfaces;
            }
        }
        public static IUserData GetIUserDataImplementation()
        {
            return (IUserData)Activator.CreateInstance(ImplementationInterfaces["IUserData"]);
        }
    }
}

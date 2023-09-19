// See https://aka.ms/new-console-template for more information

using System.Reflection;

Console.Title = "Reflection Sample";

#region  1
string name = "Avnish";
var stringType = name.GetType();
//Console.WriteLine(stringType);
#endregion

#region 2
//var stringType = typeof(string);
//Console.WriteLine(stringType); 
#endregion

#region 3 Current Assembly
//var currentAssembly = Assembly.GetExecutingAssembly();

#region Load all Assembly from current execution code
//var typessFromCurrentAssembly = currentAssembly.GetTypes();

//foreach (var type in typessFromCurrentAssembly)
//{
//	Console.WriteLine(type.Name);
//}
#endregion

#region Load single Assembly from Current Assembly

//var oneTypeFromcurrentAssembly = currentAssembly.GetType("ReflectionSample.Person");
//Console.WriteLine(oneTypeFromcurrentAssembly);

//var one11TypeFromcurrentAssembly = currentAssembly.GetType("ReflectionSample.ITalk");
//Console.WriteLine(one11TypeFromcurrentAssembly);

#endregion

#endregion

#region From External loaded Assembly, Get Types
var externalAssembly = Assembly.Load("System.Text.Json");
//var typesFromExternalAssembly = externalAssembly.GetTypes();

//foreach (var type in typesFromExternalAssembly)
//{
//    Console.WriteLine(type);
//} 
#endregion

#region Get Module and then Type
//var oneTypeFromExternalAssembly = externalAssembly.GetType("System.Text.Json.JsonProperty");


//var modulesFromExternalAssembly = externalAssembly.GetModules();

//// pass fully qualified module name
//var oneModulesFromExternalAssembly = externalAssembly.GetModule("System.Text.Json.dll");

//// Get all types from Module
//var typesFromModulesFromExternalAssembly = oneModulesFromExternalAssembly.GetTypes();

//// Get particular type from Module
//var oneTypeFromOneModulesFromExternalAssembly = oneModulesFromExternalAssembly.GetType("System.Text.Json.JsonProperty");

#endregion


#region GetConstructors/ GetMethods
var currentAssembly = Assembly.GetExecutingAssembly();
var oneTypeFromcurrentAssembly = currentAssembly.GetType("ReflectionSample.Person");

//var constructors = oneTypeFromcurrentAssembly.GetConstructors();
//foreach (var constructor in constructors)
//{
//    Console.WriteLine(constructor);
//Note : Private and Protected methods will not constructor

//    var param = constructor.GetParameters();
//    var declType = constructor.DeclaringType;
//}


var methods = oneTypeFromcurrentAssembly.GetMethods();
foreach (var _method in methods)
{
    Console.WriteLine(_method);
    //Note : Private and Protected methods will not available
}
#endregion


Console.ReadLine();

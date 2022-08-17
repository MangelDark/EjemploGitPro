using System.Reflection;

System.Data.DataSet ds;
HttpClient client;
Assembly? assembly = Assembly.GetEntryAssembly();
if(assembly == null) return;

foreach( AssemblyName name in assembly.GetReferencedAssemblies() ){

    Assembly a = Assembly.Load(name);
    int methodCount = 0;

    foreach(TypeInfo t in a.DefinedTypes){
        methodCount += t.GetMethods().Count();
    }
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,arg2: name.Name
    );
}
// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
// check the three variables have the same value
// both statements output true 

Console.WriteLine($"{decimalNotation == binaryNotation}"); Console.WriteLine(
  $"{decimalNotation == hexadecimalNotation}");


Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers inthe range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can storevnumbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

Console.WriteLine("Hello, World!");

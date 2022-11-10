// See https://aka.ms/new-console-template for more information
using NewGenericDemo;
using static NewGenericDemo.MaximumNumberCheck;
using static NewGenericDemo.MaximumStringNumber;

//Console.WriteLine("Hello,Generic World!");
//int[] arr = { 112, 344, 432, 555, 678 };
//GenericMaximum<int> generic = new GenericMaximum<int>(arr);
//generic.PrintMaxValue();
Console.WriteLine("Find Maximum & Float & String Number");
int output = MaximumIntegerNumber.MaximumintegerNumber(11, 22, 33);
Console.WriteLine(output);
double doubleoutput = MaximumFloatNumber.MaximumfloatNumber(11.22, 22.33, 33.44);
Console.WriteLine(doubleoutput);
string stringoutput = MaximumStrings.MaximumString("gani","Eswar","Ram");
Console.WriteLine(stringoutput);
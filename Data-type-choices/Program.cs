Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// value type variable stores its values directly in the stack

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

// reference type variable stores its values in a separate memory region called the heap.
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

// Type casting
// data type conversion
int first = 10;
string second = "20";
int sum = first + int.Parse(second);

Console.WriteLine($"Sum: {sum}");
// *
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//  Implicit casting / narrowing conversion - converting a larger type to a smaller type - no data loss
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

// Explicit casting / widening conversion - converting a smaller type to a larger type - data loss
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// convert
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Difference between casting and converting
int value = (int)1.5m; // casting truncates - 1
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up - 2
Console.WriteLine(value2);

// TryParse 
string value = "100";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Challenge
// Complete the required code, placing it within the array looping structure code block. It's necessary to implement the following business rules in your code logic:

// Rule 1: If the value is alphabetical, concatenate it to form a message.

// Rule 2: If the value is numeric, add it to the total.

// Rule 3: The result should match the following output:

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0;
string message = "";

foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Total: {total}");
Console.WriteLine($"Message: {message}");

// Challenge2

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 /  (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
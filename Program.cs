// C# Numbers

Console.Clear();

string myTitle = "Working with numbers";
Console.WriteLine(myTitle);

string breakPoint = "<----------------------Next Section-------------------------------->";

// we declare the data type int then give it its variable name and set its value
// this is the limit of the int data type
int myInt = 500000000;
Console.WriteLine("This is my number = " + myInt);

Console.WriteLine(breakPoint);

// so if we need to use a larger number we can use the long data type
//-9223372036854775808 to 9223372036854775807 
//is the limit of long data type
long myLong = 2000000000000000000;
Console.WriteLine("Value of myLong is " + myLong);

Console.WriteLine(breakPoint);

// if we use a float we have to declare with the float data type and with f at the end of the value
// float will go to 6-9 digits
float myFloat = 3.14f;
Console.WriteLine("Value of my float is " + myFloat);

Console.WriteLine(breakPoint);

// using double declare the data type and set the value
// double will go to 15-17 digits
double myDouble = 3.1222222222222222;
Console.WriteLine("This is the value of myDouble" + myDouble);

Console.WriteLine(breakPoint);

// using decimal declare the decimal data type and set the value and finish with a m
// decimal will got to 28-29 digits
decimal myDecimal = 3.1415926535897932384626433832m;
Console.WriteLine("This is the value of myDecimal " + myDecimal);

Console.WriteLine(breakPoint);

int firstNum = 5;
int secNum = 6;
int sum = firstNum + secNum;
Console.WriteLine(secNum + firstNum);
Console.WriteLine($"{firstNum} + {secNum} = {sum}");


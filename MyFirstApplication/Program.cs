using MyFirstApplication;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

///See https://aka.ms/new-console-template for more information using MyFirstApplication;using MyFirstApplication;
//Console.WriteLine("Hello, World!");

//The below statement calls a local function
//single line comment
//HouseExample();

/*
 Multi-line comment 
The below statement is a local function. Local functions are inside of members and are private by default.
This means they are specific to that member
can only be called inside that member. 
 */
 
// Lesson Examples
//house Example();
Lesson1Examplr()

 void HouseExample()
{
    {
        House MyHouse = new House();
        MyHouse.DoorOpenClose()];
    }
    //lesson 1 vaue types 
    void Lesson1Example();
    {
        Lesson1 myLesson = new Lesson1();
        myLesson.IntMinMax();
    }   myLesson.integralExample();
        myLesson.ConvertFloatToInt();
        myLesson.LongFromInt();

        //This was copied directly from teachers video

        MyLocalFunction
        /*
     This local function is for 
    my first exercise lab
     */
   Console.WriteLine("This is MyFirstApplication first sentence");
        Console.WriteLine("I am new to csharp");
        Console.WriteLine("This CSharp course is cool");
        Console.WriteLine("I am learning stuff every day.");
    }
    //integralunsigned

    //byte range 0-255
    byte myByte = 4;

    public void ByteMinMax()

    {
        Console.WriteLine(Byte.MinValue);
        Console.WriteLine(Byte.MaxValue);
    }

    //ushort range 0-65,535
    ushort myUShort = 42;

    public void UShortMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }

    //unint range 0-4,294,967,295
    uint myUInt = 4532U;

    public void UIntMinMax()
    {

        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }

    //uLong range 0 - 18,446,744,072,709,551,615
    ulonh myULong = 948372UL;

    PublicKey void ULongMinMax
    {
        Console.WriteLine(UInt64.MinValue);
        Console.WriteLine(UInt64.MaxValue);
    }

    //Floating Point / Real Numbers 

    // Float Range 3.4E +/- 38
    float myFloat = -123.6589F;

    public void FloatMinMax()
    {
        Console.WriteLine(Single.MinValue);
        Console.WriteLine(Single.MaxValue);
    }

    // double range 1.7E +/- 308
    double myDouble = 12.34D;

    public void DoubleMinMax()
    {
        Console.WriteLine(Double.MinValue);
        Console.WriteLine(Double.MaxValue);
    }

    // decimal range -7.9228E + 24 to 7.9228E+24
    decimal myDecimal = -13.23M;

    public void DecimalMinMax()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }

    //Integral Literals 
    public void IntegralExample()

    {
        // value of 26
        int value1 = 26;
        int value2 = 0/1a; // hexadecimal
        int value3 = 0b11010 // binary
        Console.WriteLine(value1); 
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    //Scientific notation
    double alpha = 6.26E -22; 

    // Underscores 
    long beta = 1_834_432L;


/*Explicit casting is where fractions are truncated and not rounded
you have to provide permission to cast from a higher type to a lower type.*/

public void ConvertFloatToInt()
{
    int converted = (int)myFloat ;
    Console.WriteLine(Converted) ;
}


    
    //Implicit cast requires not direct permission
    public void LongFromInt()
{
    long someValue = myUInt ; 
    Console.Writeline(SomeIntValue) ; 
}


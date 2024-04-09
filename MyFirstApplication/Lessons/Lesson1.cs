
namespace MyFirstApplication;

/*
 This class goes over value types.
 */
internal class Lesson1
{
    //Integral Signeed

    //sbyte range -128 to 127
    sbyte mySByte = 2
    public void SbyteMinMax()
    {
        Console.WriteLine(SByte.MinValue);
        Console.WriteLine(SByte.MaxValie);
    }

    // short range -32,768 to 32,767
    short myshort = 6;
    public void ShortMinMax()
    {
        Console.WriteLine(Int16.MinValue);
        Console.WriteLine(Int16.MaxValue);
    }
    //int range -2,147,483,648 to 2,147,483,647
    int myInt = 25685;

    public void IntMinMax() 
    {
    Console.WriteLine(Int32.MinValue);
    Console.WriteLine(Int32.MaxValue);
}

    //long range -9,233,372,036,084,775,808 TP 9,223,372,036,854,775,807
    long myLong = 123456789L;
    public void LongMinMax()
    {
        Console.WriteLine(Int64.MinValue);
        Console.WriteLine(Int64.MaxValue);
    }

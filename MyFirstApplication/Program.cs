using MyFirstApplication;

///See https://aka.ms/new-console-template for more information using MyFirstApplication;using MyFirstApplication;
Console.WriteLine("Hello, World!");

//The below statement calls a local function
//single line comment
HouseExample();

/*
 Multi-line comment 
The below statement is a local function. Local functions are inside of members and are private by default.
This means they are specific to that member
can only be called inside that member. 
 */
void HouseExample()
{
    House MyHouse = new House();
    MyHouse.DoorOpenClose()];
}
//This was copied directly from teachers video
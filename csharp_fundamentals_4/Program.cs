// See https://aka.ms/new-console-template for more information

////// Lecture 64 - For Loops

for(int counter = 0; counter < 50; counter+=5)
{
    Console.WriteLine(counter + " is lower than 50"); // 0 5 10 15 20 25 30 35 40 45
}

////// Lecture 65 - Do While Loop

int lengthOfText = 0;
string wholeText = " ";
do
{
    Console.WriteLine("Please enter the name of a friend");
    string nameOfAFriend = Console.ReadLine(); // reads input
    int currentLength = nameOfAFriend.Length; // I add the length of the entry of the user to the length of the whole text 
    lengthOfText += currentLength; // Add length to Int, which knows about the length of the text
    wholeText += nameOfAFriend;
} while (lengthOfText < 5);
Console.WriteLine("Thanks! " + wholeText);

////// Lecture 66 - While Loop

int counterWhileLoop = 0;
string enteredText = "";
while(enteredText.Equals("")) // checks first
{
    Console.WriteLine("Please press enter to increase amount by one and anything else " +
    "+ enter if you want to finish counting"); 
    enteredText = Console.ReadLine();
    
    counterWhileLoop++;
    Console.WriteLine("Current people count is {0}", counterWhileLoop); // will replace {0} with the value of the counter
}
Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counterWhileLoop);

////// Lecture 67 - Break and Continue

// Break
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if(i == 3)
    {
        Console.WriteLine("At 3 we stop");
        break; // will finish the for loop at this point
    }
} // Loop output 0 1 2 3 At 3 we stop

// Continue 
for (int c = 0; c < 10; c++)
{
    if (c == 3)
    {
        Console.WriteLine("skiping 3 number");
        continue; // will skip the current entry
    }
    Console.WriteLine(c);
} // Loop output 0 1 2 skiping 3 number 4 5 6 7 8 9

int i, stringsCount, periodLocation;
string myString, mySentence;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices" };
stringsCount = myStrings.Length;

myString = "";
periodLocation = 0;

for (i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    mySentence = "";

    while (periodLocation != -1)
    {
        // first sentence
        mySentence = myString.Remove(periodLocation);

        // remaining sentence
        myString = myString.Substring(periodLocation + 1);

        // remove leading white-space
        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
// Random Array
static int[] RandomArray()
{
    int[] numArray = new int[10];
    for(int index = 0; index < numArray.Count(); index++){
        Random rand = new Random ();
        int randomIdx = rand.Next(5, 25);
        numArray[index] = randomIdx;
    }
    // Use the following for loop to see what the above code has done.
    // for(int index = 0; index < numArray.Count(); index++){
    //     Console.WriteLine(numArray[index]);
    // }
    Console.WriteLine(numArray.Sum());
    Console.WriteLine(numArray.Max());
    Console.WriteLine(numArray.Min());
    return numArray;
}
RandomArray();

// Coin Flip
static string TossCoin()
{
    Console.WriteLine("Tossing a Coin");
    Random rand = new Random ();
    int randomIdx = rand.Next(0, 2);
    // Console.WriteLine(randomIdx);
    string result = "";
    if(randomIdx == 0){
        Console.WriteLine("Heads");
        result = "Heads";
    }
    else {
        Console.WriteLine("Tails");
        result = "Tails";
    }
    // Console.WriteLine(result);
    return result;
}
TossCoin();

// Names
static List<string> Names()
{
    List<string> names = new List<string>() {
        "Todd",
        "Tiffany",
        "Charlie",
        "Geneva",
        "Sydney"
    };
    for(int index = 0; index < names.Count; index++){
        if(names[index].Length < 5){
            names.RemoveAt(index);
        }
    }
    // Checking the list after removing
    // for(int index = 0; index < names.Count; index++){
    //     Console.WriteLine(names[index]);
    // }
    return names;
}
Names();
string[] names = { "Peter", "Ivan", "George", "Niya", "Polina" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Yambol" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "books", "bananas", "protein cake", "phone", "motorcycle" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "near home", "in the fitness", "near the sea" };


Console.WriteLine("Hello, this is your first random sentence.");
while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlace = GetRandomWord(places);
    string randomVerb = GetRandomWord(verbs);
    string randomNoun = GetRandomWord(nouns);
    string randomAdverb = GetRandomWord(adverbs);
    string randomDetail = GetRandomWord(details);

    string who = $"{randomName} from {randomPlace}";
    string action = $"{randomAdverb} {randomVerb} {randomNoun}";
    string sentence = $"{who} {action} {randomDetail}";

    Console.WriteLine(sentence);
    Console.WriteLine("Click [Enter] to generate a new one.");
    Console.ReadLine();
 
    
}

string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];

    return word;
}
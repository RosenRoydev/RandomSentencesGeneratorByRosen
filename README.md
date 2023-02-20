# RandomSentencesGeneratorByRosen
Just for fun
# RandomSentencesGeneratorByRosen
Just for fun
The program use metods, loops and arrays
The Generator is based on the following model :

sentence = {who} {action} {randomDetail} and {additionalVerb}

{who} = {randomName} from {randomPlace} on {randomAge}
string[] names = { "Peter", "Ivan", "George", "Niya", "Polina" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Yambol" };
string[] years = { "10", "4", "1", "36", "28", "51" };

{action} = {randomAdverb} {randomVerb} {randomNoun}
string[] adverbs = { "slowly", "diligently", "well", "sadly", "rapidly" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "books", "bananas", "protein cake", "phone", "motorcycle" };

{randomDetail}
string[] details = { "near home", "in the fitness", "near the sea" };

{additionalVerb}
string[] additionalVerbs = { "sleeps", "thinks", "looks", "takes rest", "plays" };


The following method was used: 

string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];

    return word;
}

Screenshot:

![Generator](https://user-images.githubusercontent.com/122979363/220125307-ba629f88-832b-4313-8719-ccead34dfd80.png)
##Live Demo
You can see how the programs works directrly on your browser here:
https://replit.com/@rosenroydev/InterestingHardtofindPixel#main.cs
![image](https://user-images.githubusercontent.com/122979363/220136014-4e7b3a56-c692-435e-a78a-25bc8f8725eb.png)


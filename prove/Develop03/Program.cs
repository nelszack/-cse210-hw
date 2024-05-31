using System;
// Zack Nelson,5/2/24,creates a dictonary of scripures and it slowly removes words and relpaces it with '_', for the streach chalange I made it so that there are multiple scriptures that it  chooses at random from and made it so that it removes words that haven't been chosen before
class Program
{
    
    static void Main(string[] args)
    {
        Scripture Scripture2zn=new Scripture();
        Dictionary<string,string>Scripturezn=Scripture2zn.CreateScriptureDict();
        Reference Referencezn=new Reference();
        Referencezn.SetReferenceKey(Scripturezn);
        string ToContinue="";
        Word Wordzn= new Word();
        Wordzn.SetScripture(Scripturezn[Referencezn.GetReferenceKey()]);
        do{
            string[] ScriptureList=Wordzn.SetScriptureList(Wordzn.GetScripture());
            Console.Clear();
            string FullValue=Wordzn.GetScripture();
            Console.WriteLine($"{Referencezn.GetReferenceKey()} {FullValue}\nPress enter to continue or type 'quit' to finish:");
            ToContinue=Console.ReadLine();
            FullValue=Wordzn.RemoveWords(ScriptureList);
            if (Wordzn.GetScripture().Equals(FullValue)){
                break;
            }
            Wordzn.SetScripture(FullValue);
        }while(ToContinue!="quit");

    }
}
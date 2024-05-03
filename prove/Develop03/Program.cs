using System;

class Program
{
    
    static void Main(string[] args)
    {
        Scripture scripture2=new Scripture();
        Dictionary<string,string>scripture=scripture2.CreateScriptureDict();
        Reference reference=new Reference();
        reference.SetReferenceKey(scripture);
        string ToContinue="";
        Word word= new Word();
        word.SetScripture(scripture[reference.GetReferenceKey()]);
        do{
            string[] ScriptureList=word.SetScriptureList(word.GetScripture());
            Console.Clear();
            string fullvalue=word.GetScripture();
            Console.WriteLine($"{reference.GetReferenceKey()} {fullvalue}\nPress enter to continue or type 'quit' to finish:");
            ToContinue=Console.ReadLine();
            fullvalue=word.RemoveWords(ScriptureList);
            if (word.GetScripture().Equals(fullvalue)){
                break;
            }
            word.SetScripture(fullvalue);
        }while(ToContinue!="quit");

    }
}
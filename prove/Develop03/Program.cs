using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
class program{
  static void Main() {
    Scripture scripture;
    Reference reference = new Reference("Proverbs","3","5","6");
    Random random = new Random();
    int randomNumber;
    string quitString = "";
    string scriptureFull = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    string []splitScripture = scriptureFull.Split(" ");
    List <Word> wordlist = new List<Word>();
    foreach (string x in splitScripture)
    {
        wordlist.Add(new Word(x));
    }
    scripture = new Scripture(reference, wordList);
    while(quitString != "quit"){
        reference.printFullReference();
        foreach (WaitForChangedResult word in scripture.getScriptureText()){
            Console.Write(Word.showWord() + " ");
        }
        Console.WriteLine("\n\nPress enter to hide more words or type 'quit' to finish:");
        quitString = Console.ReadLine();
        for (int i = 0; i<3; i++){
            randomNumber = random.Next(0, scripture.getScriptureText().Count);
            scripture.getScriptureText()[randomNumber].setHidden(true);
            Console.WriteLine(randomNumber);
        }
    }
}
class Reference 
    {
        private string bookName;
        private string chapterNumber;
        private string verseNumber;
        private string endVerseNumber;
        private string printFullReference = " ";
        public Reference (string bookNameParameter, string chapterNumberParameter, string verseNumberParameter){
            bookName = bookNameParameter;
            chapterNumber = chapterNumberParameter;
            verseNumber = verseNumberParameter;
            endVerseNumber = "X";
        }
        public Reference (string bookNameParameter, string chapterNumberParameter, string verseNumberParameter, string endVerseNumberParameter){
            bookName = bookNameParameter;
            chapterNumber = chapterNumberParameter;
            verseNumber = verseNumberParameter;
            endVerseNumber = endVerseNumberParameter;
        }
        public void printFullReference(){
            if (endVerseNumber == "X"){
                Console.Write(bookName + " " + chapterNumber + ":" + verseNumber + " ");
            }
            else{
                Console.Write(bookName + " " + chapterNumber + ":" + verseNumber + "-" + endVerseNumber + " ");
            }
        }
    }
    class Scripture{
        private Reference reference;
        private List <Word> scriptureText;
        public Scripture(Reference referenceParameter, List <Word>textParameter){
            reference = referenceParameter;
            scriptureText = textParameter;
        }
        public Reference GetReference(){
            return reference;
        }
        public List <Word> getScriptureText(){
            return scriptureText;
        }
    }
    class Word{
        public Word (string wordParameter){
            hiddenWord = "";
            wordVal = wordParameter;
            foreach (char x in wordVal){
                hiddenWord = hiddenWord + "_";
            }
        }
        public Word (string wordParameter, bool isHiddenParameter){
            hiddenWord = "";
            wordVal = wordParameter;
            isHidden = isHiddenParameter;
            foreach (char X in wordVal){
                hiddenWord = hiddenWord + "_";
            }
        }
        private string hiddenWord;
        private string wordVal;
        private bool isHidden;
        public string showWord(){
            if (isHidden == true){
                return hiddenWord;
            }
            else{
                return wordVal;
            }
        }
        public void setHidden(bool isHiddenParameter){
            isHidden = isHiddenParameter;
        }
    }
}
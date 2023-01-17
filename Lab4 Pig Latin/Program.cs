Console.WriteLine("Welcome to the Pig Latin translator.");

string WannaRestart;
do
{
    Console.Write("Please enter a single English word: ");
    string userWord = Console.ReadLine().ToLower();

    if (userWord == "")
    {
        Console.WriteLine("You did not input a word.");
    }

    else
    {
        int vowelPosition = -1;
        foreach (char letter in userWord)
        {
            vowelPosition++;
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                break;
            }
        }


        string pigLatinWord = "";
        string beforeLetters = "";
        string afterLetters = "";

        switch (vowelPosition)
        {
            case 0:
                pigLatinWord = userWord + "way";
                break;
            case 1:
                beforeLetters = userWord.Substring(0, 1);
                afterLetters = userWord.Substring(1);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            case 2:
                beforeLetters = userWord.Substring(0, 2);
                afterLetters = userWord.Substring(2);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            case 3:
                beforeLetters = userWord.Substring(0, 3);
                afterLetters = userWord.Substring(3);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            case 4:
                beforeLetters = userWord.Substring(0, 4);
                afterLetters = userWord.Substring(4);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            case 5:
                beforeLetters = userWord.Substring(0, 5);
                afterLetters = userWord.Substring(5);
                pigLatinWord = afterLetters + beforeLetters + "ay";
                break;
            default:
                pigLatinWord = "This word could not be translated.";
                break;
        }

        Console.WriteLine("Translation: " + pigLatinWord);
    }

    Console.WriteLine("Would you like to translate another word? Press 'Y' to restart, any other key to exit.");
    WannaRestart = Console.ReadLine();
}

while (WannaRestart == "Y");

Console.WriteLine("Thank you for using our program. Goodbye.");

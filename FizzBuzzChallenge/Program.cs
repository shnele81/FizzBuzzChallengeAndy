// See https://aka.ms/new-console-template for more information

string FizzBuzz(int number)
{
    var returnAnswer = "";
    if (number % 3 == 0)
    {
        returnAnswer = "Fizz";
    }

    if (number % 5 == 0)
    {
        returnAnswer = "Buzz";
    }

    if (number % 3 == 0 && number % 5 == 0)
    {
        returnAnswer = "FizzBuzz";
    }

    return returnAnswer;
}
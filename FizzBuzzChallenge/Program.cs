// See https://aka.ms/new-console-template for more information

string FizzBuzz(int number)
{
    var returnAnswer = "";
    if (number % 3 == 0 && number % 5 == 0)
    {
        returnAnswer = "FizzBuzz";
    }
    if (number % 3 == 0 && number % 5 != 0)
    {
        returnAnswer = "Fizz";
    }

    if (number % 5 == 0  && number % 3 != 0)
    {
        returnAnswer = "Buzz";
    }

    return returnAnswer;
}
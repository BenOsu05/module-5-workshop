namespace FizzBuzz.Core;
public class FizzBuzzService
{
    public string Print(int number)
    {
        if (IsDivisibleByThree(number) && IsDivisibleByFive(number))
        {
            return "FizzBuzz";
        }
        else if (IsDivisibleByFive(number))
        {
            return "Buzz";
        }
        else if (IsDivisibleByThree(number))
        {
            return "Fizz";
        }
        else
        {
           return number.ToString(); 
        }
        
    } 
    private bool IsDivisibleByThree(int number)
    {
        return number % 3 == 0;
    }

    private bool IsDivisibleByFive(int number)
    {
        return number % 5 == 0;
    }
}

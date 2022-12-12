using System;
using System.Text;
using System.Linq;

public class StringAnalysis
{
    protected bool isPalindrome = false;
    private int upperCount = 0;
    private int digitCount = 0;
    public void isPalindromeThread(String str)
    {

        str = str.ToLower().Replace("[\\s|,|.|?|;|']", "");
        if (str.Equals(new string(str.Reverse().ToArray()))) //source: https://stackoverflow.com/a/9791036
            isPalindrome = true;

    }

    public bool getPalindrome()
    {
        return isPalindrome;
    }

    public void upperCountThread(String str)
    {
        

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                upperCount++;
            }
        }
    }
    public int getUpperCount()
    {
        return upperCount;
    }


    public void DigitCountThread(string str)
    {
        
        for (int i = 0; i < str.Length; i++)
        {

            if (char.IsDigit(str[i]))
            {
                digitCount++;
            }
        }
    }
    public int getDigitCount()
    {
        return digitCount;
    }
}
public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Check to see if Integer is a postive number

        if (x >= 0)
        {
            Console.WriteLine("Integer is greater than zero");
            // Convert to String
            string palindrome = x.ToString();

            int a = 0;
            int b = palindrome.Length - 1;

            while (a < b)
            {
                if (palindrome[a] != palindrome[b])
                {
                    return false;
                }
                a++;
                b--;
            }

            return true;
        }
        else
        {
            Console.WriteLine("Integer is a negative number");
            return false;
        }
    }
}
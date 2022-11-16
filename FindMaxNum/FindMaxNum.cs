namespace FindMaxNumber
{
    public class FindMaxNum
    {
public int FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            if (b > a && b > c)
                return b;
            else 
                return c;
        }
    }
}
namespace FindMaxNumber
{
    public class FindMaxNum
    {
public float FindMaxInteger(float a, float b, float c)
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
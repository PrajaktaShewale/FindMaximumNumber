﻿namespace FindMaxNumber
{
    public class FindMaxNum
    {
public string FindMax(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            if (b.CompareTo(a) >0 && b.CompareTo(c) > 0)
                return b;
            else 
                return c;
        }
    }
}
using System;
class CheckPrime
{
    public static bool IsPrime(int num)
    {
        if(num<=1)
        {
		return false;
		}
        for(int i = 2; i<=Math.Sqrt(num); i++)
        {
            if(num%i==0)
            {
                return false; 
            }
        }
        return true; 
	}
    public static int FindLargestPrime(int[] arr)
    {
        int largestPrime=-1; 
        for(int i = 0; i < arr.Length; i++)
        {
            if(IsPrime(arr[i]))
            {
                if(arr[i]>largestPrime)
                {
                    largestPrime = arr[i]; 
                }
            }
        } 
        return largestPrime; 
    }
    public static void Main(string[] args)
    {
        int[] arr={3,5,7,9,11};
        int largestPrime=FindLargestPrime(arr);
        if(largestPrime!=-1)
        {
            Console.WriteLine(largestPrime);
        }
	}
}


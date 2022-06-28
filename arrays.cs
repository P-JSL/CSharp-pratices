namespace consoleApp_pratices;

public class arrays
{
    public void arr()
    {
        int[] evenNums = new int[10];
        for (int i = 0; i < 10; i++)
        {
            evenNums[i] = i * 2;
            
            Console.WriteLine("You just saved {0}", evenNums[i]);
        }
    }
    //foreach 
    public void foreachs(int[] a)
    {
        int sum =0;
        foreach (int y in a)
        {
            sum += y;
        }
        Console.WriteLine(sum);
    }
    
    //2demandtion array
    
}
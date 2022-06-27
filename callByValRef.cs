namespace consoleApp_pratices;

public class callByValRef
{
   public  int CallByValueDemo(int x)
    {
        return x;
    }

   public  void SwapNum_1(int a, int b)
   {
       int temp = a;
       a = b;
       b = temp;
   }

   public  void SwapNum_2(ref int a, ref int b)
   {
       int temp = a;
       a = b;
       b = temp;
   }

   public void GetNumbers(out int x, out int y)
   {
       x = 0;
       y = 0;
   }
}
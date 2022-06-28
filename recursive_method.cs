namespace consoleApp_pratices;

public class recursive_method
{
    public int Factorial(int n)
    {
        if (n == 1)
        {
            return n;
        }
        else
        {
            return n * Factorial(--n);
        }
    }
    //method overloading
    void Print(int a)
    {
        Console.WriteLine("입력된 정수값은 {0}입니다.",a);
    }

    void Print(double a)
    {
        Console.WriteLine("입력된 실수값은 {0}입니다.",a);
    }
}

//properties
class Person
{
    private String name = "James";
    private int age;
    /*
     * public String Name {set; get;} = "James";
     * 
     */
    public String Name
    
    {
        get { return name;}
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("이름이 입력되지 않았습니다.");
            }
            else
            {
                name = value;
            }
        }
    }

    public int Age
    {
        set
        {
            age = value;
        }
        get
        {
            if (age <= 0)
            {
                throw new ArgumentException("나이의 입력이 올바르지 않습니다.");
            }
            else
            {
                return age;
            }
        }
    }
}
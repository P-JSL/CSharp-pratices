namespace consoleApp_pratices;
public class Program2
{
        public static void PutCommand()
        {
                Console.WriteLine("이름을 입력하세요. : ");
                string name = Console.ReadLine();
                Console.WriteLine($"반갑습니다. {name}씨");
        }
        
        //convert function
        public static void XxToConvert()
        {
                string ageString;
                int sum;
                int ageInt;
                
                Console.Write("당신의 나이를 입력하세요 : ");
                ageInt = Convert.ToInt32(Console.ReadLine());
                sum = ageInt + 1;
                Console.WriteLine($"당신의 나이에 한 살을 더하면 {sum}이 됩니다");
        }

        public static void NumberConvert()
        {
                Console.Write("숫자를 입력하세요 :");
                int i = int.Parse(Console.ReadLine());
                
                Console.Write("숫자를 입력하세요 :");
                double d = Double.Parse(Console.ReadLine());
                
                Console.WriteLine("i = {0}", i);
                Console.WriteLine("d = {0}", d);

                string strInt = i.ToString();
                string strDouble = d.ToString();
                
                Console.WriteLine("strInt = {0}",strInt);
                Console.WriteLine("strDouble = {0}",strDouble);
        }

        public static void condition()
        {
                Console.WriteLine("입력 : ");
                char grade = Convert.ToChar(Console.ReadLine().ToUpper());

                if (grade == 'A')
                {
                        Console.WriteLine("A등급");
                }
                else
                {
                        Console.WriteLine("B등급");
                }

                switch (grade)
                {
                        case 'A' :
                                Console.WriteLine("A등급");
                                break;
                        case 'B':
                                Console.WriteLine("B등급");
                                break;
                        default:
                                Console.WriteLine("탈락");
                                break;
                }
        }
}
// See https://aka.ms/new-console-template for more information

using consoleApp_pratices;
/*
string name = "홍길동";
char exmark = '!';
sbyte age;
age = 20;

Console.WriteLine("Hello "+  name + exmark);
Console.WriteLine("You are "+ age + " years old" + exmark);

Program2.PutCommand();
Program2.XxToConvert();
Program2.NumberConvert();
Program2.condition();
*/  
    /*
     *산술연산자 우선순위
     *  곱셈 , 나눗셈 > 덧셈 , 뺄셈
     *
     * 컴파운드 연산자
     *  +=, -=, /=, %\ 등
      * for문 / while문 / do-while 문 
      */
      
//methods m = new methods();
//double Square = m.SquareRoot(2);
//Console.WriteLine(Square);


/*  값에의한 호출
Console.Write("정수를 입력 : ");
int a = Convert.ToInt32(Console.ReadLine());
callByValRef refs = new callByValRef();
Console.WriteLine("입력하신 정수의 값은 {0}입니다.",refs.CallByValueDemo(a));*/

/*참조에 의한 호출*/
/*
int x = 1;
int y = 2;
callByValRef refs2 = new callByValRef();
refs2.SwapNum_1(x,y); //값에의한 호출
Console.WriteLine("x의 값은 {0} 입니다.",x);
Console.WriteLine("y의 값은 {0} 입니다.",y);

Console.WriteLine();

--변수초기화
x = 1;
y = 2;
refs2.SwapNum_2(ref x,ref y);
Console.WriteLine("x의 값은 {0} 입니다.",x);
Console.WriteLine("y의 값은 {0} 입니다.",y);

--결과에 의한 호출
Console.WriteLine("a에 저장할 정수값을 입력하세요.");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("b에 저장할 정수값을 입력하세요.");
int b = Convert.ToInt16(Console.ReadLine());

refs2.GetNumbers(out a,out b);
Console.WriteLine("x의 값은 {0} 입니다.",a);
Console.WriteLine("y의 값은 {0} 입니다.",b);*/
/*
  -- 재귀함수
recursive_method recur = new recursive_method();
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}! = {1}",a,recur.Factorial(a));*/

Person p = new Person();
Console.WriteLine("이름을 입력하세요.");
p.Name = Console.ReadLine();
Console.WriteLine("나이를 입력하세요.");
p.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("안녕하세요 {0}씨, 당신의 나이는 {1}살이군요",p.Name,p.Age);
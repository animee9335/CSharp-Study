namespace study;

// [ 조건문 (Conditional Statements) ]
public class Chapter03
{
    public static void Run()
    {
        // 1
        Console.WriteLine("짝홀 확인\n정수를 입력해주세요");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("짝수");
        }
        else
            Console.WriteLine("홀수");
        
        // 2
        Console.WriteLine("최대값 찾기\n세 정수를 입력해주세요");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine()); 
        int maxValue;
        
        if (num1 > num2 && num1 > num3)
        {
            maxValue = num1;
        }
        else if (num2 > num3 && num2 > num1)
        {
            maxValue = num2;
        }
        else
            maxValue = num3;

        Console.WriteLine($"최대값: {maxValue}");
        
        // 3
        Console.WriteLine("BMI계산기\n몸무게(kg), 키(m, Cm(X))를 입력해주세요");
        double weight = Convert.ToDouble(Console.ReadLine());
        double length = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / (length * length);
        Console.WriteLine($"bmi: {bmi}");

        if (bmi >= 25)
        {
            Console.WriteLine("비만");
        }
        else if (bmi >= 23 || bmi < 25 )
        {
            Console.WriteLine("과체중");
        }
        else if (bmi >= 18.5 || bmi < 23)
        {
            Console.WriteLine("정상");    
        }
        else
            Console.WriteLine("저체중");
        
        // 4
        Console.WriteLine("월(1~12)를 입력해주세요.");
        int month = Convert.ToInt32(Console.ReadLine());
        
    }
}   
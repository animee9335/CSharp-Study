namespace study;

// [ 변수와 자료형, 형변환, 연산자 ]
public class Chapter02
{
    public static void Run()
    {
        // 1
        string name = "도라에몽";
        int age = 200;
        double length = 122.2;

        Console.WriteLine($"이름: {name}, 나이: {age}, 키: {length}");
        
        // 2
        int a = 17;
        int b = 5;

        Console.WriteLine($"+: {a + b}, -: {a - b}, *: {a * b}, /: {a / b}, %: {a % b}");
        
        // 3
        Console.WriteLine("두 수를 입력해주세요");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"+: {n1 + n2}, -: {n1 - n2}, *: {n1 * n2}");
        
        // 4
        Console.WriteLine("국어, 영어, 수학 점수를 입력해주세요");
        int score1 = Convert.ToInt32(Console.ReadLine());
        int score2 = Convert.ToInt32(Console.ReadLine());
        int score3 = Convert.ToInt32(Console.ReadLine());
        
        int addScore = score1 + score2 + score3;
        double average = (double)addScore / 3;

        Console.WriteLine($"총점: {addScore}");
        Console.WriteLine($"평균: {average}");
        
        // 5
        Console.WriteLine("시간(초)를 입력해주세요");
        int time = Convert.ToInt32(Console.ReadLine());
        int hour = time / 3600;
        int minute = (time / 60) % 60;
        int second = time % 60;
        Console.WriteLine($"{hour}시간 {minute}분 {second}초");
    }
}
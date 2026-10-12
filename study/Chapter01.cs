namespace study;

// [ 출력과 입력 (Output & Input) ]
public class Chapter01
{
    public static void Run()
    {
        Console.WriteLine("Hello World!");
        Console.Write("안녕");
        Console.WriteLine();

        Console.Write("이름을 입력하세요: ");
        // string name =  Console.ReadLine();
        // Console.WriteLine($"{name}"); // 문자열 보간(string interpolation). 문자열 앞에 $를 붙이면 { } 안의 변수 값이 글자 속에 끼워 들어간다.

        // 문제1
        Console.WriteLine("나는 C#을 배우고 있습니다.");
        Console.WriteLine("오늘이 첫걸음입니다.");
        Console.WriteLine("화이팅!");

        // 문제2
        Console.Write("A");
        Console.Write("B");
        Console.Write("C\n");

        // 문제3
        Console.Write("이름을 입력하세요: ");
        string? name =  Console.ReadLine();
        Console.WriteLine($"안녕하세요, {name}님! 오늘도 즐거운 코딩 되세요.");

        // 문제4
        Console.Write("무슨 음식을 좋아하세요: ");
        string? food = Console.ReadLine();
        Console.WriteLine($"저도 {food} 좋아해요!");

        // 문제5
        Console.Write("이름을 입력하세요: ");
        string? name2 = Console.ReadLine();
        Console.Write("취미를 입력하세요: ");
        string? hobby = Console.ReadLine();

        Console.WriteLine("=== 자기소개 ===");
        Console.WriteLine($"이름: {name2}");
        Console.WriteLine($"취미: {hobby}");
        Console.WriteLine("================");
    }
}
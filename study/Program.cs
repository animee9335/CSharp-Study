using study;

Console.Write("실행할 챕터 번호: ");
switch (Console.ReadLine())
{
    case "1": Chapter01.Run(); break;
    case "2": Chapter02.Run(); break;
    case "3": Chapter03.Run(); break;
    default: Console.WriteLine("없는 챕터예요."); break;
}
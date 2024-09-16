using System.ComponentModel.Design;

Console.WriteLine("안녕하세요!");
Console.WriteLine("첫 번째 숫자를 입력해주세요!");

var firstUserInput = int.Parse(Console.ReadLine());
Console.WriteLine(firstUserInput);

Console.WriteLine("두 번째 숫자를 입력해주세요!");
var secondUserInput = int.Parse(Console.ReadLine());

Console.WriteLine("입력된 수로 진행하고자 하는 기능을 입력해주세요.");
Console.WriteLine("[A] 덧셈");
Console.WriteLine("[S] 뺄셈");
Console.WriteLine("[M] 곱셈");

var thirdUserChoiceFunction = Console.ReadLine();

if (thirdUserChoiceFunction == "a" || thirdUserChoiceFunction == "A")
{
    var sum = firstUserInput + secondUserInput;
    PrintFinalEquation(firstUserInput, secondUserInput, sum, "+");

} else if (thirdUserChoiceFunction == "s" ||  thirdUserChoiceFunction == "S")
{
    var subtract = firstUserInput - secondUserInput;
    PrintFinalEquation(firstUserInput, secondUserInput, subtract, "-");
} else if (thirdUserChoiceFunction == "m" || thirdUserChoiceFunction == "M")
{
    var multiply = firstUserInput * secondUserInput;
    PrintFinalEquation(firstUserInput, secondUserInput, multiply, "*");
} else
{
    Console.WriteLine("잘못된 입력입니다.");
}

void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

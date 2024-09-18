
using System.Xml.Serialization;

List<string> todoLists = new List<string>();
bool isUserWantToQuit = false;

while(!isUserWantToQuit) { 

    PrintGreeting();

    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "e":
        case "E":
            PrintExit();
            isUserWantToQuit = true;
            break;

        case "s":
        case "S":
            SeeAllToDo();
            break;

        case "a":
        case "A":
            AddToDo();
            break;

        case "r":
        case "R":
            RemoveToDo();
            break;

        default:
            Console.WriteLine("유효하지 않은 입력입니다. 다시 입력해주세요!");
            Console.WriteLine("######################################");
            break;
    }

}

// user choice function

void AddToDo()
{
    bool isUserInputValid = false;

    do
    {
        Console.WriteLine("할 일을 추가해주세요!");

        string userToDoInput = Console.ReadLine();

        if(String.IsNullOrWhiteSpace(userToDoInput))
        {
            // empty
            Console.WriteLine("설명은 비워둘 수 없습니다!");
            
        } else if (todoLists.Contains(userToDoInput))
        {
            // exist same user input
            Console.WriteLine("이미 같은 내용이 추가 되어있습니다. 같은 내용의 할 일은 추가되지 않습니다.");

        } else
        {
            todoLists.Add(userToDoInput);
            Console.WriteLine("할 일이 성공적으로 추가되었습니다! : " + userToDoInput);
            isUserInputValid = true;
        }

    } while (!isUserInputValid);

}

void SeeAllToDo()
{
    if (todoLists.Count > 0)
    {
        SeeToDos();
        return;
    }

    Console.WriteLine("아직 할 일이 추가되지 않았습니다.");
}

void SeeToDos()
{
        for(int i = 0; i < todoLists.Count; ++i)
        {
            Console.WriteLine($"{i+1}. {todoLists[i]}");
        }
}

void RemoveToDo()
{
    bool correctUserInput = false;

    do
    {
        if (todoLists.Count > 0)
        {
            // exist todos

            Console.WriteLine("제거하려는 할 일의 번호를 입력해주세요!");
            SeeToDos();
            int choiceNum = 0;

            string userChoice = Console.ReadLine();
            bool isParsingSuccessful = int.TryParse(userChoice, out choiceNum);

            if (isParsingSuccessful && checkValidIndex(choiceNum))
            {
                // parsing is okay and vaild index number of list

                todoLists.RemoveAt(choiceNum-1);
                correctUserInput = true;
            } else
            {
                if(!isParsingSuccessful)
                {
                    Console.WriteLine("유효한 숫자를 입력해주세요.");
                }

                if(!checkValidIndex(choiceNum))
                {
                    Console.WriteLine("할 일 범위 안에 있는 수를 입력해주세요.");
                }
            } 
        }
        else
        {
            // no todos

            Console.WriteLine("아직 할 일이 추가되지 않았습니다.");
            correctUserInput = true;
        }
    } while (!correctUserInput);
}

bool checkValidIndex(int choiceNum)
{
    if (choiceNum < 0 || choiceNum > todoLists.Count) return false;
    else return true;
}

// Print Greeting
void PrintGreeting()
{
    Console.WriteLine("안녕하세요!");
    Console.WriteLine("무엇을 하고 싶으신가요?");
    Console.WriteLine("[S] 모든 할 일 살펴보기");
    Console.WriteLine("[A] 할 일 추가하기");
    Console.WriteLine("[R] 할 일 제거하기");
    Console.WriteLine("[E] 프로그램 종료하기");
}

void PrintExit()
{
    Console.WriteLine("안녕히가세요! Bye Bye!");
}
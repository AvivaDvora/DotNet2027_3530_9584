using DO;
using Dal;
using DalApi;

namespace DalTest;


private static IDal s_dal = new DalList();
Initialize(s_dal);


public static void main(string[] args)
{
    try
    {

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

private static void UpdateAnswer()
private static void UpdateQuestion()
private static void UpdateStudent()
 private static void UpdateTest()
private static void UpdateQuestionForStudent()

private static void ReadAll<T>(ICrud<T> icrud)
private static void Read<T>(ICrud<T> crud)
private static void Delete<T>(ICrud<T> crud)

public static void MainMenu()
{
    int choice;
    do
    {
        choice = PrintMainMenu();
        switch (choice)
        {
            case 1:
                SubMenu("Answer");
                break;
            case 2:
                SubMenu("Question");
                break;
            case 3:
                SubMenu("Student");
                break;
            case 4:
                SubMenu("Test");
                break;
            case 5:
                SubMenu("QuestionForStudent");
            case 0:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    } while (choice != 0);
}
public static int PrintMainMenu()
{
    Console.WriteLine("Main Menu:\n");
    Console.WriteLine("לתשובה הקש 1 \n ");
    Console.WriteLine("לשאלה הקש 2\n ");
    Console.WriteLine("לתלמיד הקש 1 \n ");


}
public static int SubMenu(string item)

public static int PrintSubMenu(string item)









/*
/// <summary>בודק את מתודות ה-CRUD עבור ישות התשובה.</summary>
void AnswerCrud(IAnswer dal, Answer item, int id)
{
    Console.WriteLine("--- Answer ---");
    dal.Add(item);
    Console.WriteLine($"Add: {dal.GetById(id)}");
    Console.WriteLine($"GetAll count: {dal.GetAll().Count()}");
    dal.Update(item with { Content = "טקסט תשובה לדוגמה 101" });
    Console.WriteLine($"Update: {dal.GetById(id)}");
    dal.Delete(id);
    Console.WriteLine($"GetById after delete: {dal.GetById(id)?.ToString() ?? "null"}");
}

/// <summary>בודק את מתודות ה-CRUD עבור ישות התלמיד.</summary>
void StudentCrud(IStudent dal, Student item, int id)
{
    Console.WriteLine("--- Student ---");
    dal.Add(item);
    Console.WriteLine($"Add: {dal.GetById(id)}");
    Console.WriteLine($"GetAll count: {dal.GetAll().Count()}");
    dal.Update(item with { Score = 90 });
    Console.WriteLine($"Update: {dal.GetById(id)}");
    dal.Delete(id);
    Console.WriteLine($"GetById after delete: {dal.GetById(id)?.ToString() ?? "null"}");
}

/// <summary>בודק את מתודות ה-CRUD עבור ישות השאלה-לנבחן (מפתח משולב).</summary>
void QuestionForStudentCrud(IQuestionForStudent dal, QuestionForStudent item)
{
    Console.WriteLine("--- QuestionForStudent ---");
    dal.Add(item);
    Console.WriteLine($"Add: {dal.GetById(item.StudentId, item.TestId, item.QuestionId)}");
    Console.WriteLine($"GetAll count: {dal.GetAll().Count()}");
    dal.Update(item with { SelectedAnswerId = 2 });
    Console.WriteLine($"Update: {dal.GetById(item.StudentId, item.TestId, item.QuestionId)}");
    dal.Delete(item.StudentId, item.TestId, item.QuestionId);
    Console.WriteLine($"GetById after delete: " +
        $"{dal.GetById(item.StudentId, item.TestId, item.QuestionId)?.ToString() ?? "null"}");
}
*/
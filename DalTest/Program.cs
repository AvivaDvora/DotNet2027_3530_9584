using DO;
using Dal;
using DalApi;

namespace DalTest;


private static IDal s_dal = new DalList();



public static void Main(string[] args)
{
    Initialize(s_dal);
    try
    {
        MainMenu();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

private static void AddAnswer()
{

    Console.WriteLine("Enter ID of answer to add\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Content\n");
    var content = Console.ReadLine();
    Console.WriteLine("Enter Question Id\n");
    var questionId = Convert.ToInt32(Console.ReadLine());
    var answer = new Answer { Id = id, Content = content, QuestionId = questionId };
    s_dal.Answer.Add(answer);
    Console.WriteLine($"Added Answer: {s_dal.Answer.GetById(id)}\n");
}

private static void AddQuestion()
{
    Console.WriteLine("Enter ID of question to add\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter subject\n");
    var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
    Console.WriteLine("Enter content\n");
    var content = Console.ReadLine();
    Console.WriteLine("Enter CorrectAnswerId");
    var correctAnswerId = Convert.ToInt32(Console.ReadLine());
    var question = new Question { Id = id, Subject = subject, Content = content, CorrectAnswerId = correctAnswerId };
    s_dal.Question.Add(question);
    Console.WriteLine($"Added Question: {s_dal.Question.GetById(id)}\n");
}

public static void AddStudent()
{
    Console.WriteLine("Enter ID of student to add\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter name\n");
    var name = Console.ReadLine();
    Console.WriteLine("Enter testID");
    var testId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter score\n");
    var score = Convert.ToInt32(Console.ReadLine());
    var student = new Student { Id = id, Name = name, TestId = testId, Score = score };
    s_dal.Student.Add(student);
    Console.WriteLine($"Added Student: {s_dal.Student.GetById(id)}\n");
}

public static void AddTest()
{
    Console.WriteLine("Enter ID of test to add\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter subject\n");
    var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
    Console.WriteLine("Enter exam date\n");
    var examDate = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Enter number of questions\n");
    var numOfQuestions = Convert.ToInt32(Console.ReadLine());
    var test = new Test { Id = id, Subject = subject, ExamDate = examDate, NumOfQuestions = numOfQuestions };
    s_dal.Test.Add(test);
    Console.WriteLine($"Added Test: {s_dal.Test.GetById(id)}\n");
}

public static void AddQuestionForStudent()
{
    Console.WriteLine("Enter Student ID of QuestionForStudent to add\n");
    var studentId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Test ID of QuestionForStudent to add\n");
    var testId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Question ID of QuestionForStudent to add\n");
    var questionId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Selected Answer ID\n");
    var selectedAnswerId = Convert.ToInt32(Console.ReadLine());
    var questionForStudent = new QuestionForStudent { StudentId = studentId, TestId = testId, QuestionId = questionId, SelectedAnswerId = selectedAnswerId };
    s_dal.QuestionForStudent.Add(questionForStudent);
    Console.WriteLine($"Added QuestionForStudent: {s_dal.QuestionForStudent.GetById(studentId, testId, questionId)}\n");
}

private static void UpdateAnswer()
{
    Console.WriteLine("Enter ID of answer to update\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Content\n");
    var content = Console.ReadLine();
    Console.WriteLine("Enter Question Id\n");
    var questionId = Convert.ToInt32(Console.ReadLine());
    var answer = new Answer { Id = id, Content = content, QuestionId = questionId };
    s_dal.Answer.Update(answer);
    Console.WriteLine($"Updated Answer: {s_dal.Answer.GetById(id)}\n");
}

private static void UpdateQuestion()
{
    Console.WriteLine("Enter ID of question to update\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter subject\n");
    var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
    Console.WriteLine("Enter content\n");
    var content = Console.ReadLine();
    Console.WriteLine("Enter CorrectAnswerId");
    var correctAnswerId = Convert.ToInt32(Console.ReadLine());
    var question = new Question { Id = id, Subject = subject, Content = content, CorrectAnswerId = correctAnswerId };
    s_dal.Question.Update(question);
    Console.WriteLine($"Updated Question: {s_dal.Question.GetById(id)}\n");
}

private static void UpdateStudent()
{
    Console.WriteLine("Enter ID of student to update\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter name\n");
    var name = Console.ReadLine();
    Console.WriteLine("Enter testID");
    var testId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter score\n");
    var score = Convert.ToInt32(Console.ReadLine());
    var student = new Student { Id = id, Name = name, TestId = testId, Score = score };
    s_dal.Student.Update(student);
    Console.WriteLine($"Updated Student: {s_dal.Student.GetById(id)}\n");
}

private static void UpdateTest()
{
    Console.WriteLine("Enter ID of test to update\n");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter subject\n");
    var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
    Console.WriteLine("Enter exam date\n");
    var examDate = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Enter number of questions\n");
    var numOfQuestions = Convert.ToInt32(Console.ReadLine());
    var test = new Test { Id = id, Subject = subject, ExamDate = examDate, NumOfQuestions = numOfQuestions };
    s_dal.Test.Update(test);
    Console.WriteLine($"Updated Test: {s_dal.Test.GetById(id)}\n");
}

private static void UpdateQuestionForStudent()
{
    Console.WriteLine("Enter Student ID of QuestionForStudent to update\n");
    var studentId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Test ID of QuestionForStudent to update\n");
    var testId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Question ID of QuestionForStudent to update\n");
    var questionId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Selected Answer ID\n");
    var selectedAnswerId = Convert.ToInt32(Console.ReadLine());
    var questionForStudent = new QuestionForStudent { StudentId = studentId, TestId = testId, QuestionId = questionId, SelectedAnswerId = selectedAnswerId };
    s_dal.QuestionForStudent.Update(questionForStudent);
    Console.WriteLine($"Updated QuestionForStudent: {s_dal.QuestionForStudent.GetById(studentId, testId, questionId)}\n");
}

private static void ReadAll<T>(ICrud<T> icrud)
{
    var items = icrud.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

private static void Read<T>(ICrud<T> crud)
{
    Console.WriteLine("Enter the ID of the item to read:");
    int id = Convert.ToInt32(Console.ReadLine());
    var item = crud.GetById(id);
    if (item != null)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine($"Item with ID {id} not found.");
    }
}

private static void Delete<T>(ICrud<T> crud)
{
    Console.WriteLine("Enter the ID of the item to Delete:");
    int id = Convert.ToInt32(Console.ReadLine());
    crud.Delete(id);
    var item = crud.GetById(id);
    if (item == null)
    {
        Console.WriteLine($"Item with ID {id} deleted successfully.");
    }
    else
    {
        Console.WriteLine($"Failed to delete item with ID {id}.");
    }
}

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
    Console.WriteLine("למבחן הקש 4 \n ");
    Console.WriteLine("לשאלה עבור תלמיד הקש 5 \n ");
    Console.WriteLine("ליציאה 6\n");
    return Convert.ToInt32(Console.ReadLine());

}

public static int PrintSubMenu(string item)
{
            Switch(item)
        {
        case "Answer":

            Console.WriteLine("Answer Submenu:\n");

            Console.WriteLine("1. Add Answer");
            AddAnswer();
            Console.WriteLine("2. Get Answer by ID");
            Read(item);
            Console.WriteLine("3. Get All Answers");
            ReadAll(item);
            Console.WriteLine("4. Update Answer");
            UpdateAnswer();
            Console.WriteLine("5. Delete Answer");
            Delete(item);


            break;
        case "Question":
            Console.WriteLine("Question Submenu:\n");
            Console.WriteLine("1. Add Question");
            AddQuestion();
            Console.WriteLine("2. Get Question by ID");
            read(item);
            Console.WriteLine("3. Get All Questions");
            ReadAll(item);
            Console.WriteLine("4. Update Question");
            UpdateQuestion();
            Console.WriteLine("5. Delete Question");
            Delete(item);
            break;
        case "Student":
            Console.WriteLine("Student Submenu:\n");
            Console.WriteLine("1. Add Student");
            AddStudent();
            Console.WriteLine("2. Get Student by ID");
            Read(item);
            Console.WriteLine("3. Get All Students");
            ReadAll(item);
            Console.WriteLine("4. Update Student");
            UpdateStudent(item)
            Console.WriteLine("5. Delete Student");
            Delete(item);
            break;
        case "Test":
            Console.WriteLine("Test Submenu:\n");
            Console.WriteLine("1. Add Test");
            AddTest();
            Console.WriteLine("2. Get Test by ID");
            read(item);
            Console.WriteLine("3. Get All Tests");
            ReadAll(item);
            Console.WriteLine("4. Update Test");
            UpdateTest();
            Console.WriteLine("5. Delete Test");
            Delete(item);
            break;
        case "QuestionForStudent":
            Console.WriteLine("QuestionForStudent Submenu:\n");
            Console.WriteLine("1. Add QuestionForStudent");
            AddQuestionForStudent();
            Console.WriteLine("2. Get QuestionForStudent by IDs");
            Read(item);
            Console.WriteLine("3. Get All QuestionForStudents");
            ReadAll(item);
            Console.WriteLine("4. Update QuestionForStudent");
            UpdateQuestionForStudent();
            Console.WriteLine("5. Delete QuestionForStudent");
            Delete(item);
            break;
        default:
            throw new ArgumentException($"Unknown item: {item}");
        }
    }
}













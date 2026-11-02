using DO;
using Dal;
using DalApi;
namespace DalTest;

public class Program
{
    private static IDal s_dal = new DalList();



    public static void Main(string[] args)
    {
        Initialization.Initialize(s_dal);
        try
        {
            MainMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void CreateAnswer()
    {

        Console.WriteLine("Enter ID of answer to Create\n");
        var id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Content\n");
        var content = Console.ReadLine();
        Console.WriteLine("Enter Question Id\n");
        var questionId = Convert.ToInt32(Console.ReadLine());
        var answer = new Answer { Id = id, Content = content, QuestionId = questionId };
        s_dal.Answer.Create(answer);
        Console.WriteLine($"Createed Answer: {s_dal.Answer.Read(id)}\n");
    }

    private static void CreateQuestion()
    {
        Console.WriteLine("Enter ID of question to Create\n");
        var id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter subject\n");
        var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
        Console.WriteLine("Enter content\n");
        var content = Console.ReadLine();
        Console.WriteLine("Enter CorrectAnswerId");
        var correctAnswerId = Convert.ToInt32(Console.ReadLine());
        var question = new Question { Id = id, Subject = subject, Content = content, CorrectAnswerId = correctAnswerId };
        s_dal.Question.Create(question);
        Console.WriteLine($"Createed Question: {s_dal.Question.Read(id)}\n");
    }

    public static void CreateStudent()
    {
        Console.WriteLine("Enter ID of student to Create\n");
        var id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter name\n");
        var name = Console.ReadLine();
        Console.WriteLine("Enter testID");
        var testId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter score\n");
        var score = Convert.ToInt32(Console.ReadLine());
        var student = new Student { Id = id, Name = name, TestId = testId, Score = score };
        s_dal.Student.Create(student);
        Console.WriteLine($"Createed Student: {s_dal.Student.Read(id)}\n");
    }

    public static void CreateTest()
    {
        Console.WriteLine("Enter ID of test to Create\n");
        var id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter subject\n");
        var subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
        Console.WriteLine("Enter exam date\n");
        var examDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of questions\n");
        var numOfQuestions = Convert.ToInt32(Console.ReadLine());
        var test = new Test { Id = id, Subject = subject, ExamDate = examDate, NumOfQuestions = numOfQuestions };
        s_dal.Test.Create(test);
        Console.WriteLine($"Createed Test: {s_dal.Test.Read(id)}\n");
    }

    public static void CreateQuestionForStudent()
    {
        Console.WriteLine("Enter Student ID of QuestionForStudent to Create\n");
        var studentId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Test ID of QuestionForStudent to Create\n");
        var testId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Question ID of QuestionForStudent to Create\n");
        var questionId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Selected Answer ID\n");
        var selectedAnswerId = Convert.ToInt32(Console.ReadLine());
        var questionForStudent = new QuestionForStudent { StudentId = studentId, TestId = testId, QuestionId = questionId, SelectedAnswerId = selectedAnswerId };
        s_dal.QuestionForStudent.Create(questionForStudent);
        Console.WriteLine($"Createed QuestionForStudent: {s_dal.QuestionForStudent.Read(studentId, testId, questionId)}\n");
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
        Console.WriteLine($"Updated Answer: {s_dal.Answer.Read(id)}\n");
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
        Console.WriteLine($"Updated Question: {s_dal.Question.Read(id)}\n");
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
        Console.WriteLine($"Updated Student: {s_dal.Student.Read(id)}\n");
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
        Console.WriteLine($"Updated Test: {s_dal.Test.Read(id)}\n");
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
        Console.WriteLine($"Updated QuestionForStudent: {s_dal.QuestionForStudent.Read(studentId, testId, questionId)}\n");
    }

    private static void ReadAll<T>(ICrud<T> icrud)
    {
        var items = icrud.ReadAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    private static void Read<T>(ICrud<T> crud)
    {
        Console.WriteLine("Enter the ID of the item to read:");
        int id = Convert.ToInt32(Console.ReadLine());
        var item = crud.Read(id);
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
        var item = crud.Read(id);
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
                    PrintSubMenu("Answer");
                    break;
                case 2:
                    PrintSubMenu("Question");
                    break;
                case 3:
                    PrintSubMenu("Student");
                    break;
                case 4:
                    PrintSubMenu("Test");
                    break;
                case 5:
                    PrintSubMenu("QuestionForStudent");
                    break;
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

    public static void PrintSubMenu(string item)
    {
        int choice;
        switch (item)
        {
            case "Answer":

                Console.WriteLine("Answer Submenu:\n");

                Console.WriteLine("1. Create Answer");

                Console.WriteLine("2. Get Answer by ID");

                Console.WriteLine("3. Get All Answers");

                Console.WriteLine("4. Update Answer");

                Console.WriteLine("5. Delete Answer");



                break;
            case "Question":
                Console.WriteLine("Question Submenu:\n");
                Console.WriteLine("1. Create Question");

                Console.WriteLine("2. Get Question by ID");

                Console.WriteLine("3. Get All Questions");

                Console.WriteLine("4. Update Question");

                Console.WriteLine("5. Delete Question");

                break;
            case "Student":
                Console.WriteLine("Student Submenu:\n");
                Console.WriteLine("1. Create Student");

                Console.WriteLine("2. Get Student by ID");

                Console.WriteLine("3. Get All Students");

                Console.WriteLine("4. Update Student");

                Console.WriteLine("5. Delete Student");

                break;
            case "Test":
                Console.WriteLine("Test Submenu:\n");
                Console.WriteLine("1. Create Test");

                Console.WriteLine("2. Get Test by ID");

                Console.WriteLine("3. Get All Tests");

                Console.WriteLine("4. Update Test");

                Console.WriteLine("5. Delete Test");

                break;
            case "QuestionForStudent":
                Console.WriteLine("QuestionForStudent Submenu:\n");
                Console.WriteLine("1. Create QuestionForStudent");

                Console.WriteLine("2. Get QuestionForStudent by IDs");

                Console.WriteLine("3. Get All QuestionForStudents");

                Console.WriteLine("4. Update QuestionForStudent");

                Console.WriteLine("5. Delete QuestionForStudent");

                break;
            default:
                throw new ArgumentException($"Unknown item: {item}");
        }

        choice = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
        SubMenu(item, choice);
    }

    public static void SubMenu(string item, int choice)
    {
        switch (choice)
        {
            case 1:
                switch (item)
                {
                    case "Answer":
                        CreateAnswer();
                        break;
                    case "Question":
                        CreateQuestion();
                        break;
                    case "Student":
                        CreateStudent();
                        break;
                    case "Test":
                        CreateTest();
                        break;
                    case "QuestionForStudent":
                        CreateQuestionForStudent();
                        break;
                    default:
                        throw new ArgumentException($"Unknown item: {item}");
                        break;
                }
                break;
            case 2:
                switch (item)
                {
                    case "Answer":
                        Read(s_dal.Answer);
                        break;
                    case "Question":
                        Read(s_dal.Question);
                        break;
                    case "Student":
                        Read(s_dal.Student);
                        break;
                    case "Test":
                        Read(s_dal.Test);
                        break;
                    case "QuestionForStudent":
                        Read(s_dal.QuestionForStudent);
                        break;
                    default:
                        throw new ArgumentException($"Unknown item: {item}");
                        break;
                }
                break;

            case 3:
                switch (item)
                {
                    case "Answer":
                        ReadAll(s_dal.Answer);
                        break;
                    case "Question":
                        ReadAll(s_dal.Question);
                        break;
                    case "Student":
                        ReadAll(s_dal.Student);
                        break;
                    case "Test":
                        ReadAll(s_dal.Test);
                        break;
                    case "QuestionForStudent":
                        ReadAll(s_dal.QuestionForStudent);
                        break;
                    default:
                        throw new ArgumentException($"Unknown item: {item}");
                        break;
                }
                break;
            case 4:
                switch (item)
                {
                    case "Answer":
                        UpdateAnswer();
                        break;
                    case "Question":
                        UpdateQuestion();
                        break;
                    case "Student":
                        UpdateStudent();
                        break;
                    case "Test":
                        UpdateTest();
                        break;
                    case "QuestionForStudent":
                        UpdateQuestionForStudent();
                        break;
                    default:
                        throw new ArgumentException($"Unknown item: {item}");
                        break;
                }
                break;
            case 5:
                switch (item)
                {
                    case "Answer":
                        Delete(s_dal.Answer);
                        break;
                    case "Question":
                        Delete(s_dal.Question);
                        break;
                    case "Student":
                        Delete(s_dal.Student);
                        break;
                    case "Test":
                        Delete(s_dal.Test);
                        break;
                    case "QuestionForStudent":
                        Delete(s_dal.QuestionForStudent);
                        break;
                    default:
                        throw new ArgumentException($"Unknown item: {item}");
                        break;
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}





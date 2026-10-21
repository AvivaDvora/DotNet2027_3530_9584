using DO;
using Dal;
using DalApi;

namespace DalTest;


private static IDal s_dal = new DalList();
Initialize(s_dal);
public static void main(string[] args)
{
    tr
   }






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
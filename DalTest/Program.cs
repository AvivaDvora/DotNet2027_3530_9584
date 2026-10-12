using DO;
using Dal;

// אתחול מאגר הנתונים - יצירת מקור הנתונים ממלא את כל רשימות הישויות בנתוני דמה.
DataSource dataSource = new DataSource();

// יצירת מימושי שכבת ה-DAL עבור כל ישות, דרך הממשקים המוגדרים ב-DalFacade.
ITest testDal = new TestDal(dataSource);
IQuestion questionDal = new QuestionDal(dataSource);
IAnswer answerDal = new AnswerDal(dataSource);
IStudent studentDal = new StudentDal(dataSource);
IQuestionForStudent questionForStudentDal = new QuestionForStudentDal(dataSource);

// בדיקת כל מתודות ה-CRUD של כל ישות.
TestCrud(testDal, new Test(100, Subject.Subject1, new DateTime(2026, 1, 1), 4), 100);
QuestionCrud(questionDal, new Question(100, Subject.Subject2, "טקסט לדוגמה 100", 1), 100);
AnswerCrud(answerDal, new Answer(100, 1, "טקסט תשובה לדוגמה 100"), 100);
StudentCrud(studentDal, new Student(100, "שם מלא 100", 1, 0), 100);
QuestionForStudentCrud(questionForStudentDal, new QuestionForStudent(100, 1, 1, 1));

Console.WriteLine("הבדיקות הסתיימו בהצלחה.");

// --- מתודות בדיקה לכל ישות ---

/// <summary>בודק את מתודות ה-CRUD עבור ישות המבחן.</summary>
void TestCrud(ITest dal, Test item, int id)
{
    Console.WriteLine("--- Test ---");
    dal.Add(item);
    Console.WriteLine($"Add: {dal.GetById(id)}");
    Console.WriteLine($"GetAll count: {dal.GetAll().Count()}");
    dal.Update(item with { NumOfQuestions = 5 });
    Console.WriteLine($"Update: {dal.GetById(id)}");
    dal.Delete(id);
    Console.WriteLine($"GetById after delete: {dal.GetById(id)?.ToString() ?? "null"}");
}

/// <summary>בודק את מתודות ה-CRUD עבור ישות השאלה.</summary>
void QuestionCrud(IQuestion dal, Question item, int id)
{
    Console.WriteLine("--- Question ---");
    dal.Add(item);
    Console.WriteLine($"Add: {dal.GetById(id)}");
    Console.WriteLine($"GetAll count: {dal.GetAll().Count()}");
    dal.Update(item with { Subject = Subject.Subject3 });
    Console.WriteLine($"Update: {dal.GetById(id)}");
    dal.Delete(id);
    Console.WriteLine($"GetById after delete: {dal.GetById(id)?.ToString() ?? "null"}");
}

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

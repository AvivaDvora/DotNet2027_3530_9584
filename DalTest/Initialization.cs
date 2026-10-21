using DalApi;
using DO;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;


    private static void createStusents()
    {
        s_dal!.Student.Create(new Student { Id = 1, Name = "John", TestId = 0, Score = 0 });
        s_dal.Student.Create(new Student { Id = 2, Name = "Jane", TestId = 0, Score = 0 });
        s_dal.Student.Create(new Student { Id = 3, Name = "Alice", TestId = 0, Score = 0 });
        s_dal?.Student.Create(new Student { Id = 4, Name = "Bob", TestId = 0, Score = 0 });
        
    }

    private static void createQuestion()
    {

        // Question 1: "What is the capital of France (Correct answer: "Paris")
        s_dal!.Question.Create(new Question
        {
            Id = 1,
            Content = "What is the capital of France?",
            Subject = Subject.Geography, // Replace with appropriate Subject
            CorrectAnswerId = 1 // Assuming 1 is the ID for "Paris" in your answer storage
        });
        // Question 2: "What is 2 + 2?" (Correct answer: "4")
        s_dal.Question.Create(new Question
        {
            Id = 2,
            Content = "What is 2 + 2?",
            Subject = Subject.Math, // Replace with appropriate enum value
            CorrectAnswerId = 2 // Assuming 3: "What is the largest planet in our solar system?" (Correct answer: "Jupiter")
        });
        s_dal.Question.Create(new Question
        {
            Id = 3,
            Content = "What is the largest planet our solar system?",
            Subject = Subject.Science, // Replace with appropriate Subject value
            CorrectAnswerId = 3 // Assuming 3 is the ID for "upiter"
        });
        // Question 4: "What is the chemical symbol for water?" (Correct: "H2O")
        s_dal.Question.Create(new Question
        {
            Id = 4,
            Content = "What is the chemical symbol for water?",
            Subject = Subject.Chemistry, // Replace with appropriate Subject enum
            CorrectAnswerId = 4 // Assuming 4 is the ID for "H2O"
        });
    }

    private static void createTests()
    {
        s_dal!.Test.Create(new Test
        {
            Id = 1,
            Subject = Subject.Math,
            ExamDate = DateTime.Now,
            NumOfQuestions = 1
        });
        s_dal.Test.Create(new Test
        {
            Id = 2,
            Subject = Subject.Geography,
            ExamDate = DateTime.Now,
            NumOfQuestions = 1
        });
        s_dal.Test.Create(new Test
        {
            Id = 3,
            Subject = Subject.Science,
            ExamDate = DateTime.Now,
            NumOfQuestions = 2
        });
    }

    public static void createQuestionsForStudent()
    {
        s_dal!.QuestionForStudent.Create(new QuestionForStudent
        {

            StudentId = 1,
            TestId = 1,
            QuestionId = 1,
            SelectedAnswerId = 1
        });
        s_dal!.QuestionForStudent.Create(new QuestionForStudent
        {
            StudentId = 1,
            TestId = 2,
            QuestionId = 2,
            SelectedAnswerId = 2
        });
        s_dal.QuestionForStudent.Create(new QuestionForStudent
        {
            StudentId = 3,
            TestId = 3,
            QuestionId = 3,
            SelectedAnswerId = 3
        });
    }

    public static void createAnswers()
    {
        s_dal!.Answer.Create(new Answer
        {
            Id = 1,
            QuestionId = 1,
            Content = "Paris"
        });
        s_dal.Answer.Create(new Answer
        {
            Id = 2,
            QuestionId = 2,
            Content = "4"
        });
        s_dal.Answer.Create(new Answer
        {
            Id = 3,
            QuestionId = 3,
            Content = "Jupiter"
        });
        s_dal.Answer.Create(new Answer
        {
            Id = 4,
            QuestionId = 4,
            Content = "H2O"
        });
    }

    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        createStusents();
        createQuestion();
        createTests();
        createQuestionsForStudent();
        createAnswers();
    }
}

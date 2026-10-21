using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {
        IStudent Student { get; }
        IAnswer Answer { get; }
        IQuestion Question { get; }
        IQuestionForStudent QuestionForStudent { get; }
        ITest Test { get; }
    }
}

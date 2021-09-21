using System;
using System.Collections.Generic;

namespace TriviaPorts
{
    public interface IMultipleChoiceQuestion : IQuestion
    {
        List<string> PossibleAnswers { get; set; }
        int CorrectAnswerIndex { get; set; }
    }
}

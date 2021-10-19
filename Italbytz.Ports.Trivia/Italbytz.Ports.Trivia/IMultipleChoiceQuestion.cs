using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Trivia
{
    public interface IMultipleChoiceQuestion : IQuestion
    {
        List<string> PossibleAnswers { get; set; }
        int CorrectAnswerIndex { get; set; }
    }
}

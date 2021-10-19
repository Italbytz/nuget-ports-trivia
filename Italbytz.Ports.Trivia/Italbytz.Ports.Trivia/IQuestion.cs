using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Trivia
{
    public interface IQuestion
    {
        string Category { get; set; }
        QuestionType QuestionType { get; set; }
        Choices ChoicesType { get; set; }
        Difficulty Difficulty { get; set; }
        string Text { get; set; }
        IQuestion AlternativeQuestion { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace TriviaPorts
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

using System;
namespace TriviaPorts
{
    public interface IYesNoQuestion : IQuestion
    {
        bool Answer { get; set; }
    }
}

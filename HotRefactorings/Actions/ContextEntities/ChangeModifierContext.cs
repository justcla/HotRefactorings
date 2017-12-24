﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeRefactorings;

namespace HotCommands
{
    internal sealed class ChangeModifierContext : IModifierActionContext
    {
        public CodeRefactoringContext Context { get; set; }

        public SyntaxToken[] NewModifiers { get; set; }

        public string Title { get; set; }
    }
}

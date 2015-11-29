// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

namespace Z.Expressions
{
    /// <summary>Values that represent the ParameterKind for the EvalCompiler.</summary>
    public enum EvalCompilerParameterKind
    {
        /// <summary>An enum constant representing the option when no parameter is specified.</summary>
        None,

        /// <summary>An enum constant representing the option when a dictionary parameter is specified.</summary>
        Dictionary,

        /// <summary>An enum constant representing the option when an enumerable parable is specified.</summary>
        Enumerable,

        /// <summary>An enum constant representing the option when a single dictionary parameter is specified.</summary>
        SingleDictionary,

        /// <summary>An enum constant representing the option when parameter are typed.</summary>
        Typed,

        /// <summary>An enum constant representing the option when parameter are untyped.</summary>
        Untyped
    }
}
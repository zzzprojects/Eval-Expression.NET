// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

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
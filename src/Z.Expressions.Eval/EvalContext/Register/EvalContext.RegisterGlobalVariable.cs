// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Registers a global variable.</summary>
        /// <exception cref="Exception">Thrown an exception if the global variable name already exists.</exception>
        /// <param name="name">The global variable name.</param>
        /// <param name="value">The global variable value.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterGlobalVariable(string name, object value)
        {
            if (!AliasGlobalVariables.TryAdd(name, value))
            {
                throw new Exception(string.Format(ExceptionMessage.UnexpectedAliasRegistered, name));
            }
            return this;
        }
    }
}
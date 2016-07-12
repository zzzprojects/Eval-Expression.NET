// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

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
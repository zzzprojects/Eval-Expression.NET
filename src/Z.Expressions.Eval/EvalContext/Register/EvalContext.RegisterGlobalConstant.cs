// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Linq.Expressions;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Registers a global constant.</summary>
        /// <exception cref="Exception">Thrown an exception if the global constant name already exists.</exception>
        /// <param name="name">The global constant name.</param>
        /// <param name="value">The global constant value.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterGlobalConstant(string name, object value)
        {
            if (!AliasGlobalConstants.TryAdd(name, Expression.Constant(value)))
            {
                throw new Exception(string.Format(ExceptionMessage.UnexpectedAliasRegistered, name));
            }

            return this;
        }
    }
}
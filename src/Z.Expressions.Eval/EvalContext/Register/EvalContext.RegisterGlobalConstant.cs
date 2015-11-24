// Description: Evaluate, Compile and Execute C# code and expression at runtime
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
        /// <summary>Registers a global constant.</summary>
        /// <exception cref="Exception">Thrown an exception if the global constant name already exists.</exception>
        /// <param name="name">The global constant name.</param>
        /// <param name="value">The global constant value.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterGlobalConstant(string name, object value)
        {
            if (!AliasGlobalConstants.TryAdd(name, value))
            {
                throw new Exception(string.Format(ExceptionMessage.UnexpectedAliasRegistered, name));
            }

            return this;
        }
    }
}
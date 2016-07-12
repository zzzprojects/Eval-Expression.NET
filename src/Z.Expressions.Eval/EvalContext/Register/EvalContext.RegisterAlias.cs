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
        /// <summary>Registers an alias for a variable, constant or type name.</summary>
        /// <exception cref="Exception">Thrown an exception if the alias already exists.</exception>
        /// <param name="alias">The alias to register.</param>
        /// <param name="name">The variable, constant or type name to register for the specified alias.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterAlias(string alias, string name)
        {
            if (!AliasNames.TryAdd(alias, name))
            {
                throw new Exception(string.Format(ExceptionMessage.UnexpectedAliasRegistered, alias));
            }

            return this;
        }
    }
}
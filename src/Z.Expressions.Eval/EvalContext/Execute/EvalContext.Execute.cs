// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Compile and evaluate the code or expression and return the result.</summary>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <returns>The evaluated result or null that represents the evaluted code or expression.</returns>
        public object Execute(string code)
        {
            return Execute<object>(code);
        }

        /// <summary>Compile and evaluate the code or expression and return the result.</summary>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result or null that represents the evaluted code or expression.</returns>
        public object Execute(string code, object parameters)
        {
            return Execute<object>(code, parameters);
        }

        /// <summary>Compile and evaluate the code or expression and return the result.</summary>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result or null that represents the evaluted code or expression.</returns>
        public object Execute(string code, params object[] parameters)
        {
            return Execute<object>(code, parameters);
        }
    }
}
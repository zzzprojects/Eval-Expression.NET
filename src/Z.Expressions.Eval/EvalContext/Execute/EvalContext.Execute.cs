// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

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
// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

namespace Z.Expressions
{
    public static partial class Eval
    {
        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public static TResult Execute<TResult>(string code)
        {
            return EvalManager.DefaultContext.Execute<TResult>(code);
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public static TResult Execute<TResult>(string code, object parameters)
        {
            return EvalManager.DefaultContext.Execute<TResult>(code, parameters);
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public static TResult Execute<TResult>(string code, params object[] parameters)
        {
            return EvalManager.DefaultContext.Execute<TResult>(code, parameters);
        }
    }
}
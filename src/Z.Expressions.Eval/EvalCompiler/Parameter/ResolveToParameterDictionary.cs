// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Collections;
using System.Collections.Generic;

namespace Z.Expressions
{
    internal static partial class EvalCompiler
    {
        /// <summary>Create a parameter dictionary (key / value) from an enumerable item.</summary>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>A dictionary (key / value) generated from the enumerable item</returns>
        private static Dictionary<string, object> ResolveToParameterDictionary(IEnumerable enumerable)
        {
            var dict = new Dictionary<string, object>();

            var i = 0;
            foreach (var value in enumerable)
            {
                dict.Add("{" + i + "}", value);
                i++;
            }

            return dict;
        }
    }
}
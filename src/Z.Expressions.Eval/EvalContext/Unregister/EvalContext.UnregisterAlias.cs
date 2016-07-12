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
        /// <summary>Unregisters all alias for a variable, constant or type name.</summary>
        /// <param name="aliases">A variable-length parameters list containing alias to unregister.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterAlias(params string[] aliases)
        {
            foreach (var alias in aliases)
            {
                string value;
                AliasNames.TryRemove(alias, out value);
            }

            return this;
        }
    }
}
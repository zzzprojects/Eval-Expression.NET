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
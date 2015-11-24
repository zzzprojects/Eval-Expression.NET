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
        /// <summary>Unregisters a global variable.</summary>
        /// <param name="aliases">The global variable name.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterGlobalVariable(params string[] aliases)
        {
            foreach (var alias in aliases)
            {
                object value;
                AliasGlobalVariables.TryRemove(alias, out value);
            }

            return this;
        }
    }
}
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
        /// <summary>Unregisters all kind of alias (Extension Methods, Names, Static Members, Types and Values).</summary>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterAll()
        {
            AliasExtensionMethods.Clear();
            AliasGlobalConstants.Clear();
            AliasGlobalVariables.Clear();
            AliasNames.Clear();
            AliasStaticMembers.Clear();
            AliasTypes.Clear();

            return this;
        }
    }
}
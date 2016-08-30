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
        /// <summary>Unregisters all kind of alias (Extension Methods, Names, Static Members, Types and Values).</summary>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterAll()
        {
            AliasExtensionMethods.Clear();
            AliasGlobalConstants.Clear();
            AliasGlobalVariables.Clear();
            AliasMembers.Clear();
            AliasNames.Clear();
            AliasStaticMembers.Clear();
            AliasTypes.Clear();

            return this;
        }
    }
}
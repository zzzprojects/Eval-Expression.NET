// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Reflection;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters all types from all specified assemblies.</summary>
        /// <param name="assemblies">A variable-length parameters list containing assemblies to unregister type from.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterAssembly(params Assembly[] assemblies)
        {
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                UnregisterType(types);
            }

            return this;
        }
    }
}
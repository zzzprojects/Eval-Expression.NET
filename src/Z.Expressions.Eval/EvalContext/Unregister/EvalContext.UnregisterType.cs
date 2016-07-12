// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters specified types using Type.Name and Type.FullName as alias.</summary>
        /// <param name="types">A variable-length parameters list containing types to unregister.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterType(params Type[] types)
        {
            foreach (var type in types)
            {
                Type outType;

                AliasTypes.TryRemove(type.Name, out outType);
                AliasTypes.TryRemove(type.FullName, out outType);
            }
            return this;
        }
    }
}
// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Linq;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Registers all types from all domain assemblies.</summary>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterDomainAssemblies()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var types = assemblies.SelectMany(x => x.GetTypes())
                // REMOVE some conflicted namespace
                .Where(x => x.FullName != "System.Deployment.Application.Manifest.File"
                            && x.FullName != "System.Net.WebRequestMethods+File"
                            && !x.FullName.StartsWith("System.Dynamic.Utils.CollectionExtensions")).ToArray();

            RegisterType(types);

            return this;
        }
    }
}
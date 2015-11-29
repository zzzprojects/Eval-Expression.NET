// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Runtime.Caching;

namespace Z.Expressions
{
    public class EvalManager
    {
        /// <summary>Static constructor.</summary>
        static EvalManager()
        {
            Cache = MemoryCache.Default;
            DefaultContext = new EvalContext();
        }

        /// <summary>Gets or sets the cache used to cache compiled code and expressions.</summary>
        /// <value>The cache used to cache compiled code and expressions.</value>
        public static ObjectCache Cache { get; set; }

        /// <summary>Gets or sets the default context used for static member from Eval class and Extension Methods.</summary>
        /// <value>The default context used for static member from Eval class and Extension Methods.</value>
        public static EvalContext DefaultContext { get; set; }

        /// <summary>Add the PRO license purchased from ZZZ Projects Inc. (http://eval-expression.net/).</summary>
        /// <param name="licenseName">The license name.</param>
        /// <param name="licenseKey">The license key.</param>
        public static void AddLicense(string licenseName, string licenseKey)
        {
            CompilerManager.AddLicense(licenseName, licenseKey);
        }
    }
}
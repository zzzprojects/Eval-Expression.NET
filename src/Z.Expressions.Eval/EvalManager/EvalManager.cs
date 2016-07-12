// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

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
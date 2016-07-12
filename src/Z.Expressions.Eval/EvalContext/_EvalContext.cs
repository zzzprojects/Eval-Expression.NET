// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        public EvalContext()
        {
            AliasExtensionMethods = new ConcurrentDictionary<string, ConcurrentDictionary<MethodInfo, byte>>();
            AliasGlobalConstants = new ConcurrentDictionary<string, ConstantExpression>();
            AliasGlobalVariables = new ConcurrentDictionary<string, object>();
            AliasNames = new ConcurrentDictionary<string, string>();
            AliasStaticMembers = new ConcurrentDictionary<string, ConcurrentDictionary<MemberInfo, byte>>();
            AliasTypes = new ConcurrentDictionary<string, Type>();
            BindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase;
            CacheKeyPrefix = GetType().FullName;
            UseCache = true;
            UseCaretForExponent = false;

            RegisterDefaultAlias();
        }

        /// <summary>Gets or sets the alias list for extension methods.</summary>
        /// <value>The alias list for extension methods.</value>
        public ConcurrentDictionary<string, ConcurrentDictionary<MethodInfo, byte>> AliasExtensionMethods { get; set; }

        /// <summary>Gets or sets the alias list for global constants.</summary>
        /// <value>The alias list for global constants.</value>
        public ConcurrentDictionary<string, ConstantExpression> AliasGlobalConstants { get; set; }

        /// <summary>Gets or sets the alias list for global variables.</summary>
        /// <value>The alias list for global variables.</value>
        public ConcurrentDictionary<string, object> AliasGlobalVariables { get; set; }

        /// <summary>Gets or sets the alias list for names.</summary>
        /// <value>The alias list for names.</value>
        public ConcurrentDictionary<string, string> AliasNames { get; set; }

        /// <summary>Gets or sets the alias list for static members.</summary>
        /// <value>The alias list for static members.</value>
        public ConcurrentDictionary<string, ConcurrentDictionary<MemberInfo, byte>> AliasStaticMembers { get; set; }

        /// <summary>Gets or sets the alias list for types.</summary>
        /// <value>A alias list for types.</value>
        public ConcurrentDictionary<string, Type> AliasTypes { get; set; }

        /// <summary>Gets or sets the binding flags used to resolve members in the compiler.</summary>
        /// <value>The binding flags used to resolve members in the compiler.</value>
        public BindingFlags BindingFlags { get; set; }

        /// <summary>Gets or sets the cache key prefix used for the compiled code or expression cache.</summary>
        /// <value>The cache key prefix used for the compiled code or expression cache.</value>
        public string CacheKeyPrefix { get; set; }

        /// <summary>Gets or sets a value indicating whether the compiled code or expression cache should be used.</summary>
        /// <value>true if use cache, false if not.</value>
        public bool UseCache { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the compiler should use caret for exponent expression instead of XOR
        ///     expression.
        /// </summary>
        /// <value>true if the caret should be used for exponent, false if not.</value>
        public bool UseCaretForExponent { get; set; }
    }
}
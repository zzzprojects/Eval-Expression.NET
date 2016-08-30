// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters member from specified types.</summary>
        /// <param name="types">A variable-length parameters list containing types to unregister static members from.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterMember(params Type[] types)
        {
            foreach (var type in types)
            {
                var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

                UnregisterMember(constructors);
                UnregisterMember(fields);
                UnregisterMember(methods);
                UnregisterMember(properties);
            }

            return this;
        }

        /// <summary>Unregisters member from specified types.</summary>
        /// <param name="members">A variable-length parameters list containing members.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterMember(params MemberInfo[] members)
        {
            foreach (var member in members)
            {
                if (member.DeclaringType != null)
                {
                    if (AliasTypes.ContainsKey(member.DeclaringType.FullName))
                    {
                        UnregisterType(member.DeclaringType);
                        RegisterMember(member.DeclaringType);
                    }
                }

                ConcurrentDictionary<MemberInfo, byte> values;
                if (AliasMembers.TryGetValue(member.Name, out values))
                {
                    byte outByte;
                    values.TryRemove(member, out outByte);
                }
            }

            return this;
        }
    }
}
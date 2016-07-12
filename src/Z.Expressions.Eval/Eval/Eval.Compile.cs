// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Z.Expressions
{
    public static partial class Eval
    {
        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object> Compile(string code)
        {
            return EvalManager.DefaultContext.Compile(code);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<IEnumerable, object> Compile(string code, IEnumerable<Type> parameterTypes)
        {
            return EvalManager.DefaultContext.Compile(code, parameterTypes);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<IEnumerable, object> Compile(string code, params Type[] parameterTypes)
        {
            return EvalManager.DefaultContext.Compile(code, parameterTypes);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<IDictionary, object> Compile(string code, IDictionary<string, Type> parameterTypes)
        {
            return EvalManager.DefaultContext.Compile(code, parameterTypes);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object> Compile(string code, Type type1)
        {
            return EvalManager.DefaultContext.Compile(code, type1);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object> Compile(string code, Type type1, Type type2)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object> Compile(string code, Type type1, Type type2, Type type3)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3, type4);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <param name="type5">The fifth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3, type4, type5);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <param name="type5">The fifth type used to compile the code or expression.</param>
        /// <param name="type6">The sixth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3, type4, type5, type6);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <param name="type5">The fifth type used to compile the code or expression.</param>
        /// <param name="type6">The sixth type used to compile the code or expression.</param>
        /// <param name="type7">The seventh type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3, type4, type5, type6, type7);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <param name="type5">The fifth type used to compile the code or expression.</param>
        /// <param name="type6">The sixth type used to compile the code or expression.</param>
        /// <param name="type7">The seventh type used to compile the code or expression.</param>
        /// <param name="type8">The eighth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3, type4, type5, type6, type7, type8);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <param name="type5">The fifth type used to compile the code or expression.</param>
        /// <param name="type6">The sixth type used to compile the code or expression.</param>
        /// <param name="type7">The seventh type used to compile the code or expression.</param>
        /// <param name="type8">The eighth type used to compile the code or expression.</param>
        /// <param name="type9">The ninth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public static Func<object, object, object, object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8, Type type9)
        {
            return EvalManager.DefaultContext.Compile(code, type1, type2, type3, type4, type5, type6, type7, type8, type9);
        }
    }
}
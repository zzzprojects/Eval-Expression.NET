// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<object> Compile(string code)
        {
            return EvalCompiler.Compile<Func<object>>(this, code, null, typeof (object), EvalCompilerParameterKind.None);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<IEnumerable, object> Compile(string code, IEnumerable<Type> parameterTypes)
        {
            return Compile(code, parameterTypes.ToArray());
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<IEnumerable, object> Compile(string code, params Type[] parameterTypes)
        {
            var dict = new Dictionary<string, Type>();

            for (var i = 0; i < parameterTypes.Length; i++)
            {
                dict.Add(string.Concat("{", i, "}"), parameterTypes[i]);
            }

            return EvalCompiler.Compile<Func<IEnumerable, object>>(this, code, dict, typeof (object), EvalCompilerParameterKind.Enumerable);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<IDictionary, object> Compile(string code, IDictionary<string, Type> parameterTypes)
        {
            return EvalCompiler.Compile<Func<IDictionary, object>>(this, code, parameterTypes, typeof (object), EvalCompilerParameterKind.Dictionary);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<object, object> Compile(string code, Type type1)
        {
            return EvalCompiler.Compile<Func<object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<object, object, object> Compile(string code, Type type1, Type type2)
        {
            return EvalCompiler.Compile<Func<object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<object, object, object, object> Compile(string code, Type type1, Type type2, Type type3)
        {
            return EvalCompiler.Compile<Func<object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4)
        {
            return EvalCompiler.Compile<Func<object, object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3},
                {"{3}", type4}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <param name="type3">The third type used to compile the code or expression.</param>
        /// <param name="type4">The fourth type used to compile the code or expression.</param>
        /// <param name="type5">The fifth type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Func<object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5)
        {
            return EvalCompiler.Compile<Func<object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3},
                {"{3}", type4},
                {"{4}", type5}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
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
        public Func<object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6)
        {
            return EvalCompiler.Compile<Func<object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3},
                {"{3}", type4},
                {"{4}", type5},
                {"{5}", type6}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
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
        public Func<object, object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7)
        {
            return EvalCompiler.Compile<Func<object, object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3},
                {"{3}", type4},
                {"{4}", type5},
                {"{5}", type6},
                {"{6}", type7}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
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
        public Func<object, object, object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8)
        {
            return EvalCompiler.Compile<Func<object, object, object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3},
                {"{3}", type4},
                {"{4}", type5},
                {"{5}", type6},
                {"{6}", type7},
                {"{7}", type8}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
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
        public Func<object, object, object, object, object, object, object, object, object, object> Compile(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8, Type type9)
        {
            return EvalCompiler.Compile<Func<object, object, object, object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1},
                {"{1}", type2},
                {"{2}", type3},
                {"{3}", type4},
                {"{4}", type5},
                {"{5}", type6},
                {"{6}", type7},
                {"{7}", type8},
                {"{8}", type9}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
        }
    }
}
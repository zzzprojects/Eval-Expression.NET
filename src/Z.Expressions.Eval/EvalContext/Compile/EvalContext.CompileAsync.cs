// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.


#if NET45
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Task<Func<object>> CompileAsync(string code)
        {
            return EvalCompiler.CompileAsync<Func<object>>(this, code, null, typeof (object), EvalCompilerParameterKind.None);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Task<Func<IEnumerable, object>> CompileAsync(string code, IEnumerable<Type> parameterTypes)
        {
            return CompileAsync(code, parameterTypes.ToArray());
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Task<Func<IEnumerable, object>> CompileAsync(string code, params Type[] parameterTypes)
        {
            var dict = new Dictionary<string, Type>();

            for (var i = 0; i < parameterTypes.Length; i++)
            {
                dict.Add(string.Concat("{", i, "}"), parameterTypes[i]);
            }

            return EvalCompiler.CompileAsync<Func<IEnumerable, object>>(this, code, dict, typeof (object), EvalCompilerParameterKind.Enumerable);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">Parameter types used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Task<Func<IDictionary, object>> CompileAsync(string code, IDictionary<string, Type> parameterTypes)
        {
            return EvalCompiler.CompileAsync<Func<IDictionary, object>>(this, code, parameterTypes, typeof (object), EvalCompilerParameterKind.Dictionary);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Task<Func<object, object>> CompileAsync(string code, Type type1)
        {
            return EvalCompiler.CompileAsync<Func<object, object>>(this, code, new Dictionary<string, Type>
            {
                {"{0}", type1}
            }, typeof (object), EvalCompilerParameterKind.Untyped);
        }

        /// <summary>Compile the code or expression and return a delegate of type Func to execute.</summary>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="type1">The first type used to compile the code or expression.</param>
        /// <param name="type2">The second type used to compile the code or expression.</param>
        /// <returns>A delegate of type Func that represents the compiled code or expression.</returns>
        public Task<Func<object, object, object>> CompileAsync(string code, Type type1, Type type2)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3, Type type4)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3, Type type4, Type type5)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object, object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object, object, object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
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
        public Task<Func<object, object, object, object, object, object, object, object, object, object>> CompileAsync(string code, Type type1, Type type2, Type type3, Type type4, Type type5, Type type6, Type type7, Type type8, Type type9)
        {
            return EvalCompiler.CompileAsync<Func<object, object, object, object, object, object, object, object, object, object>>(this, code, new Dictionary<string, Type>
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

#endif
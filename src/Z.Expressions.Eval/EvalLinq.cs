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
using System.Linq.Expressions;

namespace Z.Expressions
{
    public class EvalLinq
    {
        public static object Execute(string code, Expression exp = null, params object[] parameters)
        {
            if (exp != null)
            {
                var expression = exp.ToString();
                expression = expression.Remove(expression.IndexOf('"'), 1);
                expression = expression.Remove(expression.LastIndexOf('"'), 1);
                code = code.Replace("{expression}", expression);
            }

            var dictValues = new Dictionary<string, object>();
            var dictTypes = new Dictionary<string, Type>();

            for (var i = 0; i < parameters.Length; i++)
            {
                if (i == 0)
                {
                    dictValues.Add("{" + i + parameters.Length + "}", parameters[i]);

                    if (parameters[i] != null)
                    {
                        dictTypes.Add("{" + i + parameters.Length + "}", parameters[i].GetType());
                    }
                    else
                    {
                        dictTypes.Add("{" + i + parameters.Length + "}", typeof (object));
                    }
                }
                else
                {
                    dictValues.Add("{" + i + "}", parameters[i]);

                    if (parameters[i] != null)
                    {
                        dictTypes.Add("{" + i + "}", parameters[i].GetType());
                    }
                    else
                    {
                        dictTypes.Add("{" + i + "}", typeof (object));
                    }
                }
            }

            var result = EvalCompiler.Compile<Func<IDictionary, object>>(EvalManager.DefaultContext, code, dictTypes, typeof (object), EvalCompilerParameterKind.SingleDictionary, true)(dictValues);
            return result;
        }
    }
}
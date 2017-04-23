using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Custom_Sequence_Operators
{
    public static class CustomSequenceOperators
    {
        public static IEnumerable<S> Combine<S>(this IEnumerable<S> first, IEnumerable<S> second, Func<S, S, S> func)
        {
            using (IEnumerator<S> e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    yield return func(e1.Current, e2.Current);
                }
            }
        }
    }

    public partial class Combine : Form
    {
        public Combine()
        {
            InitializeComponent();
        }

        #region Combine

        private void uiCombine_LINQ_Click(object sender, EventArgs e)
        {
            int[] vectorA = {0, 2, 4, 5, 6};
            int[] vectorB = {1, 3, 5, 7, 8};

            var dotProduct = vectorA.Combine(vectorB, (a, b) => a * b).Sum();

            var sb = new StringBuilder();

            sb.AppendLine("Dot product: {0}", dotProduct);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiCombine_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] vectorA = {0, 2, 4, 5, 6};
            int[] vectorB = {1, 3, 5, 7, 8};

            EvalManager.DefaultContext.RegisterExtensionMethod(typeof(CustomSequenceOperators));
            var dotProduct = vectorA.Execute<int>("Combine(vectorB, (a, b) => a * b).Sum()", new {vectorB});

            var sb = new StringBuilder();

            sb.AppendLine("Dot product: {0}", dotProduct);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
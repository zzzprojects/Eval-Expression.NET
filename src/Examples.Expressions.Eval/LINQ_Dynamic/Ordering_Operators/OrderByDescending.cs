using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Ordering_Operators
{
    public partial class OrderByDescending : Form
    {
        public OrderByDescending()
        {
            InitializeComponent();
        }

        #region OrderByDescending_Simple_1

        private void uiOrderByDescending_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDoubles = doubles.OrderByDescending(d => d);

            var sb = new StringBuilder();

            sb.AppendLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                sb.AppendLine(d.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderByDescending_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDoubles = doubles.OrderByDescendingDynamic(d => "d");

            var sb = new StringBuilder();

            sb.AppendLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                sb.AppendLine(d.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderByDescending_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDoubles = doubles.Execute<IEnumerable<double>>("OrderByDescending(d => d)");

            var sb = new StringBuilder();

            sb.AppendLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                sb.AppendLine(d.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region OrderByDescending_Simple_2

        private void uiOrderByDescending_Simple_2_LINQ_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderByDescending(p => p.UnitsInStock);

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderByDescending_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderByDescendingDynamic(p => "p.UnitsInStock");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderByDescending_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.Execute("OrderByDescending(p => p.UnitsInStock)");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region OrderByDescending_Comparer

        private void uiOrderByDescending_Comparer_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderByDescending_Comparer_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderByDescendingDynamic(a => "a", new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderByDescending_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            EvalManager.DefaultContext.RegisterType(typeof(CaseInsensitiveComparer));

            var sortedWords = words.Execute("OrderByDescending(a => a, new CaseInsensitiveComparer())");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        public class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
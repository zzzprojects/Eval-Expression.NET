using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Ordering_Operators
{
    public partial class OrderBy : Form
    {
        public OrderBy()
        {
            InitializeComponent();
        }

        #region OrderBy_Simple_1

        private void uiOrderBy_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = words.OrderBy(w => w);

            var sb = new StringBuilder();

            sb.AppendLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderBy_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = words.OrderByDynamic(w => "w");

            var sb = new StringBuilder();

            sb.AppendLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderBy_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = words.Execute<IEnumerable<string>>("OrderBy(w => w)");

            var sb = new StringBuilder();

            sb.AppendLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region OrderBy_Simple_2

        private void uiOrderBy_Simple_2_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = words.OrderBy(w => w.Length);

            var sb = new StringBuilder();

            sb.AppendLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderBy_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = words.OrderByDynamic(w => "w.Length");

            var sb = new StringBuilder();

            sb.AppendLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderBy_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = words.Execute<IEnumerable<string>>("OrderBy(w => w.Length)");

            var sb = new StringBuilder();

            sb.AppendLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region OrderBy_Simple_3

        private void uiOrderBy_Simple_3_LINQ_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderBy(p => p.ProductName);

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderBy_Simple_3_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderByDynamic(p => "p.ProductName");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderBy_Simple_3_LINQ_Execute_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.Execute("OrderBy(p => p.ProductName)");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region OrderBy_Comparer

        private void uiOrderBy_Comparer_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOrderBy_Comparer_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderByDynamic(a => "a", new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiOrderBy_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            EvalManager.DefaultContext.RegisterType(typeof(CaseInsensitiveComparer));

            var sortedWords = words.Execute("OrderBy(a => a, new CaseInsensitiveComparer())");

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
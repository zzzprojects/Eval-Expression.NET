using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Ordering_Operators
{
    public partial class ThenByDescending : Form
    {
        public ThenByDescending()
        {
            InitializeComponent();
        }

        #region ThenByDescending_Simple_1

        private void uiThenByDescending_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiThenByDescending_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderBy(p => p.Category).ThenByDescendingDynamic(p => "p.UnitPrice");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiThenByDescending_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            List<My.Product> products = My.GetProductList();

            var sortedProducts = products.OrderBy(p => p.Category).Execute<IEnumerable<My.Product>>("ThenByDescending(p => p.UnitPrice)");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedProducts);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region ThenByDescending_Comparer

        private void uiThenByDescending_Comparer_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiThenByDescending_Comparer_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a.Length).ThenByDescendingDynamic(a => "a", new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiThenByDescending_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            EvalManager.DefaultContext.RegisterType(typeof(CaseInsensitiveComparer));

            var sortedWords = words.OrderBy(a => a.Length).Execute<IEnumerable<string>>("ThenByDescending(a => a, new CaseInsensitiveComparer())");

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
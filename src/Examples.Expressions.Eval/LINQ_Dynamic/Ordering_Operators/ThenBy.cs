using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Ordering_Operators
{
    public partial class ThenBy : Form
    {
        public ThenBy()
        {
            InitializeComponent();
        }

        #region ThenBy_Simple_1

        private void uiThenBy_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);

            var sb = new StringBuilder();

            sb.AppendLine("Sorted digits:");
            foreach (var d in sortedDigits)
            {
                sb.AppendLine(d);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiThenBy_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sortedDigits = digits.OrderBy(d => d.Length).ThenByDynamic(d => "d");

            var sb = new StringBuilder();

            sb.AppendLine("Sorted digits:");
            foreach (var d in sortedDigits)
            {
                sb.AppendLine(d);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiThenBy_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sortedDigits = digits.OrderBy(d => d.Length).Execute<IEnumerable<string>>("ThenBy(d => d)");

            var sb = new StringBuilder();

            sb.AppendLine("Sorted digits:");
            foreach (var d in sortedDigits)
            {
                sb.AppendLine(d);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region ThenBy_Comparer

        private void uiThenBy_Comparer_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiThenBy_Comparer_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words.OrderBy(a => a.Length).ThenByDynamic(a => "a", new CaseInsensitiveComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, sortedWords);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiThenBy_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            EvalManager.DefaultContext.RegisterType(typeof(CaseInsensitiveComparer));

            var sortedWords = words.OrderBy(a => a.Length).Execute<IEnumerable<string>>("ThenBy(a => a, new CaseInsensitiveComparer())");

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
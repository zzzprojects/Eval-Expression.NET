using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Partitioning_Operators
{
    public partial class TakeWhile : Form
    {
        public TakeWhile()
        {
            InitializeComponent();
        }

        #region TakeWhile_Simple

        private void uiTakeWhile_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            var sb = new StringBuilder();

            sb.AppendLine("First numbers less than 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiTakeWhile_Simple_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var firstNumbersLessThan6 = numbers.TakeWhile(n => "n < 6");

            var sb = new StringBuilder();

            sb.AppendLine("First numbers less than 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiTakeWhile_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var firstNumbersLessThan6 = numbers.Execute<IEnumerable<int>>("TakeWhile(n => n < 6)");

            var sb = new StringBuilder();

            sb.AppendLine("First numbers less than 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region TakeWhile_Indexed

        private void uiTakeWhile_Indexed_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

            var sb = new StringBuilder();

            sb.AppendLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiTakeWhile_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var firstSmallNumbers = numbers.TakeWhile((n, index) => "n >= index");

            var sb = new StringBuilder();

            sb.AppendLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiTakeWhile_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var firstSmallNumbers = numbers.Execute<IEnumerable<int>>("TakeWhile((n, index) => n >= index)");

            var sb = new StringBuilder();

            sb.AppendLine("First numbers not less than their position:");
            foreach (var n in firstSmallNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Partitioning_Operators
{
    public partial class SkipWhile : Form
    {
        public SkipWhile()
        {
            InitializeComponent();
        }

        #region SkipWhile_Simple

        private void uiSkipWhile_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            var sb = new StringBuilder();

            sb.AppendLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSkipWhile_Simple_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var allButFirst3Numbers = numbers.SkipWhile(n => "n % 3 != 0");

            var sb = new StringBuilder();

            sb.AppendLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSkipWhile_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var allButFirst3Numbers = numbers.Execute<IEnumerable<int>>("SkipWhile(n => n % 3 != 0)");

            var sb = new StringBuilder();

            sb.AppendLine("All elements starting from first element divisible by 3:");
            foreach (var n in allButFirst3Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region SkipWhile_Indexed

        private void uiSkipWhile_Indexed_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

            var sb = new StringBuilder();

            sb.AppendLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSkipWhile_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var laterNumbers = numbers.SkipWhile((n, index) => "n >= index");

            var sb = new StringBuilder();

            sb.AppendLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSkipWhile_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var laterNumbers = numbers.Execute<IEnumerable<int>>("SkipWhile((n, index) => n >= index)");

            var sb = new StringBuilder();

            sb.AppendLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
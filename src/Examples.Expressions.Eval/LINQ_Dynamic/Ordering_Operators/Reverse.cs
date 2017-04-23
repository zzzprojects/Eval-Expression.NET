using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Ordering_Operators
{
    public partial class Reverse : Form
    {
        public Reverse()
        {
            InitializeComponent();
        }

        #region Reverse

        private void uiReverse_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var reversedIDigits = digits.Where(d => d[1] == 'i').Reverse();

            var sb = new StringBuilder();

            sb.AppendLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                sb.AppendLine(d);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiReverse_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var reversedIDigits = digits.Where(d => d[1] == 'i').Execute<IEnumerable<string>>("Reverse()");

            var sb = new StringBuilder();

            sb.AppendLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                sb.AppendLine(d);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
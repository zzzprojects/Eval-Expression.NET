using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    public partial class Aggregate : Form
    {
        public Aggregate()
        {
            InitializeComponent();
        }

        #region Aggregate_Simple

        private void uiAggregate_Simple_LINQ_Click(object sender, EventArgs e)
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

            var product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            var sb = new StringBuilder();

            sb.AppendLine("Total product of all numbers: {0}", product);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAggregate_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

            var product = doubles.Execute<double>("Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor)");

            var sb = new StringBuilder();

            sb.AppendLine("Total product of all numbers: {0}", product);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Aggregate_Seed

        private void uiAggregate_Seed_LINQ_Click(object sender, EventArgs e)
        {
            var startBalance = 100.0;

            int[] attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30};

            var endBalance = attemptedWithdrawals.Aggregate(startBalance, (balance, nextWithdrawal) => nextWithdrawal <= balance ? balance - nextWithdrawal : balance);

            var sb = new StringBuilder();

            sb.AppendLine("Ending balance: {0}", endBalance);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAggregate_Seed_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var startBalance = 100.0;

            int[] attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30};

            var endBalance = attemptedWithdrawals.Execute<double>("Aggregate(startBalance, (balance, nextWithdrawal) => ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance)", new {startBalance});

            var sb = new StringBuilder();

            sb.AppendLine("Ending balance: {0}", endBalance);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
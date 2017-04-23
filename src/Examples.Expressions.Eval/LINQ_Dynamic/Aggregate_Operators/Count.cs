using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    public partial class Count : Form
    {
        public Count()
        {
            InitializeComponent();
        }

        #region Count_Simple

        private void uiCount_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] factorsOf300 = {2, 2, 3, 5, 5};

            var uniqueFactors = factorsOf300.Distinct().Count();

            var sb = new StringBuilder();

            sb.AppendLine("There are {0} unique factors of 300.", uniqueFactors);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiCount_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] factorsOf300 = {2, 2, 3, 5, 5};

            var uniqueFactors = factorsOf300.Distinct().Execute<int>("Count()");

            var sb = new StringBuilder();

            sb.AppendLine("There are {0} unique factors of 300.", uniqueFactors);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Count_Conditional

        private void uiCount_Conditional_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var oddNumbers = numbers.Count(n => n % 2 == 1);

            var sb = new StringBuilder();

            sb.AppendLine("There are {0} odd numbers in the list.", oddNumbers);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiCount_Conditional_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var oddNumbers = numbers.Count(n => "n % 2 == 1");

            var sb = new StringBuilder();

            sb.AppendLine("There are {0} odd numbers in the list.", oddNumbers);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiCount_Conditional_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var oddNumbers = numbers.Execute<int>("Count(n => n % 2 == 1)");

            var sb = new StringBuilder();

            sb.AppendLine("There are {0} odd numbers in the list.", oddNumbers);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Count_Grouped_

        private void uiCount_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categoryCounts = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, ProductCount = g.Count()});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categoryCounts);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiCount_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categoryCounts = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categoryCounts);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        # endregion

        #region Count_Nested

        private void uiCount_Nested_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orderCounts = customers.Select(c => new {c.CustomerID, OrderCount = c.Orders.Count()});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderCounts);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiCount_Nested_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orderCounts = customers.Execute("Select(c => new { c.CustomerID, OrderCount = c.Orders.Count() })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderCounts);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
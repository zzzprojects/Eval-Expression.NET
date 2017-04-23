using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        #region Sum_Simple

        private void uiSum_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            double numSum = numbers.Sum();

            var sb = new StringBuilder();

            sb.AppendLine("The sum of the numbers is {0}.", numSum);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSum_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numSum = numbers.Execute<int>("Sum()");

            var sb = new StringBuilder();

            sb.AppendLine("The sum of the numbers is {0}.", numSum);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Sum_Projection

        private void uiSum_Projection_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            double totalChars = words.Sum(w => w.Length);

            var sb = new StringBuilder();

            sb.AppendLine("There are a total of {0} characters in these words.", totalChars);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSum_Projection_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var totalChars = words.Execute<int>("Sum(w => w.Length)");

            var sb = new StringBuilder();

            sb.AppendLine("There are a total of {0} characters in these words.", totalChars);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Sum_Grouped

        private void uiSum_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock)});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories); 

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSum_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
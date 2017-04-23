using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    public partial class Average : Form
    {
        public Average()
        {
            InitializeComponent();
        }

        #region Average_Simple

        private void uiAverage_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var averageNum = numbers.Average();

            var sb = new StringBuilder();

            sb.AppendLine("The average number is {0}.", averageNum);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAverage_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var averageNum = numbers.Execute<double>("Average()");

            var sb = new StringBuilder();

            sb.AppendLine("The average number is {0}.", averageNum);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Average_Projection

        private void uiAverage_Projection_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var averageLength = words.Average(w => w.Length);

            var sb = new StringBuilder();

            sb.AppendLine("The average word length is {0} characters.", averageLength);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAverage_Projection_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var averageLength = words.Execute<double>("Average(w => w.Length)");

            var sb = new StringBuilder();

            sb.AppendLine("The average word length is {0} characters.", averageLength);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Average_Grouped

        private void uiAverage_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.GroupBy(prod => prod.Category).Select(g => new {Category = g.Key, AveragePrice = g.Average(prod => prod.UnitPrice)});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAverage_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.Execute("GroupBy(prod => prod.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(prod => prod.UnitPrice) })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
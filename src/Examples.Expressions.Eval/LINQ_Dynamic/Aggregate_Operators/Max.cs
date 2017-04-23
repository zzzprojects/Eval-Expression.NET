using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    public partial class Max : Form
    {
        public Max()
        {
            InitializeComponent();
        }

        #region Max_Simple

        private void uiMax_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var maxNum = numbers.Max();

            var sb = new StringBuilder();

            sb.AppendLine("The maximum number is {0}.", maxNum);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMax_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var maxNum = numbers.Execute<int>("Max()");

            var sb = new StringBuilder();

            sb.AppendLine("The maximum number is {0}.", maxNum);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Max_Projection

        private void uiMax_Projection_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var longestLength = words.Max(w => w.Length);

            var sb = new StringBuilder();

            sb.AppendLine("The longest word is {0} characters long.", longestLength);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMax_Projection_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var longestLength = words.Execute<int>("Max(w => w.Length)");

            var sb = new StringBuilder();

            sb.AppendLine("The longest word is {0} characters long.", longestLength);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Max_Grouped

        private void uiMax_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice)});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMax_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Max_Elements

        private void uiMax_Elements_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)) });

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories, 1);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMax_Elements_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)) })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories, 1);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
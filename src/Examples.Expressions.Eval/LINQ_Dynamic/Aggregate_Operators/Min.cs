using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    public partial class Min : Form
    {
        public Min()
        {
            InitializeComponent();
        }

        #region Min_Simple

        private void uiMin_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var minNum = numbers.Min();

            var sb = new StringBuilder();

            sb.AppendLine("The minimum number is {0}.", minNum);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMin_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var minNum = numbers.Execute<int>("Min()");

            var sb = new StringBuilder();

            sb.AppendLine("The minimum number is {0}.", minNum);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region  Min_Projection

        private void uiMin_Projection_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var shortestWord = words.Min(w => w.Length);

            var sb = new StringBuilder();

            sb.AppendLine("The shortest word is {0} characters long.", shortestWord);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMin_Projection_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var shortestWord = words.Execute<int>("Min(w => w.Length)");

            var sb = new StringBuilder();

            sb.AppendLine("The shortest word is {0} characters long.", shortestWord);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region uiMin_Grouped

        private void uiMin_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice)});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMin_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Min_Elements

        private void uiMin_Elements_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice))});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories, 1);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiMin_Elements_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categories = products.Execute("GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice)) })");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, categories, 1);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
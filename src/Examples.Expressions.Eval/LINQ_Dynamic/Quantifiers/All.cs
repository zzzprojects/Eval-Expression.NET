using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Quantifiers
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        #region All_Simple

        private void uiAll_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {1, 11, 3, 19, 41, 65, 19};

            var onlyOdd = numbers.All(n => n % 2 == 1);

            var sb = new StringBuilder();

            sb.AppendLine("The list contains only odd numbers: {0}", onlyOdd);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAll_Simple_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {1, 11, 3, 19, 41, 65, 19};

            var onlyOdd = numbers.All(n => "n % 2 == 1");

            var sb = new StringBuilder();

            sb.AppendLine("The list contains only odd numbers: {0}", onlyOdd);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiAll_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {1, 11, 3, 19, 41, 65, 19};

            var onlyOdd = numbers.Execute<bool>("All(n => n % 2 == 1)");

            var sb = new StringBuilder();

            sb.AppendLine("The list contains only odd numbers: {0}", onlyOdd);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region All_Grouped

        private void uiAll_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productGroups = products.GroupBy(p => p.Category)
                .Where(g => g.All(p => p.UnitsInStock > 0))
                .Select(g => new {Category = g.Key, Products = g});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, productGroups, 1);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAll_Grouped_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productGroups = products.GroupBy(p => p.Category)
                .Where(g => g.All(p => "p.UnitsInStock > 0"))
                .Select(g => new {Category = g.Key, Products = g});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, productGroups, 1);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiAll_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productGroups = products.GroupBy(p => p.Category)
                .Where(g => g.Execute<bool>("All(p => p.UnitsInStock > 0)"))
                .Select(g => new { Category = g.Key, Products = g });

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, productGroups, 1);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
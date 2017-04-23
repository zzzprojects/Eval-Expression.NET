using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Quantifiers
{
    public partial class Any : Form
    {
        public Any()
        {
            InitializeComponent();
        }

        #region Any_Simple

        private void uiAny_Simple_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"believe", "relief", "receipt", "field"};

            var iAfterE = words.Any(w => w.Contains("ei"));

            var sb = new StringBuilder();

            sb.AppendLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAny_Simple_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = {"believe", "relief", "receipt", "field"};

            var iAfterE = words.Any(w => "w.Contains('ei')");

            var sb = new StringBuilder();

            sb.AppendLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiAny_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"believe", "relief", "receipt", "field"};

            var iAfterE = words.Execute<bool>("Any(w => w.Contains('ei'))");

            var sb = new StringBuilder();

            sb.AppendLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Any_Grouped

        private void uiAny_Grouped_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productGroups = products.GroupBy(p => p.Category)
                .Where(g => g.Any(p => p.UnitsInStock == 0))
                .Select(g => new {Category = g.Key, Products = g});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, productGroups, 1);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiAny_Grouped_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productGroups = products.GroupBy(p => p.Category)
                .Where(g => g.Any(p => "p.UnitsInStock == 0"))
                .Select(g => new {Category = g.Key, Products = g});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, productGroups, 1);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiAny_Grouped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productGroups = products.GroupBy(p => p.Category)
                 .Where(g => g.Execute<bool>("Any(p => p.UnitsInStock == 0)"))
                 .Select(g => new { Category = g.Key, Products = g });

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, productGroups, 1);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
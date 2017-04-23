using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Join_Operators
{
    public partial class CrossJoinwithGroupJoin : Form
    {
        public CrossJoinwithGroupJoin()
        {
            InitializeComponent();
        }

        #region CrossJoinwithGroupJoin

        private void uiCrossJoinwithGroupJoin_LINQ_Click(object sender, EventArgs e)
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            var products = My.GetProductList();

            var q = categories.Join(products, c => c, p => p.Category, (c, p) => new {Category = c, p.ProductName});

            var sb = new StringBuilder();

            foreach (var v in q)
            {
                sb.AppendLine(v.ProductName + ": " + v.Category);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiCrossJoinwithGroupJoin_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            var products = My.GetProductList();

            dynamic q = categories.Execute("Join(products, c => c, p => p.Category, (c, p) => new { Category = c, p.ProductName })", new {products});

            var sb = new StringBuilder();

            foreach (var v in q)
            {
                sb.AppendLine(v.ProductName + ": " + v.Category);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
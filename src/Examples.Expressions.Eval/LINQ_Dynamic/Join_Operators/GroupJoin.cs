using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Join_Operators
{
    public partial class GroupJoin : Form
    {
        public GroupJoin()
        {
            InitializeComponent();
        }

        #region GroupJoin

        private void uiGroupJoin_LINQ_Click(object sender, EventArgs e)
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

            var q = categories.GroupJoin(products, c => c, p => p.Category, (c, ps) => new { Category = c, Products = ps });

            var sb = new StringBuilder();

            foreach (var v in q)
            {
                sb.AppendLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    sb.AppendLine("   " + p.ProductName);
                }
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupJoin_LINQ_Execute_Click(object sender, EventArgs e)
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
            
            dynamic q = categories.Execute("GroupJoin(products, c => c, p => p.Category, (c, ps) => new { Category = c, Products = ps })", new { products });            

            var sb = new StringBuilder();

            foreach (var v in q)
            {
                sb.AppendLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    sb.AppendLine("   " + p.ProductName);
                }
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
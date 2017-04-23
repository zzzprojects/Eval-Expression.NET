using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Join_Operators
{
    public partial class LeftOuterJoin : Form
    {
        public LeftOuterJoin()
        {
            InitializeComponent();
        }

        #region LeftOuterJoin

        private void uiLeftOuterJoin_LINQ_Click(object sender, EventArgs e)
        {
            //string[] categories =
            //{
            //    "Beverages",
            //    "Condiments",
            //    "Vegetables",
            //    "Dairy Products",
            //    "Seafood"
            //};

            //var products = My.GetProductList();


            //var q = categories.Join(products, c => c, p => p.Category, (c, ps) => ps )
            //    from c in categories join p in products on c equals p.Category into ps from p in ps.DefaultIfEmpty() select new { Category = c, ProductName = p == null ? "(No products)" : p.ProductName };

            //var sb = new StringBuilder();

            //foreach (var v in q)
            //{
            //    sb.AppendLine(v.ProductName + ": " + v.Category);
            //}

            //My.ShowResult(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiLeftOuterJoin_LINQ_Execute_Click(object sender, EventArgs e)
        {
            //string[] categories =
            //{
            //    "Beverages",
            //    "Condiments",
            //    "Vegetables",
            //    "Dairy Products",
            //    "Seafood"
            //};

            //var products = My.GetProductList();


            //var q = from c in categories join p in products on c equals p.Category into ps from p in ps.DefaultIfEmpty() select new {Category = c, ProductName = p == null ? "(No products)" : p.ProductName};

            //var sb = new StringBuilder();

            //foreach (var v in q)
            //{
            //    sb.AppendLine(v.ProductName + ": " + v.Category);
            //}

            //My.ShowResult(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
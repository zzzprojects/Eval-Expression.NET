using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Restriction_Operators
{
    public partial class Where : Form
    {
        public Where()
        {
            InitializeComponent();
        }

        #region Where_Simple_1

        private void uiWhere_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var lowNums = numbers.Where(n => n < 5);

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                sb.AppendLine(x.ToString());
            }

            My.ShowResult(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var lowNums = numbers.Where(n => "n < 5");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                sb.AppendLine(x.ToString());
            }

            My.ShowResult(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Simple_1_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var lowNums = numbers.Execute<IEnumerable<int>>("Where(n => n < 5)");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                sb.AppendLine(x.ToString());
            }

            My.ShowResult(My.LinqResultType.Execute, uiResult, sb);
        }

        #endregion

        #region Where_Simple_2

        private void uiWhere_Simple_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var soldOutProducts = products.Where(prod => prod.UnitsInStock == 0);

            var sb = new StringBuilder();

            sb.AppendLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                sb.AppendLine("{0} is sold out!", product.ProductName);
            }

            My.ShowResult(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var soldOutProducts = products.Where(prod => "prod.UnitsInStock == 0");

            var sb = new StringBuilder();

            sb.AppendLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                sb.AppendLine("{0} is sold out!", product.ProductName);
            }

            My.ShowResult(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Simple_2_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var soldOutProducts = products.Execute<IEnumerable<My.Product>>("Where(prod => prod.UnitsInStock == 0)");

            var sb = new StringBuilder();

            sb.AppendLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                sb.AppendLine("{0} is sold out!", product.ProductName);
            }

            My.ShowResult(My.LinqResultType.Execute, uiResult, sb);
        }

        #endregion
    }
}
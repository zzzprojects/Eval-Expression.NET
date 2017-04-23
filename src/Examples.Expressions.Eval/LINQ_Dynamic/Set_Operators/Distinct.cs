using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Set_Operators
{
    public partial class Distinct : Form
    {
        public Distinct()
        {
            InitializeComponent();
        }

        #region Distinct_1

        private void uiDistinct_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] factorsOf300 = {2, 2, 3, 5, 5};

            var uniqueFactors = factorsOf300.Distinct();

            var sb = new StringBuilder();

            sb.AppendLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                sb.AppendLine(f.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiDistinct_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] factorsOf300 = {2, 2, 3, 5, 5};

            var uniqueFactors = factorsOf300.Execute<IEnumerable<int>>("Distinct()");

            var sb = new StringBuilder();

            sb.AppendLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                sb.AppendLine(f.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Distinct_2

        private void uiDistinct_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categoryNames = products.Select(x => x.Category).Distinct();

            var sb = new StringBuilder();

            sb.AppendLine("Category names:");
            foreach (var n in categoryNames)
            {
                sb.AppendLine(n);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiDistinct_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var categoryNames = products.Execute<IEnumerable<string>>("Select(x => x.Category).Distinct()");

            var sb = new StringBuilder();

            sb.AppendLine("Category names:");
            foreach (var n in categoryNames)
            {
                sb.AppendLine(n);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
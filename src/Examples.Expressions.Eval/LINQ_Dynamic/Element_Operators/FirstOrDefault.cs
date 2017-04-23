using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Element_Operators
{
    public partial class FirstOrDefault : Form
    {
        public FirstOrDefault()
        {
            InitializeComponent();
        }

        #region FirstOrDefault_Simple

        private void uiFirstOrDefault_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {};

            var firstNumOrDefault = numbers.FirstOrDefault();

            var sb = new StringBuilder();

            sb.AppendLine(firstNumOrDefault.ToString());

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiFirstOrDefault_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {};

            var firstNumOrDefault = numbers.Execute<int>("FirstOrDefault()");

            var sb = new StringBuilder();

            sb.AppendLine(firstNumOrDefault.ToString());

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region FirstOrDefault_Condition

        private void uiFirstOrDefault_Condition_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var product789 = products.FirstOrDefault(p => p.ProductID == 789);

            var sb = new StringBuilder();

            sb.AppendLine("Product 789 exists: {0}", product789 != null);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiFirstOrDefault_Condition_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var product789 = products.FirstOrDefault(p => "p.ProductID == 789");

            var sb = new StringBuilder();

            sb.AppendLine("Product 789 exists: {0}", product789 != null);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiFirstOrDefault_Condition_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var product789 = products.Execute<My.Product>("FirstOrDefault(p => p.ProductID == 789)");

            var sb = new StringBuilder();

            sb.AppendLine("Product 789 exists: {0}", product789 != null);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
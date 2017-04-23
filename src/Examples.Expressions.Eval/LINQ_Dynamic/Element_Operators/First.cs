using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Element_Operators
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        #region First_Simple

        private void uiFirst_Simple_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var product12 = products.Where(p => p.ProductID == 12).First();

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, product12);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiFirst_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var product12 = products.Where(p => p.ProductID == 12).Execute("First()");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, product12);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region First_Condition

        private void uiFirst_Condition_LINQ_Click(object sender, EventArgs e)
        {
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var startsWithO = strings.First(s => s[0] == 'o');

            var sb = new StringBuilder();

            sb.AppendLine("A string starting with 'o': {0}", startsWithO);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiFirst_Condition_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var startsWithO = strings.First(s => "s[0] == 'o'");

            var sb = new StringBuilder();

            sb.AppendLine("A string starting with 'o': {0}", startsWithO);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiFirst_Condition_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var startsWithO = strings.Execute<string>("First(s => s[0] == 'o')");

            var sb = new StringBuilder();

            sb.AppendLine("A string starting with 'o': {0}", startsWithO);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Miscellaneous_Operators
{
    public partial class Concat : Form
    {
        public Concat()
        {
            InitializeComponent();
        }

        #region Concat_1

        private void uiConcat_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var allNumbers = numbersA.Concat(numbersB);

            var sb = new StringBuilder();

            sb.AppendLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiConcat_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var allNumbers = numbersA.Execute<IEnumerable<int>>("Concat(numbersB)", new {numbersB});

            var sb = new StringBuilder();

            sb.AppendLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Concat_2

        private void uiConcat_2_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();
            var products = My.GetProductList();

            var customerNames = from c in customers select c.CompanyName;
            var productNames = from p in products select p.ProductName;

            var allNames = customerNames.Concat(productNames);

            var sb = new StringBuilder();

            sb.AppendLine("Customer and product names:");
            foreach (var n in allNames)
            {
                sb.AppendLine(n);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiConcat_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();
            var products = My.GetProductList();

            var customerNames = from c in customers select c.CompanyName;
            var productNames = from p in products select p.ProductName;

            var allNames = customerNames.Execute<IEnumerable<string>>("Concat(productNames)", new {productNames});

            var sb = new StringBuilder();

            sb.AppendLine("Customer and product names:");
            foreach (var n in allNames)
            {
                sb.AppendLine(n);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
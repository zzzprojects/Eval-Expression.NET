using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Set_Operators
{
    public partial class Except : Form
    {
        public Except()
        {
            InitializeComponent();
        }

        #region Except_1

        private void uiExcept_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var aOnlyNumbers = numbersA.Except(numbersB);

            var sb = new StringBuilder();

            sb.AppendLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiExcept_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var aOnlyNumbers = numbersA.Execute<IEnumerable<int>>("Except(numbersB)", new {numbersB});

            var sb = new StringBuilder();

            sb.AppendLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Except_2

        private void uiExcept_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var customers = My.GetCustomerList();

            var productFirstChars = from p in products select p.ProductName[0];
            var customerFirstChars = from c in customers select c.CompanyName[0];

            var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

            var sb = new StringBuilder();

            sb.AppendLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiExcept_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var customers = My.GetCustomerList();

            var productFirstChars = from p in products select p.ProductName[0];
            var customerFirstChars = from c in customers select c.CompanyName[0];

            var productOnlyFirstChars = productFirstChars.Execute<IEnumerable<char>>("Except(customerFirstChars)", new {customerFirstChars});

            var sb = new StringBuilder();

            sb.AppendLine("First letters from Product names, but not from Customer names:");
            foreach (var ch in productOnlyFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
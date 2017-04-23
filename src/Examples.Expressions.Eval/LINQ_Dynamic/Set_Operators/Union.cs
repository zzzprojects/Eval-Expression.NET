using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Set_Operators
{
    public partial class Union : Form
    {
        public Union()
        {
            InitializeComponent();
        }

        #region Union_1

        private void uiUnion_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var uniqueNumbers = numbersA.Union(numbersB);

            var sb = new StringBuilder();

            sb.AppendLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiUnion_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var uniqueNumbers = numbersA.Execute<IEnumerable<int>>("Union(numbersB)", new {numbersB});

            var sb = new StringBuilder();

            sb.AppendLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Union_2

        private void uiUnion_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var customers = My.GetCustomerList();

            var productFirstChars = from p in products select p.ProductName[0];
            var customerFirstChars = from c in customers select c.CompanyName[0];

            var uniqueFirstChars = productFirstChars.Union(customerFirstChars);

            var sb = new StringBuilder();

            sb.AppendLine("Unique first letters from Product names and Customer names:");
            foreach (var ch in uniqueFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiUnion_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var customers = My.GetCustomerList();

            var productFirstChars = from p in products select p.ProductName[0];
            var customerFirstChars = from c in customers select c.CompanyName[0];

            var uniqueFirstChars = productFirstChars.Execute<IEnumerable<char>>("Union(customerFirstChars)", new {customerFirstChars});

            var sb = new StringBuilder();

            sb.AppendLine("Unique first letters from Product names and Customer names:");
            foreach (var ch in uniqueFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
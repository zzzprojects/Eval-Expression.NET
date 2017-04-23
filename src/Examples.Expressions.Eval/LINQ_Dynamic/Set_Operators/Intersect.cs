using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Set_Operators
{
    public partial class Intersect : Form
    {
        public Intersect()
        {
            InitializeComponent();
        }

        #region Intersect_1

        private void uiIntersect_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var commonNumbers = numbersA.Intersect(numbersB);

            var sb = new StringBuilder();

            sb.AppendLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiIntersect_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var commonNumbers = numbersA.Execute<IEnumerable<int>>("Intersect(numbersB)", new {numbersB});

            var sb = new StringBuilder();

            sb.AppendLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Intersect_2

        private void uiIntersect_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var customers = My.GetCustomerList();

            var productFirstChars = from p in products select p.ProductName[0];
            var customerFirstChars = from c in customers select c.CompanyName[0];

            var commonFirstChars = productFirstChars.Intersect(customerFirstChars);

            var sb = new StringBuilder();

            sb.AppendLine("Common first letters from Product names and Customer names:");
            foreach (var ch in commonFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiIntersect_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var customers = My.GetCustomerList();

            var productFirstChars = from p in products select p.ProductName[0];
            var customerFirstChars = from c in customers select c.CompanyName[0];

            var commonFirstChars = productFirstChars.Execute<IEnumerable<char>>("Intersect(customerFirstChars)", new {customerFirstChars});

            var sb = new StringBuilder();

            sb.AppendLine("Common first letters from Product names and Customer names:");
            foreach (var ch in commonFirstChars)
            {
                sb.AppendLine(ch.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
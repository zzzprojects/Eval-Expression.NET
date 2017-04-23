using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Projection_Operators
{
    public partial class SelectMany : Form
    {
        public SelectMany()
        {
            InitializeComponent();
        }

        #region SelectMany_Compound_From_1

        private void uiSelectMany_CF_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new {a, b}).Where(arg => arg.a < arg.b);
                
            var sb = new StringBuilder();

            sb.AppendLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                sb.AppendLine("{0} is less than {1}", pair.a, pair.b);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelectMany_CF_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA.SelectMany(a => "numbersB", (a, b) => new {a, b}, new {numbersB}).Where(arg => arg.a < arg.b);

            //var sb = new StringBuilder();

            //sb.AppendLine("Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    sb.AppendLine("{0} is less than {1}", pair.a, pair.b);
            //}

            //My.ShowResult(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelectMany_CF_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(arg => arg.a < arg.b);

            var sb = new StringBuilder();

            sb.AppendLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                sb.AppendLine("{0} is less than {1}", pair.a, pair.b);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region SelectMany_Compound_From_1

        private void uiSelectMany_CF_2_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.Total < 500.00M select new {c.CustomerID, o.OrderID, o.Total};

            var sb = new StringBuilder();
            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelectMany_CF_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.Total < 500.00M select new {c.CustomerID, o.OrderID, o.Total};

            var sb = new StringBuilder();
            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelectMany_CF_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.Total < 500.00M select new {c.CustomerID, o.OrderID, o.Total};

            var sb = new StringBuilder();
            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region SelectMany_Compound_From_3

        private void uiSelectMany_CF_3_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new {c.CustomerID, o.OrderID, o.OrderDate};

            var sb = new StringBuilder();

            ///ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelectMany_CF_3_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new {c.CustomerID, o.OrderID, o.OrderDate};

            var sb = new StringBuilder();

            //ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelectMany_CF_3_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new {c.CustomerID, o.OrderID, o.OrderDate};

            var sb = new StringBuilder();

            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region SelectMany_From_Assignment

        private void uiSelectMany_From_Assignment_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            ///ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelectMany_From_Assignment_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            //ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelectMany_From_Assignment_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region SelectMany_Multiple_From

        private void uiSelectMany_Multiple_From_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            ///ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelectMany_Multiple_From_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            //ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelectMany_Multiple_From_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region SelectMany_Indexed

        private void uiSelectMany_Indexed_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            ///ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelectMany_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            //ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelectMany_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1998, 1, 1) select new { c.CustomerID, o.OrderID, o.OrderDate };

            var sb = new StringBuilder();

            // ObjectDumper.Write(orders);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
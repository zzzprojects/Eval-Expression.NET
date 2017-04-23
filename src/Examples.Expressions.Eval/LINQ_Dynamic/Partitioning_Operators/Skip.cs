using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Partitioning_Operators
{
    public partial class Skip : Form
    {
        public Skip()
        {
            InitializeComponent();
        }

        #region Skip_Simple

        private void uiSkip_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var allButFirst4Numbers = numbers.Skip(4);

            var sb = new StringBuilder();

            sb.AppendLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSkip_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var allButFirst4Numbers = numbers.Execute<IEnumerable<int>>("Skip(4)");

            var sb = new StringBuilder();

            sb.AppendLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Skip_Nested

        private void uiSkip_Nested_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var waOrders =
                from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new {c.CustomerID, o.OrderID, o.OrderDate};

            var allButFirst2Orders = waOrders.Skip(2);

            var sb = new StringBuilder();

            sb.AppendLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
            {
                My.ObjectDumper.Write(sb, order);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSkip_Nested_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var waOrders =
                from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new { c.CustomerID, o.OrderID, o.OrderDate };

            dynamic allButFirst2Orders = waOrders.Execute("Skip(2)");

            var sb = new StringBuilder();

            sb.AppendLine("All but first 2 orders in WA:");
            foreach (var order in allButFirst2Orders)
            {
                My.ObjectDumper.Write(sb, order);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Partitioning_Operators
{
    public partial class Take : Form
    {
        public Take()
        {
            InitializeComponent();
        }

        private void uiTake_Simple_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var first3Numbers = numbers.Take(3);

            var sb = new StringBuilder();
            sb.AppendLine("First 3 numbers:");

            foreach (var n in first3Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiTake_Simple_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var first3Numbers = numbers.Execute<IEnumerable<int>>("Take(3)");

            var sb = new StringBuilder();
            sb.AppendLine("First 3 numbers:");

            foreach (var n in first3Numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiTake_Nested_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();


            var first3WAOrders = (
                    from c in customers
                    from o in c.Orders
                    where c.Region == "WA"
                    select new {c.CustomerID, o.OrderID, o.OrderDate})
                .Take(3);


            Console.WriteLine("First 3 orders in WA:");

            foreach (var order in first3WAOrders)
            {
                //  ObjectDumper.Write(order);
            }
        }

        private void uiTake_Nested_LINQ_Execute_Click(object sender, EventArgs e)
        {
        }
    }
}
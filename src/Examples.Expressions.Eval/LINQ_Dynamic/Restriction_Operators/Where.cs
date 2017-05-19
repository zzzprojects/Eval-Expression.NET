using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Restriction_Operators
{
    public partial class Where : Form
    {
        public Where()
        {
            InitializeComponent();
        }

        #region Where_Simple_1

        private void uiWhere_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = numbers.Where(n => n < 5);

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                sb.AppendLine(x.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = numbers.Where(n => "n < 5");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                sb.AppendLine(x.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = numbers.Execute<IEnumerable<int>>("Where(n => n < 5)");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                sb.AppendLine(x.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Where_Simple_2

        private void uiWhere_Simple_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var soldOutProducts = products.Where(prod => prod.UnitsInStock == 0);

            var sb = new StringBuilder();

            sb.AppendLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                sb.AppendLine("{0} is sold out!", product.ProductName);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var soldOutProducts = products.Where(prod => "prod.UnitsInStock == 0");

            var sb = new StringBuilder();

            sb.AppendLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                sb.AppendLine("{0} is sold out!", product.ProductName);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var soldOutProducts = products.Execute<IEnumerable<My.Product>>("Where(prod => prod.UnitsInStock == 0)");

            var sb = new StringBuilder();

            sb.AppendLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                sb.AppendLine("{0} is sold out!", product.ProductName);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Where_Simple_3

        private void uiWhere_Simple_3_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var expensiveInStockProducts = from prod in products where (prod.UnitsInStock > 0) && (prod.UnitPrice > 3.00M) select prod;

            var sb = new StringBuilder();

            sb.AppendLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Simple_3_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var expensiveInStockProducts = products.Where(prod => "prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M");

            var sb = new StringBuilder();

            sb.AppendLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Simple_3_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var expensiveInStockProducts = products.Execute<IEnumerable<My.Product>>("Where(prod => prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M)");

            var sb = new StringBuilder();

            sb.AppendLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Where_DrillDown

        private void uiWhere_DrillDown_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var waCustomers = from cust in customers where cust.Region == "WA" select cust;

            var sb = new StringBuilder();

            sb.AppendLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);

                foreach (var order in customer.Orders)
                {
                    sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_DrillDown_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var waCustomers = customers.Where(cust => "cust.Region == 'WA'");

            var sb = new StringBuilder();

            sb.AppendLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);

                foreach (var order in customer.Orders)
                {
                    sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_DrillDown_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var waCustomers = customers.Execute<IEnumerable<My.Customer>>("Where(cust => cust.Region == 'WA')");

            var sb = new StringBuilder();

            sb.AppendLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                foreach (var order in customer.Orders)
                {
                    sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Where_Indexed

        private void uiWhere_Indexed_LINQ_Click(object sender, EventArgs e)
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            var sb = new StringBuilder();

            sb.AppendLine("Short digits:");
            foreach (var d in shortDigits)
            {
                sb.AppendLine("The word {0} is shorter than its value.", d);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            var sb = new StringBuilder();

            sb.AppendLine("Short digits:");
            foreach (var d in shortDigits)
            {
                sb.AppendLine("The word {0} is shorter than its value.", d);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            var sb = new StringBuilder();

            sb.AppendLine("Short digits:");
            foreach (var d in shortDigits)
            {
                sb.AppendLine("The word {0} is shorter than its value.", d);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        private void uiWhere_Simple_3_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var expensiveInStockProducts = from p in products where p.UnitsInStock > 0 && p.UnitPrice > 3.00M select p;
            var sb = new StringBuilder();
            sb.AppendLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }

            My.ShowResult(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Simple_3_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var expensiveInStockProducts = products.Where(prod => "prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M");
            var sb = new StringBuilder();
            sb.AppendLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }
            My.ShowResult(My.LinqResultType.LinqDynamic, uiResult, sb);
        }
        private void uiWhere_Simple_3_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();
            var expensiveInStockProducts = products.Execute<IEnumerable<My.Product>>("Where(prod => prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M)");
            var sb = new StringBuilder();
            sb.AppendLine("In-stock products that cost more than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                sb.AppendLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }
            My.ShowResult(My.LinqResultType.Execute, uiResult, sb);
        }

        private void uiWhere_DrillDown_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var waCustomers = from c in customers where c.Region == "WA" select c;
            var sb = new StringBuilder();
            sb.AppendLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                foreach (var order in customer.Orders)
                {
                    sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }
            My.ShowResult(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_DrillDown_Dynamic_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();            
            var waCustomers = customers.Where(cust => "cust.Region == 'WA'");
            var sb = new StringBuilder();
            sb.AppendLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                foreach (var order in customer.Orders)
                {
                    sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }
            My.ShowResult(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_DrillDown_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();            
            var waCustomers = customers.Execute<IEnumerable<My.Customer>>("Where(cust => cust.Region == 'WA')");
            var sb = new StringBuilder();
            sb.AppendLine("Customers from Washington and their orders:");
            foreach (var customer in waCustomers)
            {
                sb.AppendLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
                foreach (var order in customer.Orders)
                {
                    sb.AppendLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
                }
            }
            My.ShowResult(My.LinqResultType.Execute, uiResult, sb);
        }

        private void uiWhere_Indexed_LINQ_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            var sb = new StringBuilder();
            sb.AppendLine("Short digits:");
            foreach (var d in shortDigits)
            {
                sb.AppendLine("The word {0} is shorter than its value.", d);
            }
            My.ShowResult(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiWhere_Indexed_Dynamic_LINQ_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where(digit => "digit.Length < index");
            var sb = new StringBuilder();
            sb.AppendLine("Short digits:");
            foreach (var d in shortDigits)
            {
                sb.AppendLine("The word {0} is shorter than its value.", d);
            }
            My.ShowResult(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiWhere_Indexed_Execute_LINQ_Click(object sender, EventArgs e)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Execute<IEnumerable<int>>("Where(digit => digit.Length < index)");            
            var sb = new StringBuilder();
            sb.AppendLine("Short digits:");
            foreach (var d in shortDigits)
            {
                sb.AppendLine("The word {0} is shorter than its value.", d);
            }
            My.ShowResult(My.LinqResultType.Execute, uiResult, sb);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Query_Execution
{
    public partial class QueryReuse : Form
    {
        public QueryReuse()
        {
            InitializeComponent();
        }

        #region QueryReuse

        private void uiQueryReuse_LINQ_Click(object sender, EventArgs e)
        {
            // Deferred execution lets us define a query once 
            // and then reuse it later after data changes. 

            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var lowNumbers = numbers.Where(n => n <= 3);

            var sb = new StringBuilder();

            sb.AppendLine("First run numbers <= 3:");

            foreach (var n in lowNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            for (var i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object, 
            // lowNumbers, will be iterating over the new state 
            // of numbers[], producing different results: 

            sb.AppendLine("Second run numbers <= 3:");

            foreach (var n in lowNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiQueryReuse_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            // Deferred execution lets us define a query once 
            // and then reuse it later after data changes. 

            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var lowNumbers = numbers.Where(n => "n <= 3");

            var sb = new StringBuilder();

            sb.AppendLine("First run numbers <= 3:");

            foreach (var n in lowNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            for (var i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object, 
            // lowNumbers, will be iterating over the new state 
            // of numbers[], producing different results: 

            sb.AppendLine("Second run numbers <= 3:");

            foreach (var n in lowNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiQueryReuse_LINQ_Execute_Click(object sender, EventArgs e)
        {
            // Deferred execution lets us define a query once 
            // and then reuse it later after data changes. 

            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var lowNumbers = numbers.Execute<IEnumerable<int>>("Where(n => n <= 3)");

            var sb = new StringBuilder();

            sb.AppendLine("First run numbers <= 3:");

            foreach (var n in lowNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            for (var i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object, 
            // lowNumbers, will be iterating over the new state 
            // of numbers[], producing different results: 

            sb.AppendLine("Second run numbers <= 3:");

            foreach (var n in lowNumbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
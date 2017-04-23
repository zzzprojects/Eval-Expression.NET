using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Query_Execution
{
    public partial class ImmediateExecution : Form
    {
        public ImmediateExecution()
        {
            InitializeComponent();
        }

        #region ImmediateExecution

        private void uiImmediateExecution_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var local = new LocalVariable();
            var q = numbers.Select(n => ++local.i).ToList();

            // The local variable i has already been fully 
            // incremented before we iterate the results: 
            var sb = new StringBuilder();
            foreach (var v in q)
            {
                sb.AppendLine("v = {0}, i = {1}", v, local.i);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiImmediateExecution_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var local = new LocalVariable();
            var q = numbers.SelectDynamic(n => "++local.i", new {local}).ToList();

            // The local variable i has already been fully 
            // incremented before we iterate the results: 
            var sb = new StringBuilder();
            foreach (var v in q)
            {
                sb.AppendLine("v = {0}, i = {1}", v, local.i);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiImmediateExecution_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var local = new LocalVariable();
            var q = numbers.Execute<IEnumerable<int>>("Select(n => ++local.i)", new {local}).ToList();

            // The local variable i has already been fully 
            // incremented before we iterate the results: 
            var sb = new StringBuilder();
            foreach (var v in q)
            {
                sb.AppendLine("v = {0}, i = {1}", v, local.i);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        public class LocalVariable
        {
            public int i { get; set; }
        }
    }
}
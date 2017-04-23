using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Generation_Operators
{
    public partial class Repeat : Form
    {
        public Repeat()
        {
            InitializeComponent();
        }

        private void uiRepeat_LINQ_Click(object sender, EventArgs e)
        {
            var numbers = Enumerable.Repeat(7, 10);

            var sb = new StringBuilder();

            foreach (var n in numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiRepeat_LINQ_Execute_Click(object sender, EventArgs e)
        {
            EvalManager.DefaultContext.RegisterType(typeof(Enumerable));
            var numbers = Z.Expressions.Eval.Execute<IEnumerable<int>>("Enumerable.Repeat(7, 10)");

            var sb = new StringBuilder();

            foreach (var n in numbers)
            {
                sb.AppendLine(n.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }
    }
}
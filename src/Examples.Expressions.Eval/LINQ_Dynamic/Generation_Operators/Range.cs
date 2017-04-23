using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Generation_Operators
{
    public partial class Range : Form
    {
        public Range()
        {
            InitializeComponent();
        }

        #region Range

        private void uiRange_LINQ_Click(object sender, EventArgs e)
        {
            var numbers = Enumerable.Range(100, 50).Select(n => new {Number = n, OddEven = n % 2 == 1 ? "odd" : "even"});

            var sb = new StringBuilder();

            foreach (var n in numbers)
            {
                sb.AppendLine("The number {0} is {1}.", n.Number, n.OddEven);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiRange_LINQ_Execute_Click(object sender, EventArgs e)
        {
            EvalManager.DefaultContext.RegisterType(typeof(Enumerable));
            dynamic numbers = Z.Expressions.Eval.Execute("Enumerable.Range(100, 50).Select(n => new { Number = n, OddEven = n % 2 == 1 ? 'odd' : 'even' })");

            var sb = new StringBuilder();

            foreach (var n in numbers)
            {
                sb.AppendLine("The number {0} is {1}.", (object) n.Number, (object) n.OddEven);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
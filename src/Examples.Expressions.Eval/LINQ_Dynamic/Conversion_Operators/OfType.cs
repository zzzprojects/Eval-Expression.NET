using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Conversion_Operators
{
    public partial class OfType : Form
    {
        public OfType()
        {
            InitializeComponent();
        }

        #region OfType

        private void uiOfType_LINQ_Click(object sender, EventArgs e)
        {
            object[] numbers = {null, 1.0, "two", 3, "four", 5, "six", 7.0};

            var doubles = numbers.OfType<double>();

            var sb = new StringBuilder();

            sb.AppendLine("Numbers stored as doubles:");
            foreach (var d in doubles)
            {
                sb.AppendLine(d.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiOfType_LINQ_Execute_Click(object sender, EventArgs e)
        {
            object[] numbers = {null, 1.0, "two", 3, "four", 5, "six", 7.0};

            var doubles = numbers.Execute<IEnumerable<double>>("OfType<double>()");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers stored as doubles:");
            foreach (var d in doubles)
            {
                sb.AppendLine(d.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
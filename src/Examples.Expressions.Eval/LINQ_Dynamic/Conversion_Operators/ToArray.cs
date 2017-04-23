using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Conversion_Operators
{
    public partial class ToArray : Form
    {
        public ToArray()
        {
            InitializeComponent();
        }

        #region ToArray

        private void uiToArray_LINQ_Click(object sender, EventArgs e)
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

            var sortedDoubles = from d in doubles orderby d descending select d;

            var doublesArray = sortedDoubles.ToArray();

            var sb = new StringBuilder();

            sb.AppendLine("Every other double from highest to lowest:");
            for (var d = 0; d < doublesArray.Length; d += 2)
            {
                sb.AppendLine(doublesArray[d].ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiToArray_LINQ_Execute_Click(object sender, EventArgs e)
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

            var sortedDoubles = from d in doubles orderby d descending select d;

            var doublesArray = sortedDoubles.Execute<double[]>("ToArray()");

            var sb = new StringBuilder();

            sb.AppendLine("Every other double from highest to lowest:");
            for (var d = 0; d < doublesArray.Length; d += 2)
            {
                sb.AppendLine(doublesArray[d].ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
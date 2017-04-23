using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Miscellaneous_Operators
{
    public partial class EqualAll : Form
    {
        public EqualAll()
        {
            InitializeComponent();
        }

        #region EqualAll_1

        private void uiEqualAll_1_LINQ_Click(object sender, EventArgs e)
        {
            var wordsA = new[] {"cherry", "apple", "blueberry"};
            var wordsB = new[] {"cherry", "apple", "blueberry"};

            var match = wordsA.SequenceEqual(wordsB);

            var sb = new StringBuilder();

            sb.AppendLine("The sequences match: {0}", match);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiEqualAll_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var wordsA = new[] {"cherry", "apple", "blueberry"};
            var wordsB = new[] {"cherry", "apple", "blueberry"};

            var match = wordsA.Execute<bool>("SequenceEqual(wordsB)", new {wordsB});

            var sb = new StringBuilder();

            sb.AppendLine("The sequences match: {0}", match);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region EqualAll_2

        private void uiEqualAll_2_LINQ_Click(object sender, EventArgs e)
        {
            var wordsA = new[] {"cherry", "apple", "blueberry"};
            var wordsB = new[] {"apple", "blueberry", "cherry"};

            var match = wordsA.SequenceEqual(wordsB);

            var sb = new StringBuilder();

            sb.AppendLine("The sequences match: {0}", match);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiEqualAll_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var wordsA = new[] {"cherry", "apple", "blueberry"};
            var wordsB = new[] {"apple", "blueberry", "cherry"};

            var match = wordsA.Execute<bool>("SequenceEqual(wordsB)", new {wordsB});

            var sb = new StringBuilder();

            sb.AppendLine("The sequences match: {0}", match);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
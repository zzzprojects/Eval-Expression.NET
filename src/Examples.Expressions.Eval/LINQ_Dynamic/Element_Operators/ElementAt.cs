using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Element_Operators
{
    public partial class ElementAt : Form
    {
        public ElementAt()
        {
            InitializeComponent();
        }

        #region  ElementAt

        private void uiElementAt_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var fourthLowNum = numbers.Where(n => n > 5).ElementAt(1); // second number is index 1 because sequences use 0-based indexing 

            var sb = new StringBuilder();

            sb.AppendLine("Second number > 5: {0}", fourthLowNum);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiElementAt_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var fourthLowNum = numbers.Where(n => n > 5).Execute<int>("ElementAt(1)"); // second number is index 1 because sequences use 0-based indexing 

            var sb = new StringBuilder();

            sb.AppendLine("Second number > 5: {0}", fourthLowNum);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
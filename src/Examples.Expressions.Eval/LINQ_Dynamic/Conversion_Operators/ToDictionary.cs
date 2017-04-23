using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Conversion_Operators
{
    public partial class ToDictionary : Form
    {
        public ToDictionary()
        {
            InitializeComponent();
        }

        #region ToDictionary

        private void uiToDictionary_LINQ_Click(object sender, EventArgs e)
        {
            var scoreRecords = new[]
            {
                new {Name = "Alice", Score = 50},
                new {Name = "Bob", Score = 40},
                new {Name = "Cathy", Score = 45}
            };

            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

            var sb = new StringBuilder();

            sb.AppendLine("Bob's score: {0}", scoreRecordsDict["Bob"]);
            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiToDictionary_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var scoreRecords = new[]
            {
                new {Name = "Alice", Score = 50},
                new {Name = "Bob", Score = 40},
                new {Name = "Cathy", Score = 45}
            };

            dynamic scoreRecordsDict = scoreRecords.Execute("ToDictionary(sr => sr.Name)");

            var sb = new StringBuilder();

            sb.AppendLine("Bob's score: {0}", (object)scoreRecordsDict["Bob"]);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
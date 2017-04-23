using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Conversion_Operators
{
    public partial class ToList : Form
    {
        public ToList()
        {
            InitializeComponent();
        }

        #region ToList

        private void uiToList_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var sortedWords = from w in words orderby w select w;

            var wordList = sortedWords.ToList();

            var sb = new StringBuilder();

            sb.AppendLine("The sorted word list:");
            foreach (var w in wordList)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiToList_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var sortedWords = from w in words orderby w select w;

            var wordList = sortedWords.Execute<List<string>>("ToList()");

            var sb = new StringBuilder();

            sb.AppendLine("The sorted word list:");
            foreach (var w in wordList)
            {
                sb.AppendLine(w);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
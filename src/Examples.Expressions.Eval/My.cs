using System;
using System.Text;
using System.Windows.Forms;

namespace Examples.Expressions.Eval
{
    public static class My
    {
        public enum LinqResultType
        {
            Linq,
            LinqDynamic,
            Execute
        }

        public static void ShowResult(LinqResultType resultType, RichTextBox textbox, StringBuilder sb)
        {
            // CLEAR
            textbox.Text = "";

            textbox.Text = (resultType == LinqResultType.Linq ?
                "LINQ Test" :
                resultType == LinqResultType.LinqDynamic ?
                    "LINQ Dynamic Test" :
                    "Execute Test")
                    + Environment.NewLine
                    + sb;
        }
    }
}
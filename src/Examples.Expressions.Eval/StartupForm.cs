using System;
using System.Windows.Forms;

namespace Examples.Expressions.Eval
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        public void ShowExample_Click(object sender, EventArgs e)
        {
            Form form = null;

            switch (((Button)sender).Name)
            {
                // LINQ Dynamic | Restriction Operators
                case "uiWhere":
                    form = new LINQ_Dynamic.Restriction_Operators.Where();
                    break;
            }

            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
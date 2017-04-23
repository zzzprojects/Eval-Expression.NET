using System;
using System.Windows.Forms;
using Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Conversion_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Custom_Sequence_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Element_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Generation_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Grouping_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Join_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Miscellaneous_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Ordering_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Partitioning_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Projection_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Quantifiers;
using Examples.Expressions.Eval.LINQ_Dynamic.Query_Execution;
using Examples.Expressions.Eval.LINQ_Dynamic.Restriction_Operators;
using Examples.Expressions.Eval.LINQ_Dynamic.Set_Operators;

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

            switch (((Button) sender).Name)
            {
                // LINQ Dynamic | Restriction Operators
                case "uiROWhere":
                    form = new Where();
                    break;

                // LINQ Dynamic | Projection Operators
                case "uiPOSelect":
                    form = new Select();
                    break;
                case "uiPOSelectMany":
                    form = new SelectMany();
                    break;

                // LINQ Dynamic | Aggregate Operators
                case "uiAOMin":
                    form = new Min();
                    break;
                case "uiAOMax":
                    form = new Max();
                    break;
                case "uiAOSum":
                    form = new Sum();
                    break;
                case "uiAOCount":
                    form = new Count();
                    break;
                case "uiAOAverage":
                    form = new Average();
                    break;
                case "uiAOAggregate":
                    form = new Aggregate();
                    break;

                // LINQ Dynamic | Query Execution
                case "uiQEDeferredExecution":
                    form = new DeferredExecution();
                    break;
                case "uiQEQueryReuse":
                    form = new QueryReuse();
                    break;
                case "uiQEImmediateExecution":
                    form = new ImmediateExecution();
                    break;


                // LINQ Dynamic |  Join Operators
                case "uiJOCrossJoin":
                    form = new CrossJoin();
                    break;
                case "uiJOGroupJoin":
                    form = new GroupJoin();
                    break;
                case "uiJOCrossWithGroupJoin":
                    form = new CrossJoinwithGroupJoin();
                    break;
                case "uiJOLeftOuterJoin":
                    form = new LeftOuterJoin();
                    break;

                // LINQ Dynamic |    Set Operators
                case "uiSODistinct":
                    form = new Distinct();
                    break;
                case "uiSOExcept":
                    form = new Except();
                    break;
                case "uiSOIntersect":
                    form = new Intersect();
                    break;
                case "uiSOUnion":
                    form = new Union();
                    break;

                // LINQ Dynamic |    Element Operators
                case "uiEOElementAt":
                    form = new ElementAt();
                    break;
                case "uiEOFirst":
                    form = new First();
                    break;
                case "uiEOFirstDefault":
                    form = new FirstOrDefault();
                    break;

                // LINQ Dynamic |    Custom Sequence Operators
                case "uiCSOCombine":
                    form = new Combine();
                    break;

                // LINQ Dynamic |    Quantifiers
                case "uiQuantifiersAll":
                    form = new All();
                    break;
                case "uiQuantifiersAny":
                    form = new Any();
                    break;

                // LINQ Dynamic |    Grouping Operators
                case "uiGOGroupBy":
                    form = new GroupBy();
                    break;

                // LINQ Dynamic |    Miscellaneous Operators
                case "uiMOConcat":
                    form = new Concat();
                    break;
                case "uiMOEqualAll":
                    form = new EqualAll();
                    break;


                // LINQ Dynamic |    Generation Operators
                case "uiGORepeat":
                    form = new Repeat();
                    break;
                case "uiGORange":
                    form = new Range();
                    break;


                // LINQ Dynamic |    Ordering Operators
                case "uiOOOrderBy":
                    form = new OrderBy();
                    break;
                case "uiOOThenBy":
                    form = new ThenBy();
                    break;
                case "uiOOThenByDescending":
                    form = new ThenByDescending();
                    break;
                case "uiOOOrderByDescending":
                    form = new OrderByDescending();
                    break;
                case "uiOOReverse":
                    form = new Reverse();
                    break;

                // LINQ Dynamic |    Conversion Operators
                case "uiCOOfType":
                    form = new OfType();
                    break;
                case "uiCOToArray":
                    form = new ToArray();
                    break;
                case "uiCOToDictionary":
                    form = new ToDictionary();
                    break;
                case "uiCOToList":
                    form = new ToList();
                    break;


                // LINQ Dynamic |    Partitioning Operators
                case "uiPOTake":
                    form = new Take();
                    break;
                case "uiPOTakeWhile":
                    form = new TakeWhile();
                    break;
                case "uiPOSkip":
                    form = new Skip();
                    break;
                case "uiPOSkipWhile":
                    form = new SkipWhile();
                    break;
            }

            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
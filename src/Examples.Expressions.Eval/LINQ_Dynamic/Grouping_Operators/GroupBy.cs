using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Grouping_Operators
{
    public partial class GroupBy : Form
    {
        public GroupBy()
        {
            InitializeComponent();
        }

        #region GroupBy_Simple_1

        private void uiGroupBy_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numberGroups = numbers.GroupBy(n => n % 5).Select(g => new {Remainder = g.Key, Numbers = g});

            var sb = new StringBuilder();

            foreach (var g in numberGroups)
            {
                sb.AppendLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);

                foreach (var n in g.Numbers)
                {
                    sb.AppendLine(n.ToString());
                }
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupBy_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numberGroups = numbers.Execute<IEnumerable<IGrouping<int, int>>>("GroupBy(n => n % 5)").Select(g => new {Remainder = g.Key, Numbers = g});

            var sb = new StringBuilder();

            foreach (var g in numberGroups)
            {
                sb.AppendLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);

                foreach (var n in g.Numbers)
                {
                    sb.AppendLine(n.ToString());
                }
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region GroupBy_Simple_2

        private void uiGroupBy_Simple_2_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese"};

            var wordGroups = words.GroupBy(w => w[0]).Select(g => new {FirstLetter = g.Key, Words = g});

            var sb = new StringBuilder();

            foreach (var g in wordGroups)
            {
                sb.AppendLine("Words that start with the letter '{0}':", g.FirstLetter);

                foreach (var w in g.Words)
                {
                    sb.AppendLine(w);
                }
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupBy_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese"};

            dynamic wordGroups = words.Execute<IEnumerable<IGrouping<char, string>>>("GroupBy(w => w[0])").Select(g => new { FirstLetter = g.Key, Words = g });

            var sb = new StringBuilder();

            foreach (var g in wordGroups)
            {
                sb.AppendLine("Words that start with the letter '{0}':", (object)g.FirstLetter);

                foreach (var w in g.Words)
                {
                    sb.AppendLine(w);
                }
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region GroupBy_Simple_3

        private void uiGroupBy_Simple_3_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var orderGroups = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, Products = g});

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderGroups);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupBy_Simple_3_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var orderGroups = products.Execute<IEnumerable<IGrouping<string, My.Product>>>("GroupBy(p => p.Category)").Select(g => new { Category = g.Key, Products = g });

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderGroups);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region GroupBy_Nested

        private void uiGroupBy_Nested_LINQ_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var customerOrderGroups = customers.Select(c =>
                new
                {
                    c.CompanyName,
                    YearGroups = c.Orders.GroupBy(o => o.OrderDate.Year).Select(yg =>
                        new
                        {
                            Year = yg,
                            MonthGroups = yg.GroupBy(o => o.OrderDate.Month).Select(mg =>
                                new
                                {
                                    Month = mg.Key,
                                    Orders = mg
                                })
                        })
                });

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, customerOrderGroups, 3);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupBy_Nested_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var customers = My.GetCustomerList();

            var customerOrderGroups = customers.Select(c =>
                new
                {
                    c.CompanyName,
                    YearGroups = c.Orders.Execute<IEnumerable<IGrouping<int, My.Order>>>("GroupBy(o => o.OrderDate.Year)").Select(yg =>
                        new
                        {
                            Year = yg,
                            MonthGroups = yg.Execute<IEnumerable<IGrouping<int, My.Order>>>("GroupBy(o => o.OrderDate.Month)").Select(mg =>
                                new
                                {
                                    Month = mg.Key,
                                    Orders = mg
                                })
                        })
                });

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, customerOrderGroups, 3);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region GroupBy_Comparer

        private void uiGroupBy_Comparer_LINQ_Click(object sender, EventArgs e)
        {
            string[] anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "};

            var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderGroups, 1);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupBy_Comparer_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "};

            EvalManager.DefaultContext.RegisterType(typeof(AnagramEqualityComparer));

            var orderGroups = anagrams.Execute("GroupBy(w => w.Trim(), new AnagramEqualityComparer())");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderGroups, 1);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region GroupBy_ComparerMapped

        private void uiGroupBy_ComparerMapped_LINQ_Click(object sender, EventArgs e)
        {
            string[] anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "};

            var orderGroups = anagrams.GroupBy(w => w.Trim(), a => a.ToUpper(), new AnagramEqualityComparer());

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderGroups, 1);

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiGroupBy_ComparerMapped_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "};

            EvalManager.DefaultContext.RegisterType(typeof(AnagramEqualityComparer));

            var orderGroups = anagrams.Execute("GroupBy(w => w.Trim(), a => a.ToUpper(), new AnagramEqualityComparer())");

            var sb = new StringBuilder();

            My.ObjectDumper.Write(sb, orderGroups, 1);

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }

    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return getCanonicalString(x) == getCanonicalString(y);
        }

        public int GetHashCode(string obj)
        {
            return getCanonicalString(obj).GetHashCode();
        }

        private string getCanonicalString(string word)
        {
            var wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            return new string(wordChars);
        }
    }
}
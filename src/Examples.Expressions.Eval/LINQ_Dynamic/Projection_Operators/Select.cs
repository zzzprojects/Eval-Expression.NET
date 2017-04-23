using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace Examples.Expressions.Eval.LINQ_Dynamic.Projection_Operators
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        #region Select_Anonymous_1

        private void uiSelect_Anonymous_1_LINQ_Click(object sender, EventArgs e)
        {
            string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};

            var upperLowerWords = words.Select(word => new {Upper = word.ToUpper(), Lower = word.ToLower()});

            var sb = new StringBuilder();

            foreach (var ul in upperLowerWords)
            {
                sb.AppendLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Anonymous_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};

            dynamic upperLowerWords = words.SelectDynamic(word => "new { Upper = word.ToUpper(), Lower = word.ToLower() }");

            var sb = new StringBuilder();

            foreach (var ul in upperLowerWords)
            {
                sb.AppendLine("Uppercase: {0}, Lowercase: {1}", (object)ul.Upper, (object)ul.Lower);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Anonymous_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};

            dynamic upperLowerWords = words.Execute("Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() })");

            var sb = new StringBuilder();

            foreach (var ul in upperLowerWords)
            {
                sb.AppendLine("Uppercase: {0}, Lowercase: {1}", (object)ul.Upper, (object)ul.Lower);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Select_Anonymous_2

        private void uiSelect_Anonymous_2_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var digitOddEvens = numbers.Select(n => new {Digit = strings[n], Even = n % 2 == 0});

            var sb = new StringBuilder();

            foreach (var d in digitOddEvens)
            {
                sb.AppendLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd");
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Anonymous_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            dynamic digitOddEvens = numbers.SelectDynamic(n => "new { Digit = strings[n], Even = (n % 2 == 0) }", new {strings});

            var sb = new StringBuilder();

            foreach (var d in digitOddEvens)
            {
                sb.AppendLine("The digit {0} is {1}.", (object)d.Digit, d.Even ? "even" : "odd");
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Anonymous_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            dynamic digitOddEvens = numbers.Execute("Select(n => new { Digit = strings[n], Even = (n % 2 == 0) })", new { strings });

            var sb = new StringBuilder();

            foreach (var d in digitOddEvens)
            {
                sb.AppendLine("The digit {0} is {1}.", (object)d.Digit, d.Even ? "even" : "odd");
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }
        #endregion

        #region Select_Anonymouys_3

        private void uiSelect_Anonymous_3_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productInfos = products.Select(p => new {p.ProductName, p.Category, Price = p.UnitPrice});

            var sb = new StringBuilder();

            sb.AppendLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                sb.AppendLine("{0} is in the category {1} and costs {2} per unit.", productInfo.ProductName, productInfo.Category, productInfo.Price);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Anonymous_3_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            dynamic productInfos = products.SelectDynamic(p => "new { p.ProductName, p.Category, Price = p.UnitPrice }");

            var sb = new StringBuilder();

            sb.AppendLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                sb.AppendLine("{0} is in the category {1} and costs {2} per unit.", (object)productInfo.ProductName, (object)productInfo.Category, (object)productInfo.Price);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Anonymous_3_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            dynamic productInfos = products.Execute("Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice })");

            var sb = new StringBuilder();

            sb.AppendLine("Product Info:");
            foreach (var productInfo in productInfos)
            {
                sb.AppendLine("{0} is in the category {1} and costs {2} per unit.", (object)productInfo.ProductName, (object)productInfo.Category, (object)productInfo.Price);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Select_Simple_1

        private void uiSelect_Simple_1_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numsPlusOne = numbers.Select(n => n + 1);

            var sb = new StringBuilder();

            sb.AppendLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                sb.AppendLine(i.ToString());
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Simple_1_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numsPlusOne = numbers.SelectDynamic(n => "n + 1");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                sb.AppendLine(i.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Simple_1_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numsPlusOne = numbers.Execute<IEnumerable<int>>("Select(n => n +1)");

            var sb = new StringBuilder();

            sb.AppendLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                sb.AppendLine(i.ToString());
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Select_Simple_2

        private void uiSelect_Simple_2_LINQ_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productNames = products.Select(p => p.ProductName);

            var sb = new StringBuilder();

            sb.AppendLine("Product Names:");
            foreach (var productName in productNames)
            {
                sb.AppendLine(productName);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Simple_2_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productNames = (IEnumerable<string>) products.SelectDynamic(x => "x.ProductName");

            var sb = new StringBuilder();

            sb.AppendLine("Product Names:");
            foreach (var productName in productNames)
            {
                sb.AppendLine(productName);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Simple_2_LINQ_Execute_Click(object sender, EventArgs e)
        {
            var products = My.GetProductList();

            var productNames = products.Execute<IEnumerable<string>>("Select(p => p.ProductName)");

            var sb = new StringBuilder();

            sb.AppendLine("Product Names:");
            foreach (var productName in productNames)
            {
                sb.AppendLine(productName);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Select_Transformation

        private void uiSelect_Transformation_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var sb = new StringBuilder();
            var textNums = numbers.Select(n => strings[n]);

            sb.AppendLine("Number strings:");
            foreach (var s in textNums)
            {
                sb.AppendLine(s);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Transformation_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var sb = new StringBuilder();
            var textNums = (IEnumerable<string>) numbers.SelectDynamic(n => "strings[n]", new {strings});

            sb.AppendLine("Number strings:");
            foreach (var s in textNums)
            {
                sb.AppendLine(s);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Transformation_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var sb = new StringBuilder();
            var textNums = numbers.Execute<IEnumerable<string>>("Select(n => strings[n])", new {strings});

            sb.AppendLine("Number strings:");
            foreach (var s in textNums)
            {
                sb.AppendLine(s);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Select_Indexed

        private void uiSelect_Indexed_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numsInPlace = numbers.Select((num, index) => new {Num = num, InPlace = num == index});

            var sb = new StringBuilder();

            sb.AppendLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                sb.AppendLine("{0}: {1}", n.Num, n.InPlace);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Indexed_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            dynamic numsInPlace = numbers.SelectDynamic((num, index) => "new { Num = num, InPlace = (num == index) }");

            var sb = new StringBuilder();

            sb.AppendLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                sb.AppendLine("{0}: {1}", (object)n.Num, (object)n.InPlace);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Indexed_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            dynamic numsInPlace = numbers.Execute("Select((num, index) => new { Num = num, InPlace = (num == index) })");

            var sb = new StringBuilder();

            sb.AppendLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                sb.AppendLine("{0}: {1}", (object)n.Num, (object)n.InPlace);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion

        #region Select_Filtered

        private void uiSelect_Filtered_LINQ_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var lowNums = numbers.Where(n => n < 5).Select(n => digits[n]);

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                sb.AppendLine(num);
            }

            My.Result.Show(My.LinqResultType.Linq, uiResult, sb);
        }

        private void uiSelect_Filtered_LINQ_Dynamic_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var lowNums = (IEnumerable<string>) numbers.Where(n => n < 5).SelectDynamic(n => "digits[n]", new {digits});

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                sb.AppendLine(num);
            }

            My.Result.Show(My.LinqResultType.LinqDynamic, uiResult, sb);
        }

        private void uiSelect_Filtered_LINQ_Execute_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            var lowNums = numbers.Where(n => n < 5).Execute<IEnumerable<string>>("Select(n => digits[n])", new { digits });

            var sb = new StringBuilder();

            sb.AppendLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                sb.AppendLine(num);
            }

            My.Result.Show(My.LinqResultType.LinqExecute, uiResult, sb);
        }

        #endregion
    }
}
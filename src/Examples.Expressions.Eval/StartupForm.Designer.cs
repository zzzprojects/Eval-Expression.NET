namespace Examples.Expressions.Eval
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiROWhere = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiPOSelectMany = new System.Windows.Forms.Button();
            this.uiPOSelect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiPOTakeWhile = new System.Windows.Forms.Button();
            this.uiPOSkipWhile = new System.Windows.Forms.Button();
            this.uiPOSkip = new System.Windows.Forms.Button();
            this.uiPOTake = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uiOOThenByDescending = new System.Windows.Forms.Button();
            this.uiOOOrderByDescending = new System.Windows.Forms.Button();
            this.uiOOReverse = new System.Windows.Forms.Button();
            this.uiOOThenBy = new System.Windows.Forms.Button();
            this.uiOOOrderBy = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uiGOGroupBy = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.uiSOExcept = new System.Windows.Forms.Button();
            this.uiSOIntersect = new System.Windows.Forms.Button();
            this.uiSOUnion = new System.Windows.Forms.Button();
            this.uiSODistinct = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.uiCOOfType = new System.Windows.Forms.Button();
            this.uiCOToDictionary = new System.Windows.Forms.Button();
            this.uiCOToList = new System.Windows.Forms.Button();
            this.uiCOToArray = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.uiEOElementAt = new System.Windows.Forms.Button();
            this.uiEOFirstDefault = new System.Windows.Forms.Button();
            this.uiEOFirst = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.uiGORepeat = new System.Windows.Forms.Button();
            this.uiGORange = new System.Windows.Forms.Button();
            this.Quantifiers = new System.Windows.Forms.GroupBox();
            this.uiQuantifiersAll = new System.Windows.Forms.Button();
            this.uiQuantifiersAny = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.uiAOMax = new System.Windows.Forms.Button();
            this.uiAOSum = new System.Windows.Forms.Button();
            this.uiAOAggregate = new System.Windows.Forms.Button();
            this.uiAOAverage = new System.Windows.Forms.Button();
            this.uiAOMin = new System.Windows.Forms.Button();
            this.uiAOCount = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.uiMOEqualAll = new System.Windows.Forms.Button();
            this.uiMOConcat = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.uiCSOCombine = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.uiQEQueryReuse = new System.Windows.Forms.Button();
            this.uiQEImmediateExecution = new System.Windows.Forms.Button();
            this.uiQEDeferredExecution = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.uiJOLeftOuterJoin = new System.Windows.Forms.Button();
            this.uiJOCrossWithGroupJoin = new System.Windows.Forms.Button();
            this.uiJOGroupJoin = new System.Windows.Forms.Button();
            this.uiJOCrossJoin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.Quantifiers.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiROWhere);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restriction Operators";
            // 
            // uiROWhere
            // 
            this.uiROWhere.Location = new System.Drawing.Point(7, 20);
            this.uiROWhere.Name = "uiROWhere";
            this.uiROWhere.Size = new System.Drawing.Size(75, 23);
            this.uiROWhere.TabIndex = 0;
            this.uiROWhere.Text = "Where";
            this.uiROWhere.UseVisualStyleBackColor = true;
            this.uiROWhere.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiPOSelectMany);
            this.groupBox2.Controls.Add(this.uiPOSelect);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projection Operators";
            // 
            // uiPOSelectMany
            // 
            this.uiPOSelectMany.Location = new System.Drawing.Point(7, 49);
            this.uiPOSelectMany.Name = "uiPOSelectMany";
            this.uiPOSelectMany.Size = new System.Drawing.Size(75, 23);
            this.uiPOSelectMany.TabIndex = 1;
            this.uiPOSelectMany.Text = "SelectMany";
            this.uiPOSelectMany.UseVisualStyleBackColor = true;
            this.uiPOSelectMany.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiPOSelect
            // 
            this.uiPOSelect.Location = new System.Drawing.Point(7, 20);
            this.uiPOSelect.Name = "uiPOSelect";
            this.uiPOSelect.Size = new System.Drawing.Size(75, 23);
            this.uiPOSelect.TabIndex = 0;
            this.uiPOSelect.Text = "Select";
            this.uiPOSelect.UseVisualStyleBackColor = true;
            this.uiPOSelect.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiPOTakeWhile);
            this.groupBox3.Controls.Add(this.uiPOSkipWhile);
            this.groupBox3.Controls.Add(this.uiPOSkip);
            this.groupBox3.Controls.Add(this.uiPOTake);
            this.groupBox3.Location = new System.Drawing.Point(425, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Partitioning Operators";
            // 
            // uiPOTakeWhile
            // 
            this.uiPOTakeWhile.Location = new System.Drawing.Point(88, 20);
            this.uiPOTakeWhile.Name = "uiPOTakeWhile";
            this.uiPOTakeWhile.Size = new System.Drawing.Size(75, 23);
            this.uiPOTakeWhile.TabIndex = 2;
            this.uiPOTakeWhile.Text = "TakeWhile";
            this.uiPOTakeWhile.UseVisualStyleBackColor = true;
            this.uiPOTakeWhile.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiPOSkipWhile
            // 
            this.uiPOSkipWhile.Location = new System.Drawing.Point(87, 49);
            this.uiPOSkipWhile.Name = "uiPOSkipWhile";
            this.uiPOSkipWhile.Size = new System.Drawing.Size(75, 23);
            this.uiPOSkipWhile.TabIndex = 1;
            this.uiPOSkipWhile.Text = "SkipWhile";
            this.uiPOSkipWhile.UseVisualStyleBackColor = true;
            this.uiPOSkipWhile.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiPOSkip
            // 
            this.uiPOSkip.Location = new System.Drawing.Point(6, 49);
            this.uiPOSkip.Name = "uiPOSkip";
            this.uiPOSkip.Size = new System.Drawing.Size(75, 23);
            this.uiPOSkip.TabIndex = 1;
            this.uiPOSkip.Text = "Skip";
            this.uiPOSkip.UseVisualStyleBackColor = true;
            this.uiPOSkip.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiPOTake
            // 
            this.uiPOTake.Location = new System.Drawing.Point(7, 20);
            this.uiPOTake.Name = "uiPOTake";
            this.uiPOTake.Size = new System.Drawing.Size(75, 23);
            this.uiPOTake.TabIndex = 0;
            this.uiPOTake.Text = "Take";
            this.uiPOTake.UseVisualStyleBackColor = true;
            this.uiPOTake.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uiOOThenByDescending);
            this.groupBox4.Controls.Add(this.uiOOOrderByDescending);
            this.groupBox4.Controls.Add(this.uiOOReverse);
            this.groupBox4.Controls.Add(this.uiOOThenBy);
            this.groupBox4.Controls.Add(this.uiOOOrderBy);
            this.groupBox4.Location = new System.Drawing.Point(12, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 107);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordering Operators";
            // 
            // uiOOThenByDescending
            // 
            this.uiOOThenByDescending.Location = new System.Drawing.Point(81, 48);
            this.uiOOThenByDescending.Name = "uiOOThenByDescending";
            this.uiOOThenByDescending.Size = new System.Drawing.Size(113, 23);
            this.uiOOThenByDescending.TabIndex = 0;
            this.uiOOThenByDescending.Text = "ThenByDescending";
            this.uiOOThenByDescending.UseVisualStyleBackColor = true;
            this.uiOOThenByDescending.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiOOOrderByDescending
            // 
            this.uiOOOrderByDescending.Location = new System.Drawing.Point(81, 19);
            this.uiOOOrderByDescending.Name = "uiOOOrderByDescending";
            this.uiOOOrderByDescending.Size = new System.Drawing.Size(113, 23);
            this.uiOOOrderByDescending.TabIndex = 0;
            this.uiOOOrderByDescending.Text = "OrderByDescending";
            this.uiOOOrderByDescending.UseVisualStyleBackColor = true;
            this.uiOOOrderByDescending.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiOOReverse
            // 
            this.uiOOReverse.Location = new System.Drawing.Point(6, 77);
            this.uiOOReverse.Name = "uiOOReverse";
            this.uiOOReverse.Size = new System.Drawing.Size(75, 23);
            this.uiOOReverse.TabIndex = 0;
            this.uiOOReverse.Text = "Reverse";
            this.uiOOReverse.UseVisualStyleBackColor = true;
            this.uiOOReverse.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiOOThenBy
            // 
            this.uiOOThenBy.Location = new System.Drawing.Point(6, 48);
            this.uiOOThenBy.Name = "uiOOThenBy";
            this.uiOOThenBy.Size = new System.Drawing.Size(75, 23);
            this.uiOOThenBy.TabIndex = 0;
            this.uiOOThenBy.Text = "ThenBy";
            this.uiOOThenBy.UseVisualStyleBackColor = true;
            this.uiOOThenBy.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiOOOrderBy
            // 
            this.uiOOOrderBy.Location = new System.Drawing.Point(6, 19);
            this.uiOOOrderBy.Name = "uiOOOrderBy";
            this.uiOOOrderBy.Size = new System.Drawing.Size(75, 23);
            this.uiOOOrderBy.TabIndex = 0;
            this.uiOOOrderBy.Text = "OrderBy";
            this.uiOOOrderBy.UseVisualStyleBackColor = true;
            this.uiOOOrderBy.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.uiGOGroupBy);
            this.groupBox5.Location = new System.Drawing.Point(219, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grouping Operators";
            // 
            // uiGOGroupBy
            // 
            this.uiGOGroupBy.Location = new System.Drawing.Point(7, 20);
            this.uiGOGroupBy.Name = "uiGOGroupBy";
            this.uiGOGroupBy.Size = new System.Drawing.Size(75, 23);
            this.uiGOGroupBy.TabIndex = 0;
            this.uiGOGroupBy.Text = "GroupBy";
            this.uiGOGroupBy.UseVisualStyleBackColor = true;
            this.uiGOGroupBy.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.uiSOExcept);
            this.groupBox6.Controls.Add(this.uiSOIntersect);
            this.groupBox6.Controls.Add(this.uiSOUnion);
            this.groupBox6.Controls.Add(this.uiSODistinct);
            this.groupBox6.Location = new System.Drawing.Point(425, 126);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Set Operators";
            // 
            // uiSOExcept
            // 
            this.uiSOExcept.Location = new System.Drawing.Point(88, 49);
            this.uiSOExcept.Name = "uiSOExcept";
            this.uiSOExcept.Size = new System.Drawing.Size(75, 23);
            this.uiSOExcept.TabIndex = 3;
            this.uiSOExcept.Text = "Except";
            this.uiSOExcept.UseVisualStyleBackColor = true;
            this.uiSOExcept.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiSOIntersect
            // 
            this.uiSOIntersect.Location = new System.Drawing.Point(7, 49);
            this.uiSOIntersect.Name = "uiSOIntersect";
            this.uiSOIntersect.Size = new System.Drawing.Size(75, 23);
            this.uiSOIntersect.TabIndex = 2;
            this.uiSOIntersect.Text = "Intersect";
            this.uiSOIntersect.UseVisualStyleBackColor = true;
            this.uiSOIntersect.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiSOUnion
            // 
            this.uiSOUnion.Location = new System.Drawing.Point(87, 20);
            this.uiSOUnion.Name = "uiSOUnion";
            this.uiSOUnion.Size = new System.Drawing.Size(75, 23);
            this.uiSOUnion.TabIndex = 1;
            this.uiSOUnion.Text = "Union";
            this.uiSOUnion.UseVisualStyleBackColor = true;
            this.uiSOUnion.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiSODistinct
            // 
            this.uiSODistinct.Location = new System.Drawing.Point(7, 20);
            this.uiSODistinct.Name = "uiSODistinct";
            this.uiSODistinct.Size = new System.Drawing.Size(75, 23);
            this.uiSODistinct.TabIndex = 0;
            this.uiSODistinct.Text = "Distinct";
            this.uiSODistinct.UseVisualStyleBackColor = true;
            this.uiSODistinct.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.uiCOOfType);
            this.groupBox7.Controls.Add(this.uiCOToDictionary);
            this.groupBox7.Controls.Add(this.uiCOToList);
            this.groupBox7.Controls.Add(this.uiCOToArray);
            this.groupBox7.Location = new System.Drawing.Point(644, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Conversion Operators";
            // 
            // uiCOOfType
            // 
            this.uiCOOfType.Location = new System.Drawing.Point(88, 49);
            this.uiCOOfType.Name = "uiCOOfType";
            this.uiCOOfType.Size = new System.Drawing.Size(75, 23);
            this.uiCOOfType.TabIndex = 3;
            this.uiCOOfType.Text = "OfType";
            this.uiCOOfType.UseVisualStyleBackColor = true;
            this.uiCOOfType.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiCOToDictionary
            // 
            this.uiCOToDictionary.Location = new System.Drawing.Point(7, 49);
            this.uiCOToDictionary.Name = "uiCOToDictionary";
            this.uiCOToDictionary.Size = new System.Drawing.Size(75, 23);
            this.uiCOToDictionary.TabIndex = 2;
            this.uiCOToDictionary.Text = "ToDictionary";
            this.uiCOToDictionary.UseVisualStyleBackColor = true;
            this.uiCOToDictionary.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiCOToList
            // 
            this.uiCOToList.Location = new System.Drawing.Point(88, 20);
            this.uiCOToList.Name = "uiCOToList";
            this.uiCOToList.Size = new System.Drawing.Size(75, 23);
            this.uiCOToList.TabIndex = 1;
            this.uiCOToList.Text = "ToList";
            this.uiCOToList.UseVisualStyleBackColor = true;
            this.uiCOToList.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiCOToArray
            // 
            this.uiCOToArray.Location = new System.Drawing.Point(7, 20);
            this.uiCOToArray.Name = "uiCOToArray";
            this.uiCOToArray.Size = new System.Drawing.Size(75, 23);
            this.uiCOToArray.TabIndex = 0;
            this.uiCOToArray.Text = "ToArray";
            this.uiCOToArray.UseVisualStyleBackColor = true;
            this.uiCOToArray.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.uiEOElementAt);
            this.groupBox8.Controls.Add(this.uiEOFirstDefault);
            this.groupBox8.Controls.Add(this.uiEOFirst);
            this.groupBox8.Location = new System.Drawing.Point(644, 126);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 100);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Element Operators";
            // 
            // uiEOElementAt
            // 
            this.uiEOElementAt.Location = new System.Drawing.Point(7, 49);
            this.uiEOElementAt.Name = "uiEOElementAt";
            this.uiEOElementAt.Size = new System.Drawing.Size(75, 23);
            this.uiEOElementAt.TabIndex = 2;
            this.uiEOElementAt.Text = "ElementAt";
            this.uiEOElementAt.UseVisualStyleBackColor = true;
            this.uiEOElementAt.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiEOFirstDefault
            // 
            this.uiEOFirstDefault.Location = new System.Drawing.Point(88, 20);
            this.uiEOFirstDefault.Name = "uiEOFirstDefault";
            this.uiEOFirstDefault.Size = new System.Drawing.Size(85, 23);
            this.uiEOFirstDefault.TabIndex = 1;
            this.uiEOFirstDefault.Text = "FirstOrDefault";
            this.uiEOFirstDefault.UseVisualStyleBackColor = true;
            this.uiEOFirstDefault.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiEOFirst
            // 
            this.uiEOFirst.Location = new System.Drawing.Point(7, 20);
            this.uiEOFirst.Name = "uiEOFirst";
            this.uiEOFirst.Size = new System.Drawing.Size(75, 23);
            this.uiEOFirst.TabIndex = 0;
            this.uiEOFirst.Text = "First";
            this.uiEOFirst.UseVisualStyleBackColor = true;
            this.uiEOFirst.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.uiGORepeat);
            this.groupBox9.Controls.Add(this.uiGORange);
            this.groupBox9.Location = new System.Drawing.Point(13, 232);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 100);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Generation Operators";
            // 
            // uiGORepeat
            // 
            this.uiGORepeat.Location = new System.Drawing.Point(88, 19);
            this.uiGORepeat.Name = "uiGORepeat";
            this.uiGORepeat.Size = new System.Drawing.Size(75, 23);
            this.uiGORepeat.TabIndex = 0;
            this.uiGORepeat.Text = "Repeat";
            this.uiGORepeat.UseVisualStyleBackColor = true;
            this.uiGORepeat.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiGORange
            // 
            this.uiGORange.Location = new System.Drawing.Point(7, 20);
            this.uiGORange.Name = "uiGORange";
            this.uiGORange.Size = new System.Drawing.Size(75, 23);
            this.uiGORange.TabIndex = 0;
            this.uiGORange.Text = "Range";
            this.uiGORange.UseVisualStyleBackColor = true;
            this.uiGORange.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // Quantifiers
            // 
            this.Quantifiers.Controls.Add(this.uiQuantifiersAll);
            this.Quantifiers.Controls.Add(this.uiQuantifiersAny);
            this.Quantifiers.Location = new System.Drawing.Point(219, 232);
            this.Quantifiers.Name = "Quantifiers";
            this.Quantifiers.Size = new System.Drawing.Size(200, 100);
            this.Quantifiers.TabIndex = 1;
            this.Quantifiers.TabStop = false;
            this.Quantifiers.Text = "Quantifiers";
            // 
            // uiQuantifiersAll
            // 
            this.uiQuantifiersAll.Location = new System.Drawing.Point(88, 19);
            this.uiQuantifiersAll.Name = "uiQuantifiersAll";
            this.uiQuantifiersAll.Size = new System.Drawing.Size(75, 23);
            this.uiQuantifiersAll.TabIndex = 0;
            this.uiQuantifiersAll.Text = "All";
            this.uiQuantifiersAll.UseVisualStyleBackColor = true;
            this.uiQuantifiersAll.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiQuantifiersAny
            // 
            this.uiQuantifiersAny.Location = new System.Drawing.Point(7, 20);
            this.uiQuantifiersAny.Name = "uiQuantifiersAny";
            this.uiQuantifiersAny.Size = new System.Drawing.Size(75, 23);
            this.uiQuantifiersAny.TabIndex = 0;
            this.uiQuantifiersAny.Text = "Any";
            this.uiQuantifiersAny.UseVisualStyleBackColor = true;
            this.uiQuantifiersAny.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.uiAOMax);
            this.groupBox11.Controls.Add(this.uiAOSum);
            this.groupBox11.Controls.Add(this.uiAOAggregate);
            this.groupBox11.Controls.Add(this.uiAOAverage);
            this.groupBox11.Controls.Add(this.uiAOMin);
            this.groupBox11.Controls.Add(this.uiAOCount);
            this.groupBox11.Location = new System.Drawing.Point(425, 232);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(201, 107);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Aggregate Operators";
            // 
            // uiAOMax
            // 
            this.uiAOMax.Location = new System.Drawing.Point(88, 48);
            this.uiAOMax.Name = "uiAOMax";
            this.uiAOMax.Size = new System.Drawing.Size(75, 23);
            this.uiAOMax.TabIndex = 0;
            this.uiAOMax.Text = "Max";
            this.uiAOMax.UseVisualStyleBackColor = true;
            this.uiAOMax.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiAOSum
            // 
            this.uiAOSum.Location = new System.Drawing.Point(88, 19);
            this.uiAOSum.Name = "uiAOSum";
            this.uiAOSum.Size = new System.Drawing.Size(75, 23);
            this.uiAOSum.TabIndex = 0;
            this.uiAOSum.Text = "Sum";
            this.uiAOSum.UseVisualStyleBackColor = true;
            this.uiAOSum.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiAOAggregate
            // 
            this.uiAOAggregate.Location = new System.Drawing.Point(88, 77);
            this.uiAOAggregate.Name = "uiAOAggregate";
            this.uiAOAggregate.Size = new System.Drawing.Size(74, 23);
            this.uiAOAggregate.TabIndex = 0;
            this.uiAOAggregate.Text = "Aggregate ";
            this.uiAOAggregate.UseVisualStyleBackColor = true;
            this.uiAOAggregate.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiAOAverage
            // 
            this.uiAOAverage.Location = new System.Drawing.Point(7, 77);
            this.uiAOAverage.Name = "uiAOAverage";
            this.uiAOAverage.Size = new System.Drawing.Size(75, 23);
            this.uiAOAverage.TabIndex = 0;
            this.uiAOAverage.Text = "Average";
            this.uiAOAverage.UseVisualStyleBackColor = true;
            this.uiAOAverage.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiAOMin
            // 
            this.uiAOMin.Location = new System.Drawing.Point(6, 48);
            this.uiAOMin.Name = "uiAOMin";
            this.uiAOMin.Size = new System.Drawing.Size(75, 23);
            this.uiAOMin.TabIndex = 0;
            this.uiAOMin.Text = "Min";
            this.uiAOMin.UseVisualStyleBackColor = true;
            this.uiAOMin.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiAOCount
            // 
            this.uiAOCount.Location = new System.Drawing.Point(6, 19);
            this.uiAOCount.Name = "uiAOCount";
            this.uiAOCount.Size = new System.Drawing.Size(75, 23);
            this.uiAOCount.TabIndex = 0;
            this.uiAOCount.Text = "Count";
            this.uiAOCount.UseVisualStyleBackColor = true;
            this.uiAOCount.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.uiMOEqualAll);
            this.groupBox12.Controls.Add(this.uiMOConcat);
            this.groupBox12.Location = new System.Drawing.Point(12, 338);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 100);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Miscellaneous Operators";
            // 
            // uiMOEqualAll
            // 
            this.uiMOEqualAll.Location = new System.Drawing.Point(88, 19);
            this.uiMOEqualAll.Name = "uiMOEqualAll";
            this.uiMOEqualAll.Size = new System.Drawing.Size(75, 23);
            this.uiMOEqualAll.TabIndex = 0;
            this.uiMOEqualAll.Text = "EqualAll";
            this.uiMOEqualAll.UseVisualStyleBackColor = true;
            this.uiMOEqualAll.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiMOConcat
            // 
            this.uiMOConcat.Location = new System.Drawing.Point(7, 20);
            this.uiMOConcat.Name = "uiMOConcat";
            this.uiMOConcat.Size = new System.Drawing.Size(75, 23);
            this.uiMOConcat.TabIndex = 0;
            this.uiMOConcat.Text = "Concat";
            this.uiMOConcat.UseVisualStyleBackColor = true;
            this.uiMOConcat.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.uiCSOCombine);
            this.groupBox13.Location = new System.Drawing.Point(219, 338);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(200, 100);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Custom Sequence Operators";
            // 
            // uiCSOCombine
            // 
            this.uiCSOCombine.Location = new System.Drawing.Point(7, 19);
            this.uiCSOCombine.Name = "uiCSOCombine";
            this.uiCSOCombine.Size = new System.Drawing.Size(75, 23);
            this.uiCSOCombine.TabIndex = 0;
            this.uiCSOCombine.Text = "Combine";
            this.uiCSOCombine.UseVisualStyleBackColor = true;
            this.uiCSOCombine.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.uiQEQueryReuse);
            this.groupBox14.Controls.Add(this.uiQEImmediateExecution);
            this.groupBox14.Controls.Add(this.uiQEDeferredExecution);
            this.groupBox14.Location = new System.Drawing.Point(644, 239);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(200, 100);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Query Execution";
            // 
            // uiQEQueryReuse
            // 
            this.uiQEQueryReuse.Location = new System.Drawing.Point(7, 71);
            this.uiQEQueryReuse.Name = "uiQEQueryReuse";
            this.uiQEQueryReuse.Size = new System.Drawing.Size(156, 23);
            this.uiQEQueryReuse.TabIndex = 0;
            this.uiQEQueryReuse.Text = "Query Reuse";
            this.uiQEQueryReuse.UseVisualStyleBackColor = true;
            this.uiQEQueryReuse.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiQEImmediateExecution
            // 
            this.uiQEImmediateExecution.Location = new System.Drawing.Point(7, 45);
            this.uiQEImmediateExecution.Name = "uiQEImmediateExecution";
            this.uiQEImmediateExecution.Size = new System.Drawing.Size(156, 23);
            this.uiQEImmediateExecution.TabIndex = 0;
            this.uiQEImmediateExecution.Text = "Immediate Execution";
            this.uiQEImmediateExecution.UseVisualStyleBackColor = true;
            this.uiQEImmediateExecution.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiQEDeferredExecution
            // 
            this.uiQEDeferredExecution.Location = new System.Drawing.Point(7, 19);
            this.uiQEDeferredExecution.Name = "uiQEDeferredExecution";
            this.uiQEDeferredExecution.Size = new System.Drawing.Size(156, 23);
            this.uiQEDeferredExecution.TabIndex = 0;
            this.uiQEDeferredExecution.Text = "Deferred Execution";
            this.uiQEDeferredExecution.UseVisualStyleBackColor = true;
            this.uiQEDeferredExecution.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.uiJOLeftOuterJoin);
            this.groupBox15.Controls.Add(this.uiJOCrossWithGroupJoin);
            this.groupBox15.Controls.Add(this.uiJOGroupJoin);
            this.groupBox15.Controls.Add(this.uiJOCrossJoin);
            this.groupBox15.Location = new System.Drawing.Point(425, 345);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(200, 100);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Join Operators";
            // 
            // uiJOLeftOuterJoin
            // 
            this.uiJOLeftOuterJoin.Location = new System.Drawing.Point(5, 70);
            this.uiJOLeftOuterJoin.Name = "uiJOLeftOuterJoin";
            this.uiJOLeftOuterJoin.Size = new System.Drawing.Size(157, 23);
            this.uiJOLeftOuterJoin.TabIndex = 0;
            this.uiJOLeftOuterJoin.Text = "Left Outer Join";
            this.uiJOLeftOuterJoin.UseVisualStyleBackColor = true;
            this.uiJOLeftOuterJoin.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiJOCrossWithGroupJoin
            // 
            this.uiJOCrossWithGroupJoin.Location = new System.Drawing.Point(6, 45);
            this.uiJOCrossWithGroupJoin.Name = "uiJOCrossWithGroupJoin";
            this.uiJOCrossWithGroupJoin.Size = new System.Drawing.Size(157, 23);
            this.uiJOCrossWithGroupJoin.TabIndex = 0;
            this.uiJOCrossWithGroupJoin.Text = "Cross Join with Group Join";
            this.uiJOCrossWithGroupJoin.UseVisualStyleBackColor = true;
            this.uiJOCrossWithGroupJoin.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiJOGroupJoin
            // 
            this.uiJOGroupJoin.Location = new System.Drawing.Point(88, 19);
            this.uiJOGroupJoin.Name = "uiJOGroupJoin";
            this.uiJOGroupJoin.Size = new System.Drawing.Size(75, 23);
            this.uiJOGroupJoin.TabIndex = 0;
            this.uiJOGroupJoin.Text = "Group Join";
            this.uiJOGroupJoin.UseVisualStyleBackColor = true;
            this.uiJOGroupJoin.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiJOCrossJoin
            // 
            this.uiJOCrossJoin.Location = new System.Drawing.Point(7, 20);
            this.uiJOCrossJoin.Name = "uiJOCrossJoin";
            this.uiJOCrossJoin.Size = new System.Drawing.Size(75, 23);
            this.uiJOCrossJoin.TabIndex = 0;
            this.uiJOCrossJoin.Text = "Cross Join";
            this.uiJOCrossJoin.UseVisualStyleBackColor = true;
            this.uiJOCrossJoin.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 487);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Quantifiers);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartupForm";
            this.Text = "LINQ Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.Quantifiers.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiROWhere;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uiPOSelectMany;
        private System.Windows.Forms.Button uiPOSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uiPOTakeWhile;
        private System.Windows.Forms.Button uiPOSkipWhile;
        private System.Windows.Forms.Button uiPOSkip;
        private System.Windows.Forms.Button uiPOTake;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button uiOOThenByDescending;
        private System.Windows.Forms.Button uiOOOrderByDescending;
        private System.Windows.Forms.Button uiOOReverse;
        private System.Windows.Forms.Button uiOOThenBy;
        private System.Windows.Forms.Button uiOOOrderBy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button uiGOGroupBy;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button uiSOExcept;
        private System.Windows.Forms.Button uiSOIntersect;
        private System.Windows.Forms.Button uiSOUnion;
        private System.Windows.Forms.Button uiSODistinct;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button uiCOOfType;
        private System.Windows.Forms.Button uiCOToDictionary;
        private System.Windows.Forms.Button uiCOToList;
        private System.Windows.Forms.Button uiCOToArray;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button uiEOElementAt;
        private System.Windows.Forms.Button uiEOFirstDefault;
        private System.Windows.Forms.Button uiEOFirst;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button uiGORepeat;
        private System.Windows.Forms.Button uiGORange;
        private System.Windows.Forms.GroupBox Quantifiers;
        private System.Windows.Forms.Button uiQuantifiersAll;
        private System.Windows.Forms.Button uiQuantifiersAny;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button uiAOMax;
        private System.Windows.Forms.Button uiAOSum;
        private System.Windows.Forms.Button uiAOAggregate;
        private System.Windows.Forms.Button uiAOAverage;
        private System.Windows.Forms.Button uiAOMin;
        private System.Windows.Forms.Button uiAOCount;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button uiMOEqualAll;
        private System.Windows.Forms.Button uiMOConcat;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button uiCSOCombine;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button uiQEQueryReuse;
        private System.Windows.Forms.Button uiQEImmediateExecution;
        private System.Windows.Forms.Button uiQEDeferredExecution;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button uiJOLeftOuterJoin;
        private System.Windows.Forms.Button uiJOCrossWithGroupJoin;
        private System.Windows.Forms.Button uiJOGroupJoin;
        private System.Windows.Forms.Button uiJOCrossJoin;
    }
}


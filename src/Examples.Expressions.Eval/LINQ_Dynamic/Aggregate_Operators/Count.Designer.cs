namespace Examples.Expressions.Eval.LINQ_Dynamic.Aggregate_Operators
{
    partial class Count
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
            this.uiCount_Simple_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiCount_Simple_LINQ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiResult = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiCount_Conditional_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiCount_Conditional_LINQ_Dynamic = new System.Windows.Forms.Button();
            this.uiCount_Conditional_LINQ = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uiCount_Grouped_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiCount_Grouped_LINQ = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uiCount_Nested_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiCount_Nested_LINQ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiCount_Simple_LINQ_Execute);
            this.groupBox1.Controls.Add(this.uiCount_Simple_LINQ);
            this.groupBox1.Location = new System.Drawing.Point(19, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count - Simple";
            // 
            // uiCount_Simple_LINQ_Execute
            // 
            this.uiCount_Simple_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiCount_Simple_LINQ_Execute.Name = "uiCount_Simple_LINQ_Execute";
            this.uiCount_Simple_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Simple_LINQ_Execute.TabIndex = 2;
            this.uiCount_Simple_LINQ_Execute.Text = "LINQ Execute";
            this.uiCount_Simple_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiCount_Simple_LINQ_Execute.Click += new System.EventHandler(this.uiCount_Simple_LINQ_Execute_Click);
            // 
            // uiCount_Simple_LINQ
            // 
            this.uiCount_Simple_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiCount_Simple_LINQ.Name = "uiCount_Simple_LINQ";
            this.uiCount_Simple_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Simple_LINQ.TabIndex = 0;
            this.uiCount_Simple_LINQ.Text = "LINQ";
            this.uiCount_Simple_LINQ.UseVisualStyleBackColor = true;
            this.uiCount_Simple_LINQ.Click += new System.EventHandler(this.uiCount_Simple_LINQ_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // uiResult
            // 
            this.uiResult.Location = new System.Drawing.Point(7, 35);
            this.uiResult.Name = "uiResult";
            this.uiResult.Size = new System.Drawing.Size(736, 158);
            this.uiResult.TabIndex = 0;
            this.uiResult.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiCount_Conditional_LINQ_Execute);
            this.groupBox3.Controls.Add(this.uiCount_Conditional_LINQ_Dynamic);
            this.groupBox3.Controls.Add(this.uiCount_Conditional_LINQ);
            this.groupBox3.Location = new System.Drawing.Point(211, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Count - Conditional";
            // 
            // uiCount_Conditional_LINQ_Execute
            // 
            this.uiCount_Conditional_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiCount_Conditional_LINQ_Execute.Name = "uiCount_Conditional_LINQ_Execute";
            this.uiCount_Conditional_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Conditional_LINQ_Execute.TabIndex = 2;
            this.uiCount_Conditional_LINQ_Execute.Text = "LINQ Execute";
            this.uiCount_Conditional_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiCount_Conditional_LINQ_Execute.Click += new System.EventHandler(this.uiCount_Conditional_LINQ_Execute_Click);
            // 
            // uiCount_Conditional_LINQ_Dynamic
            // 
            this.uiCount_Conditional_LINQ_Dynamic.Location = new System.Drawing.Point(10, 60);
            this.uiCount_Conditional_LINQ_Dynamic.Name = "uiCount_Conditional_LINQ_Dynamic";
            this.uiCount_Conditional_LINQ_Dynamic.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Conditional_LINQ_Dynamic.TabIndex = 1;
            this.uiCount_Conditional_LINQ_Dynamic.Text = "LINQ Dynamic";
            this.uiCount_Conditional_LINQ_Dynamic.UseVisualStyleBackColor = true;
            this.uiCount_Conditional_LINQ_Dynamic.Click += new System.EventHandler(this.uiCount_Conditional_LINQ_Dynamic_Click);
            // 
            // uiCount_Conditional_LINQ
            // 
            this.uiCount_Conditional_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiCount_Conditional_LINQ.Name = "uiCount_Conditional_LINQ";
            this.uiCount_Conditional_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Conditional_LINQ.TabIndex = 0;
            this.uiCount_Conditional_LINQ.Text = "LINQ";
            this.uiCount_Conditional_LINQ.UseVisualStyleBackColor = true;
            this.uiCount_Conditional_LINQ.Click += new System.EventHandler(this.uiCount_Conditional_LINQ_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uiCount_Grouped_LINQ_Execute);
            this.groupBox4.Controls.Add(this.uiCount_Grouped_LINQ);
            this.groupBox4.Location = new System.Drawing.Point(403, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 135);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Count - Grouped";
            // 
            // uiCount_Grouped_LINQ_Execute
            // 
            this.uiCount_Grouped_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiCount_Grouped_LINQ_Execute.Name = "uiCount_Grouped_LINQ_Execute";
            this.uiCount_Grouped_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Grouped_LINQ_Execute.TabIndex = 2;
            this.uiCount_Grouped_LINQ_Execute.Text = "LINQ Execute";
            this.uiCount_Grouped_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiCount_Grouped_LINQ_Execute.Click += new System.EventHandler(this.uiCount_Grouped_LINQ_Execute_Click);
            // 
            // uiCount_Grouped_LINQ
            // 
            this.uiCount_Grouped_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiCount_Grouped_LINQ.Name = "uiCount_Grouped_LINQ";
            this.uiCount_Grouped_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Grouped_LINQ.TabIndex = 0;
            this.uiCount_Grouped_LINQ.Text = "LINQ";
            this.uiCount_Grouped_LINQ.UseVisualStyleBackColor = true;
            this.uiCount_Grouped_LINQ.Click += new System.EventHandler(this.uiCount_Grouped_LINQ_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.uiCount_Nested_LINQ_Execute);
            this.groupBox5.Controls.Add(this.uiCount_Nested_LINQ);
            this.groupBox5.Location = new System.Drawing.Point(19, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 135);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Count - Nested";
            // 
            // uiCount_Nested_LINQ_Execute
            // 
            this.uiCount_Nested_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiCount_Nested_LINQ_Execute.Name = "uiCount_Nested_LINQ_Execute";
            this.uiCount_Nested_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Nested_LINQ_Execute.TabIndex = 2;
            this.uiCount_Nested_LINQ_Execute.Text = "LINQ Execute";
            this.uiCount_Nested_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiCount_Nested_LINQ_Execute.Click += new System.EventHandler(this.uiCount_Nested_LINQ_Execute_Click);
            // 
            // uiCount_Nested_LINQ
            // 
            this.uiCount_Nested_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiCount_Nested_LINQ.Name = "uiCount_Nested_LINQ";
            this.uiCount_Nested_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiCount_Nested_LINQ.TabIndex = 0;
            this.uiCount_Nested_LINQ.Text = "LINQ";
            this.uiCount_Nested_LINQ.UseVisualStyleBackColor = true;
            this.uiCount_Nested_LINQ.Click += new System.EventHandler(this.uiCount_Nested_LINQ_Click);
            // 
            // Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Count";
            this.Text = "Count";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiCount_Simple_LINQ_Execute;
        private System.Windows.Forms.Button uiCount_Simple_LINQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox uiResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uiCount_Conditional_LINQ_Execute;
        private System.Windows.Forms.Button uiCount_Conditional_LINQ_Dynamic;
        private System.Windows.Forms.Button uiCount_Conditional_LINQ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button uiCount_Grouped_LINQ_Execute;
        private System.Windows.Forms.Button uiCount_Grouped_LINQ;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button uiCount_Nested_LINQ_Execute;
        private System.Windows.Forms.Button uiCount_Nested_LINQ;
    }
}
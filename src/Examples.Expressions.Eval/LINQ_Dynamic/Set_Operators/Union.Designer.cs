namespace Examples.Expressions.Eval.LINQ_Dynamic.Set_Operators
{
    partial class Union
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiUnion_1_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiUnion_1_LINQ = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiUnion_2_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiUnion_2_LINQ = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 197);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiUnion_1_LINQ_Execute);
            this.groupBox1.Controls.Add(this.uiUnion_1_LINQ);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Union - 1";
            // 
            // uiUnion_1_LINQ_Execute
            // 
            this.uiUnion_1_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiUnion_1_LINQ_Execute.Name = "uiUnion_1_LINQ_Execute";
            this.uiUnion_1_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiUnion_1_LINQ_Execute.TabIndex = 2;
            this.uiUnion_1_LINQ_Execute.Text = "LINQ Execute";
            this.uiUnion_1_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiUnion_1_LINQ_Execute.Click += new System.EventHandler(this.uiUnion_1_LINQ_Execute_Click);
            // 
            // uiUnion_1_LINQ
            // 
            this.uiUnion_1_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiUnion_1_LINQ.Name = "uiUnion_1_LINQ";
            this.uiUnion_1_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiUnion_1_LINQ.TabIndex = 0;
            this.uiUnion_1_LINQ.Text = "LINQ";
            this.uiUnion_1_LINQ.UseVisualStyleBackColor = true;
            this.uiUnion_1_LINQ.Click += new System.EventHandler(this.uiUnion_1_LINQ_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiUnion_2_LINQ_Execute);
            this.groupBox3.Controls.Add(this.uiUnion_2_LINQ);
            this.groupBox3.Location = new System.Drawing.Point(216, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Union - 2";
            // 
            // uiUnion_2_LINQ_Execute
            // 
            this.uiUnion_2_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiUnion_2_LINQ_Execute.Name = "uiUnion_2_LINQ_Execute";
            this.uiUnion_2_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiUnion_2_LINQ_Execute.TabIndex = 2;
            this.uiUnion_2_LINQ_Execute.Text = "LINQ Execute";
            this.uiUnion_2_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiUnion_2_LINQ_Execute.Click += new System.EventHandler(this.uiUnion_2_LINQ_Execute_Click);
            // 
            // uiUnion_2_LINQ
            // 
            this.uiUnion_2_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiUnion_2_LINQ.Name = "uiUnion_2_LINQ";
            this.uiUnion_2_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiUnion_2_LINQ.TabIndex = 0;
            this.uiUnion_2_LINQ.Text = "LINQ";
            this.uiUnion_2_LINQ.UseVisualStyleBackColor = true;
            this.uiUnion_2_LINQ.Click += new System.EventHandler(this.uiUnion_2_LINQ_Click);
            // 
            // Union
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Union";
            this.Text = "Union";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiUnion_1_LINQ_Execute;
        private System.Windows.Forms.Button uiUnion_1_LINQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox uiResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uiUnion_2_LINQ_Execute;
        private System.Windows.Forms.Button uiUnion_2_LINQ;

    }
}
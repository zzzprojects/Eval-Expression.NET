namespace Examples.Expressions.Eval.LINQ_Dynamic.Element_Operators
{
    partial class ElementAt
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
            this.uiElementAt_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiElementAt_LINQ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiElementAt_LINQ_Execute);
            this.groupBox1.Controls.Add(this.uiElementAt_LINQ);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ElementAt";
            // 
            // uiElementAt_LINQ_Execute
            // 
            this.uiElementAt_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiElementAt_LINQ_Execute.Name = "uiElementAt_LINQ_Execute";
            this.uiElementAt_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiElementAt_LINQ_Execute.TabIndex = 2;
            this.uiElementAt_LINQ_Execute.Text = "LINQ Execute";
            this.uiElementAt_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiElementAt_LINQ_Execute.Click += new System.EventHandler(this.uiElementAt_LINQ_Execute_Click);
            // 
            // uiElementAt_LINQ
            // 
            this.uiElementAt_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiElementAt_LINQ.Name = "uiElementAt_LINQ";
            this.uiElementAt_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiElementAt_LINQ.TabIndex = 0;
            this.uiElementAt_LINQ.Text = "LINQ";
            this.uiElementAt_LINQ.UseVisualStyleBackColor = true;
            this.uiElementAt_LINQ.Click += new System.EventHandler(this.uiElementAt_LINQ_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 206);
            this.groupBox2.TabIndex = 6;
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
            // ElementAt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ElementAt";
            this.Text = "ElementAt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiElementAt_LINQ_Execute;
        private System.Windows.Forms.Button uiElementAt_LINQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox uiResult;
    }
}
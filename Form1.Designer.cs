namespace WordsCounter
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.Typing_Label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.words_label = new System.Windows.Forms.Label();
            this.chars_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.Black;
            this.HeaderLabel.Font = new System.Drawing.Font("Cascadia Code", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HeaderLabel.Location = new System.Drawing.Point(2, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(493, 85);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Hello, World";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.BackColor = System.Drawing.Color.Black;
            this.WLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WLabel.Location = new System.Drawing.Point(12, 85);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(836, 49);
            this.WLabel.TabIndex = 1;
            this.WLabel.Text = "This is the right place for typing...";
            // 
            // Typing_Label
            // 
            this.Typing_Label.AutoSize = true;
            this.Typing_Label.BackColor = System.Drawing.Color.Black;
            this.Typing_Label.Enabled = false;
            this.Typing_Label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Typing_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Typing_Label.Location = new System.Drawing.Point(2, 30);
            this.Typing_Label.Name = "Typing_Label";
            this.Typing_Label.Size = new System.Drawing.Size(330, 49);
            this.Typing_Label.TabIndex = 2;
            this.Typing_Label.Text = "Type anything:";
            this.Typing_Label.Visible = false;
            this.Typing_Label.Click += new System.EventHandler(this.Typing_Label_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.Black;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextBox.Location = new System.Drawing.Point(12, 110);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(914, 312);
            this.TextBox.TabIndex = 3;
            this.TextBox.TabStop = false;
            this.TextBox.Text = "Write your words here...";
            this.TextBox.Visible = false;
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // words_label
            // 
            this.words_label.AutoSize = true;
            this.words_label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.words_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.words_label.Location = new System.Drawing.Point(31, 458);
            this.words_label.Name = "words_label";
            this.words_label.Size = new System.Drawing.Size(155, 25);
            this.words_label.TabIndex = 4;
            this.words_label.Text = "Words count: ";
            this.words_label.Visible = false;
            // 
            // chars_label
            // 
            this.chars_label.AutoSize = true;
            this.chars_label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chars_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chars_label.Location = new System.Drawing.Point(452, 458);
            this.chars_label.Name = "chars_label";
            this.chars_label.Size = new System.Drawing.Size(210, 25);
            this.chars_label.TabIndex = 5;
            this.chars_label.Text = "Characters count: ";
            this.chars_label.Visible = false;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.chars_label);
            this.Controls.Add(this.words_label);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Typing_Label);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "MyForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private Label WLabel;
        private Label Typing_Label;
        private RichTextBox TextBox;
        private string first_msg = "Write your words here...";
        private int words_counter;
        private int chars_counter;
        private Label words_label;
        private Label chars_label;
        private char[] not_counted = {',', ';', '.', ':', '(', ')'};
    }
}
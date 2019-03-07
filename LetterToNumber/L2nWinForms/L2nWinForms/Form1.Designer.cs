namespace L2nWinForms
{
    partial class Form1
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
            this.ShowResult = new System.Windows.Forms.Button();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowResult
            // 
            this.ShowResult.AutoSize = true;
            this.ShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowResult.Location = new System.Drawing.Point(12, 100);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.Size = new System.Drawing.Size(125, 34);
            this.ShowResult.TabIndex = 0;
            this.ShowResult.Text = "Show Result";
            this.ShowResult.UseVisualStyleBackColor = true;
            this.ShowResult.Click += new System.EventHandler(this.ShowResult_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.Location = new System.Drawing.Point(12, 9);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(153, 25);
            this.WelcomeText.TabIndex = 2;
            this.WelcomeText.Text = "Type in a word";
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(12, 48);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(243, 31);
            this.Word.TabIndex = 3;
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.ShowResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowResult;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Button button1;
    }
}


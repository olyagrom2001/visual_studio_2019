namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.WordList = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.Label();
            this.ReadingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.White;
            this.buttonRead.Location = new System.Drawing.Point(43, 181);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(117, 50);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Open";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "EnterYourWord";
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(426, 181);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 50);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // WordList
            // 
            this.WordList.FormattingEnabled = true;
            this.WordList.Location = new System.Drawing.Point(43, 51);
            this.WordList.Margin = new System.Windows.Forms.Padding(2);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(392, 108);
            this.WordList.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(423, 166);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            // 
            // ReadingTime
            // 
            this.ReadingTime.AutoSize = true;
            this.ReadingTime.Location = new System.Drawing.Point(40, 166);
            this.ReadingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReadingTime.Name = "ReadingTime";
            this.ReadingTime.Size = new System.Drawing.Size(70, 13);
            this.ReadingTime.TabIndex = 6;
            this.ReadingTime.Text = "ReadingTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(572, 252);
            this.Controls.Add(this.ReadingTime);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonRead);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox WordList;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label ReadingTime;
    }
}


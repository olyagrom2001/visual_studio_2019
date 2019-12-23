namespace HW
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
            this.components = new System.ComponentModel.Container();
            this.reading_button = new System.Windows.Forms.Button();
            this.Time_of_loading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Field_for_input = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Result_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Time_of_searching = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.label_dist = new System.Windows.Forms.Label();
            this.text_dist = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.count_of_words = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_count_of_steam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.count_of_stream = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exp_search_time = new System.Windows.Forms.Label();
            this.explicit_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_report = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reading_button
            // 
            this.reading_button.Location = new System.Drawing.Point(15, 35);
            this.reading_button.Name = "reading_button";
            this.reading_button.Size = new System.Drawing.Size(127, 35);
            this.reading_button.TabIndex = 0;
            this.reading_button.Text = "Выбрать файл";
            this.reading_button.UseVisualStyleBackColor = true;
            this.reading_button.Click += new System.EventHandler(this.reading_button_Click);
            // 
            // Time_of_loading
            // 
            this.Time_of_loading.AutoSize = true;
            this.Time_of_loading.Location = new System.Drawing.Point(322, 18);
            this.Time_of_loading.Name = "Time_of_loading";
            this.Time_of_loading.Size = new System.Drawing.Size(44, 17);
            this.Time_of_loading.TabIndex = 1;
            this.Time_of_loading.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время загрузки:";
            // 
            // Field_for_input
            // 
            this.Field_for_input.Location = new System.Drawing.Point(214, 23);
            this.Field_for_input.Name = "Field_for_input";
            this.Field_for_input.Size = new System.Drawing.Size(347, 22);
            this.Field_for_input.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(24, 159);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(126, 48);
            this.Search.TabIndex = 4;
            this.Search.Text = "Нечёткий поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Result_list
            // 
            this.Result_list.FormattingEnabled = true;
            this.Result_list.ItemHeight = 16;
            this.Result_list.Location = new System.Drawing.Point(27, 363);
            this.Result_list.Name = "Result_list";
            this.Result_list.Size = new System.Drawing.Size(563, 212);
            this.Result_list.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время нечёткого поиска:";
            // 
            // Time_of_searching
            // 
            this.Time_of_searching.AutoSize = true;
            this.Time_of_searching.Location = new System.Drawing.Point(438, 159);
            this.Time_of_searching.Name = "Time_of_searching";
            this.Time_of_searching.Size = new System.Drawing.Size(44, 17);
            this.Time_of_searching.TabIndex = 7;
            this.Time_of_searching.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(507, 588);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(83, 31);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label_dist
            // 
            this.label_dist.AutoSize = true;
            this.label_dist.Location = new System.Drawing.Point(24, 99);
            this.label_dist.Name = "label_dist";
            this.label_dist.Size = new System.Drawing.Size(339, 17);
            this.label_dist.TabIndex = 9;
            this.label_dist.Text = "Максимальное расстояние для нечёткого поиска:";
            this.label_dist.Click += new System.EventHandler(this.label_dist_Click);
            // 
            // text_dist
            // 
            this.text_dist.Location = new System.Drawing.Point(369, 96);
            this.text_dist.Name = "text_dist";
            this.text_dist.Size = new System.Drawing.Size(65, 22);
            this.text_dist.TabIndex = 10;
            this.text_dist.Text = "3";
            this.text_dist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.count_of_words);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.reading_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Time_of_loading);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 92);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Чтение файла";
            // 
            // count_of_words
            // 
            this.count_of_words.AutoSize = true;
            this.count_of_words.Location = new System.Drawing.Point(403, 53);
            this.count_of_words.Name = "count_of_words";
            this.count_of_words.Size = new System.Drawing.Size(16, 17);
            this.count_of_words.TabIndex = 4;
            this.count_of_words.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество уникальных слов:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_count_of_steam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.count_of_stream);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.text_dist);
            this.groupBox2.Controls.Add(this.Time_of_searching);
            this.groupBox2.Controls.Add(this.exp_search_time);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_dist);
            this.groupBox2.Controls.Add(this.explicit_search);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Field_for_input);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 232);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // label_count_of_steam
            // 
            this.label_count_of_steam.AutoSize = true;
            this.label_count_of_steam.Location = new System.Drawing.Point(478, 190);
            this.label_count_of_steam.Name = "label_count_of_steam";
            this.label_count_of_steam.Size = new System.Drawing.Size(0, 17);
            this.label_count_of_steam.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вычисленное кол-во потоков:";
            // 
            // count_of_stream
            // 
            this.count_of_stream.Location = new System.Drawing.Point(369, 123);
            this.count_of_stream.Name = "count_of_stream";
            this.count_of_stream.Size = new System.Drawing.Size(65, 22);
            this.count_of_stream.TabIndex = 12;
            this.count_of_stream.Text = "10";
            this.count_of_stream.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество потоков:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время чёткого поиска:";
            // 
            // exp_search_time
            // 
            this.exp_search_time.AutoSize = true;
            this.exp_search_time.Location = new System.Drawing.Point(438, 63);
            this.exp_search_time.Name = "exp_search_time";
            this.exp_search_time.Size = new System.Drawing.Size(44, 17);
            this.exp_search_time.TabIndex = 6;
            this.exp_search_time.Text = "00:00";
            // 
            // explicit_search
            // 
            this.explicit_search.Location = new System.Drawing.Point(27, 51);
            this.explicit_search.Name = "explicit_search";
            this.explicit_search.Size = new System.Drawing.Size(123, 40);
            this.explicit_search.TabIndex = 5;
            this.explicit_search.Text = "Чёткий поиск";
            this.explicit_search.UseVisualStyleBackColor = true;
            this.explicit_search.Click += new System.EventHandler(this.explicit_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите слово для поиска:";
            // 
            // button_report
            // 
            this.button_report.Location = new System.Drawing.Point(349, 588);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(145, 31);
            this.button_report.TabIndex = 13;
            this.button_report.Text = "Создать отчёт";
            this.button_report.UseVisualStyleBackColor = true;
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 631);
            this.Controls.Add(this.button_report);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Result_list);
            this.Name = "Form1";
            this.Text = "Домашнее задание по курсу БКИТ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reading_button;
        private System.Windows.Forms.Label Time_of_loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Field_for_input;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox Result_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time_of_searching;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label_dist;
        private System.Windows.Forms.TextBox text_dist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label count_of_words;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exp_search_time;
        private System.Windows.Forms.Button explicit_search;
        private System.Windows.Forms.TextBox count_of_stream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_count_of_steam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_report;
    }
}


namespace Games_Information
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимыИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одиночныеИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мультиплеерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большеВсегоПроданныхКопийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меньшеВсегоПроданныхКопийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.топИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.топ3СамыхПродаваемыхИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.топ3СамыхНепродаваемыхИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txb_release = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_genre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_creator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_buh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 277);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.добавитьДанныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимыИгрыToolStripMenuItem,
            this.играToolStripMenuItem,
            this.топИгрToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // режимыИгрыToolStripMenuItem
            // 
            this.режимыИгрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одиночныеИгрыToolStripMenuItem,
            this.мультиплеерToolStripMenuItem});
            this.режимыИгрыToolStripMenuItem.Name = "режимыИгрыToolStripMenuItem";
            this.режимыИгрыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.режимыИгрыToolStripMenuItem.Text = "Режимы игры";
            // 
            // одиночныеИгрыToolStripMenuItem
            // 
            this.одиночныеИгрыToolStripMenuItem.Name = "одиночныеИгрыToolStripMenuItem";
            this.одиночныеИгрыToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.одиночныеИгрыToolStripMenuItem.Text = "Одиночные игры";
            this.одиночныеИгрыToolStripMenuItem.Click += new System.EventHandler(this.одиночныеИгрыToolStripMenuItem_Click);
            // 
            // мультиплеерToolStripMenuItem
            // 
            this.мультиплеерToolStripMenuItem.Name = "мультиплеерToolStripMenuItem";
            this.мультиплеерToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.мультиплеерToolStripMenuItem.Text = "Мультиплеер";
            this.мультиплеерToolStripMenuItem.Click += new System.EventHandler(this.мультиплеерToolStripMenuItem_Click);
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.большеВсегоПроданныхКопийToolStripMenuItem,
            this.меньшеВсегоПроданныхКопийToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.играToolStripMenuItem.Text = "Продажи";
            // 
            // большеВсегоПроданныхКопийToolStripMenuItem
            // 
            this.большеВсегоПроданныхКопийToolStripMenuItem.Name = "большеВсегоПроданныхКопийToolStripMenuItem";
            this.большеВсегоПроданныхКопийToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.большеВсегоПроданныхКопийToolStripMenuItem.Text = "Больше всего проданных копий";
            this.большеВсегоПроданныхКопийToolStripMenuItem.Click += new System.EventHandler(this.большеВсегоПроданныхКопийToolStripMenuItem_Click);
            // 
            // меньшеВсегоПроданныхКопийToolStripMenuItem
            // 
            this.меньшеВсегоПроданныхКопийToolStripMenuItem.Name = "меньшеВсегоПроданныхКопийToolStripMenuItem";
            this.меньшеВсегоПроданныхКопийToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.меньшеВсегоПроданныхКопийToolStripMenuItem.Text = "Меньше всего проданных копий";
            this.меньшеВсегоПроданныхКопийToolStripMenuItem.Click += new System.EventHandler(this.меньшеВсегоПроданныхКопийToolStripMenuItem_Click);
            // 
            // топИгрToolStripMenuItem
            // 
            this.топИгрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.топ3СамыхПродаваемыхИгрToolStripMenuItem,
            this.топ3СамыхНепродаваемыхИгрToolStripMenuItem});
            this.топИгрToolStripMenuItem.Name = "топИгрToolStripMenuItem";
            this.топИгрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.топИгрToolStripMenuItem.Text = "Топ игр";
            // 
            // топ3СамыхПродаваемыхИгрToolStripMenuItem
            // 
            this.топ3СамыхПродаваемыхИгрToolStripMenuItem.Name = "топ3СамыхПродаваемыхИгрToolStripMenuItem";
            this.топ3СамыхПродаваемыхИгрToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.топ3СамыхПродаваемыхИгрToolStripMenuItem.Text = "Топ-3 самых продаваемых игр";
            this.топ3СамыхПродаваемыхИгрToolStripMenuItem.Click += new System.EventHandler(this.топ3СамыхПродаваемыхИгрToolStripMenuItem_Click);
            // 
            // топ3СамыхНепродаваемыхИгрToolStripMenuItem
            // 
            this.топ3СамыхНепродаваемыхИгрToolStripMenuItem.Name = "топ3СамыхНепродаваемыхИгрToolStripMenuItem";
            this.топ3СамыхНепродаваемыхИгрToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.топ3СамыхНепродаваемыхИгрToolStripMenuItem.Text = "Топ-3 самых непродаваемых игр";
            this.топ3СамыхНепродаваемыхИгрToolStripMenuItem.Click += new System.EventHandler(this.топ3СамыхНепродаваемыхИгрToolStripMenuItem_Click);
            // 
            // добавитьДанныеToolStripMenuItem
            // 
            this.добавитьДанныеToolStripMenuItem.Name = "добавитьДанныеToolStripMenuItem";
            this.добавитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.добавитьДанныеToolStripMenuItem.Text = "Добавить новую игру";
            this.добавитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txb_release);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_genre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_creator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск игры";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_search.Location = new System.Drawing.Point(526, 126);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(133, 39);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(526, 39);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 39);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txb_release
            // 
            this.txb_release.Location = new System.Drawing.Point(135, 155);
            this.txb_release.Margin = new System.Windows.Forms.Padding(4);
            this.txb_release.Name = "txb_release";
            this.txb_release.Size = new System.Drawing.Size(377, 22);
            this.txb_release.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год релиза";
            // 
            // txb_genre
            // 
            this.txb_genre.Location = new System.Drawing.Point(135, 112);
            this.txb_genre.Margin = new System.Windows.Forms.Padding(4);
            this.txb_genre.Name = "txb_genre";
            this.txb_genre.Size = new System.Drawing.Size(377, 22);
            this.txb_genre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стиль";
            // 
            // txb_creator
            // 
            this.txb_creator.Location = new System.Drawing.Point(135, 69);
            this.txb_creator.Margin = new System.Windows.Forms.Padding(4);
            this.txb_creator.Name = "txb_creator";
            this.txb_creator.Size = new System.Drawing.Size(377, 22);
            this.txb_creator.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Разработчик";
            // 
            // txb_title
            // 
            this.txb_title.Location = new System.Drawing.Point(135, 27);
            this.txb_title.Margin = new System.Windows.Forms.Padding(4);
            this.txb_title.Name = "txb_title";
            this.txb_title.Size = new System.Drawing.Size(377, 22);
            this.txb_title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название игры";
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit.Location = new System.Drawing.Point(16, 231);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(141, 39);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Изменить данные";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.Location = new System.Drawing.Point(542, 231);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(141, 39);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_buh
            // 
            this.btn_buh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_buh.Location = new System.Drawing.Point(259, 231);
            this.btn_buh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buh.Name = "btn_buh";
            this.btn_buh.Size = new System.Drawing.Size(141, 39);
            this.btn_buh.TabIndex = 10;
            this.btn_buh.Text = "Сбросить";
            this.btn_buh.UseVisualStyleBackColor = true;
            this.btn_buh.Click += new System.EventHandler(this.btn_buh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 554);
            this.Controls.Add(this.btn_buh);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_release;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_creator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem режимыИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одиночныеИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мультиплеерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem большеВсегоПроданныхКопийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem меньшеВсегоПроданныхКопийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem топИгрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem топ3СамыхПродаваемыхИгрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem топ3СамыхНепродаваемыхИгрToolStripMenuItem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_buh;
    }
}


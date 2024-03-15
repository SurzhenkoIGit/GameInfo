namespace Games_Information
{
    partial class AddForm
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
            this.txb_Release = new System.Windows.Forms.TextBox();
            this.cmb_GameMode = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Creator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.nud_Count = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_Count);
            this.groupBox1.Controls.Add(this.cmb_Genre);
            this.groupBox1.Controls.Add(this.txb_Release);
            this.groupBox1.Controls.Add(this.cmb_GameMode);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_Creator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_Title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 376);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Игра";
            // 
            // txb_Release
            // 
            this.txb_Release.Location = new System.Drawing.Point(105, 166);
            this.txb_Release.Name = "txb_Release";
            this.txb_Release.Size = new System.Drawing.Size(196, 26);
            this.txb_Release.TabIndex = 19;
            // 
            // cmb_GameMode
            // 
            this.cmb_GameMode.FormattingEnabled = true;
            this.cmb_GameMode.Items.AddRange(new object[] {
            "Однопользовательский",
            "Многопользовательский",
            "Смешанный"});
            this.cmb_GameMode.Location = new System.Drawing.Point(105, 212);
            this.cmb_GameMode.Name = "cmb_GameMode";
            this.cmb_GameMode.Size = new System.Drawing.Size(196, 28);
            this.cmb_GameMode.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(172, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(51, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество копий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Режим игры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата релиза";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Жанр";
            // 
            // txb_Creator
            // 
            this.txb_Creator.Location = new System.Drawing.Point(105, 76);
            this.txb_Creator.Name = "txb_Creator";
            this.txb_Creator.Size = new System.Drawing.Size(196, 26);
            this.txb_Creator.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Разработчик";
            // 
            // txb_Title
            // 
            this.txb_Title.Location = new System.Drawing.Point(105, 31);
            this.txb_Title.Name = "txb_Title";
            this.txb_Title.Size = new System.Drawing.Size(196, 26);
            this.txb_Title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Items.AddRange(new object[] {
            "FPS",
            "Action",
            "Fighting",
            "Platformer",
            "Survival horror",
            "Adventure",
            "RPG",
            "MMORPG",
            "Strategy"});
            this.cmb_Genre.Location = new System.Drawing.Point(105, 121);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(196, 28);
            this.cmb_Genre.TabIndex = 21;
            // 
            // nud_Count
            // 
            this.nud_Count.Location = new System.Drawing.Point(138, 261);
            this.nud_Count.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.nud_Count.Name = "nud_Count";
            this.nud_Count.Size = new System.Drawing.Size(163, 26);
            this.nud_Count.TabIndex = 22;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txb_Creator;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txb_Title;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_GameMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txb_Release;
        public System.Windows.Forms.ComboBox cmb_Genre;
        public System.Windows.Forms.NumericUpDown nud_Count;
    }
}
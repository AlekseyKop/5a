namespace NewtonPolynomial
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DictionaryGridView = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.inputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindWordsButton = new System.Windows.Forms.Button();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.Слова = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryGridView)).BeginInit();
            this.inputDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DictionaryGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Словарь Ожегова";
            // 
            // DictionaryGridView
            // 
            this.DictionaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DictionaryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Слова});
            this.DictionaryGridView.Location = new System.Drawing.Point(6, 19);
            this.DictionaryGridView.Name = "DictionaryGridView";
            this.DictionaryGridView.Size = new System.Drawing.Size(448, 227);
            this.DictionaryGridView.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(320, 76);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Очистить все";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(88, 61);
            this.CountBox.Name = "CountBox";
            this.CountBox.ReadOnly = true;
            this.CountBox.Size = new System.Drawing.Size(205, 20);
            this.CountBox.TabIndex = 25;
            // 
            // inputDataGroupBox
            // 
            this.inputDataGroupBox.Controls.Add(this.AddWordButton);
            this.inputDataGroupBox.Controls.Add(this.label2);
            this.inputDataGroupBox.Controls.Add(this.label1);
            this.inputDataGroupBox.Controls.Add(this.ClearButton);
            this.inputDataGroupBox.Controls.Add(this.FindWordsButton);
            this.inputDataGroupBox.Controls.Add(this.WordBox);
            this.inputDataGroupBox.Controls.Add(this.CountBox);
            this.inputDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputDataGroupBox.Name = "inputDataGroupBox";
            this.inputDataGroupBox.Size = new System.Drawing.Size(460, 109);
            this.inputDataGroupBox.TabIndex = 0;
            this.inputDataGroupBox.TabStop = false;
            this.inputDataGroupBox.Text = "Исходные данные";
            // 
            // AddWordButton
            // 
            this.AddWordButton.Location = new System.Drawing.Point(320, 47);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(134, 23);
            this.AddWordButton.TabIndex = 30;
            this.AddWordButton.Text = "Добавить в словарь";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Количество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Слово:";
            // 
            // FindWordsButton
            // 
            this.FindWordsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FindWordsButton.Location = new System.Drawing.Point(320, 19);
            this.FindWordsButton.Name = "FindWordsButton";
            this.FindWordsButton.Size = new System.Drawing.Size(134, 22);
            this.FindWordsButton.TabIndex = 1;
            this.FindWordsButton.Text = "Найти в словаре";
            this.FindWordsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FindWordsButton.UseVisualStyleBackColor = true;
            this.FindWordsButton.Click += new System.EventHandler(this.butFind_Click);
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(88, 35);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(205, 20);
            this.WordBox.TabIndex = 26;
            // 
            // Слова
            // 
            this.Слова.HeaderText = "Слова";
            this.Слова.Name = "Слова";
            this.Слова.Width = 400;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inputDataGroupBox);
            this.MaximumSize = new System.Drawing.Size(860, 600);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainForm";
            this.Text = "Поиск слова в словаре";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryGridView)).EndInit();
            this.inputDataGroupBox.ResumeLayout(false);
            this.inputDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.Button FindWordsButton;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.DataGridView DictionaryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Слова;
    }
}


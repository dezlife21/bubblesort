namespace bubblesort
{
    partial class frmBubbleSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBubbleSort = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.btBubbleSort = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtArray);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация массива";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(268, 173);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(357, 44);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Сгенирировать пустой массив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click_1);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(10, 93);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(127, 26);
            this.txtArray.TabIndex = 1;
            this.txtArray.TextChanged += new System.EventHandler(this.txtArray_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во элементов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBubbleSort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBubbleSort);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 139);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пузырьковая сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Массив после сортировки:";
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.Location = new System.Drawing.Point(185, 85);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.Size = new System.Drawing.Size(454, 26);
            this.txtBubbleSort.TabIndex = 1;
            this.txtBubbleSort.TextChanged += new System.EventHandler(this.txtBubbleSort_TextChanged);
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(166, 17);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 62;
            this.dgvMass.RowTemplate.Height = 28;
            this.dgvMass.Size = new System.Drawing.Size(548, 150);
            this.dgvMass.TabIndex = 3;
            this.dgvMass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMass_CellContentClick);
            // 
            // btBubbleSort
            // 
            this.btBubbleSort.Location = new System.Drawing.Point(20, 46);
            this.btBubbleSort.Name = "btBubbleSort";
            this.btBubbleSort.Size = new System.Drawing.Size(135, 65);
            this.btBubbleSort.TabIndex = 4;
            this.btBubbleSort.Text = "Сортировать";
            this.btBubbleSort.UseVisualStyleBackColor = true;
            this.btBubbleSort.Click += new System.EventHandler(this.btBubbleSort_Click_1);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(307, 395);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(112, 43);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // frmBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBubbleSort";
            this.Text = "Сортировка пузырьком";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBubbleSort;
        private System.Windows.Forms.Button btBubbleSort;
        private System.Windows.Forms.Button btExit;
    }
}


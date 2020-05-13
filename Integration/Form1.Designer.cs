namespace Integration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.initialX_textBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.finalX_textBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.step_textBox = new System.Windows.Forms.ToolStripTextBox();
            this.CreateValueTable_Button = new System.Windows.Forms.ToolStripButton();
            this.function_dataGridView = new System.Windows.Forms.DataGridView();
            this.columnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLeftSquares = new System.Windows.Forms.Button();
            this.LeftSquares_textBox = new System.Windows.Forms.TextBox();
            this.buttonRightSquares = new System.Windows.Forms.Button();
            this.RightSquares_textBox = new System.Windows.Forms.TextBox();
            this.buttonCentralSquares = new System.Windows.Forms.Button();
            this.buttonTrapezeSquares = new System.Windows.Forms.Button();
            this.CentralSquares_textBox = new System.Windows.Forms.TextBox();
            this.TrapezeSquares_textBox = new System.Windows.Forms.TextBox();
            this.button1stDerivation = new System.Windows.Forms.Button();
            this.button2ndDerivation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X_1stDerivation_textBox = new System.Windows.Forms.TextBox();
            this.X_2ndDerivation_textBox = new System.Windows.Forms.TextBox();
            this.FirstDerivation_textBox = new System.Windows.Forms.TextBox();
            this.SecondDerivation_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.function_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.initialX_textBox,
            this.toolStripLabel3,
            this.finalX_textBox,
            this.toolStripLabel1,
            this.step_textBox,
            this.CreateValueTable_Button,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(772, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel2.Text = "Initial x=";
            // 
            // initialX_textBox
            // 
            this.initialX_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.initialX_textBox.Name = "initialX_textBox";
            this.initialX_textBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel3.Text = "Final x=";
            // 
            // finalX_textBox
            // 
            this.finalX_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.finalX_textBox.Name = "finalX_textBox";
            this.finalX_textBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "Number of points=";
            // 
            // step_textBox
            // 
            this.step_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.step_textBox.Name = "step_textBox";
            this.step_textBox.Size = new System.Drawing.Size(100, 25);
            // 
            // CreateValueTable_Button
            // 
            this.CreateValueTable_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreateValueTable_Button.Image = ((System.Drawing.Image)(resources.GetObject("CreateValueTable_Button.Image")));
            this.CreateValueTable_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateValueTable_Button.Name = "CreateValueTable_Button";
            this.CreateValueTable_Button.Size = new System.Drawing.Size(105, 22);
            this.CreateValueTable_Button.Text = "Create value table";
            this.CreateValueTable_Button.Click += new System.EventHandler(this.CreateValueTable_Button_Click);
            // 
            // function_dataGridView
            // 
            this.function_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.function_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnX,
            this.columnY});
            this.function_dataGridView.Location = new System.Drawing.Point(0, 28);
            this.function_dataGridView.Name = "function_dataGridView";
            this.function_dataGridView.Size = new System.Drawing.Size(258, 205);
            this.function_dataGridView.TabIndex = 10;
            // 
            // columnX
            // 
            this.columnX.Frozen = true;
            this.columnX.HeaderText = "X";
            this.columnX.Name = "columnX";
            // 
            // columnY
            // 
            this.columnY.Frozen = true;
            this.columnY.HeaderText = "Y";
            this.columnY.Name = "columnY";
            // 
            // buttonLeftSquares
            // 
            this.buttonLeftSquares.Location = new System.Drawing.Point(406, 78);
            this.buttonLeftSquares.Name = "buttonLeftSquares";
            this.buttonLeftSquares.Size = new System.Drawing.Size(96, 23);
            this.buttonLeftSquares.TabIndex = 11;
            this.buttonLeftSquares.Text = "Left Squares";
            this.buttonLeftSquares.UseVisualStyleBackColor = true;
            this.buttonLeftSquares.Click += new System.EventHandler(this.buttonLeftRectangles_Click);
            // 
            // LeftSquares_textBox
            // 
            this.LeftSquares_textBox.Location = new System.Drawing.Point(508, 80);
            this.LeftSquares_textBox.Name = "LeftSquares_textBox";
            this.LeftSquares_textBox.ReadOnly = true;
            this.LeftSquares_textBox.Size = new System.Drawing.Size(100, 20);
            this.LeftSquares_textBox.TabIndex = 12;
            // 
            // buttonRightSquares
            // 
            this.buttonRightSquares.Location = new System.Drawing.Point(406, 107);
            this.buttonRightSquares.Name = "buttonRightSquares";
            this.buttonRightSquares.Size = new System.Drawing.Size(96, 23);
            this.buttonRightSquares.TabIndex = 13;
            this.buttonRightSquares.Text = "Right Squares";
            this.buttonRightSquares.UseVisualStyleBackColor = true;
            this.buttonRightSquares.Click += new System.EventHandler(this.buttonRightRectangles_Click);
            // 
            // RightSquares_textBox
            // 
            this.RightSquares_textBox.Location = new System.Drawing.Point(508, 110);
            this.RightSquares_textBox.Name = "RightSquares_textBox";
            this.RightSquares_textBox.ReadOnly = true;
            this.RightSquares_textBox.Size = new System.Drawing.Size(100, 20);
            this.RightSquares_textBox.TabIndex = 14;
            // 
            // buttonCentralSquares
            // 
            this.buttonCentralSquares.Location = new System.Drawing.Point(406, 136);
            this.buttonCentralSquares.Name = "buttonCentralSquares";
            this.buttonCentralSquares.Size = new System.Drawing.Size(96, 23);
            this.buttonCentralSquares.TabIndex = 15;
            this.buttonCentralSquares.Text = "Central Squares";
            this.buttonCentralSquares.UseVisualStyleBackColor = true;
            this.buttonCentralSquares.Click += new System.EventHandler(this.buttonCentralRectangles_Click);
            // 
            // buttonTrapezeSquares
            // 
            this.buttonTrapezeSquares.Location = new System.Drawing.Point(406, 165);
            this.buttonTrapezeSquares.Name = "buttonTrapezeSquares";
            this.buttonTrapezeSquares.Size = new System.Drawing.Size(96, 23);
            this.buttonTrapezeSquares.TabIndex = 16;
            this.buttonTrapezeSquares.Text = "Trapeze Squares";
            this.buttonTrapezeSquares.UseVisualStyleBackColor = true;
            this.buttonTrapezeSquares.Click += new System.EventHandler(this.buttonTrapezoidalRule_Click);
            // 
            // CentralSquares_textBox
            // 
            this.CentralSquares_textBox.Location = new System.Drawing.Point(508, 138);
            this.CentralSquares_textBox.Name = "CentralSquares_textBox";
            this.CentralSquares_textBox.ReadOnly = true;
            this.CentralSquares_textBox.Size = new System.Drawing.Size(100, 20);
            this.CentralSquares_textBox.TabIndex = 17;
            // 
            // TrapezeSquares_textBox
            // 
            this.TrapezeSquares_textBox.Location = new System.Drawing.Point(508, 167);
            this.TrapezeSquares_textBox.Name = "TrapezeSquares_textBox";
            this.TrapezeSquares_textBox.ReadOnly = true;
            this.TrapezeSquares_textBox.Size = new System.Drawing.Size(100, 20);
            this.TrapezeSquares_textBox.TabIndex = 18;
            // 
            // button1stDerivation
            // 
            this.button1stDerivation.Location = new System.Drawing.Point(159, 246);
            this.button1stDerivation.Name = "button1stDerivation";
            this.button1stDerivation.Size = new System.Drawing.Size(85, 23);
            this.button1stDerivation.TabIndex = 19;
            this.button1stDerivation.Text = "1st derivative";
            this.button1stDerivation.UseVisualStyleBackColor = true;
            this.button1stDerivation.Click += new System.EventHandler(this.button1stDerivation_Click);
            // 
            // button2ndDerivation
            // 
            this.button2ndDerivation.Location = new System.Drawing.Point(159, 272);
            this.button2ndDerivation.Name = "button2ndDerivation";
            this.button2ndDerivation.Size = new System.Drawing.Size(85, 23);
            this.button2ndDerivation.TabIndex = 20;
            this.button2ndDerivation.Text = "2nd derivative";
            this.button2ndDerivation.UseVisualStyleBackColor = true;
            this.button2ndDerivation.Click += new System.EventHandler(this.button2ndDerivation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "x=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "x=";
            // 
            // X_1stDerivation_textBox
            // 
            this.X_1stDerivation_textBox.Location = new System.Drawing.Point(53, 248);
            this.X_1stDerivation_textBox.Name = "X_1stDerivation_textBox";
            this.X_1stDerivation_textBox.Size = new System.Drawing.Size(100, 20);
            this.X_1stDerivation_textBox.TabIndex = 23;
            // 
            // X_2ndDerivation_textBox
            // 
            this.X_2ndDerivation_textBox.Location = new System.Drawing.Point(53, 274);
            this.X_2ndDerivation_textBox.Name = "X_2ndDerivation_textBox";
            this.X_2ndDerivation_textBox.Size = new System.Drawing.Size(100, 20);
            this.X_2ndDerivation_textBox.TabIndex = 24;
            // 
            // FirstDerivation_textBox
            // 
            this.FirstDerivation_textBox.Location = new System.Drawing.Point(297, 247);
            this.FirstDerivation_textBox.Name = "FirstDerivation_textBox";
            this.FirstDerivation_textBox.ReadOnly = true;
            this.FirstDerivation_textBox.Size = new System.Drawing.Size(100, 20);
            this.FirstDerivation_textBox.TabIndex = 25;
            // 
            // SecondDerivation_textBox
            // 
            this.SecondDerivation_textBox.Location = new System.Drawing.Point(297, 278);
            this.SecondDerivation_textBox.Name = "SecondDerivation_textBox";
            this.SecondDerivation_textBox.ReadOnly = true;
            this.SecondDerivation_textBox.Size = new System.Drawing.Size(100, 20);
            this.SecondDerivation_textBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(256, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "f\'(x)=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "f\'\'(x)=";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton1.Text = "Load value table";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondDerivation_textBox);
            this.Controls.Add(this.FirstDerivation_textBox);
            this.Controls.Add(this.X_2ndDerivation_textBox);
            this.Controls.Add(this.X_1stDerivation_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2ndDerivation);
            this.Controls.Add(this.button1stDerivation);
            this.Controls.Add(this.TrapezeSquares_textBox);
            this.Controls.Add(this.CentralSquares_textBox);
            this.Controls.Add(this.buttonTrapezeSquares);
            this.Controls.Add(this.buttonCentralSquares);
            this.Controls.Add(this.RightSquares_textBox);
            this.Controls.Add(this.buttonRightSquares);
            this.Controls.Add(this.LeftSquares_textBox);
            this.Controls.Add(this.buttonLeftSquares);
            this.Controls.Add(this.function_dataGridView);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.function_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox initialX_textBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox finalX_textBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox step_textBox;
        private System.Windows.Forms.ToolStripButton CreateValueTable_Button;
        private System.Windows.Forms.DataGridView function_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnY;
        private System.Windows.Forms.Button buttonLeftSquares;
        private System.Windows.Forms.TextBox LeftSquares_textBox;
        private System.Windows.Forms.Button buttonRightSquares;
        private System.Windows.Forms.TextBox RightSquares_textBox;
        private System.Windows.Forms.Button buttonCentralSquares;
        private System.Windows.Forms.Button buttonTrapezeSquares;
        private System.Windows.Forms.TextBox CentralSquares_textBox;
        private System.Windows.Forms.TextBox TrapezeSquares_textBox;
        private System.Windows.Forms.Button button1stDerivation;
        private System.Windows.Forms.Button button2ndDerivation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X_1stDerivation_textBox;
        private System.Windows.Forms.TextBox X_2ndDerivation_textBox;
        private System.Windows.Forms.TextBox FirstDerivation_textBox;
        private System.Windows.Forms.TextBox SecondDerivation_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


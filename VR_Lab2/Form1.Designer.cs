namespace VR_Lab2
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
            this.openFile_button = new System.Windows.Forms.Button();
            this.fileStatus_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.single_textBox = new System.Windows.Forms.TextBox();
            this.RLE_textBox = new System.Windows.Forms.TextBox();
            this.Haffman_textBox = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile_button
            // 
            this.openFile_button.AutoSize = true;
            this.openFile_button.Location = new System.Drawing.Point(12, 12);
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(122, 39);
            this.openFile_button.TabIndex = 0;
            this.openFile_button.Text = "Открыть";
            this.openFile_button.UseVisualStyleBackColor = true;
            this.openFile_button.Click += new System.EventHandler(this.openFile_button_Click);
            // 
            // fileStatus_label
            // 
            this.fileStatus_label.AutoSize = true;
            this.fileStatus_label.Location = new System.Drawing.Point(140, 17);
            this.fileStatus_label.Name = "fileStatus_label";
            this.fileStatus_label.Size = new System.Drawing.Size(198, 29);
            this.fileStatus_label.TabIndex = 1;
            this.fileStatus_label.Text = "Файл не выбран";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 601);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.input_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Исходный массив";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.single_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Одномерный массив";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RLE_textBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RLE сжатие";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Haffman_textBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(877, 560);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сжатие Хаффмана";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(6, 6);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(865, 548);
            this.input_textBox.TabIndex = 0;
            // 
            // single_textBox
            // 
            this.single_textBox.Location = new System.Drawing.Point(6, 6);
            this.single_textBox.Multiline = true;
            this.single_textBox.Name = "single_textBox";
            this.single_textBox.Size = new System.Drawing.Size(865, 548);
            this.single_textBox.TabIndex = 0;
            // 
            // RLE_textBox
            // 
            this.RLE_textBox.Location = new System.Drawing.Point(6, 6);
            this.RLE_textBox.Multiline = true;
            this.RLE_textBox.Name = "RLE_textBox";
            this.RLE_textBox.Size = new System.Drawing.Size(865, 548);
            this.RLE_textBox.TabIndex = 0;
            // 
            // Haffman_textBox
            // 
            this.Haffman_textBox.Location = new System.Drawing.Point(6, 6);
            this.Haffman_textBox.Multiline = true;
            this.Haffman_textBox.Name = "Haffman_textBox";
            this.Haffman_textBox.Size = new System.Drawing.Size(865, 548);
            this.Haffman_textBox.TabIndex = 0;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(17, 668);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(27, 29);
            this.result_label.TabIndex = 3;
            this.result_label.Text = "--";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 720);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fileStatus_label);
            this.Controls.Add(this.openFile_button);
            this.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа 2";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFile_button;
        private System.Windows.Forms.Label fileStatus_label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox single_textBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox RLE_textBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox Haffman_textBox;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


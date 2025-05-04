namespace laba_6
{
    partial class MainForm
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
            buttonFunc = new Button();
            buttonGetTime = new Button();
            button = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // buttonFunc
            // 
            buttonFunc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFunc.Location = new Point(88, 21);
            buttonFunc.Name = "buttonFunc";
            buttonFunc.Size = new Size(257, 47);
            buttonFunc.TabIndex = 0;
            buttonFunc.Text = "Найти среднее значение вектора";
            buttonFunc.UseVisualStyleBackColor = true;
            // 
            // buttonGetTime
            // 
            buttonGetTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGetTime.Location = new Point(108, 107);
            buttonGetTime.Name = "buttonGetTime";
            buttonGetTime.Size = new Size(215, 47);
            buttonGetTime.TabIndex = 0;
            buttonGetTime.Text = "Вывести системное время";
            buttonGetTime.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(108, 190);
            button.Name = "button";
            button.Size = new Size(215, 47);
            button.TabIndex = 1;
            button.Text = "Вычислить факториал";
            button.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(108, 279);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(215, 29);
            numericUpDown1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 349);
            Controls.Add(numericUpDown1);
            Controls.Add(button);
            Controls.Add(buttonGetTime);
            Controls.Add(buttonFunc);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа №6";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFunc;
        private Button buttonGetTime;
        private Button button;
        private NumericUpDown numericUpDown1;
    }
}

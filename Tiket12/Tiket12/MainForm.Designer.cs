namespace Tiket12
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
            CountButton = new Button();
            label1 = new Label();
            MainTextBox = new TextBox();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // CountButton
            // 
            CountButton.Location = new Point(12, 56);
            CountButton.Name = "CountButton";
            CountButton.Size = new Size(100, 23);
            CountButton.TabIndex = 0;
            CountButton.Text = "Подсчитать";
            CountButton.UseVisualStyleBackColor = true;
            CountButton.Click += CountButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите выражение";
            // 
            // MainTextBox
            // 
            MainTextBox.Location = new Point(12, 27);
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(100, 23);
            MainTextBox.TabIndex = 2;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(12, 82);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 15);
            ResultLabel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 183);
            Controls.Add(ResultLabel);
            Controls.Add(MainTextBox);
            Controls.Add(label1);
            Controls.Add(CountButton);
            Name = "MainForm";
            Text = "Главная";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CountButton;
        private Label label1;
        private TextBox MainTextBox;
        private Label ResultLabel;
    }
}

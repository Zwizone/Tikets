namespace Tiket_11
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
            StringTextBox = new TextBox();
            VowelsLabel = new Label();
            ConsonantsLabel = new Label();
            NumbersLabel = new Label();
            MarksLabel = new Label();
            SpaceLabel = new Label();
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
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите строку";
            // 
            // StringTextBox
            // 
            StringTextBox.Location = new Point(12, 27);
            StringTextBox.Name = "StringTextBox";
            StringTextBox.Size = new Size(100, 23);
            StringTextBox.TabIndex = 2;
            // 
            // VowelsLabel
            // 
            VowelsLabel.AutoSize = true;
            VowelsLabel.Location = new Point(12, 82);
            VowelsLabel.Name = "VowelsLabel";
            VowelsLabel.Size = new Size(0, 15);
            VowelsLabel.TabIndex = 3;
            // 
            // ConsonantsLabel
            // 
            ConsonantsLabel.AutoSize = true;
            ConsonantsLabel.Location = new Point(12, 97);
            ConsonantsLabel.Name = "ConsonantsLabel";
            ConsonantsLabel.Size = new Size(0, 15);
            ConsonantsLabel.TabIndex = 4;
            // 
            // NumbersLabel
            // 
            NumbersLabel.AutoSize = true;
            NumbersLabel.Location = new Point(12, 112);
            NumbersLabel.Name = "NumbersLabel";
            NumbersLabel.Size = new Size(0, 15);
            NumbersLabel.TabIndex = 5;
            // 
            // MarksLabel
            // 
            MarksLabel.AutoSize = true;
            MarksLabel.Location = new Point(12, 127);
            MarksLabel.Name = "MarksLabel";
            MarksLabel.Size = new Size(0, 15);
            MarksLabel.TabIndex = 6;
            // 
            // SpaceLabel
            // 
            SpaceLabel.AutoSize = true;
            SpaceLabel.Location = new Point(12, 142);
            SpaceLabel.Name = "SpaceLabel";
            SpaceLabel.Size = new Size(0, 15);
            SpaceLabel.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 196);
            Controls.Add(SpaceLabel);
            Controls.Add(MarksLabel);
            Controls.Add(NumbersLabel);
            Controls.Add(ConsonantsLabel);
            Controls.Add(VowelsLabel);
            Controls.Add(StringTextBox);
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
        private TextBox StringTextBox;
        private Label VowelsLabel;
        private Label ConsonantsLabel;
        private Label NumbersLabel;
        private Label MarksLabel;
        private Label SpaceLabel;
    }
}

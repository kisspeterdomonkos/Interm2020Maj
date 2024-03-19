namespace sudokuGUI
{
    partial class sudokuGUI
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
            label1 = new Label();
            label2 = new Label();
            minusButton = new Button();
            plusButton = new Button();
            sizeTextBox = new TextBox();
            stateTextBox = new TextBox();
            resultButton = new Button();
            sizeLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Új feladvány mérete:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Kezdőállapot:";
            // 
            // minusButton
            // 
            minusButton.Location = new Point(151, 22);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(27, 25);
            minusButton.TabIndex = 2;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(230, 22);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(27, 25);
            plusButton.TabIndex = 2;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // sizeTextBox
            // 
            sizeTextBox.Location = new Point(184, 22);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.ReadOnly = true;
            sizeTextBox.Size = new Size(40, 23);
            sizeTextBox.TabIndex = 3;
            sizeTextBox.Text = "4";
            sizeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(11, 103);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(501, 23);
            stateTextBox.TabIndex = 4;
            stateTextBox.TextChanged += stateTextBox_TextChanged_1;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(437, 136);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(75, 23);
            resultButton.TabIndex = 5;
            resultButton.Text = "ellenőrzés";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(11, 140);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(50, 15);
            sizeLabel.TabIndex = 6;
            sizeLabel.Text = "Hossz: 0";
            // 
            // sudokuGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 171);
            Controls.Add(sizeLabel);
            Controls.Add(resultButton);
            Controls.Add(stateTextBox);
            Controls.Add(sizeTextBox);
            Controls.Add(plusButton);
            Controls.Add(minusButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sudokuGUI";
            Text = "Sudoku-ellenőrző";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button minusButton;
        private Button plusButton;
        private TextBox sizeTextBox;
        private TextBox stateTextBox;
        private Button resultButton;
        private Label sizeLabel;
    }
}

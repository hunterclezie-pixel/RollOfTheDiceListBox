namespace RollOfTheDiceListBox
{
    partial class RollOfTheDiceListBoxForm1
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
            RollOfTheDiceLabel = new Label();
            RollButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // RollOfTheDiceLabel
            // 
            RollOfTheDiceLabel.AutoSize = true;
            RollOfTheDiceLabel.Location = new Point(316, 103);
            RollOfTheDiceLabel.Name = "RollOfTheDiceLabel";
            RollOfTheDiceLabel.Size = new Size(117, 20);
            RollOfTheDiceLabel.TabIndex = 0;
            RollOfTheDiceLabel.Text = "Roll Of The Dice";
            // 
            // RollButton
            // 
            RollButton.Location = new Point(383, 378);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(131, 60);
            RollButton.TabIndex = 1;
            RollButton.Text = "Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(520, 378);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(131, 60);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(657, 378);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 60);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RollOfTheDiceListBoxForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(RollButton);
            Controls.Add(RollOfTheDiceLabel);
            Name = "RollOfTheDiceListBoxForm1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RollOfTheDiceLabel;
        private Button RollButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}

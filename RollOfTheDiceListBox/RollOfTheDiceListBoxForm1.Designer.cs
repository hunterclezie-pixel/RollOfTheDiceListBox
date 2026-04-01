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
            RollButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            RollOfTheDiceListBox1 = new ListBox();
            SuspendLayout();
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
            // RollOfTheDiceListBox1
            // 
            RollOfTheDiceListBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RollOfTheDiceListBox1.Location = new Point(37, 29);
            RollOfTheDiceListBox1.Name = "RollOfTheDiceListBox1";
            RollOfTheDiceListBox1.Size = new Size(732, 238);
            RollOfTheDiceListBox1.TabIndex = 0;
            // 
            // RollOfTheDiceListBoxForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RollOfTheDiceListBox1);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(RollButton);
            Name = "RollOfTheDiceListBoxForm1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button RollButton;
        private Button ClearButton;
        private Button ExitButton;
        private ListBox RollOfTheDiceListBox1;
    }
}

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
            components = new System.ComponentModel.Container();
            RollButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            RollOfTheDiceListBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            rollToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RollButton
            // 
            RollButton.Location = new Point(383, 378);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(131, 60);
            RollButton.TabIndex = 1;
            RollButton.Text = "Roll";
            toolTip1.SetToolTip(RollButton, "Rolls dice");
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
            toolTip1.SetToolTip(ClearButton, "Clears list");
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
            toolTip1.SetToolTip(ExitButton, "Exit");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RollOfTheDiceListBox1
            // 
            RollOfTheDiceListBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RollOfTheDiceListBox1.Location = new Point(32, 85);
            RollOfTheDiceListBox1.Name = "RollOfTheDiceListBox1";
            RollOfTheDiceListBox1.Size = new Size(732, 238);
            RollOfTheDiceListBox1.TabIndex = 0;
            toolTip1.SetToolTip(RollOfTheDiceListBox1, "List of dice simulator");
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rollToolStripMenuItem, clearToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // rollToolStripMenuItem
            // 
            rollToolStripMenuItem.Name = "rollToolStripMenuItem";
            rollToolStripMenuItem.Size = new Size(224, 26);
            rollToolStripMenuItem.Text = "Roll";
            rollToolStripMenuItem.ToolTipText = "Rolls dice";
            rollToolStripMenuItem.Click += rollToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(224, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.ToolTipText = "Clears list";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.ToolTipText = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.ToolTipText = "Help menu";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RollOfTheDiceListBoxForm1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button RollButton;
        private Button ClearButton;
        private Button ExitButton;
        private ListBox RollOfTheDiceListBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem rollToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolTip toolTip1;
    }
}

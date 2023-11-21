namespace FoodRecipeManager
{
    partial class Form1
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
            NavigationBar = new FlowLayoutPanel();
            MainPanel = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            NavigationBar.SuspendLayout();
            MainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationBar
            // 
            NavigationBar.BackColor = SystemColors.AppWorkspace;
            NavigationBar.Controls.Add(panel1);
            NavigationBar.Controls.Add(panel2);
            NavigationBar.Dock = DockStyle.Left;
            NavigationBar.Location = new Point(0, 0);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.Size = new Size(176, 627);
            NavigationBar.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(button3);
            MainPanel.Controls.Add(flowLayoutPanel1);
            MainPanel.Dock = DockStyle.Right;
            MainPanel.Location = new Point(182, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(869, 627);
            MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 46);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-12, -3);
            button1.Name = "button1";
            button1.Size = new Size(192, 60);
            button1.TabIndex = 1;
            button1.Text = "My Recipes";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 46);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-3, -9);
            button2.Name = "button2";
            button2.Size = new Size(176, 64);
            button2.TabIndex = 1;
            button2.Text = "Discover ";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Location = new Point(127, 139);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(723, 459);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(126, 111);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 627);
            Controls.Add(MainPanel);
            Controls.Add(NavigationBar);
            Name = "Form1";
            NavigationBar.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel NavigationBar;
        private Panel MainPanel;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
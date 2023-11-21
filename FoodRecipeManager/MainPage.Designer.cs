namespace FoodRecipeManager
{
    partial class MainPage
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            MainPanel = new Panel();
            NavigationBar.SuspendLayout();
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
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Right;
            MainPanel.Location = new Point(182, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(869, 627);
            MainPanel.TabIndex = 1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 627);
            Controls.Add(MainPanel);
            Controls.Add(NavigationBar);
            Name = "MainPage";
            Load += MainPage_Load;
            NavigationBar.ResumeLayout(false);
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
    }
}
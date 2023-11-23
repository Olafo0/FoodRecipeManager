namespace FoodRecipeManager
{
    partial class ViewYourRecipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewYourRecipes));
            AddNewRecipe = new Button();
            RecipeViewer = new FlowLayoutPanel();
            AddRecipePanel = new Panel();
            CreateNewRecipe = new Button();
            groupBox1 = new GroupBox();
            IconRB3 = new RadioButton();
            IconRB2 = new RadioButton();
            IconRB1 = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RecipeDetailsGB = new GroupBox();
            FoodTypeCB = new ComboBox();
            label4 = new Label();
            StarPB = new PictureBox();
            label3 = new Label();
            RatingCB = new ComboBox();
            AuthorNameTB = new TextBox();
            RecipesNameTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            AddingIngreBTN = new Button();
            AddIndegrientsGB = new GroupBox();
            FormsMainPanel = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AddRecipePanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            RecipeDetailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StarPB).BeginInit();
            FormsMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewRecipe
            // 
            AddNewRecipe.BackColor = SystemColors.MenuHighlight;
            AddNewRecipe.FlatStyle = FlatStyle.Flat;
            AddNewRecipe.ForeColor = SystemColors.ButtonHighlight;
            AddNewRecipe.Location = new Point(134, 136);
            AddNewRecipe.Name = "AddNewRecipe";
            AddNewRecipe.Size = new Size(75, 23);
            AddNewRecipe.TabIndex = 3;
            AddNewRecipe.Text = "Create";
            AddNewRecipe.UseVisualStyleBackColor = false;
            AddNewRecipe.Click += AddNewRecipe_Click;
            // 
            // RecipeViewer
            // 
            RecipeViewer.AutoScroll = true;
            RecipeViewer.BackColor = SystemColors.ActiveCaption;
            RecipeViewer.Location = new Point(134, 166);
            RecipeViewer.Name = "RecipeViewer";
            RecipeViewer.Size = new Size(714, 420);
            RecipeViewer.TabIndex = 2;
            // 
            // AddRecipePanel
            // 
            AddRecipePanel.BackColor = SystemColors.ControlLightLight;
            AddRecipePanel.Controls.Add(CreateNewRecipe);
            AddRecipePanel.Controls.Add(groupBox1);
            AddRecipePanel.Controls.Add(RecipeDetailsGB);
            AddRecipePanel.Controls.Add(AddingIngreBTN);
            AddRecipePanel.Controls.Add(AddIndegrientsGB);
            AddRecipePanel.Location = new Point(999, 0);
            AddRecipePanel.Name = "AddRecipePanel";
            AddRecipePanel.Size = new Size(648, 628);
            AddRecipePanel.TabIndex = 4;
            AddRecipePanel.Visible = false;
            // 
            // CreateNewRecipe
            // 
            CreateNewRecipe.FlatStyle = FlatStyle.Flat;
            CreateNewRecipe.Location = new Point(283, 591);
            CreateNewRecipe.Name = "CreateNewRecipe";
            CreateNewRecipe.Size = new Size(105, 23);
            CreateNewRecipe.TabIndex = 8;
            CreateNewRecipe.Text = "Add Recipe";
            CreateNewRecipe.UseVisualStyleBackColor = true;
            CreateNewRecipe.Click += CreateNewRecipe_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IconRB3);
            groupBox1.Controls.Add(IconRB2);
            groupBox1.Controls.Add(IconRB1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 137);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Icon selector";
            // 
            // IconRB3
            // 
            IconRB3.AutoSize = true;
            IconRB3.Location = new Point(302, 104);
            IconRB3.Name = "IconRB3";
            IconRB3.Size = new Size(67, 24);
            IconRB3.TabIndex = 5;
            IconRB3.TabStop = true;
            IconRB3.Text = "Icon 3";
            IconRB3.UseVisualStyleBackColor = true;
            // 
            // IconRB2
            // 
            IconRB2.AutoSize = true;
            IconRB2.Location = new Point(185, 103);
            IconRB2.Name = "IconRB2";
            IconRB2.Size = new Size(67, 24);
            IconRB2.TabIndex = 4;
            IconRB2.TabStop = true;
            IconRB2.Text = "Icon 2";
            IconRB2.UseVisualStyleBackColor = true;
            // 
            // IconRB1
            // 
            IconRB1.AutoSize = true;
            IconRB1.Location = new Point(65, 105);
            IconRB1.Name = "IconRB1";
            IconRB1.Size = new Size(67, 24);
            IconRB1.TabIndex = 3;
            IconRB1.TabStop = true;
            IconRB1.Text = "Icon 1";
            IconRB1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(297, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 73);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(177, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 73);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(58, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 73);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RecipeDetailsGB
            // 
            RecipeDetailsGB.Controls.Add(FoodTypeCB);
            RecipeDetailsGB.Controls.Add(label4);
            RecipeDetailsGB.Controls.Add(StarPB);
            RecipeDetailsGB.Controls.Add(label3);
            RecipeDetailsGB.Controls.Add(RatingCB);
            RecipeDetailsGB.Controls.Add(AuthorNameTB);
            RecipeDetailsGB.Controls.Add(RecipesNameTB);
            RecipeDetailsGB.Controls.Add(label2);
            RecipeDetailsGB.Controls.Add(label1);
            RecipeDetailsGB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeDetailsGB.Location = new Point(19, 26);
            RecipeDetailsGB.Name = "RecipeDetailsGB";
            RecipeDetailsGB.Size = new Size(600, 184);
            RecipeDetailsGB.TabIndex = 2;
            RecipeDetailsGB.TabStop = false;
            RecipeDetailsGB.Text = "Recipe Details";
            // 
            // FoodTypeCB
            // 
            FoodTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FoodTypeCB.FormattingEnabled = true;
            FoodTypeCB.Items.AddRange(new object[] { "Main dish", "Side dish", "Dessert", "Appetisers", "Soups", "Salads" });
            FoodTypeCB.Location = new Point(269, 31);
            FoodTypeCB.Name = "FoodTypeCB";
            FoodTypeCB.Size = new Size(104, 28);
            FoodTypeCB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(226, 38);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Type :";
            // 
            // StarPB
            // 
            StarPB.BackgroundImage = (Image)resources.GetObject("StarPB.BackgroundImage");
            StarPB.BackgroundImageLayout = ImageLayout.Stretch;
            StarPB.Location = new Point(285, 97);
            StarPB.Name = "StarPB";
            StarPB.Size = new Size(195, 35);
            StarPB.TabIndex = 6;
            StarPB.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 107);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Rating :";
            // 
            // RatingCB
            // 
            RatingCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RatingCB.FormattingEnabled = true;
            RatingCB.Items.AddRange(new object[] { "5", "4", "3", "2", "1", "0" });
            RatingCB.Location = new Point(116, 101);
            RatingCB.Name = "RatingCB";
            RatingCB.Size = new Size(100, 28);
            RatingCB.TabIndex = 4;
            // 
            // AuthorNameTB
            // 
            AuthorNameTB.Location = new Point(474, 33);
            AuthorNameTB.Name = "AuthorNameTB";
            AuthorNameTB.Size = new Size(100, 27);
            AuthorNameTB.TabIndex = 3;
            // 
            // RecipesNameTB
            // 
            RecipesNameTB.Location = new Point(116, 33);
            RecipesNameTB.Name = "RecipesNameTB";
            RecipesNameTB.Size = new Size(100, 27);
            RecipesNameTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(415, 38);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Author :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Recipe Name : ";
            // 
            // AddingIngreBTN
            // 
            AddingIngreBTN.FlatStyle = FlatStyle.Flat;
            AddingIngreBTN.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddingIngreBTN.Location = new Point(19, 359);
            AddingIngreBTN.Name = "AddingIngreBTN";
            AddingIngreBTN.Size = new Size(111, 25);
            AddingIngreBTN.TabIndex = 1;
            AddingIngreBTN.Text = "+ Add Ingredient";
            AddingIngreBTN.UseVisualStyleBackColor = true;
            AddingIngreBTN.Click += AddingIngreBTN_Click;
            // 
            // AddIndegrientsGB
            // 
            AddIndegrientsGB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddIndegrientsGB.Location = new Point(19, 390);
            AddIndegrientsGB.Name = "AddIndegrientsGB";
            AddIndegrientsGB.Size = new Size(600, 195);
            AddIndegrientsGB.TabIndex = 0;
            AddIndegrientsGB.TabStop = false;
            AddIndegrientsGB.Text = "Ingredients";
            // 
            // FormsMainPanel
            // 
            FormsMainPanel.Controls.Add(AddNewRecipe);
            FormsMainPanel.Controls.Add(AddRecipePanel);
            FormsMainPanel.Controls.Add(RecipeViewer);
            FormsMainPanel.Location = new Point(0, 0);
            FormsMainPanel.Name = "FormsMainPanel";
            FormsMainPanel.Size = new Size(869, 628);
            FormsMainPanel.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ViewYourRecipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 627);
            Controls.Add(FormsMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewYourRecipes";
            Text = "ViewYourRecipes";
            AddRecipePanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            RecipeDetailsGB.ResumeLayout(false);
            RecipeDetailsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StarPB).EndInit();
            FormsMainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddNewRecipe;
        private FlowLayoutPanel RecipeViewer;
        private Panel AddRecipePanel;
        private GroupBox AddIndegrientsGB;
        private GroupBox RecipeDetailsGB;
        private Button AddingIngreBTN;
        private Label label2;
        private Label label1;
        private TextBox AuthorNameTB;
        private TextBox RecipesNameTB;
        private Label label3;
        private ComboBox RatingCB;
        private PictureBox StarPB;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox FoodTypeCB;
        private Label label4;
        private Button CreateNewRecipe;
        private RadioButton IconRB3;
        private RadioButton IconRB2;
        private RadioButton IconRB1;
        private Panel FormsMainPanel;
        private ContextMenuStrip contextMenuStrip1;
    }
}
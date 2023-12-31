﻿namespace FoodRecipeManager
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
            CloseAddRecipePanel = new Button();
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
            ViewingRecipePanel = new Panel();
            CloseViewPanelBTN = new Button();
            groupBox2 = new GroupBox();
            RatingViewGB = new GroupBox();
            RaingPicBoxView = new PictureBox();
            RatingViewLB = new Label();
            label14 = new Label();
            RDViewGB = new GroupBox();
            AuthorViewLB = new Label();
            TypeViewLB = new Label();
            label8 = new Label();
            label7 = new Label();
            RecipeNameViewLB = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AddRecipePanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            RecipeDetailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StarPB).BeginInit();
            FormsMainPanel.SuspendLayout();
            ViewingRecipePanel.SuspendLayout();
            RatingViewGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RaingPicBoxView).BeginInit();
            RDViewGB.SuspendLayout();
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
            AddRecipePanel.Controls.Add(CloseAddRecipePanel);
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
            // CloseAddRecipePanel
            // 
            CloseAddRecipePanel.BackColor = Color.LightCoral;
            CloseAddRecipePanel.FlatStyle = FlatStyle.Flat;
            CloseAddRecipePanel.Location = new Point(574, 3);
            CloseAddRecipePanel.Name = "CloseAddRecipePanel";
            CloseAddRecipePanel.Size = new Size(74, 26);
            CloseAddRecipePanel.TabIndex = 9;
            CloseAddRecipePanel.Text = "Close";
            CloseAddRecipePanel.UseVisualStyleBackColor = false;
            CloseAddRecipePanel.Click += CloseAddRecipePanel_Click;
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
            FormsMainPanel.Controls.Add(ViewingRecipePanel);
            FormsMainPanel.Controls.Add(AddNewRecipe);
            FormsMainPanel.Controls.Add(AddRecipePanel);
            FormsMainPanel.Controls.Add(RecipeViewer);
            FormsMainPanel.Location = new Point(-1, -3);
            FormsMainPanel.Name = "FormsMainPanel";
            FormsMainPanel.Size = new Size(870, 631);
            FormsMainPanel.TabIndex = 5;
            FormsMainPanel.Paint += FormsMainPanel_Paint;
            // 
            // ViewingRecipePanel
            // 
            ViewingRecipePanel.BackColor = SystemColors.ControlLightLight;
            ViewingRecipePanel.Controls.Add(CloseViewPanelBTN);
            ViewingRecipePanel.Controls.Add(groupBox2);
            ViewingRecipePanel.Controls.Add(RatingViewGB);
            ViewingRecipePanel.Controls.Add(RDViewGB);
            ViewingRecipePanel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewingRecipePanel.Location = new Point(999, 0);
            ViewingRecipePanel.Name = "ViewingRecipePanel";
            ViewingRecipePanel.Size = new Size(600, 577);
            ViewingRecipePanel.TabIndex = 5;
            ViewingRecipePanel.Visible = false;
            // 
            // CloseViewPanelBTN
            // 
            CloseViewPanelBTN.BackColor = Color.LightCoral;
            CloseViewPanelBTN.FlatStyle = FlatStyle.Flat;
            CloseViewPanelBTN.Location = new Point(526, 0);
            CloseViewPanelBTN.Name = "CloseViewPanelBTN";
            CloseViewPanelBTN.Size = new Size(74, 26);
            CloseViewPanelBTN.TabIndex = 10;
            CloseViewPanelBTN.Text = "Close";
            CloseViewPanelBTN.UseVisualStyleBackColor = false;
            CloseViewPanelBTN.Click += CloseViewPanelBTN_Click;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 359);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(568, 201);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingredients";
            // 
            // RatingViewGB
            // 
            RatingViewGB.Controls.Add(RaingPicBoxView);
            RatingViewGB.Controls.Add(RatingViewLB);
            RatingViewGB.Controls.Add(label14);
            RatingViewGB.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RatingViewGB.Location = new Point(280, 216);
            RatingViewGB.Name = "RatingViewGB";
            RatingViewGB.Size = new Size(306, 137);
            RatingViewGB.TabIndex = 4;
            RatingViewGB.TabStop = false;
            RatingViewGB.Text = "Rating";
            // 
            // RaingPicBoxView
            // 
            RaingPicBoxView.Location = new Point(46, 73);
            RaingPicBoxView.Name = "RaingPicBoxView";
            RaingPicBoxView.Size = new Size(217, 42);
            RaingPicBoxView.TabIndex = 2;
            RaingPicBoxView.TabStop = false;
            // 
            // RatingViewLB
            // 
            RatingViewLB.AutoSize = true;
            RatingViewLB.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RatingViewLB.Location = new Point(112, 34);
            RatingViewLB.Name = "RatingViewLB";
            RatingViewLB.Size = new Size(38, 15);
            RatingViewLB.TabIndex = 1;
            RatingViewLB.Text = "label6";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(26, 32);
            label14.Name = "label14";
            label14.Size = new Size(63, 17);
            label14.TabIndex = 0;
            label14.Text = "Rating-> ";
            // 
            // RDViewGB
            // 
            RDViewGB.Controls.Add(AuthorViewLB);
            RDViewGB.Controls.Add(TypeViewLB);
            RDViewGB.Controls.Add(label8);
            RDViewGB.Controls.Add(label7);
            RDViewGB.Controls.Add(RecipeNameViewLB);
            RDViewGB.Controls.Add(label5);
            RDViewGB.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RDViewGB.Location = new Point(18, 216);
            RDViewGB.Name = "RDViewGB";
            RDViewGB.Size = new Size(237, 137);
            RDViewGB.TabIndex = 0;
            RDViewGB.TabStop = false;
            RDViewGB.Text = "Recipe Details";
            // 
            // AuthorViewLB
            // 
            AuthorViewLB.AutoSize = true;
            AuthorViewLB.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorViewLB.Location = new Point(149, 101);
            AuthorViewLB.Name = "AuthorViewLB";
            AuthorViewLB.Size = new Size(38, 15);
            AuthorViewLB.TabIndex = 3;
            AuthorViewLB.Text = "label6";
            // 
            // TypeViewLB
            // 
            TypeViewLB.AutoSize = true;
            TypeViewLB.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TypeViewLB.Location = new Point(149, 67);
            TypeViewLB.Name = "TypeViewLB";
            TypeViewLB.Size = new Size(38, 15);
            TypeViewLB.TabIndex = 3;
            TypeViewLB.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 98);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 2;
            label8.Text = "Author - >";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 65);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 2;
            label7.Text = "Type -> ";
            // 
            // RecipeNameViewLB
            // 
            RecipeNameViewLB.AutoSize = true;
            RecipeNameViewLB.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeNameViewLB.Location = new Point(149, 34);
            RecipeNameViewLB.Name = "RecipeNameViewLB";
            RecipeNameViewLB.Size = new Size(38, 15);
            RecipeNameViewLB.TabIndex = 1;
            RecipeNameViewLB.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 32);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 0;
            label5.Text = "Name -> ";
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
            Load += ViewYourRecipes_Load;
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
            ViewingRecipePanel.ResumeLayout(false);
            RatingViewGB.ResumeLayout(false);
            RatingViewGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RaingPicBoxView).EndInit();
            RDViewGB.ResumeLayout(false);
            RDViewGB.PerformLayout();
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
        private Button CloseAddRecipePanel;
        private Panel ViewingRecipePanel;
        private GroupBox RDViewGB;
        private Label label5;
        private Label RecipeNameViewLB;
        private GroupBox RatingViewGB;
        private Label label14;
        private Label AuthorViewLB;
        private Label TypeViewLB;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private PictureBox RaingPicBoxView;
        private Label RatingViewLB;
        private Button CloseViewPanelBTN;
    }
}
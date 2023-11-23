using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecipeManager
{
    public partial class ViewYourRecipes : Form
    {

        int CurrentPagesMade = 0;


        // Ingredient buttons
        int xPosOfIngBtn = 6;
        int yPosOfIngBtn = 26;
        int TBforIngr = 0;




        public ViewYourRecipes()
        {
            InitializeComponent();
        }

        private void AddNewRecipe_Click(object sender, EventArgs e)
        {
            // Making the Panel viewable
            FormsMainPanel.Visible = true;
            AddRecipePanel.Location = new(145, 0);
            AddRecipePanel.Visible = true;
            AddRecipePanel.BringToFront();
        }

        private void CreateNewRecipe_Click(object sender, EventArgs e)
        {
            int TextBoxesInGB = AddIndegrientsGB.Controls.Count;

            if (TextBoxesInGB == 0)
            {
                MessageBox.Show("You've not added any Ingredients to your recipe", "Ingredient ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Resetting the x and y postions for the TB
                xPosOfIngBtn = 6;
                yPosOfIngBtn = 26;

                // Removing the TB
                for (int i = TextBoxesInGB - 1; i >= 0; i--)
                {
                    AddIndegrientsGB.Controls.Remove(AddIndegrientsGB.Controls[i]);
                }

                string RecipeTitle = RecipesNameTB.Text;
                string FoodType = FoodTypeCB.Text;
                string AuthorName = AuthorNameTB.Text;
                int Rating = int.Parse(RatingCB.Text);


                RecipesNameTB.Text = "";
                FoodTypeCB.SelectedItem = null;
                AuthorNameTB.Text = "";
                RatingCB.SelectedItem = null;
                // Rating stars 
                // here
                // - - - - - 
                IconRB1.Checked = false;
                IconRB2.Checked = false;
                IconRB3.Checked = false;


                // Making a small viewable 
                Panel newPanel = new Panel();
                newPanel.Size = new Size(200, 195);
                newPanel.Name = "RecipePanel" + CurrentPagesMade;
                newPanel.BackColor = Color.White;

                Button btn = new Button();
                btn.Name = "RecipeViewBtn" + CurrentPagesMade;
                btn.Text = "Temp";
                btn.Location = new(20, 70);
                newPanel.Controls.Add(btn);

                Label Ratinglabel = new Label();
                Ratinglabel.Text = "Rating :";
                Ratinglabel.Location = new(10, 160);
                newPanel.Controls.Add(Ratinglabel);

                Label Titlelabel = new Label();
                Titlelabel.Name = "RecipeTitleLabel" + CurrentPagesMade;
                Titlelabel.Text = RecipeTitle;

                if (RecipeTitle.Length > 25)
                {
                    Titlelabel.AutoEllipsis = true;
                    Titlelabel.AutoSize = false;
                }
                else
                {
                    Titlelabel.AutoEllipsis = false;
                    Titlelabel.AutoSize = true;
                }
                Titlelabel.Location = new(10, 110);
                newPanel.Controls.Add(Titlelabel);

                CurrentPagesMade += 1;
                RecipeViewer.Controls.Add(newPanel);
                // - - - - - - 


                FormsMainPanel.Visible = true;
                AddRecipePanel.Location = new(999, 0);
                AddRecipePanel.Visible = false;

            }

        }

        private void AddingIngreBTN_Click(object sender, EventArgs e)
        {
            TextBox TB = new TextBox();
            TB.Name = "IngredientTB" + TBforIngr;
            TB.Size = new Size(137, 27);
            TB.Location = new(xPosOfIngBtn, yPosOfIngBtn);

            if (yPosOfIngBtn >= 146)
            {
                yPosOfIngBtn = 26;
                xPosOfIngBtn += 150;
            }
            else if (xPosOfIngBtn > 456) { }
            else
            {
                yPosOfIngBtn += 40;
            }

            AddIndegrientsGB.Controls.Add(TB);


            int TextBoxesInGB = AddIndegrientsGB.Controls.Count;

            if (TextBoxesInGB == 0)
            {
                MessageBox.Show("There are no ingredients added for this recipe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { }



        }
    }
}
//Location: 6,26
//Size 137,27
//Add 40 to y
//Max reach 146 (Y)



//Add 150 to X
//Max reach 456 (X)
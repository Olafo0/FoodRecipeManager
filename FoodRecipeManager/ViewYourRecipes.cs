using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecipeManager
{
    public partial class ViewYourRecipes : Form
    {

        string connectionString = "Data Source=LC21205XX\\SQLEXPRESS;Initial Catalog=RecipeManagerDB;User ID =sa;Password=sa2023;";
        SqlConnection cnn;
        SqlCommand cmd;

        List<RecipeDB> recipeItems = new List<RecipeDB>();

        int recipeID = 0;
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

                //List<string> ContainerForIng = new List<string>();
                string ContainerForIng = "";

                for (int i = 0; i < TextBoxesInGB; i++)
                {
                    string tempString = "";
                    tempString = AddIndegrientsGB.Controls[i].Text;
                    ContainerForIng += $"{tempString} ";
                    //tempString = AddIndegrientsGB.Controls[i].Text;
                    //ContainerForIng.Add(tempString);
                }

                // Removing the TB
                for (int i = TextBoxesInGB - 1; i >= 0; i--)
                {
                    AddIndegrientsGB.Controls.Remove(AddIndegrientsGB.Controls[i]);
                }

                int CurrentRecipeID = recipeID + 1;
                string RecipeTitle = RecipesNameTB.Text;
                string FoodType = FoodTypeCB.Text;
                string AuthorName = AuthorNameTB.Text;
                int Rating = int.Parse(RatingCB.Text);

                RecipeDB CurrentRecipe = new RecipeDB(CurrentRecipeID, RecipeTitle, FoodType, AuthorName, Rating, ContainerForIng);
                recipeItems.Add(CurrentRecipe);

                RecipesNameTB.Text = "";
                FoodTypeCB.SelectedItem = null;
                AuthorNameTB.Text = "";
                RatingCB.SelectedItem = null;

                // Rating stars 
                // here
                // - - - - - 
                // Creating the panel
                Panel newPanel = new Panel();
                newPanel.Size = new Size(200, 195);
                newPanel.Name = "RecipePanel" + CurrentPagesMade;
                newPanel.BackColor = Color.White;

                Button btn = new Button();
                btn.Name = "RecipeViewBtn" + CurrentPagesMade;
                btn.Text = "Temp";
                btn.Location = new(20, 70);
                btn.Click += Btn_Click;
                newPanel.Controls.Add(btn);

                // Rating label
                Label Ratinglabel = new Label();
                Ratinglabel.Text = $"Rating: {Rating}";
                Ratinglabel.Location = new(10, 160);
                newPanel.Controls.Add(Ratinglabel);

                //Name of recipe
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
                Titlelabel.Location = new(10, 120);
                newPanel.Controls.Add(Titlelabel);

                // Author label
                Label AuthorLabel = new Label();
                AuthorLabel.Name = "AutherLabel" + CurrentPagesMade;
                AuthorLabel.Text = $"By: {Rating}";
                AuthorLabel.Location = new(10, 140);
                newPanel.Controls.Add(AuthorLabel);

                CurrentPagesMade += 1;
                RecipeViewer.Controls.Add(newPanel);


                FormsMainPanel.Visible = true;
                AddRecipePanel.Location = new(999, 0);
                AddRecipePanel.Visible = false;

            }

        }

        // Gets the information from the button we clicked. 
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
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

        private void CloseAddRecipePanel_Click(object sender, EventArgs e)
        {
            AddRecipePanel.Location = new(999, 0);
            AddRecipePanel.Visible = false;
        }

        private void FormsMainPanel_Paint(object sender, PaintEventArgs e)
        {
            //https://www.codeproject.com/Tips/825532/Read-Insert-Data-Using-Stored-Procedures-in-Csharp
            //// Making a small viewable 
            //Panel newPanel = new Panel();
            //newPanel.Size = new Size(200, 195);
            //newPanel.Name = "RecipePanel" + CurrentPagesMade;
            //newPanel.BackColor = Color.White;

            //Button btn = new Button();
            //btn.Name = "RecipeViewBtn" + CurrentPagesMade;
            //btn.Text = "Temp";
            //btn.Location = new(20, 70);
            //newPanel.Controls.Add(btn);

            //Label Ratinglabel = new Label();
            //Ratinglabel.Text = "Rating :";
            //Ratinglabel.Location = new(10, 160);
            //newPanel.Controls.Add(Ratinglabel);

            //Label Titlelabel = new Label();
            //Titlelabel.Name = "RecipeTitleLabel" + CurrentPagesMade;
            //Titlelabel.Text = RecipeTitle;

            //if (RecipeTitle.Length > 25)
            //{
            //    Titlelabel.AutoEllipsis = true;
            //    Titlelabel.AutoSize = false;
            //}
            //else
            //{
            //    Titlelabel.AutoEllipsis = false;
            //    Titlelabel.AutoSize = true;
            //}
            //Titlelabel.Location = new(10, 110);
            //newPanel.Controls.Add(Titlelabel);

            //CurrentPagesMade += 1;
            //RecipeViewer.Controls.Add(newPanel);
        }

        private void ViewYourRecipes_Load(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                cmd = new SqlCommand("OutputAllItems",cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int RecipeID = int.Parse(reader["RecipeID"].ToString());
                        string? RecipeName = reader["RecipeName"].ToString();
                        string? FoodType = reader["Type_"].ToString();
                        string? Author = reader["Author_"].ToString();
                        int Rating = int.Parse(reader["Rating"].ToString());
                        string? Ingredients = reader["Ingredients"].ToString();

                        RecipeDB CurrentRecipe = new RecipeDB(RecipeID,RecipeName,FoodType, Author,Rating,Ingredients);
                        recipeItems.Add(CurrentRecipe);

                    }
                }
                cnn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            foreach (var recipe in recipeItems)
            {
                // Creating the panel
                Panel newPanel = new Panel();
                newPanel.Size = new Size(200, 195);
                newPanel.Name = "RecipePanel" + CurrentPagesMade;
                newPanel.BackColor = Color.White;

                Button btn = new Button();
                btn.Name = "RecipeViewBtn" + CurrentPagesMade;
                btn.Text = "Temp";
                btn.Location = new(20, 70);
                newPanel.Controls.Add(btn);

                // Rating label
                Label Ratinglabel = new Label();
                Ratinglabel.Text = $"Rating: {recipe.Rating.ToString()}";
                Ratinglabel.Location = new(10, 160);
                newPanel.Controls.Add(Ratinglabel);

                //Name of recipe
                Label Titlelabel = new Label();
                Titlelabel.Name = "RecipeTitleLabel" + CurrentPagesMade;
                Titlelabel.Text = recipe.RecipeName;
                if (recipe.RecipeName.Length > 25)
                {
                    Titlelabel.AutoEllipsis = true;
                    Titlelabel.AutoSize = false;
                }
                else
                {
                    Titlelabel.AutoEllipsis = false;
                    Titlelabel.AutoSize = true;
                }
                Titlelabel.Location = new(10, 120);
                newPanel.Controls.Add(Titlelabel);

                // Author label
                Label AuthorLabel = new Label();
                AuthorLabel.Name = "AutherLabel" + CurrentPagesMade;
                AuthorLabel.Text = $"By: {recipe.Author}";
                AuthorLabel.Location = new(10, 140);
                newPanel.Controls.Add(AuthorLabel);

                CurrentPagesMade += 1;
                RecipeViewer.Controls.Add(newPanel);
            }


        }
    }
}
//Location: 6,26
//Size 137,27
//Add 40 to y
//Max reach 146 (Y)



//Add 150 to X
//Max reach 456 (X)


// What to do Save to a database 
// To save ingriadents iterate through textbox in GroupBox append it to a string and save it to a database 
// Homeload automatically the data from the database.
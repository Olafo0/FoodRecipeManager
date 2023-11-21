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
        public ViewYourRecipes()
        {
            InitializeComponent();
        }

        private void AddNewRecipe_Click(object sender, EventArgs e)
        {
            FormsMainPanel.Visible = true;

            AddRecipePanel.Location = new(145, 0);
            AddRecipePanel.Visible = true;
            AddRecipePanel.BringToFront();


            //Panel panel = new Panel();
            //panel.Size = new Size(200, 200);
            //RecipeViewer.Controls.Add(panel);
            //Controls.Add(RecipeViewer);


            Panel newPabel = new Panel();
            newPabel.Size = new Size(185, 195);
            newPabel.BackColor = Color.White;

            Button btn = new Button();
            btn.Text = "Temp";
            btn.Location = new(20, 70);
            newPabel.Controls.Add(btn);


            Label Ratinglabel = new Label();
            Ratinglabel.Text = "Rating :";
            Ratinglabel.Location = new(10, 160);
            newPabel.Controls.Add(Ratinglabel);

            Label Titlelabel = new Label();
            Titlelabel.Text = "Title";
            Titlelabel.Location = new(10, 110);
            newPabel.Controls.Add(Titlelabel);

            RecipeViewer.Controls.Add(newPabel);
        }

        private void CreateNewRecipe_Click(object sender, EventArgs e)
        {
            FormsMainPanel.Visible = true;
            AddRecipePanel.Location = new(999, 0);
            AddRecipePanel.Visible = false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calorie_Tracker.data;

namespace Calorie_Tracker
{
    public partial class showFoodInfo : Form
    {
        public showFoodInfo(Food food)
        {
            InitializeComponent();
            decimal portionFactor = food.GramsInPortion / 100m;
            Food foodPortion = new Food
            {
                Id = food.Id,
                Name = food.Name,
                Calorie = food.Calorie * portionFactor,
                Fats = food.Fats * portionFactor,
                Salts = food.Salts * portionFactor,
                Protein = food.Protein * portionFactor,
                Caffeine = food.Caffeine.HasValue ? food.Caffeine * portionFactor : null,
                GramsInPortion = food.GramsInPortion
            };

            nameLBL.Text = foodPortion.Name;
            calorieLBL.Text = $"Kalorie = {food.Calorie:F0}kcal/100g, {foodPortion.Calorie:F0} kcal w porcji";
            fatsLBL.Text = $"Tłuszcze = {foodPortion.Fats:F2}g w porcji";
            saltsLBL.Text = $"Sole = {foodPortion.Salts:F2}g w porcji";
            proteinLBL.Text = $"Proteiny = {foodPortion.Protein:F2}g w porcji";
            if (foodPortion.Caffeine != null)
            {
                caffeineLBL.Text = $"Kofeina = {foodPortion.Caffeine:F2}g w porcji";
            }
            else
            {
                caffeineLBL.Text = "";
            }
            gramsLBL.Text = $"Gram w porcji = {foodPortion.GramsInPortion:F2}";
        }

        private void saltsLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
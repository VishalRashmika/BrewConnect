using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrewConnect
{
    public partial class BrewConnect : Form
    {
        public BrewConnect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrLoading.Start();
            pnlLoadingScreen.Visible = true;
            pnlHomepg.Visible = false;


            // Recipe Panel Scroller
            pnlRecipeGrid.AutoScroll = false; 
            pnlRecipeGrid.HorizontalScroll.Enabled = false;
            pnlRecipeGrid.HorizontalScroll.Visible = false;
            pnlRecipeGrid.HorizontalScroll.Maximum = 0;
            pnlRecipeGrid.AutoScroll = true;

            pnlRecipeDetail.AutoScroll = false;
            pnlRecipeDetail.HorizontalScroll.Enabled = false;
            pnlRecipeDetail.HorizontalScroll.Visible = false;
            pnlRecipeDetail.HorizontalScroll.Maximum = 0;
            pnlRecipeDetail.AutoScroll = true;

            pnlRecipeDetail.Visible = false;
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (pbrLoading.Value < 100)
            {
                pbrLoading.Value += 4;
                //lblLoadStat.Text = pbrLoading.Value.ToString() + "%";
            }
            else
            {
                tmrLoading.Stop();
                //MessageBox.Show("Loading Completed !!!");
                pnlLoadingScreen.Visible = false;
                pnlHomepg.Visible = true;
                pnlSideBar.Visible = true;
                
                pnlRecipes.Visible = true;
                pnlCategories.Visible = false;
                pnlCoffeeBeans.Visible = false;
                pnlExtra.Visible = false;

                pnlRecipeEnabled.Visible = true;
                pnlCatEnabled.Visible = false;
                pnlCofBeaEnabled.Visible = false;
                pnlExtraEnabled.Visible = false;

                btnRecipes.BackColor = bgColor;
                btnRecipes.ForeColor = fontColor;
                btnCategories.BackColor = fontColor;
                btnCategories.ForeColor = bgColor;
                btnCoffeeBeans.BackColor = fontColor;
                btnCoffeeBeans.ForeColor = bgColor;
                btnExtra.BackColor = fontColor;
                btnExtra.ForeColor = bgColor;
            }
        }

        private void lblLoadStat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Color bgColor = Color.FromArgb(76, 34, 27);
        Color fontColor = Color.FromArgb(156, 92, 45);
        private void btnRecipes_Click(object sender, EventArgs e)
        {
            pnlRecipes.Visible = true;
            pnlCategories.Visible = false;
            pnlCoffeeBeans.Visible = false;
            pnlExtra.Visible = false;

            pnlRecipeEnabled.Visible = true;
            pnlCatEnabled.Visible = false;
            pnlCofBeaEnabled.Visible = false;
            pnlExtraEnabled.Visible = false;

            pnlRecipeDetail.Visible = false;
            pnlRecipeGrid.Visible = true;

            btnRecipes.BackColor = bgColor;
            btnRecipes.ForeColor = fontColor;
            btnCategories.BackColor = fontColor;
            btnCategories.ForeColor = bgColor;
            btnCoffeeBeans.BackColor = fontColor;
            btnCoffeeBeans.ForeColor = bgColor;
            btnExtra.BackColor = fontColor;
            btnExtra.ForeColor = bgColor;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            pnlRecipes.Visible = false;
            pnlCategories.Visible = true;
            pnlCoffeeBeans.Visible = false;
            pnlExtra.Visible = false;

            pnlRecipeEnabled.Visible = false;
            pnlCatEnabled.Visible = true;
            pnlCofBeaEnabled.Visible = false;
            pnlExtraEnabled.Visible = false;

            btnRecipes.BackColor = fontColor;
            btnRecipes.ForeColor = bgColor;
            btnCategories.BackColor = bgColor;
            btnCategories.ForeColor = fontColor;
            btnCoffeeBeans.BackColor = fontColor;
            btnCoffeeBeans.ForeColor = bgColor;
            btnExtra.BackColor = fontColor;
            btnExtra.ForeColor = bgColor;
        }

        private void btnCoffeeBeans_Click(object sender, EventArgs e)
        {
            pnlRecipes.Visible = false;
            pnlCategories.Visible = false;
            pnlCoffeeBeans.Visible = true;
            pnlExtra.Visible = false;

            pnlRecipeEnabled.Visible = false;
            pnlCatEnabled.Visible = false;
            pnlCofBeaEnabled.Visible = true;
            pnlExtraEnabled.Visible = false;

            pnlCoffeeBeans.Visible = true;
            pnlBeanGrid.Visible = true;
            pnlBeanDetail.Visible = false;
            lblCoffeeBeans.Visible = true;

            btnRecipes.BackColor = fontColor;
            btnRecipes.ForeColor = bgColor;
            btnCategories.BackColor = fontColor;
            btnCategories.ForeColor = bgColor;
            btnCoffeeBeans.BackColor = bgColor;
            btnCoffeeBeans.ForeColor = fontColor;
            btnExtra.BackColor = fontColor;
            btnExtra.ForeColor = bgColor;
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            pnlRecipes.Visible = false;
            pnlCategories.Visible = false;
            pnlCoffeeBeans.Visible = false;
            pnlExtra.Visible = true;

            pnlRecipeEnabled.Visible = false;
            pnlCatEnabled.Visible = false;
            pnlCofBeaEnabled.Visible = false;
            pnlExtraEnabled.Visible = true;

            btnRecipes.BackColor = fontColor;
            btnRecipes.ForeColor = bgColor;
            btnCategories.BackColor = fontColor;
            btnCategories.ForeColor = bgColor;
            btnCoffeeBeans.BackColor = fontColor;
            btnCoffeeBeans.ForeColor = bgColor;
            btnExtra.BackColor = bgColor;
            btnExtra.ForeColor = fontColor;
        }

        private void pnlRecipeDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRecipeDetail.Visible = false;
            pnlRecipeGrid.Visible = true;
        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            pnlRecipeGrid.Visible = false;
            pnlRecipeDetail.Visible = true;
            //lblHeading.Text = "";
            lblHeading.Text = "Americano";
            lblIngredientList.Text = "- 8 ounces of off-boil water\r\n- Two ounces (double shot) of espresso\r\n";
            lblStep1.Text = " Add a double shot of espresso (the standard \nfor most specialty coffee drinks) to a tall coffee cup";
            lblStep2.Text = "Pour your hot water over top.";
            pbImage.ImageLocation = @"./Assets/4.png";
        }

        private void btnCortado_Click(object sender, EventArgs e)
        {
            pnlRecipeGrid.Visible = false;
            pnlRecipeDetail.Visible = true;
            lblHeading.Text = "Cortado";
            lblIngredientList.Text = "- 40ml espresso\r\n- 40ml steamed milk (heat to 55-65C)";
            lblStep1.Text = "Pour the espresso into a 4-6oz heatproof \nglass or cup, then pour over the steamed \nmilk. Finish with a little bit of foam on \ntop (around the thickness of a finger).";
            lblStep2.Visible = false;
            lblStep2Title.Visible = false;
            pbImage.ImageLocation = @"./Assets/3.png";
        }

        private void btnIrish_Click(object sender, EventArgs e)
        {
            pnlRecipeGrid.Visible = false;
            pnlRecipeDetail.Visible = true;
            lblHeading.Text = "Irish";
            lblIngredientList.Text = "- 2 tbsp double cream\r\n- 150ml freshly brewed black coffee\r\n- 50ml Irish whiskey\r\n- ½ - 1 tsp brown sugar\r\n- pinch freshly grated nutmeg";
            lblStep1.Text = "Lightly whip the cream just so it’s very \nslightly thickened, then set aside. ";
            lblStep2.Text = "Pour the hot coffee into a mug or \nheatproof glass, then add the whiskey\nand sugar. Stir until the sugar has \ndissolved. Gently float the cream on the \ntop and sprinkle the \nnutmeg over the cream. Serve hot.";
            pbImage.ImageLocation = @"./Assets/1.png";

        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            pnlRecipeGrid.Visible = false;
            pnlRecipeDetail.Visible = true;
            lblHeading.Text = "Espresso";
            lblIngredientList.Text = "- 18g ground espresso (or 1 espresso pod)\r\n- 150ml milk\n- cocoa powder (optional)\n- cup, 200-250ml capacity";
            lblStep1.Text = "Make around 35ml espresso using a \ncoffee machine and pour it into the base \nof your cup.";
            lblStep2.Text = "Steam the milk with the steamer \nattachment so that it has around 4-6cm \nof foam on top. Hold the jug so that the \nspout is about 3-4cm above the cup and \npour the milk in steadily. As the volume \nwithin the cup increases, bring the jug as \nclose to the surface of the drink as \npossible whilst aiming to pour into the \ncentre. Once the milk jug is almost \ntouching the surface of the coffee, tilt \nthe jug to speed up the rate of pour. As \nyou accelerate, the milk will hit the back \nof the cup and start naturally folding in \non itself to create a pattern on the top. \nDust the surface with a little cocoa \npowder if you like.";
            pbImage.ImageLocation = @"./Assets/2.png";
        }

        private void btnMachiato_Click(object sender, EventArgs e)
        {
            pnlRecipeGrid.Visible = false;
            pnlRecipeDetail.Visible = true;
            lblHeading.Text = "Macchiato";
            lblIngredientList.Text = "- 18g ground espresso, or 1 espresso pod\r\n- 50-100ml milk\n- small cup, 50-80ml capacity";
            lblStep1.Text = "Make around 35ml espresso using your \ncoffee machine and pour into the base of \nyour cup.";
            lblStep2.Text = "Steam the milk with the steamer \nattachment so that it has around 1-2cm \nof foam on top, then spoon 2-3 \nteaspoons of the foam on top of the \nespresso (discard the rest of the milk).";
            pbImage.ImageLocation = @"./Assets/6.png";
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            pnlRecipeGrid.Visible = false;
            pnlRecipeDetail.Visible = true;
            lblHeading.Text = "Mocha";
            lblIngredientList.Text = "- 18g ground espresso, or 1 espresso pod\r\n- 250ml milk\r\n- 1 tsp drinking chocolate\n- large cup, 300-350ml capacity";
            lblStep1.Text = "Make around 35ml espresso using a \ncoffee machine and pour into the base of \nyour cup. Add the drinking chocolate and \nmix well until smooth.";
            lblStep2.Text = "Steam the milk with the steamer \nattachment so that it has around 4-6cm \nof foam on top. Hold the jug so that the \nspout is about 3-4cm above the cup and \npour the milk in steadily. As the volume \nwithin the cup increases, bring the jug as \nclose to the surface of the drink as \npossible whilst aiming into the centre. \nOnce the milk jug is almost touching the \nsurface of the coffee, tilt to speed up the \nrate of pour. As you accelerate, the milk \nwill hit the back of the cup and start \nnaturally folding in on itself to create a\n pattern on the top.";
            pbImage.ImageLocation = @"./Assets/5.png";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            pnlBeanDetail.Visible = false;
            pnlBeanGrid.Visible = true;
            lblCoffeeBeans.Visible = true;

        }

        private void btnArabica_Click(object sender, EventArgs e)
        {
            pnlBeanGrid.Visible = false;
            pnlBeanDetail.Visible = true;
            lblCoffeeBeans.Visible = false;
            lblBeanHeading.Text = "Arabica";
            lblInfoPlaceholder.Text = "Arabica coffee beans, dating back over 3,000 years, are the most popular globally. They are larger, \n sweeter, and more expensive than Robusta beans due to their more demanding \ngrowth conditions, requiring more water, shade, and higher altitudes.\r\n\r\nBrazil is the top producer of Arabica, which grows between 500 and 2,500 meters in elevation, although \nthe beans originated in Ethiopia. Their name comes from their use in \nthe Arabian Peninsula in the 7th century.\r\n\r\nNow grown in over 50 equatorial countries, \nArabica beans' taste and aroma vary greatly between regions.";
            pbBeanImg.ImageLocation = @"./Assets/7.jpg";

        }

        private void btnRobusta_Click(object sender, EventArgs e)
        {
            pnlBeanGrid.Visible = false;
            pnlBeanDetail.Visible = true;
            lblCoffeeBeans.Visible = false;
            lblBeanHeading.Text = "Robusta";
            lblInfoPlaceholder.Text = "Robusta beans make up almost 40% of worldwide exports, and are grown in many of \nthe same areas as Arabica beans to include much of Africa, Indonesia, and Vietnam. \nTheir origin of Robusta beans is African.\r\n\r\nRobusta beans have a lower acidity than Arabica making them less sweet and the \ntype most often used in espresso and in instant coffee. Robusta beans have almost \ndouble the caffeine content of Arabica beans and are known for a stronger and more \nbitter taste and smell.";
            pbBeanImg.ImageLocation = @"./Assets/8.jpg";
        }

        private void btnJava_Click(object sender, EventArgs e)
        {
            pnlBeanGrid.Visible = false;
            pnlBeanDetail.Visible = true;
            lblCoffeeBeans.Visible = false;
            lblBeanHeading.Text = "Java";
            lblInfoPlaceholder.Text = "The origin of Java coffee lies in its namesake, the Indonesian island of Java, \nwhich in the 1700s was under Dutch colonial rule.\n During this period, Pieter van den Broecke, a merchant on the\n island of Java, began cultivating Arabica coffee plants\n he had smuggled from Yemen’s port of Mocha.";
            pbBeanImg.ImageLocation = @"./Assets/9.jpg";
        }

        private void btnLiberica_Click(object sender, EventArgs e)
        {
            pnlBeanGrid.Visible = false;
            pnlBeanDetail.Visible = true;
            lblCoffeeBeans.Visible = false;
            lblBeanHeading.Text = "Liberica";
            lblInfoPlaceholder.Text = "Liberica beans are native to Western Africa and primarily Liberia for which the beans \nare named. These beans are unusual in that they are tolerant of heat and grow well at \nlow altitudes. Today Liberica beans are grown mostly in Malaysia, Indonesia, and the \nPhilippines.  While they only tally 2% of world production, they represent 95% of the \nbeans grown in Malaysia. The taste of these beans is known to be rather \ninconsistent which limits worldwide popularity.";
            pbBeanImg.ImageLocation = @"./Assets/10.jpg";
        }

        private void btnPacamara_Click(object sender, EventArgs e)
        {
            pnlBeanGrid.Visible = false;
            pnlBeanDetail.Visible = true;
            lblCoffeeBeans.Visible = false;
            lblBeanHeading.Text = "Pacamara";
            lblInfoPlaceholder.Text = "Pacamara high altitude beans are a hybrid between Pacas (a Bourbon mutation) and \nMaragogype (a Typica mutation). This coffee bean type demonstrates how in the wide world\n of coffee all beans really trace their origin back to Arabica and \nRobusta plants through a variety of mutations and hybridizations. \nPacamara was created by the Salvadoran Institute for Coffee Research in 1958. The intent\n was to leverage the recognized high quality coffee from Maragogype and the higher yields of Pacas. \nThe institute tinkered with this plant for about 30 years\n before releasing the variety for commercial production. Pacamara Coffee Beans are\n available at a moderate price if you want to test how they did on the quality for yourself.";
            pbBeanImg.ImageLocation = @"./Assets/11.jpg";
        }

        private void btnTimor_Click(object sender, EventArgs e)
        {
            pnlBeanGrid.Visible = false;
            pnlBeanDetail.Visible = true;
            lblCoffeeBeans.Visible = false;
            lblBeanHeading.Text = "Timor";
            lblInfoPlaceholder.Text = "The small island of Timor produces about 11 million pounds of their own unique \nbeans each year, or about 0.1% of worldwide production. Despite this, their beans \nare an important export crop for the poor nation of 1.3 million people. The beans are a \ncross between Arabica and Robusta beans, and are grown on small farms in East \nTimor where the hand picked beans are known for their sweetness and mild acidity.";
            pbBeanImg.ImageLocation = @"./Assets/12.jpg";
        }

        private void btnCatRecipes_Click(object sender, EventArgs e)
        {
            pnlRecipes.Visible = true;
            pnlCategories.Visible = false;
            pnlCoffeeBeans.Visible = false;
            pnlExtra.Visible = false;

            pnlRecipeEnabled.Visible = true;
            pnlCatEnabled.Visible = false;
            pnlCofBeaEnabled.Visible = false;
            pnlExtraEnabled.Visible = false;

            pnlRecipeDetail.Visible = false;
            pnlRecipeGrid.Visible = true;

            btnRecipes.BackColor = bgColor;
            btnRecipes.ForeColor = fontColor;
            btnCategories.BackColor = fontColor;
            btnCategories.ForeColor = bgColor;
            btnCoffeeBeans.BackColor = fontColor;
            btnCoffeeBeans.ForeColor = bgColor;
            btnExtra.BackColor = fontColor;
            btnExtra.ForeColor = bgColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlRecipes.Visible = false;
            pnlCategories.Visible = false;
            pnlCoffeeBeans.Visible = true;
            pnlExtra.Visible = false;

            pnlRecipeEnabled.Visible = false;
            pnlCatEnabled.Visible = false;
            pnlCofBeaEnabled.Visible = true;
            pnlExtraEnabled.Visible = false;

            pnlCoffeeBeans.Visible = true;
            pnlBeanGrid.Visible = true;
            pnlBeanDetail.Visible = false;
            lblCoffeeBeans.Visible = true;

            btnRecipes.BackColor = fontColor;
            btnRecipes.ForeColor = bgColor;
            btnCategories.BackColor = fontColor;
            btnCategories.ForeColor = bgColor;
            btnCoffeeBeans.BackColor = bgColor;
            btnCoffeeBeans.ForeColor = fontColor;
            btnExtra.BackColor = fontColor;
            btnExtra.ForeColor = bgColor;
        }
    }
}

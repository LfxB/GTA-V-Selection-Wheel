using GTA; // This is a reference that is needed! do not edit this
using GTA.Native; // This is a reference that is needed! do not edit this
using GTA.Math;
using System; // This is a reference that is needed! do not edit this
using System.Windows.Forms; // This is a reference that is needed! do not edit this
using SelectorWheel;

namespace SelectorWheelExample
{
    public class SelectorWheelExample : Script // declare Modname as a script
    {
        Wheel testWheel;
        WheelCategory firstCat;
        WheelCategory secondCat;
        WheelCategory thirdCat;
        WheelCategory fourthCat;
        WheelCategory fifthCat;
        WheelCategory sixthCat;
        WheelCategory seventhCat;
        WheelCategory eigthCat;
        WheelCategory ninthCat;
        WheelCategory tenthCat;
        WheelCategory eleventhCat;
        WheelCategory twelvthCat;
        WheelCategory thirteenthCat;
        WheelCategory fourteenthCat;
        WheelCategory fifteenthCat;
        WheelCategory sixteenthCat;
        WheelCategory seventeenthCat;
        WheelCategory eighteenthCat;

        WheelCategoryItem cat1_item1;
        WheelCategoryItem cat1_item2;
        WheelCategoryItem cat1_item3;
        WheelCategoryItem cat1_item4;

        WheelCategoryItem cat2_item1;

        WheelCategoryItem cat3_item1;

        WheelCategoryItem cat4_item1;

        WheelCategoryItem cat5_item1;

        WheelCategoryItem cat6_item1;

        WheelCategoryItem cat7_item1;

        WheelCategoryItem cat8_item1;

        WheelCategoryItem cat9_item1;

        WheelCategoryItem cat10_item1;

        WheelCategoryItem cat11_item1;

        WheelCategoryItem cat12_item1;

        WheelCategoryItem cat13_item1;

        WheelCategoryItem cat14_item1;

        WheelCategoryItem cat15_item1;

        WheelCategoryItem cat16_item1;

        WheelCategoryItem cat17_item1;

        WheelCategoryItem cat18_item1;

        public SelectorWheelExample() // main function
        {
            SetupTestWheel();

            Tick += OnTick;
            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;

            Interval = 0;
        }

        void SetupTestWheel()
        {
            testWheel = new Wheel("Test Wheel", @"scripts\SelectorWheelExample\", 0, 0, new System.Drawing.Size(65, 65), 200, 300); //images will be searched for inside "\scripts\SelectorWheelExample\"

            /* Invalid characters in a filename will be replaced by an underscore ("_")
                Ex: A wheel category with the name "Abilty:Spark" will still show as "Ability:Spark" in the wheel
                but the corresponding .png image that will be searched is "Ability_Spark.png".
             */

            firstCat = new WheelCategory("1st"); //if an image called "1st.png" is found, all items within this category will share this same image.
            testWheel.AddCategory(firstCat);
            cat1_item1 = new WheelCategoryItem("Item 1", "From Category 1"); //looks for an image called "Item 1.png" but will only be used if "1st.png" does not exist.
            cat1_item2 = new WheelCategoryItem("Item 2", "From Category 2"); //looks for an image called "Item 2.png" but will only be used if "1st.png" does not exist.
            cat1_item3 = new WheelCategoryItem("Item 3", "From Category 3"); //etc.
            cat1_item4 = new WheelCategoryItem("Item 4", "From Category 4");
            firstCat.AddItem(cat1_item1);
            firstCat.AddItem(cat1_item2);
            firstCat.AddItem(cat1_item3);
            firstCat.AddItem(cat1_item4);

            secondCat = new WheelCategory("2nd");
            testWheel.AddCategory(secondCat);
            cat2_item1 = new WheelCategoryItem("Item 1, Category 2", "From Category 2");
            secondCat.AddItem(cat2_item1);

            thirdCat = new WheelCategory("3rd");
            testWheel.AddCategory(thirdCat);
            cat3_item1 = new WheelCategoryItem("Item 1, Category 3", "From Category 3");
            thirdCat.AddItem(cat3_item1);

            fourthCat = new WheelCategory("4th");
            testWheel.AddCategory(fourthCat);
            cat4_item1 = new WheelCategoryItem("Item 1, Category 4", "From Category 4");
            fourthCat.AddItem(cat4_item1);

            fifthCat = new WheelCategory("5th");
            testWheel.AddCategory(fifthCat);
            cat5_item1 = new WheelCategoryItem("Item 1, Category 5", "From Category 5");
            fifthCat.AddItem(cat5_item1);

            sixthCat = new WheelCategory("6th");
            testWheel.AddCategory(sixthCat);
            cat6_item1 = new WheelCategoryItem("Item 1, Category 6", "From Category 6");
            sixthCat.AddItem(cat6_item1);

            /*seventhCat = new WheelCategory("7th");
            testWheel.AddCategory(seventhCat);
            cat7_item1 = new WheelCategoryItem("Item 1, Category 7", "From Category 7");
            seventhCat.AddItem(cat7_item1);

            eigthCat = new WheelCategory("8th");
            testWheel.AddCategory(eigthCat);
            cat8_item1 = new WheelCategoryItem("Item 1, Category 8", "From Category 8");
            eigthCat.AddItem(cat8_item1);

            ninthCat = new WheelCategory("9th");
            testWheel.AddCategory(ninthCat);
            cat9_item1 = new WheelCategoryItem("Item 1, Category 9", "From Category 9");
            ninthCat.AddItem(cat9_item1);

            tenthCat = new WheelCategory("10th");
            testWheel.AddCategory(tenthCat);
            cat10_item1 = new WheelCategoryItem("Item 1, Category 10", "From Category 10");
            tenthCat.AddItem(cat10_item1);

            eleventhCat = new WheelCategory("11th");
            testWheel.AddCategory(eleventhCat);
            cat11_item1 = new WheelCategoryItem("Item 1, Category 11", "From Category 11");
            eleventhCat.AddItem(cat11_item1);

            twelvthCat = new WheelCategory("12th");
            testWheel.AddCategory(twelvthCat);
            cat12_item1 = new WheelCategoryItem("Item 1, Category 12", "From Category 12");
            twelvthCat.AddItem(cat12_item1);

            thirteenthCat = new WheelCategory("13th");
            testWheel.AddCategory(thirteenthCat);
            cat13_item1 = new WheelCategoryItem("Item 1, Category 13", "From Category 13");
            thirteenthCat.AddItem(cat13_item1);

            fourteenthCat = new WheelCategory("14th");
            testWheel.AddCategory(fourteenthCat);
            cat14_item1 = new WheelCategoryItem("Item 1, Category 14", "From Category 14");
            fourteenthCat.AddItem(cat14_item1);

            fifteenthCat = new WheelCategory("15th");
            testWheel.AddCategory(fifteenthCat);
            cat15_item1 = new WheelCategoryItem("Item 1, Category 15th", "From Category 15th");
            fifteenthCat.AddItem(cat15_item1);

            sixteenthCat = new WheelCategory("16th");
            testWheel.AddCategory(sixteenthCat);
            cat16_item1 = new WheelCategoryItem("Item 1, Category 16th", "From Category 16th");
            sixteenthCat.AddItem(cat16_item1);

            seventeenthCat = new WheelCategory("17th");
            testWheel.AddCategory(seventeenthCat);
            cat17_item1 = new WheelCategoryItem("Item 1, Category 17th", "From Category 17th");
            seventeenthCat.AddItem(cat17_item1);

            eighteenthCat = new WheelCategory("18th");
            testWheel.AddCategory(eighteenthCat);
            cat18_item1 = new WheelCategoryItem("Item 1, Category 18th", "From Category 18th");
            eighteenthCat.AddItem(cat18_item1);*/

            testWheel.Origin = new Vector2(0.5f, 0.5f);
            testWheel.CalculateCategoryPlacement();

            testWheel.OnCategoryChange += TestWheel_OnCategoryChange;
            testWheel.OnItemChange += TestWheel_OnItemChange;
            testWheel.OnWheelOpen += TestWheel_OnWheelOpen;
            testWheel.OnWheelClose += TestWheel_OnWheelClose;
        }

        private void TestWheel_OnCategoryChange(Wheel sender, WheelCategory selectedCategory, WheelCategoryItem selectedItem)
        {
            UI.ShowSubtitle("New Category: " + selectedCategory.Name, 250);
        }

        private void TestWheel_OnItemChange(Wheel sender, WheelCategory selectedCategory, WheelCategoryItem selectedItem)
        {
            UI.ShowSubtitle("New Item: " + selectedItem.Name, 250);
        }

        private void TestWheel_OnWheelOpen(Wheel sender, WheelCategory selectedCategory, WheelCategoryItem selectedItem)
        {
            UI.ShowSubtitle("Wheel just opened", 250);
            Game.Player.Character.Task.ClearAll();
            Game.Player.Character.Task.HandsUp(800);
        }

        private void TestWheel_OnWheelClose(Wheel sender, WheelCategory selectedCategory, WheelCategoryItem selectedItem)
        {
            UI.ShowSubtitle("Wheel just closed", 250);
            Ped player = Game.Player.Character;
            player.Task.ClearAll();
            /*player.Task.Jump();
            player.Velocity = new GTA.Math.Vector3(player.ForwardVector.X * 20f, player.ForwardVector.Y * 20f, player.ForwardVector.Z);*/
        }

        void OnTick(object sender, EventArgs e) // This is where most of your script goes
        {
            /*UIHelper.DrawCustomText("This is left-justified", 1.5f, Font.ChaletComprimeCologne, 255, 243, 95, 255, 0.5f, 0.2f, UIHelper.TextJustification.Left, false, 0, 1, true, 0f, 0, 255, 255, 150);
            UIHelper.DrawCustomText("This is center-justified", 1.5f, Font.ChaletComprimeCologne, 255, 243, 95, 255, 0.5f, 0.5f, UIHelper.TextJustification.Center, false, 0, 1, true, 0f, 0, 255, 255, 150);
            UIHelper.DrawCustomText("This is Right-justified", 1.5f, Font.ChaletComprimeCologne, 255, 243, 95, 255, 0.5f, 0.8f, UIHelper.TextJustification.Right, false, 0, 0.5f, true, 0f, 0, 255, 255, 150);*/

            //UI.ShowSubtitle("Left/Right: " + Game.GetControlNormal(2, GTA.Control.WeaponWheelLeftRight).ToString() + "Up/Down: " + Game.GetControlNormal(2, GTA.Control.WeaponWheelUpDown).ToString());

            /* Right: positive 1
             * Left: negative 1
             * Down: positive 1
             * Up: negative 1
             * */

            testWheel.ProcessSelectorWheel();
        }

        void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                testWheel.Visible = true;
            }
        }

        void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                testWheel.Visible = false;
            }
        }
    }
}
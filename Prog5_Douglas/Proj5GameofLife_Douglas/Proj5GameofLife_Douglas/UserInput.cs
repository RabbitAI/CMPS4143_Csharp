/*
 *      Name: Christian Douglas 
 *      File: UserInput, Proj5GameofLife_Douglas
 *      Purpose: Gets the values entered into the textboxes from the user
 *      and applies the values to its respective components in GameForm.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj5GameofLife_Douglas
{
    public partial class UserInput : Form
    {
        private int grid;                               //variable for the GameBoard's dimensions
        private int gen;                                //variable for total number of generations
        private int maj;                                //variable for number of Majestics
        private int mim;                                //variable for number of Mimics
        private int fly;                                //variables for number of Flys
        public UserInput()
        {
            InitializeComponent();
        }

        /*
         *      Method Name: SetValues
         *      Return: void
         *      Purpose: Sets the values from the textboxes to member variables
         */
        public void SetValues()
        {
            try
            {
                grid = Convert.ToInt32(GridSizeInput.Text);
            }
            catch
            {
                MessageBox.Show("You have entered an incorrect value, defaulting to 10\n");
                grid = 10;
            }
            try
            {
                gen = Convert.ToInt32(GenNumInput.Text);
            }
            catch
            {
                MessageBox.Show("You have entered an incorrect value, defaulting to 5 generations\n");
                gen = 5;
            }
            try
            {
                maj = Convert.ToInt32(MajNumInput.Text);
            }
            catch
            {
                MessageBox.Show("You have entered an incorrect value\n");
                maj = 0;
            }
            try
            {
                mim = Convert.ToInt32(MimNumInput.Text);
            }
            catch
            {
                MessageBox.Show("You have entered an incorrect value\n");
                mim = 0;
            }
            try
            {
                fly = Convert.ToInt32(FlyNumInput.Text);
            }
            catch
            {
                MessageBox.Show("You have entered an incorrect value\n");
                fly = 0;
            }
        }

        /*
         *      Component Name: EnterButton
         *      Event: Click
         *      Purpose: Sends user's desired values to GameForm
         */
        private void EnterButton_Click(object sender, EventArgs e)
        {

            SetValues();
            GameForm gf = new GameForm(grid, gen, maj, mim, fly);
            gf.SetLabelValues(Convert.ToString(maj), Convert.ToString(mim),
                Convert.ToString(fly));
            gf.SetGameBoard();
            gf.Show();
            
            this.Close();                                                   //Closes UserInput form
        }
    }
}

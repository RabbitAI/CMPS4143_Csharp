/*
 *  Name: Christian Douglas
 *  File: GameForm, Proj5GameofLife_Douglas.cs
 *  Purpose: Takes the input values from UserInput to define 
 *  the number of actors printed on a 2d array called GameBoard.
 *  GameBoard is a 2d array of PictureBoxs each PictureBox relates to a class
 *  in Critters.dll, the PictureBoxs are for Majestic, Mimic, or Fly. 
 *  Fly moves during each generation, if it lands on a Majestic it
 *  eats and has another generation added to its life value, if fly
 *  lands on a Mimic its life value equals zero meaning it is dead
 *  and Mimic has another generation added to its life. Majestics
 *  and Flys can only live 5 generations without eating or they die.
 *  The size of the grid is defined in UserInput and sized by squaring
 *  the value of the input making the graph a square. The start button
 *  opens the UserInput form allowing the user to enter their desired 
 *  values. The quantity of each character along with an PictureBox that 
 *  represents each character.
 */
using Proj5GameofLife_Douglas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Critters;
using System.IO;

namespace Proj5GameofLife_Douglas
{
    /*
     *      Struct Name: MajesticStruct
     *      Purpose: Contains all the Majestic variables
     */
    struct MajesticStruct
    {
        public Image[] Majestic;
        public Actor M;
        public int majesticQuant;
    }
    /*
     *      Struct Name: MimicStruct
     *      Purpose: Contains all the Mimic variables
     */
    struct MimicStruct
    {
        public Image[] Mimic;
        public Actor N;
        public int mimicQuant;
    }
    /*
     *      Struct Name: FlyStruct
     *      Purpose: Contains all the Fly variables
     */
    struct FlyStruct
    {
        public Image[] Fly;
        public Actor F;
        public int flyQuant;
    }
    public partial class GameForm : Form
    {
        private int gridDim;                            //Dimension size for GameBoard
        private int generation;                         //Variable for number of generations
        private static int startGen;                    //Accumulator to traverse the grid through
                                                        //each generation
        private int imageSize = 50;                     //Variable for the size of each image initialized
                                                        //to 50
        private PictureBox[,] GameBoard;                //2D array of pictureboxes to contain the characters
                                                        //pictures 
        private MajesticStruct majS;                    //instances of the different character structs
        private MimicStruct mimS;
        private FlyStruct flyS;

        public GameForm()
        {
            InitializeComponent();
        }

        /*
         *      Method Name: GameForm
         *      Params: gridsize, gen, maj, mim, fly
         *      Purpose: Parameterized constructor  that intializes the variables
         *      taken from UserInput
         */
        public GameForm(int gridsize, int gen, int maj, int mim, int fly)
        {
            InitializeComponent();
            gridDim = gridsize;
            GameBoard = new PictureBox[gridDim, gridDim];
            generation = gen;
            startGen = 0;
            majS.majesticQuant = maj;
            mimS.mimicQuant = mim;
            flyS.flyQuant = fly;
        }

        /*
         *      Method Name: SetMjesticArray
         *      Return: Image
         *      Params: i
         *      Purpose: Creates a new array of images and initializes
         *      each element with images relating to Majesic and returns
         *      the image of one of the elements
         */
        private Image SetMajesticArray(int i)
        {
            majS.Majestic = new Image[3];
        
            majS.Majestic[0] = Resources.Seed;  
            majS.Majestic[1] = Resources.PlantSprout;
            majS.Majestic[2] = Resources.Majestic_Live;
                   
            return majS.Majestic[i];
        }

        /*
         *      Method Name: SetMimicArray
         *      Return: Image
         *      Params: i
         *      Purpose: Creates a new array of images and initializes
         *      each element with images relating to Mimic and returns
         *      the image of one of the elements
         */
        private Image SetMimicArray(int i)
        {
            
            mimS.Mimic = new Image[5];
            
            mimS.Mimic[0] = Resources.Seed;
            mimS.Mimic[1] = Resources.PlantSprout;
            mimS.Mimic[2] = Resources.mimic;
            mimS.Mimic[3] = Resources.DeadMimic_Plant;
            mimS.Mimic[4] = Resources.mimic_eat;
            
            return mimS.Mimic[i];
        }

        /*
         *      Method Name: SetFlyArray
         *      Return: Image
         *      Params: i
         *      Purpose: Creates a new array of images and initializes
         *      each element with images relating to Fly and returns
         *      the image of one of the elements
         */
        private Image SetFlyArray(int i)
        {
            flyS.Fly = new Image[2];

            flyS.Fly[0] = Resources.fly1;
            flyS.Fly[1] = Resources.dead_fly;
            
            return flyS.Fly[i];
        }

        /*
         *      Method Name: SetMjesticArray
         *      Return: void
         *      Params: maj, mim, fly
         *      Purpose: takes the values from UserInput form and 
         *      assigns the values to the labels in the Character
         *      Stats message box.
         */
        public void SetLabelValues(string maj, string mim, string fly)
        {
            MajNum.Text = maj;
            MimNum.Text = mim;
            FlyNum.Text = fly;
        }

        /*
         *      Method Name: SetGameBoard
         *      Return: void
         *      Purpose: Sets the user's desired amount of characters in random
         *      locations of GameBoard. 
         */
        public void SetGameBoard()
        {
            majS.M = new Majestic();                        //Creates a new object for Majestic class
            mimS.N = new Mimic();                           //Creates a new object for Mimic class
            flyS.F = new Fly();                             //Creates a new object for Fly Class

            Random randi = new Random();                    //Creates a new Random object called randi
            int x, y;                                       //Variables for the x and y coordinates 
            if (gridDim > 5)
            {
                imageSize = 280 / gridDim;                  //resizes the image to a percentage of
            }                                               //desired GameBoard size

            for (int i = 0; i < majS.majesticQuant; i++)    //Loops through desired number of Majestic
            {                                               //characters randomly setting their locations
                x = randi.Next(gridDim);                    //and attributes
                y = randi.Next(gridDim);

                GameBoard[x, y] = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Transparent,
                    Size = new Size(imageSize, imageSize),
                    Anchor = AnchorStyles.Left,
                    Image = SetMajesticArray(0),
                    Location = new Point(130 + (x * (imageSize + 2)), 80 + (y * (imageSize + 2))),
                    Visible = true
                };
                this.majS.M.Position(x, y);                //assigns the same coordinates for Majestic object
                                                           //to correlate with the image's location on GameBoard
                this.Controls.Add(GameBoard[x, y]);        //Initializes the image on the GameBoard
                majS.M = new Actor('M', x, y, gridDim);    //Creates a new object for the next Majestic
            }
            for (int i = 0; i < mimS.mimicQuant; i++)       //Does the same thing as the loop above but for Mimic
            {
                x = randi.Next(gridDim);
                y = randi.Next(gridDim);

                GameBoard[x, y] = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Transparent,
                    Size = new Size(imageSize, imageSize),
                    Anchor = AnchorStyles.Left,
                    Image = SetMimicArray(0),
                    Location = new Point(130 + (x * (imageSize + 5)), 80 + (y * (imageSize + 5))),
                    Visible = true
                };
                this.mimS.N.Position(x, y);
                this.Controls.Add(GameBoard[x, y]);
                mimS.N = new Actor('N', x, y, gridDim);
            }
            for (int i = 0; i < flyS.flyQuant; i++)         //Does the same as the above loops but for Fly
            {
                x = randi.Next(gridDim);
                y = randi.Next(gridDim);

                GameBoard[x, y] = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke,
                    Size = new Size(imageSize, imageSize),
                    Anchor = AnchorStyles.Left,
                    Image = SetFlyArray(0),
                    Location = new Point(130 + (x * (imageSize + 5)), 80 + (y * (imageSize + 5))),
                    Visible = true
                };
                this.flyS.F.Position(x, y);
                this.Controls.Add(GameBoard[x,y]);
                flyS.F = new Actor('F', x, y, gridDim);
            }
        }

        /*
         *      Component Name: StartButton
         *      Event: Click
         *      Purpose: Creates a new instance of UserInput and shows it
         */
        private void StartButton_Click(object sender, EventArgs e)
        {
            UserInput user = new UserInput();
            user.Show();
        }

        /*
         *      Component Name: NextButton
         *      Event: Click
         *      Purpose: Traverses through each scene of GameBoard until reaching
         *      the desired generation from the user. Moves the fly characters and
         *      grows the plant object(during the first 2 generations). Once 
         *      the end is reached the Next button is disabled.
         */
        private void NextButton_Click(object sender, EventArgs e)
        {
            startGen++;
            if (startGen <= generation)
            {
                GenBox.Text = "Generation: " + startGen;            //Prints each generation
                if(startGen == 1 || startGen == 2)                  //Conditional for the plant
                {                                                   //characters to grow
                    
                }
            }
            else NextButton.Enabled = false;                        //once the value is greater
                                                                    //than generation the button
                                                                    //is disabled.
        }
    }
}

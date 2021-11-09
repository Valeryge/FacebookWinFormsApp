using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class GameOfLifeForm : Form
    {
        private MyFacebookService k_FacebookService;

        public GameOfLifeForm(MyFacebookService i_FacebookService)
        {
            k_Engine = new GameEngine(k_GameRows, k_GameColumns, k_GameMatrixModel1);
            k_FacebookService = i_FacebookService;
            InitializeComponent();
            myInitComponents();
        }

        private void myInitComponents()
        {
            TableLayoutGameOfLife.RowCount = k_GameRows;
            TableLayoutGameOfLife.ColumnCount = k_GameColumns;
            TableLayoutGameOfLife.Size = new Size(k_CellLength * k_GameRows, k_CellLength * k_GameColumns);
            TableLayoutGameOfLife.BackgroundImage = k_FacebookService.GetRandomFriendImage();
            // Photo gamePhotos = FaceBookServices.getPhotos();
            //GridTemplateNum1 gt = k_Engine.
            createCellButtons();

            updatesVisualEffects();
            updateAndDrawNextGeneration();
            //updateAndDrawNextGeneration();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void createCellButtons()
        {
            for (int rowsIndex = 0; rowsIndex < k_GameRows; ++rowsIndex)
            {
                for (int columIndex = 0; columIndex < k_GameColumns; ++columIndex)
                {
                    {
                        TableLayoutGameOfLife.Controls.Add(new Button()
                        {
                            Dock = DockStyle.Fill,
                            Size = new Size(k_CellLength, k_CellLength),
                            //   Click  += new System.EventHandler(gameButtonClicked);  //TODO: doesn't work.

                            Padding = new Padding(0),
                            Margin = new Padding(0),
                            ForeColor = Color.Black
                        }, columIndex, rowsIndex);

                    }
                }
            }
        }

        private void gameButtonClicked(object i_Sender, EventArgs i_E)
        {
            throw new NotImplementedException();
        }



        //TODO: switch yellow color with pictures from facebook
        private void updatesVisualEffects()
        {
            {
                for (int rowIndex = 0; rowIndex < k_GameRows; ++rowIndex)
                {
                    for (int colIndex = 0; colIndex < k_GameColumns; ++colIndex)

                        if (k_Engine.TemplateCurrentlyBeingUsed.GameMatrix[rowIndex, colIndex] == 1)
                        {
                            //      Button currButton = TableLayoutGameOfLife.GetControlFromPosition(i, j) as Button;

                            // TableLayoutGameOfLife.GetControlFromPosition(colIndex, rowIndex).ForeColor = Color.Yellow;
                            TableLayoutGameOfLife.GetControlFromPosition(colIndex, rowIndex).Visible = false;
                            //    test();

                        }
                        else
                        {
                            // TableLayoutGameOfLife.GetControlFromPosition(colIndex, rowIndex).ForeColor = Color.Gray;
                            TableLayoutGameOfLife.GetControlFromPosition(colIndex, rowIndex).Visible = true;
                        }
                }
            }
        }

        private void updateAndDrawNextGeneration(object sender, EventArgs e)
        {
            k_Engine.UpdateToNextGeneration();
            updatesVisualEffects();
        }

        private void updateAndDrawNextGeneration()
        {
            k_Engine.UpdateToNextGeneration();
            updatesVisualEffects();
        }


        //TODO: Move to an engine class
        private void InitGameProgression()
        {
            System.Windows.Forms.Timer gameProgressionTimer = new System.Windows.Forms.Timer();
            gameProgressionTimer.Tick += updateAndDrawNextGeneration;
            gameProgressionTimer.Interval = 1000;
            gameProgressionTimer.Start();

        }


        private void NextGeneration_Load(object sender, EventArgs e)
        {
            InitGameProgression();

        }



        // private static void Main(string[] args)
        // {
        //     int runs = 0;
        //     LifeSimulation sim = new LifeSimulation(Heigth, Width);
        //
        //     while (runs++ < MaxRuns)
        //     {
        //         sim.updateAndDrawNextGeneration();
        //
        //         // Give the user a chance to view the game in a more reasonable speed.
        //         System.Threading.Thread.Sleep(100);
        //     }
        // }

        private readonly int k_CellLength = 30;
        private readonly int k_GameRows = 10;
        private readonly int k_GameColumns = 10;
        private readonly GameEngine k_Engine;
        private readonly int[,] k_GameMatrixModel1 =
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
            { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },


        };
        private readonly int[,] k_GameMatrixModel2 =
        {
            { 0, 0, 0, 0, 0},
            { 0, 0, 1, 0, 0},
            { 0, 0, 1, 0, 0},
            { 0, 0, 1, 0, 0},
            { 0, 0, 0, 0, 0},


        };
    }
}

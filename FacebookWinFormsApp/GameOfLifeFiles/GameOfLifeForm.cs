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
        public GameOfLifeForm(MyFacebookService i_FacebookService)
        {
            initGameTimer();
            k_Engine = new GameEngine(k_GameRows, k_GameColumns);
            k_FacebookService = i_FacebookService;
            InitializeComponent();
            myInitComponents();
        }

        private void initGameTimer()
        {
            m_GameProgressionTimer = new System.Windows.Forms.Timer();
            m_GameProgressionTimer.Tick += updateAndDrawNextGeneration;
            m_GameProgressionTimer.Interval = 1000;

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

        private void createCellButtons()
        {
            for (int rowsIndex = 0; rowsIndex < k_GameRows; ++rowsIndex)
            {
                for (int columIndex = 0; columIndex < k_GameColumns; ++columIndex)
                {
                    {
                        TableLayoutGameOfLife.Controls.Add(createGameButton()
                      , columIndex, rowsIndex);

                    }
                }
            }
        }

        private Button createGameButton()
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.Size = new Size(k_CellLength, k_CellLength);
            button.Click += new System.EventHandler(gameButton_Clicked);  //TODO: doesn't work.
            button.Padding = new Padding(0);
            button.Margin = new Padding(0);
            button.ForeColor = Color.Black;
            return button;
        }
        private void gameButton_Clicked(object i_Sender, EventArgs i_E)
        {
            TableLayoutPanelCellPosition position = TableLayoutGameOfLife.GetPositionFromControl(i_Sender as Button);
            k_Engine.GameBoard.ChangeValue(position.Row, position.Column);
            updatesVisualEffects();
        }



        //TODO: switch yellow color with pictures from facebook
        private void updatesVisualEffects()
        {
            {
                for (int rowIndex = 0; rowIndex < k_GameRows; ++rowIndex)
                {
                    for (int colIndex = 0; colIndex < k_GameColumns; ++colIndex)

                        if (k_Engine.GameBoard.GameMatrix[rowIndex, colIndex] == true)
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (isPlaying)
            {
                m_GameProgressionTimer.Stop();
                isPlaying = false;
                buttonStart.BackgroundImage = new Bitmap(BasicFacebookFeatures.Properties.Resources.START);

            } else
            {
                m_GameProgressionTimer.Start();
                isPlaying = true;
                buttonStart.BackgroundImage = new Bitmap(BasicFacebookFeatures.Properties.Resources.STOP);
            }
        }

        // private void buttonRules_MouseHover(object sender, EventArgs e)
        // {
        //     pictureBoxRules.Visible = true;
        //     Button button = sender as Button;
        //     
        // }
        //
        // private void buttonRules_MouseLeave(object sender, EventArgs e)
        // {
        //     pictureBoxRules.Visible = false;
        // }

      

        private void buttonNext_Click(object sender, EventArgs e)
        {
            updateAndDrawNextGeneration(sender,e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            k_Engine.restart();
            updatesVisualEffects();
        }


        private bool isPlaying = false;
        private MyFacebookService k_FacebookService;
        private readonly int k_CellLength = 30;

        private readonly int k_GameRows = 15;
        private readonly int k_GameColumns = 15;
        private readonly GameEngine k_Engine;
        private Timer m_GameProgressionTimer;//TODO: this should be inside the engine

        private void buttonRules_Click(object sender, EventArgs e)
        {
            pictureBoxRules.Visible = pictureBoxRules.Visible != true;
        }
    }
}

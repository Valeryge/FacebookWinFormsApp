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

                        if (k_Engine.TemplateCurrentlyBeingUsed.GameMatrix[rowIndex, colIndex] == true)
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

        private void buttonRules_MouseHover(object sender, EventArgs e)
        {
            pictureBoxRules.Visible = true;
        }

        private void buttonRules_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRules.Visible = false;
        }

      

        private void buttonNext_Click(object sender, EventArgs e)
        {
            updateAndDrawNextGeneration(sender,e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            k_Engine.restart();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private bool isPlaying = false;
        private MyFacebookService k_FacebookService;
        private readonly int k_CellLength = 30;
        private readonly int k_GameRows = 10;
        private readonly int k_GameColumns = 10;
        private readonly GameEngine k_Engine;
        private Timer m_GameProgressionTimer;//TODO: this should be inside the engine
    }
}

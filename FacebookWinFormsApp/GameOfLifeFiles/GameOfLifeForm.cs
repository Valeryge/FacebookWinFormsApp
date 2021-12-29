using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookApp.GameOfLifeFiles
{
    public partial class GameOfLifeForm : Form
    {
        public GameOfLifeForm(Image i_BackGroundImage, GameEngineFacade i_EngineControl)
        {
            initGameTimer();
            k_Engine = i_EngineControl;
            InitializeComponent();
            myInitComponents(i_BackGroundImage);
        }

        // public GameOfLifeForm(Image i_BackgroundImage, GameEngine i_GameEngine)
        // {
        //     initGameTimer();
        //     k_Engine = new GameEngineFacade(i_GameEngine);
        //     InitializeComponent();
        //     myInitComponents(i_BackgroundImage);
        // }

        private void initGameTimer()
        {
            m_GameProgressionTimer = new System.Windows.Forms.Timer();
            m_GameProgressionTimer.Tick += updateAndDrawNextGeneration;
            m_GameProgressionTimer.Interval = 1000;
        }

        private void myInitComponents(Image i_BackgroundImage)
        {
            TableLayoutGameOfLife.BackgroundImage = i_BackgroundImage;
            TableLayoutGameOfLife.RowCount = k_Engine.GetRows();
            TableLayoutGameOfLife.ColumnCount = k_Engine.GetCols(); ;
            TableLayoutGameOfLife.Size = new Size(k_CellLength * k_Engine.GetRows(), k_CellLength * k_Engine.GetCols());
            createCellButtons();
            updatesVisualEffects();
            updateAndDrawNextGeneration();

        }

        private void createCellButtons()
        {
            for (int rowsIndex = 0; rowsIndex < k_Engine.GetRows(); ++rowsIndex)
            {
                for (int columnIndex = 0; columnIndex < k_Engine.GetCols(); ++columnIndex)
                {
                    {
                        TableLayoutGameOfLife.Controls.Add(createGameButton()
                      , columnIndex, rowsIndex);
                    }
                }
            }
        }

        private Button createGameButton()
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.Size = new Size(k_CellLength, k_CellLength);
            button.Click += new System.EventHandler(gameButton_Clicked);
            button.Padding = new Padding(0);
            button.Margin = new Padding(0);
            button.ForeColor = Color.Black;
            return button;
        }
        private void gameButton_Clicked(object i_Sender, EventArgs i_E)
        {
            TableLayoutPanelCellPosition position = TableLayoutGameOfLife.GetPositionFromControl(i_Sender as Button);
            k_Engine.ChangeCell(position.Row, position.Column);
            updatesVisualEffects();
        }

        private void updatesVisualEffects()
        {
            {
                for (int rowIndex = 0; rowIndex < k_Engine.GetRows(); ++rowIndex)
                {
                    for (int colIndex = 0; colIndex < k_Engine.GetCols(); ++colIndex)
                    {
                        if (k_Engine.IsCellFull(rowIndex, colIndex))
                        {
                            TableLayoutGameOfLife.GetControlFromPosition(colIndex, rowIndex).Visible = false;
                        }
                        else
                        {
                            TableLayoutGameOfLife.GetControlFromPosition(colIndex, rowIndex).Visible = true;
                        }
                    }
                }

                labelRoundsCounter.Text = k_Engine.Rounds.ToString();
            }
        }

        private void updateAndDrawNextGeneration(object i_Sender, EventArgs i_E)
        {
            k_Engine.Update();
            updatesVisualEffects();
        }

        private void updateAndDrawNextGeneration()
        {
            k_Engine.Update();
            updatesVisualEffects();
        }

        private void buttonStart_Click(object i_Sender, EventArgs i_E)
        {
            if (isPlaying)
            {
                m_GameProgressionTimer.Stop();
                isPlaying = false;
                buttonStart.BackgroundImage = new Bitmap(FacebookApp.Properties.Resources.START);

            }
            else
            {
                m_GameProgressionTimer.Start();
                isPlaying = true;
                buttonStart.BackgroundImage = new Bitmap(FacebookApp.Properties.Resources.STOP);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            updateAndDrawNextGeneration(sender, e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            k_Engine.Restart();
            updatesVisualEffects();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            pictureBoxRules.Visible = pictureBoxRules.Visible != true;
        }

        private void GameOfLifeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPlaying)
            {
                m_GameProgressionTimer.Stop();
            }
        }

        private bool isPlaying = false;

        private readonly int k_CellLength = 30;
        private readonly Size cellSize;

        private readonly GameEngineFacade k_Engine;
        private Timer m_GameProgressionTimer;//TODO: this should be inside the engine     
    }
}

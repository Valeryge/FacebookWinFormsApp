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
            k_Engine = new GameEngine(k_GameRows, k_GameColumns);
            k_TableLayoutGameOfLife2 = new TableLayoutPanel();
            k_FacebookService = i_FacebookService;
            InitializeComponent();
            myInitComponents();
        }

        private void myInitComponents()
        {
           
            k_TableLayoutGameOfLife2.RowCount = k_GameRows;
            k_TableLayoutGameOfLife2.ColumnCount = k_GameColumns;

            k_TableLayoutGameOfLife2.Size = new Size(k_CellLength * k_GameRows, k_CellLength * k_GameColumns);
            createCellButtons();

            k_TableLayoutGameOfLife2.BackgroundImage = k_FacebookService.GetRandomFriendImage();

            // Photo gamePhotos = FaceBookServices.getPhotos();
            //GridTemplateNum1 gt = k_Engine.
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
                        Button button1 = createGameButton();
                    //     Button button2;
                    //     button2 = new Button()
                    //     {
                    //         Dock = DockStyle.Fill,
                    //         Size = new Size(k_CellLength, k_CellLength),
                    //         AutoSize = false,
                    //        
                    //         Padding = new Padding(0),
                    //         Margin = new Padding(0),
                    //         ForeColor = Color.Black
                    // };

                        k_TableLayoutGameOfLife2.Controls.Add(button1
                       , columIndex, rowsIndex);
                    }
                    
                   
                }
            }
        }
       


        //TODO: switch yellow color with pictures from facebook
        private void updatesVisualEffects()
        {
            {
                for (int rowIndex = 0; rowIndex < k_GameRows; ++rowIndex)
                {
                    for (int colIndex = 0; colIndex < k_GameColumns; ++colIndex)

                        if (k_Engine.CurrentlyBeingUsed.GameMatrix[rowIndex, colIndex] == 1)
                        {
                            //      Button currButton = TableLayoutGameOfLife2.GetControlFromPosition(i, j) as Button;

                            // TableLayoutGameOfLife2.GetControlFromPosition(colIndex, rowIndex).ForeColor = Color.Yellow;
                            k_TableLayoutGameOfLife2.GetControlFromPosition(colIndex, rowIndex).Visible = false;
                            //    test();

                        }
                        else
                        {
                            // TableLayoutGameOfLife2.GetControlFromPosition(colIndex, rowIndex).ForeColor = Color.Gray;
                            k_TableLayoutGameOfLife2.GetControlFromPosition(colIndex, rowIndex).Visible = true;
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
           // InitGameProgression();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = false;
                buttonStart.BackgroundImage = new Bitmap(BasicFacebookFeatures.Properties.Resources.START);
            } else
            {
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
     
        public void GameButton_Click(object i_Sender, EventArgs i_E)
        {
            TableLayoutPanelCellPosition position = k_TableLayoutGameOfLife2.GetPositionFromControl(i_Sender as Control);
            k_Engine.CurrentlyBeingUsed.GameMatrix[position.Row, position.Column] = 1 - k_Engine.CurrentlyBeingUsed.GameMatrix[position.Row, position.Column];
        }

        private Button createGameButton()
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            Size = new Size(k_CellLength, k_CellLength);
            // button.Click += GameButton_Click;
            Padding = new Padding(0);
            Margin = new Padding(0);
            ForeColor = Color.Black;
            return button;
        }

        private class GameButton : Button
        {
            private GameButton(int i_CellLength, int i_CellWidth, GameOfLifeForm form) : base()
            {
                Dock = DockStyle.Fill;
                Size = new Size(i_CellLength, i_CellWidth);
                MaximumSize = Size;
                Click += form.GameButton_Click;
                Padding = new Padding(0);
                Margin = new Padding(0);
                ForeColor = Color.Black;
            }
        }
        // private GameButton(int i_Length, int i_Highet)
        // {
        //     Dock = DockStyle.Fill;
        //     Size = new Size(i_Length, i_Highet);
        //     Click += new System.EventHandler(GameOfLifeForm.GameButtonClicked);  //TODO: doesn't work.
        //     Padding = new Padding(0);
        //     Margin = new Padding(0);
        //     ForeColor = Color.Black;
        // }

        private readonly int k_CellLength = 30;
        private readonly int k_GameRows = 10;
        private readonly int k_GameColumns = 10;
        private readonly GameEngine k_Engine;
        private bool isPlaying = false;
        private readonly MyFacebookService k_FacebookService;
        private readonly TableLayoutPanel k_TableLayoutGameOfLife2;
    }
}


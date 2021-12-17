
namespace FacebookApp.GameOfLifeFiles
{
    partial class GameOfLifeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayoutGameOfLife = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxRules = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRoundsCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutGameOfLife
            // 
            this.TableLayoutGameOfLife.BackColor = System.Drawing.Color.Black;
            this.TableLayoutGameOfLife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TableLayoutGameOfLife.ColumnCount = 2;
            this.TableLayoutGameOfLife.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.Location = new System.Drawing.Point(320, 25);
            this.TableLayoutGameOfLife.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutGameOfLife.Name = "TableLayoutGameOfLife";
            this.TableLayoutGameOfLife.RowCount = 2;
            this.TableLayoutGameOfLife.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.79012F));
            this.TableLayoutGameOfLife.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.20988F));
            this.TableLayoutGameOfLife.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutGameOfLife.TabIndex = 0;
            // 
            // pictureBoxRules
            // 
            this.pictureBoxRules.BackgroundImage = global::FacebookApp.Properties.Resources.gameoflife;
            this.pictureBoxRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRules.Location = new System.Drawing.Point(945, 161);
            this.pictureBoxRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRules.Name = "pictureBoxRules";
            this.pictureBoxRules.Size = new System.Drawing.Size(585, 415);
            this.pictureBoxRules.TabIndex = 6;
            this.pictureBoxRules.TabStop = false;
            this.pictureBoxRules.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::FacebookApp.Properties.Resources.RESET;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(15, 341);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 85);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::FacebookApp.Properties.Resources.START;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(15, 161);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(221, 85);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::FacebookApp.Properties.Resources.NEXT;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(15, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 85);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.BackgroundImage = global::FacebookApp.Properties.Resources.RULES;
            this.buttonRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRules.FlatAppearance.BorderSize = 0;
            this.buttonRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRules.Location = new System.Drawing.Point(1128, 40);
            this.buttonRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(221, 85);
            this.buttonRules.TabIndex = 1;
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Controls:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rounds passed:";
            // 
            // labelRoundsCounter
            // 
            this.labelRoundsCounter.AutoSize = true;
            this.labelRoundsCounter.Location = new System.Drawing.Point(156, 473);
            this.labelRoundsCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoundsCounter.Name = "labelRoundsCounter";
            this.labelRoundsCounter.Size = new System.Drawing.Size(16, 17);
            this.labelRoundsCounter.TabIndex = 9;
            this.labelRoundsCounter.Text = "0";
            // 
            // GameOfLifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1554, 651);
            this.Controls.Add(this.labelRoundsCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRules);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.TableLayoutGameOfLife);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameOfLifeForm";
            this.Text = "GameOfLifeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOfLifeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutGameOfLife;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBoxRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRoundsCounter;
    }
}
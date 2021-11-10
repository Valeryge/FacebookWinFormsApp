
namespace BasicFacebookFeatures
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
            this.TableLayoutGameOfLife.Location = new System.Drawing.Point(2, 0);
            this.TableLayoutGameOfLife.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutGameOfLife.Name = "TableLayoutGameOfLife";
            this.TableLayoutGameOfLife.RowCount = 2;
            this.TableLayoutGameOfLife.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutGameOfLife.TabIndex = 0;
            // 
            // pictureBoxRules
            // 
            this.pictureBoxRules.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.gameoflife;
            this.pictureBoxRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRules.Location = new System.Drawing.Point(133, 160);
            this.pictureBoxRules.Name = "pictureBoxRules";
            this.pictureBoxRules.Size = new System.Drawing.Size(733, 448);
            this.pictureBoxRules.TabIndex = 6;
            this.pictureBoxRules.TabStop = false;
            this.pictureBoxRules.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.RESET;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(723, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 85);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.START;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(723, 171);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(221, 85);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.NEXT;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(723, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 85);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonRules
            // 
            this.buttonRules.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.RULES;
            this.buttonRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRules.FlatAppearance.BorderSize = 0;
            this.buttonRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRules.Location = new System.Drawing.Point(723, 69);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(221, 85);
            this.buttonRules.TabIndex = 1;
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.MouseLeave += new System.EventHandler(this.buttonRules_MouseLeave);
            this.buttonRules.MouseHover += new System.EventHandler(this.buttonRules_MouseHover);
            // 
            // GameOfLifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1003, 651);
            this.Controls.Add(this.pictureBoxRules);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.TableLayoutGameOfLife);
            this.Name = "GameOfLifeForm";
            this.Text = "GameOfLifeForm";
            this.Load += new System.EventHandler(this.NextGeneration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutGameOfLife;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBoxRules;
    }
}
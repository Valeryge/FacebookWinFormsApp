
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
            this.SuspendLayout();
            // 
            // TableLayoutGameOfLife
            // 
            this.TableLayoutGameOfLife.ColumnCount = 2;
            this.TableLayoutGameOfLife.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutGameOfLife.Name = "TableLayoutGameOfLife";
            this.TableLayoutGameOfLife.RowCount = 2;
            this.TableLayoutGameOfLife.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutGameOfLife.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutGameOfLife.TabIndex = 0;
            // 
            // GameOfLifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutGameOfLife);
            this.Name = "GameOfLifeForm";
            this.Text = "GameOfLifeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutGameOfLife;
    }
}
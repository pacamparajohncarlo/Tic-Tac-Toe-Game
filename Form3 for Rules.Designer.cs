namespace Tic_Tac_Toe_Game
{
    partial class Form3_for_Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_for_Rules));
            this.gameplaymechanics = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameplaymechanics
            // 
            this.gameplaymechanics.AutoSize = true;
            this.gameplaymechanics.BackColor = System.Drawing.Color.Silver;
            this.gameplaymechanics.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameplaymechanics.Location = new System.Drawing.Point(26, 108);
            this.gameplaymechanics.Name = "gameplaymechanics";
            this.gameplaymechanics.Size = new System.Drawing.Size(753, 200);
            this.gameplaymechanics.TabIndex = 0;
            this.gameplaymechanics.Text = resources.GetString("gameplaymechanics.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "RULES FOR TIC-TAC-TOE";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(278, 358);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(163, 31);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back to Menu";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Form3_for_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameplaymechanics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3_for_Rules";
            this.Text = "How to play?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameplaymechanics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
    }
}
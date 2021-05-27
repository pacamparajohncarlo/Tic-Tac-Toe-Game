namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playbttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonquit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playbttn
            // 
            this.playbttn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbttn.Location = new System.Drawing.Point(48, 238);
            this.playbttn.Name = "playbttn";
            this.playbttn.Size = new System.Drawing.Size(133, 37);
            this.playbttn.TabIndex = 0;
            this.playbttn.Text = "Play";
            this.playbttn.UseVisualStyleBackColor = true;
            this.playbttn.Click += new System.EventHandler(this.Playbttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIC TAC TOE GAME";
            // 
            // buttonquit
            // 
            this.buttonquit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonquit.Location = new System.Drawing.Point(48, 281);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(133, 37);
            this.buttonquit.TabIndex = 2;
            this.buttonquit.Text = "Quit";
            this.buttonquit.UseVisualStyleBackColor = true;
            this.buttonquit.Click += new System.EventHandler(this.Buttonquit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "How to play?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.istockphoto_691550798_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playbttn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playbttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonquit;
        private System.Windows.Forms.Button button1;
    }
}


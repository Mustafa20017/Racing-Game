namespace Final_Project_Module_2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.reward = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.rdtrack2 = new System.Windows.Forms.PictureBox();
            this.rdtrack1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.reward);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.rdtrack2);
            this.panel1.Controls.Add(this.rdtrack1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 422);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gametime
            // 
            this.gametime.Interval = 20;
            this.gametime.Tick += new System.EventHandler(this.gametimertick);
            // 
            // txt_player1
            // 
            this.txt_player1.Location = new System.Drawing.Point(168, 489);
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(160, 20);
            this.txt_player1.TabIndex = 3;
            this.txt_player1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_player2
            // 
            this.txt_player2.Location = new System.Drawing.Point(168, 515);
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(160, 20);
            this.txt_player2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 1 Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 2 Name";
            // 
            // player2
            // 
            this.player2.Image = global::Final_Project_Module_2.Properties.Resources.CarRed;
            this.player2.Location = new System.Drawing.Point(98, 331);
            this.player2.Margin = new System.Windows.Forms.Padding(2);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(38, 80);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 7;
            this.player2.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Final_Project_Module_2.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(244, 331);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 80);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::Final_Project_Module_2.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(60, 258);
            this.explosion.Margin = new System.Windows.Forms.Padding(2);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(48, 52);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // reward
            // 
            this.reward.Image = global::Final_Project_Module_2.Properties.Resources.bronze;
            this.reward.Location = new System.Drawing.Point(70, 162);
            this.reward.Margin = new System.Windows.Forms.Padding(2);
            this.reward.Name = "reward";
            this.reward.Size = new System.Drawing.Size(188, 81);
            this.reward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reward.TabIndex = 4;
            this.reward.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::Final_Project_Module_2.Properties.Resources.carGrey;
            this.car2.Location = new System.Drawing.Point(251, 46);
            this.car2.Margin = new System.Windows.Forms.Padding(2);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(38, 81);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 3;
            this.car2.TabStop = false;
            this.car2.Tag = "carright";
            // 
            // car1
            // 
            this.car1.Image = global::Final_Project_Module_2.Properties.Resources.carGreen;
            this.car1.Location = new System.Drawing.Point(70, 46);
            this.car1.Margin = new System.Windows.Forms.Padding(2);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(38, 82);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 2;
            this.car1.TabStop = false;
            this.car1.Tag = "carleft";
            // 
            // rdtrack2
            // 
            this.rdtrack2.Image = global::Final_Project_Module_2.Properties.Resources.roadTrack;
            this.rdtrack2.Location = new System.Drawing.Point(0, 0);
            this.rdtrack2.Margin = new System.Windows.Forms.Padding(2);
            this.rdtrack2.Name = "rdtrack2";
            this.rdtrack2.Size = new System.Drawing.Size(356, 422);
            this.rdtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rdtrack2.TabIndex = 1;
            this.rdtrack2.TabStop = false;
            // 
            // rdtrack1
            // 
            this.rdtrack1.Image = global::Final_Project_Module_2.Properties.Resources.roadTrack;
            this.rdtrack1.Location = new System.Drawing.Point(0, -422);
            this.rdtrack1.Margin = new System.Windows.Forms.Padding(2);
            this.rdtrack1.Name = "rdtrack1";
            this.rdtrack1.Size = new System.Drawing.Size(356, 422);
            this.rdtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rdtrack1.TabIndex = 0;
            this.rdtrack1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(194, 552);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Score Board";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 628);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_player2);
            this.Controls.Add(this.txt_player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox reward;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox rdtrack2;
        private System.Windows.Forms.PictureBox rdtrack1;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project_Module_2
{
   
    public partial class Form1 : Form
    {
        int speed = 14;
        int rdspeed =15;
        int trafficsp = 12;
        int score = 0;
        bool left,right;
        bool left2, right2;

        //for random car 
        Random rnd = new Random();

        // for random car position
        Random carposition = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=WIN10WS7;Initial Catalog=RacingGame;Integrated Security=True");

        private void Reset()
        {       
            // hide image and setting default value of score and speed
            reward.Visible = false;
            button1.Enabled = false;
            txt_player1.Enabled = false;
            txt_player2.Enabled = false;
            button2.Enabled = false;
            explosion.Visible = false;
            trafficsp = 12;
            rdspeed = 15;
            score = 0;

            

            left = false;
            right = false;

           // moving cars to default position
            car1.Top = carposition.Next(200, 500) * -1;
            car1.Left = carposition.Next(6, 194);

            car2.Top = carposition.Next(200, 500) * -1;
            car2.Left = carposition.Next(248, 422);
            player.Location = new Point(250, 320);
            player2.Location = new Point(90, 320);
            //player.Left = carposition.Next(248, 422);


            // start game 
            gametime.Start();

        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left )
            {
                left = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left2 = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right2 = true;
            }
            if (e.KeyCode == Keys.Right )
            {
                right = true;
            }
        }

      

        private void keyup(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.Left)
            {
                left =false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left2 = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right2 = false;
            }
        }

        private void gametimertick(object sender, EventArgs e)
        {
            //score increase on move display on label
            label1.Text = "Score: " + score;
            score++;

            //bouncing back car from edges of track
            if(left == true && player.Left > 180)
            {
                player.Left -= speed;
            }
            if (right == true && player.Left + player.Width< 350)
            {
                player.Left += speed;
            }
            if (left2 == true && player2.Left > 10)
            {
                player2.Left -= speed;
            }
            if (right2 == true && player2.Left + player2.Width < 180)
            {
                player2.Left += speed;
            }

            //track moving with roadspeed 
            rdtrack1.Top += rdspeed;
            rdtrack2.Top += rdspeed;

            //moving both track in a loop 
            if (rdtrack1.Top > 519)
            {
                rdtrack1.Top = -519;
            }
            if (rdtrack2.Top > 519)
            {
                rdtrack2.Top = -519;
            }

            //move car down 
            car1.Top += trafficsp;
            car2.Top += trafficsp;

           // show different car
            if (car1.Top > 530)
            {
                changecar(car1);
                
            }
            if (car2.Top > 530)
            {
                changecar(car2);

            }

            // car hit
            if (player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
            {

                gameover(player, "Player 2");
            }
            if (player2.Bounds.IntersectsWith(car1.Bounds) || player2.Bounds.IntersectsWith(car2.Bounds))
            {


                gameover(player2, "Player 1");

            }

            //generate reward on score and icreasing speed on increase of score
            if (score > 100 && score < 500)
            {
                reward.Image = Properties.Resources.bronze;
            }
            else if (score > 500 && score < 1000)
            {
                reward.Image = Properties.Resources.silver;
                trafficsp = 20;
                rdspeed = 22;
            }
            else if (score > 1200)
            {
                reward.Image = Properties.Resources.gold;
                trafficsp =27;
                rdspeed = 25;
            }


        }
        // car generating method
        private void changecar(PictureBox car)
        {
            int num = rnd.Next(1, 9);

            switch (num)
            {
                case 1:
                    car.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    car.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    car.Image = Properties.Resources.carPink;
                    break;
                case 4:
                    car.Image = Properties.Resources.CarRed;
                    break;
                case 5:
                    car.Image = Properties.Resources.carYellow;
                    break;
                case 6:
                    car.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    car.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    car.Image = Properties.Resources.TruckWhite;
                    break;
                case 9:
                    car.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }

            // car respawn randomly on track
            car.Top = carposition.Next(100, 400) * -1;

            if((string)car.Tag == "carleft")
            {
                car.Left = carposition.Next(6, 185);
            }
            if((string)car.Tag == "carright")
            {
                car.Left = carposition.Next(248, 418);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        public bool IsValid()
        {
            if (txt_player1.Text == string.Empty)
            {
                MessageBox.Show("Player 1 Name is Required");
                return false;
            }
            else if (txt_player2.Text == string.Empty)
            {
                MessageBox.Show("Player 2 Name is Required");
                return false;
            }            
            else
            {
                return true;
            }
        }
        private void gameover(PictureBox player,string PLayer)
        {
            //stop game on car hit and display reward
            gametime.Stop();

            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            reward.Visible = true;
            reward.BringToFront();
            MessageBox.Show(""+ PLayer + " Won");

            SqlCommand cmd = new SqlCommand("INSERT INTO Player_log VALUES (@Player_1, @Player_2, @score)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Player_1", txt_player1.Text);
            cmd.Parameters.AddWithValue("@Player_2", txt_player2.Text);
            cmd.Parameters.AddWithValue("@score", score-1);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txt_player1.Text = "";
            txt_player2.Text = "";
            button1.Enabled = true;
            txt_player1.Enabled = true;
            txt_player2.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
              


                Reset();
            }
        }

       
       
    }
}

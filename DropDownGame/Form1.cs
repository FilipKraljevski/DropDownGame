using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownGame
{
    public partial class Form1 : Form
    {
        Scene Scene;
        String[] Comments = {"Rookie!", "Not bad!", "You are getting good at this!", "You are doing a great job!", "This is excellent!",
        "Wow wow chill!", "Relax bro it is just a game!" , "Are you even a human?", "Is this the power of a god?", 
        "Okay there is no point in showing off"};
        int count = 3;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Scene = new Scene(new Player(player), panel1);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Scene.Move();
            lblScore.Text = "Score: " + Scene.Player.score;
            if(Scene.Player.score == 200)
            {
                gameTimer.Stop();
                DialogResult dialogResult = MessageBox.Show("Congratulations, you beat the game, you could be proud of yourself!!!", "VICTORY", 
                    MessageBoxButtons.OK);
                if(dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            lblComments.Text = Comments[Scene.I];
            if (Scene.Player.player.Top + Scene.Player.player.Height < 0 || Scene.Player.player.Top > Scene.Panel.Height)
            {
                gameTimer.Stop();
                DialogResult dialogResult = MessageBox.Show("You lose! Do you want to start a new game?\nYour score: " + Scene.Player.score + 
                    "\t Score left to win: " + (200 - Scene.Player.score), "GAME OVER", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Scene.Player.moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Scene.Player.moveRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Scene.Player.moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Scene.Player.moveRight = false;
            }
        }

        private void readyTimer_Tick(object sender, EventArgs e)
        {
            if(count == 0)
            {
                gameTimer.Start();
                readyTimer.Stop();
            }
            else
            {
                lblComments.Text = "Ready in " + count;
            }
            count--;
        }
    }
}

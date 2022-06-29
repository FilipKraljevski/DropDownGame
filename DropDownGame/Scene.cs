using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownGame
{
    public class Scene
    {
        public Player Player { get; set; }
        public Panel Panel { get; set; }
        public static Random Rnd { get; set; } = new Random();
        public int LastGravity { get; set; }
        public int LastSpeed { get; set; }
        public int PlatformsSpeed { get; set; } = 5;
        public int GxSxPS { get; set; } = 1;
        public int I { get; set; } = 0;

        public Scene(Player player, Panel panel)
        {
            Player = player;
            Panel = panel;
            LastGravity = Player.gravity;
            LastSpeed = Player.speed;
        }

        public void Move()
        {
            Player.player.Top += Player.gravity;
            if (Player.moveLeft && Player.player.Left > 1)
            {
                Player.player.Left -= Player.speed;
            }
            if (Player.moveRight && Player.player.Left + Player.player.Width < Panel.Width)
            {
                Player.player.Left += Player.speed;
            }
            foreach (Control x in Panel.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    x.Top -= PlatformsSpeed;
                    if (x.Top < Panel.Top - x.Height)
                    {
                        x.Top = Panel.Height + x.Height;
                        x.Width = Rnd.Next(100, 400);
                        Player.score++;
                        if (Player.score % 20 == 0)
                        {
                            if (GxSxPS == 1)
                            {
                                LastGravity += 2;
                            }
                            else if(GxSxPS == 2)
                            {
                                LastSpeed += 2;
                            }
                            else
                            {
                                PlatformsSpeed++;
                                GxSxPS = 0;
                            }
                            GxSxPS++;
                            I++;
                        }
                    }
                    if (Player.player.Bounds.IntersectsWith(x.Bounds))
                    {
                        Player.gravity = 0;
                        Player.player.Top = x.Top - Player.player.Height;
                    }
                    else
                    {
                        Player.gravity = LastGravity;
                        Player.speed = LastSpeed;
                    }
                }
            }
        }
    }
}

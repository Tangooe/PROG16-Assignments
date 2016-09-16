using System;
using System.Media;
using System.Windows.Forms;
using Assignment02_Shotgun.Classes;
using Assignment02_Shotgun.Extensions;

namespace Assignment02_Shotgun
{
    public partial class Form1 : Form
    {
        SoundPlayer sfxReload = new SoundPlayer(Properties.Resources.Reload);

        public Form1()
        {
            sfxReload.Load();
            InitializeComponent();
        }

        #region - Button Events -

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (Player.BulletCount != 0 && Player.BulletCount < 3)
            {
                var aiAction = Opponent.AI();

                if (aiAction == "Reload")
                {
                    IconRecolor.PlayerRecolor("Shoot");
                    Player.ShootPistol();

                    EndScreen("You Won!", "Congratulations");
                }
                else if (aiAction == "Shoot")
                {
                    IconRecolor.PlayerRecolor("Shoot");
                    Player.ShootPistol();

                    //EndScreen("It's a Tie", "Game over");
                }
                else if (aiAction == "Block")
                {
                    IconRecolor.PlayerRecolor("Shoot");
                    Player.ShootPistol();
                }
            }

            else if(Player.BulletCount >= 3)
            {
                Player.ShootShotgun();

                EndScreen("You Won!", "Congratulations");
            }

            else
            {
                var sfxEmptyGunShot = new SoundPlayer(Properties.Resources.EmptyGunShot);
                sfxEmptyGunShot.Play();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            IconRecolor.PlayerRecolor("Reload");
  
            if (Opponent.AI() == "Shoot")
            {
                SoundPlayer sfxShoot = new SoundPlayer(Properties.Resources.GunShot02);
                sfxShoot.Play();

                EndScreen("You Lost","Game Over");
            }
            else
            {
                sfxReload.Play();

                ++Player.BulletCount;
                lblBullets.Text = lblBullets.Text.ReplaceLastChar(Player.BulletCount);

                if (Player.BulletCount >= 3)
                {
                    btnShoot.BackgroundImage = Properties.Resources.Shotgun;
                }
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Opponent.AI();
            IconRecolor.PlayerRecolor("Block");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region - End of Game -

        private void EndScreen(string text, string title)
        {
            text = text + "\n Do you want to play again?";
            if (MessageBox.Show(text, title, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                Close();
            }
        }

        private void RestartGame()
        {
            Opponent.BulletCount = 0;
            lblAIBullets.Text = lblAIBullets.Text.ReplaceLastChar(0);

            Player.BulletCount = 0;
            lblBullets.Text = lblBullets.Text.ReplaceLastChar(0);

            IconRecolor.AiRecolor("Default");
            IconRecolor.PlayerRecolor("Default");
        }

        #endregion
    }
}
 
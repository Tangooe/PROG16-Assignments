using Assignment02_Shotgun.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02_Shotgun.Classes
{
    public class Player
    {
        public static int BulletCount { get; set; }
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void ShootShotgun()
        {
            var sfxShotGunShot = new SoundPlayer(Properties.Resources.GunShot01);

            sfxShotGunShot.Play();

            BulletCount = 0;
            form.lblBullets.Text = form.lblBullets.Text.ReplaceLastChar(BulletCount);
        }

        public static void ShootPistol()
        {
            var sfxPistolShot = new SoundPlayer(Properties.Resources.GunShot02);

            sfxPistolShot.Play();

            --BulletCount;
            form.lblBullets.Text = form.lblBullets.Text.ReplaceLastChar(BulletCount);
        }
    }
}

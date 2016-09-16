using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02_Shotgun.Classes
{
    public static class ButtonColorChange
    {
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void PlayerRecolor(string icon)
        {
            //var reload = Properties.Resources.Reload;
            //var reloadRed = Properties.Resources.ReloadRed;
            //var shield = Properties.Resources.Shield;
            //var shieldRed = Properties.Resources.ShieldRed;
            //var gunRight = Properties.Resources.GunRight;
            //var gunRightRed = Properties.Resources.GunRightRed;
            //var gunLeft = Properties.Resources.GunLeft;
            //var gunLeftRed = Properties.Resources.GunLeftRed;

            form.btnReload.BackgroundImage = Properties.Resources.Reload1;
            form.btnShoot.BackgroundImage = Properties.Resources.GunRight;
            form.btnBlock.BackgroundImage = Properties.Resources.Shield;

            switch (icon)
            {
                case "Reload":
                    form.btnReload.BackgroundImage = Properties.Resources.ReloadRed;
                    break;

                case "Block":
                    form.btnBlock.BackgroundImage = Properties.Resources.ShieldRed;
                    break;

                case "Shoot":
                    form.btnShoot.BackgroundImage = Properties.Resources.GunRightRed;
                    break;

                default:
                    break;
            }
        }

        public void AiRecolor(string icon)
        {
            form.btnAIReload.BackgroundImage = Properties.Resources.Reload1;
            form.btnAIShoot.BackgroundImage = Properties.Resources.GunLeft;
            form.btnAIBlock.BackgroundImage = Properties.Resources.Shield;

            switch (icon)
            {

                case "Reload":
                    form.btnAIReload.BackgroundImage = Properties.Resources.ReloadRed;
                    break;

                case "Block":
                    form.btnAIBlock.BackgroundImage = Properties.Resources.ShieldRed;
                    break;

                case "Shoot":
                    form.btnAIShoot.BackgroundImage = Properties.Resources.GunLeftRed;
                    break;

                default:
                    break;
            }
        }
    }
}

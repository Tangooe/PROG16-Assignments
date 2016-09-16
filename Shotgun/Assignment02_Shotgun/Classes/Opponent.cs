using Assignment02_Shotgun.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02_Shotgun.Classes
{
    class Opponent
    {
        public static int BulletCount { get; set; }
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static string AI()
        {
            var r = new Random();
            var randomAction = r.Next(1, 4);

            if (Player.BulletCount == 0)
            {
                randomAction = 1;
            }

            else if(Player.BulletCount == 0 && BulletCount >= 1 && randomAction == 3)
            {
                randomAction = r.Next(1, 3);
            }

            else if (Player.BulletCount >= 1 && BulletCount == 0)
            {
                randomAction = 3;
            }
            else if (BulletCount >= 3)
            {
                IconRecolor.AiRecolor("Shotgun");
                randomAction = 2;
            }

            switch (randomAction)
            {
                case 1: //RELOAD
                    IconRecolor.AiRecolor("Reload");

                    ++BulletCount;
                    form.lblAIBullets.Text = form.lblAIBullets.Text.ReplaceLastChar(BulletCount);
                    return "Reload";

                case 2: //SHOOT
                    if (BulletCount != 0)
                    {
                        IconRecolor.AiRecolor("Shoot");

                        --BulletCount;
                        form.lblAIBullets.Text = form.lblAIBullets.Text.ReplaceLastChar(BulletCount);
                        return "Shoot";
                    }
                    else
                    {
                        AI();
                        return "Nothing";
                    }

                case 3: //BLOCK
                    IconRecolor.AiRecolor("Block");
                    return "Block";

                default:
                    return "Error";
            }
        }
    }
}

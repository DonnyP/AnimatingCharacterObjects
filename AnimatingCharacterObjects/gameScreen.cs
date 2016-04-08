using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AnimatingCharacterObjects
{
    public partial class gameScreen : UserControl
    {
        #region Variables | List
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;
        List<monsterClass> monster  = new List<monsterClass>();
        List<bulletClass> ammo = new List<bulletClass>();
        playerClass pc;
        monsterClass mc;
        bulletClass bc;
        

        int leftStartX = 100;
        int playerSize = 30;
        int playerSpeed = 7;
        int direction = 0;

        Image[] monsterImages = new Image[] {Properties.Resources.notdonnyDown, Properties.Resources.notdonnyUp,
            Properties.Resources.notdonnyLeft, Properties.Resources.notdonnyRight};

        Image[] playerImages = new Image[] {Properties.Resources.RedGuyDown, Properties.Resources.RedGuyUp,
            Properties.Resources.RedGuyLeft,Properties.Resources.RedGuyRight};

        #endregion 

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (upArrowDown == true)
            {
                direction = 1;
                pc.move(pc, "up");
            }
            else if (downArrowDown == true)
            {
                direction = 0;
                pc.move(pc, "down");
            }
            else if (leftArrowDown == true)
            {
                direction = 2;
                pc.move(pc, "left");
            }
            else if (rightArrowDown == true)
            {
                direction = 3;
                pc.move(pc, "right");
            }
            Refresh();
            #region Monster following player

            //Monster following player
            if (pc.x - mc.x < 0)
            {
                mc.move(mc, "left");
            }
            else if (pc.x - mc.x > 0)
            {
                mc.move(mc, "right");
            }
            if (pc.y - mc.y < 0)
            {
                mc.move(mc, "up");
            }
            else if (pc.y - mc.y > 0)
            {
                mc.move(mc, "down");
            }
            Refresh();
            #endregion

            foreach (bulletClass bc in ammo)
            {
                bc.move(bc);

                if (bc.x > this.Width || bc.x < 0 || bc.y > this.Height || bc.y < 0)
                {
                    ammo.Remove(bc);
                    break;
                }
            }
            if (spaceDown == true && ammo.Count() < 4)
            {
               // bulletClass bc = new bulletClass(pc.x + (pc.size / 2), pc.y + (pc.size / 2), 2, 10, pc.direction);
                ammo.Add(bc);
            }

        }
        public gameScreen()
        {
            InitializeComponent();
            pc = new playerClass(leftStartX, 30, playerSize, playerSpeed, playerImages);
        }
        private void gameScreen_Load(object sender, EventArgs e)
        {
             mc = new monsterClass(leftStartX, 0, playerSize, 4, monsterImages);
            monster.Add(mc);
            timer1.Enabled = true;
            timer1.Start();
            this.Focus();
        }
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush bulletbrush = new SolidBrush(Color.DarkOrange);
            foreach (bulletClass bc in ammo)
            {
                e.Graphics.FillRectangle(bulletbrush, bc.x, bc.y, bc.size, bc.size);
            }
            e.Graphics.DrawImage(pc.playerImages[direction], pc.x, pc.y, pc.size, pc.size);
            e.Graphics.DrawImage(mc.monsterImages[direction], mc.x, mc.y, mc.size, mc.size);
        }
        #region Buttons
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}

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
        List<monsterClass> ghost = new List<monsterClass>();
        playerClass player1;
        monsterClass mc;
        List<bulletClass> bullet = new List<bulletClass>();

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
                player1.move(player1, "up");
            }
            else if (downArrowDown == true)
            {
                direction = 0;
                player1.move(player1, "down");
            }
            else if (leftArrowDown == true)
            {
                direction = 2;
                player1.move(player1, "left");
            }
            else if (rightArrowDown == true)
            {
                direction = 3;
                player1.move(player1, "right");
            }
            Refresh();
        }
        public gameScreen()
        {
            InitializeComponent();
            player1 = new playerClass(leftStartX, 30, playerSize, playerSpeed, playerImages);
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
        private void gameScreen_Load(object sender, EventArgs e)
        {
             mc = new monsterClass(leftStartX, 0, playerSize, playerSpeed, monsterImages);

            ghost.Add(mc);
            timer1.Enabled = true;
            timer1.Start();
            this.Focus();
        }
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(player1.playerImages[direction], player1.x, player1.y, player1.size, player1.size);
            e.Graphics.DrawImage(mc.monsterImages[direction], mc.x, mc.y, mc.size, mc.size);
        }
    }
}

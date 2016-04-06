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
        int playerObject;
        List<monsterClass> ghost = new List<monsterClass>();
        playerClass me;
        List<bulletClass> bullet = new List<bulletClass>();

        int leftStartX = 300;
        int playerSize = 30;
        int playerSpeed = 7;
        
        int patternDirection = 0;  // 0 = left, 1 = right
        int patternLength = 4;
        int xChange = 7;
        int gameScore = 0;

        Image[] monsterImages = new Image[] { Properties.Resources.RedGuyDown, Properties.Resources.RedGuyDown,
            Properties.Resources.RedGuyDown,Properties.Resources.RedGuyDown
        };

        public gameScreen()
        {
            InitializeComponent();

        }

        private void gameScreen_Load(object sender, EventArgs e)
        {
            //LEFT OFF HERE
            monsterClass mc = new monsterClass(leftStartX, 0, playerSize, playerSpeed, monsterImages);
           // ghost.Add(mc);

 

        }
    }
}

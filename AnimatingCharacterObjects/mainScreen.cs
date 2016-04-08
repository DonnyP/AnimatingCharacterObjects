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
    public partial class mainScreen : UserControl
    {
        public mainScreen()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();
            f.Controls.Add(gs);
            //gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
        }
    }
}

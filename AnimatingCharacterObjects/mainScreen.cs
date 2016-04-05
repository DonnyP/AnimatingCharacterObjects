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

            bulletClass bc = new bulletClass(4, 45, 10, 8, "left");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSpapers
{
    public partial class Newpapers_Redit : Form
    {
        public Model1 db { get; set; }
        public Agent prod { get; set; }
        
        public Newpapers_Redit()
        {
            InitializeComponent();
        }

        public class TypeOfAgComboBox
        {
            public int id { get; set; }
            public string ageent { get; set; }
        }
        private void Newpapers_Redit_Load(object sender, EventArgs e)
        {
            var tp = from p in db.Agent
                     where p.ID == prod.ID
                     select p.Title;

        }
    }
}

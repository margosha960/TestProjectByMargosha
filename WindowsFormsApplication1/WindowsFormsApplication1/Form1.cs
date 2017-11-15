using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			
        }
		public function createEverything(){
			Label name = new Label();
			name.Text = "The best project in the world!";
			Label query = new Label();
			query.Text = "Do you agree?";
			Button yes = new Button();
			yes.Text = "Yes";
			Button no = new Button();
			no.Text = "No";
			name.Position.X = 10;
			name.Position.Y = 10;
			query.Position.X = 10;
			query.Position.Y = 30;
			yes.Position.X = 25;
			yes.Position.Y = 50;
			no.Position.X = 75;
			no.Position.Y = 50;
			this.Elements.Add(name);
			this.Elements.Add(query);
			this.Elements.Add(yes);
			this.Elements.Add(no);
		}
    }
}

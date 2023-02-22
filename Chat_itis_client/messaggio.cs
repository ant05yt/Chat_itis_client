using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_itis_client
{
    public partial class messaggio : UserControl
    {
        
        public messaggio()
        {
            InitializeComponent();

        }
        #region Properties
        [Category("Custom Props")]
        private string _messaggio;
        public string Messaggio
        {
            get { return _messaggio; }
            set { _messaggio = value; lbl_messaggio.Text = value; }
        }
        [Category("Custom Props")]
        private string _data;
        public string Data
        {
            get { return _data; }
            set { _data = value; lbl_data.Text = value; }
        }
        [Category("Custom Props")]
        private string _contatto;
        public string Contatto
        {
            get { return _contatto; }
            set { _contatto = value; lbl_contatto.Text = value; }
        }
        private Color _colore;
        public Color Colore
        {
            get { return _colore; }
            set { _colore = value; tableLayoutPanel1.BackColor = value; }
        }
        private DockStyle _ancora;
        public DockStyle Ancora
        {
            get { return _ancora; }
            set { _ancora = value; tableLayoutPanel1.Dock = value; }
        }
        private Bitmap _img;
        public Bitmap Img
        {
            get { return _img; }
            set { _img = value; pictureBox1.Image = value;
                this.Height = 200;
            }
        }
        public bool i_t
        {
            set {
                if (value)
                {
                    //rendere invisibile la prima colonna
                    tableLayoutPanel2.ColumnStyles[0].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.ColumnStyles[0].Width = 0;

                    //impostare la seconda colonna a 100%
                    tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Percent;
                    tableLayoutPanel2.ColumnStyles[1].Width = 100;
                    lbl_messaggio.Visible = false;

                }else
                {
                    //rendere invisibile la prima colonna
                    tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Absolute;
                    tableLayoutPanel2.ColumnStyles[1].Width = 0;

                    //impostare la seconda colonna a 100%
                    tableLayoutPanel2.ColumnStyles[0].SizeType = SizeType.Percent;
                    tableLayoutPanel2.ColumnStyles[0].Width = 100;
                    pictureBox1.Visible = false;
                }

            }
        }
        #endregion

        private void messaggio_DoubleClick(object sender, EventArgs e)
        {
            impostazioni f = new impostazioni(this);
            f.Show();
        }

        private void messaggio_Load(object sender, EventArgs e)
        {

        }
    }
}

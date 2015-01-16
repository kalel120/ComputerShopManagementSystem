using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop_v1._0
{
    public partial class MDIAdmin : Form
    {
        private int childFormNumber = 0;

        public MDIAdmin()
        {
            InitializeComponent ();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form ();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show ();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog ();
            openFileDialog.InitialDirectory = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog (this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog ();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog (this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi (MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi (MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi (MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi (MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close ();
            }
        }

        private void newComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPartsInput objNewParts = new FormPartsInput ();
            objNewParts.MdiParent = this;
            objNewParts.Dock = DockStyle.Fill;
            objNewParts.Show ();
        }

        private void MDIAdmin_Load(object sender, EventArgs e)
        {          
        }

        private void productHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductHistory objProduct = new FormProductHistory ();
            objProduct.MdiParent = this;
            objProduct.Dock = DockStyle.Fill;
            objProduct.Show ();
        }

        private void MDIAdmin_Load_1(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point (0, 0);
            this.Size = new Size (w, h-40);
        }

        private void soldHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoldHistory objsoldHistory = new FormSoldHistory ();
            objsoldHistory.MdiParent = this;
            objsoldHistory.Dock = DockStyle.Fill;
            objsoldHistory.Show ();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analizadorLexico
{
    public partial class Form1 : Form
    {
        private int countTab = 1;

        public Form1()
        {
            InitializeComponent();

            closeButton.MouseEnter += OnMouseEnter;
            closeButton.MouseLeave += OnMouseLeave;

            minimizeButton.MouseEnter += OnMouseEnter;
            minimizeButton.MouseLeave += OnMouseLeave;

            this.tabControl1.MouseUp += new MouseEventHandler(tabControl1_MouseUp);

            menu.Renderer = new MyRenderer();
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (sender == closeButton)
            {
                closeButton.BackColor = Color.FromArgb(213, 19, 36);
            }
            else if (sender == minimizeButton)
            {
                minimizeButton.BackColor = Color.FromArgb(26, 32, 44);
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (sender == closeButton)
            {
                closeButton.BackColor = Color.FromArgb(29, 34, 46);
            }
            else if (sender == minimizeButton)
            {
                minimizeButton.BackColor = Color.FromArgb(29, 34, 46);
            }
        }

        private void NuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countTab++;
            TabPage tabPage = new TabPage("Tab" + countTab);

            TextBox txtBox = new TextBox();
            txtBox.BackColor = Color.FromArgb(31, 36, 48);
            txtBox.BorderStyle = BorderStyle.Fixed3D;
            txtBox.Font = new Font("Microsoft Sans Serif", 12);
            txtBox.ForeColor = Color.FromArgb(203, 204, 198);
            txtBox.Dock = DockStyle.Fill;
            txtBox.Multiline = true;
            txtBox.AcceptsTab = true;
            txtBox.ScrollBars = ScrollBars.Vertical;

            tabPage.Controls.Add(txtBox);
            tabControl1.TabPages.Add(tabPage);
        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int ix = 0; ix < tabControl1.TabCount; ++ix)
                {
                    if (tabControl1.GetTabRect(ix).Contains(e.Location))
                    {
                        tabControl1.TabPages.RemoveAt(ix);
                        break;
                    }
                }
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "";
            openFileDialog.DefaultExt = "ly";
            openFileDialog.Filter = "Archivos LY (*.ly)|*.ly";

            TextBox txtBox = tabControl1.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);
            String line = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBox.Clear();
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                while (line != null)
                {
                    line = streamReader.ReadLine();
                    if (line != null)
                    {
                        txtBox.AppendText(line);
                        txtBox.AppendText(Environment.NewLine);
                    }
                }
                streamReader.Close();

                tabControl1.SelectedTab.Text = openFileDialog.FileName;
            }
        }

        private void GuardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "";
            saveFileDialog.DefaultExt = "ly";
            saveFileDialog.Filter = "Archivos LY (*.ly)|*.ly";

            TextBox txtBox = tabControl1.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog.OpenFile();
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(txtBox.Text);
                streamWriter.Close();
                fileStream.Close();

                tabControl1.SelectedTab.Text = saveFileDialog.FileName;
                Console.WriteLine("Archivo " + saveFileDialog.FileName + " guardado con exito");
                // txtBox.Clear();
            }
        }

        private void ButtonAnalizar_Click(object sender, EventArgs e)
        {
            AnalizadorLex analizadorLex = new AnalizadorLex();
            AnalizadorSemantico analizadorSemantico = new AnalizadorSemantico();

            TextBox txtBox = tabControl1.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);
            String entrada = txtBox.Text;
            analizadorLex.escaner(entrada);


            treeView.Nodes.Clear();

            if (!analizadorLex.ListError.Any())
            {
                if (analizadorLex.ListToken.Any())
                {
                    // analizadorLex.imprimirTokens();
                    analizadorSemantico.analizar(analizadorLex.ListToken);

                }
            }
            else
            {
                // analizadorLex.imprimirErrores();
            }
        }
    }
}

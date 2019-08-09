﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // Set the Multiline property to true.
            txtBox.Multiline = true;
            // Allow the TAB key to be entered in the TextBox control.
            txtBox.AcceptsTab = true;
            // Add vertical scroll bars to the TextBox control.
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

        private void ButtonAnalizar_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(tabControl1.SelectedTab);
            TextBox txtBox = tabControl1.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);

            // Console.WriteLine(txtBox.Text);
            // txtBox.Text = txtBox.Text.Replace("\t", "  ");

            String entrada = txtBox.Text;
            AnalizadorLex lex = new AnalizadorLex();
            LinkedList<Token> lTokens = lex.escaner(entrada);
            lex.imprimirTokens(lTokens);
        }
    }
}

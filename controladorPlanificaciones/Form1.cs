using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controladorPlanificaciones
{
    public partial class Form1 : Form
    {
        private List<Planificaciones> Listplanificaciones;
        private int countTab;
        private bool draggable;
        private int mouseX;
        private int mouseY;

        public Form1()
        {
            InitializeComponent();

            closeButton.MouseEnter += OnMouseEnter;
            closeButton.MouseLeave += OnMouseLeave;

            minimizeButton.MouseEnter += OnMouseEnter;
            minimizeButton.MouseLeave += OnMouseLeave;

            tabControl1.MouseUp += new MouseEventHandler(tabControl1_MouseUp);

            menu.Renderer = new MyRenderer();

            countTab = 1;
            Listplanificaciones = new List<Planificaciones>();
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

            TextBox txtBox = new TextBox
            {
                BackColor = Color.FromArgb(31, 36, 48),
                BorderStyle = BorderStyle.Fixed3D,
                Font = new Font("Microsoft Sans Serif", 12),
                ForeColor = Color.FromArgb(203, 204, 198),
                Dock = DockStyle.Fill,
                Multiline = true,
                AcceptsTab = true,
                ScrollBars = ScrollBars.Vertical
            };

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

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - Left;
            mouseY = Cursor.Position.Y - Top;
        }

        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                Top = Cursor.Position.Y - mouseY;
                Left = Cursor.Position.X - mouseX;
            }
        }

        private void MenuTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                FileName = "",
                DefaultExt = "ly",
                Filter = "Archivos LY (*.ly)|*.ly"
            };

            TextBox txtBox = tabControl1.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);
            string line = "";

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
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                FileName = "",
                DefaultExt = "ly",
                Filter = "Archivos LY (*.ly)|*.ly"
            };

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
            }
        }

        private void ButtonAnalizar_Click(object sender, EventArgs e)
        {
            AnalizadorLexico analizadorLexico = new AnalizadorLexico();
            AnalizadorSintactico analizadorSintactico = new AnalizadorSintactico();
            GeneradorHTML generadorHTML = new GeneradorHTML();

            TextBox txtBox = tabControl1.SelectedTab.Controls.Cast<TextBox>().FirstOrDefault(x => x is TextBox);
            string entrada = txtBox.Text;
            analizadorLexico.escaner(entrada);


            treeView.Nodes.Clear();
            richTextBoxDescripcion.Clear();
            monthCalendar.SetDate(DateTime.Now);
            pictureBoxImagen.Image = null;

            if (!analizadorLexico.ListError.Any())
            {
                if (analizadorLexico.ListToken.Any())
                {
                    if (analizadorSintactico.analizar(analizadorLexico.ListToken))
                    {
                        // analizadorLexico.imprimirTokens();
                        agregarNodos(analizadorLexico.ListToken);
                        generadorHTML.generarReporte("listadoTokens.html", analizadorLexico.ListToken);

                        if (File.Exists(Directory.GetCurrentDirectory() + "\\listadoTokens.html"))
                        {
                            Process.Start(Directory.GetCurrentDirectory() + "\\listadoTokens.html");
                        }
                    }
                }
            }
            else
            {
                // analizadorLexico.imprimirErrores();
                generadorHTML.generarReporte("listadoTokens.html", analizadorLexico.ListToken);
                generadorHTML.generarReporte("listadoErrores.html", analizadorLexico.ListError);

                if (File.Exists(Directory.GetCurrentDirectory() + "\\listadoTokens.html") 
                    && File.Exists(Directory.GetCurrentDirectory() + "\\listadoErrores.html"))
                {
                    Process.Start(Directory.GetCurrentDirectory() + "\\listadoTokens.html");
                    Process.Start(Directory.GetCurrentDirectory() + "\\listadoErrores.html");
                }
            }
        }

        private void agregarNodos(List<Token> ListToken)
        {
            TreeNode treeNodePlanificador;
            TreeNode treeNodeAnio;
            TreeNode treeNodeMes;
            TreeNode treeNodeDia;

            for (int i = 0; i < ListToken.Count; i++)
            {
                if (ListToken[i].TipoToken.Equals("Reservada Planificador"))
                {
                    // Nodo Planificador
                    string nombrePlanificacion = eliminarComillas(ListToken[i + 2].Valor);
                    treeNodePlanificador = new TreeNode(nombrePlanificacion);

                    for (int j = (i + 2); j < ListToken.Count; j++)
                    {
                        if (ListToken[j].TipoToken.Equals("Reservada Año"))
                        {
                            // Nodo Año
                            treeNodeAnio = new TreeNode(ListToken[j + 2].Valor);
                            treeNodePlanificador.Nodes.Add(treeNodeAnio);

                            for (int k = (j + 2); k < ListToken.Count; k++)
                            {
                                if (ListToken[k].TipoToken.Equals("Reservada Mes"))
                                {
                                    // Nodo Mes
                                    treeNodeMes = new TreeNode(ListToken[k + 2].Valor);
                                    treeNodeAnio.Nodes.Add(treeNodeMes);

                                    for (int l = k + 2; l < ListToken.Count; l++)
                                    {
                                        if (ListToken[l].TipoToken.Equals("Reservada Dia"))
                                        {
                                            // Nodo Dia
                                            treeNodeDia = new TreeNode(ListToken[l + 2].Valor);
                                            treeNodeMes.Nodes.Add(treeNodeDia);

                                            Listplanificaciones.Add(new Planificaciones(nombrePlanificacion,
                                                new DateTime(
                                                    int.Parse(ListToken[j + 2].Valor),
                                                    int.Parse(ListToken[k + 2].Valor),
                                                    int.Parse(ListToken[l + 2].Valor)),
                                                eliminarComillas(ListToken[l + 6].Valor),
                                                eliminarComillas(ListToken[l + 10].Valor)));
                                        }
                                        else if (ListToken[l].TipoToken.Equals("Simbolo Parentesis Derecho"))
                                        {
                                            break;
                                        }
                                    }
                                }
                                else if (ListToken[k].TipoToken.Equals("Simbolo Llave Derecha"))
                                {
                                    break;
                                }
                            }
                        }
                        else if (ListToken[j].TipoToken.Equals("Simbolo Corchete Derecho"))
                        {
                            break;
                        }
                    }
                    treeView.Nodes.Add(treeNodePlanificador);
                }
            }
        }

        public String eliminarComillas(String cadena)
        {
            StringBuilder expresion = new StringBuilder(cadena);
            expresion.Remove(0, 1);
            expresion.Remove((expresion.Length - 1), 1);
            cadena = expresion.ToString();
            return cadena;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                List<DateTime> ListFechas = new List<DateTime>();
                string[] splitString = e.Node.FullPath.Split('\\');
                DateTime fechaSeleccionada = new DateTime(
                    int.Parse(splitString[1]),
                    int.Parse(splitString[2]),
                    int.Parse(splitString[3]));
                string descripcion = "";
                string imagen = "";

                foreach (Planificaciones item in Listplanificaciones)
                {
                    if (splitString[0] == item.NombrePlanificacion)
                    {
                        ListFechas.Add(item.Fecha);
                    }

                    if (fechaSeleccionada == item.Fecha)
                    {
                        descripcion = item.Descripcion;
                        imagen = item.Imagen;
                    }
                }
                monthCalendar.BoldedDates = ListFechas.ToArray();
                monthCalendar.SetDate(fechaSeleccionada);

                //descripcion = descripcion.Replace("\t", " ");
                //descripcion = descripcion.Replace("\n", " ");
                //while (descripcion.IndexOf("  ") >= 0)
                //{
                //    descripcion = descripcion.Replace("  ", " ");
                //}
                richTextBoxDescripcion.Text = descripcion;

                if (File.Exists(@imagen))
                {
                    Image image = Image.FromFile(@imagen);
                    pictureBoxImagen.Image = image;
                } else
                {
                    pictureBoxImagen.Image = null;
                }
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg m = new msg();
            m.Show();
        }

        private void ManualAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Manual de Usuario.pdf"))
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\Manual de Usuario.pdf");
            }
        }
    }
}

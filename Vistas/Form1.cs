using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using FinalTestProgra3.Utility;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace FinalTestProgra3
{
    public partial class Form1 : Form
    {
        
        // Seteamos los procesos que 
        int[] procesadores_disponibles = { 2, 4, 8, 12, 16 };
        int[] memoria_disponible = { 128, 256, 512, 1024 };

        // Configuraciones
        int configMemoria = 0;
        int configProcesadores = 0;
        int configCiclos = 0;
        int totaldememoria = 0;
        List<List<string>> procesosLista = new List<List<string>>();
        ListaCircular lista = new ListaCircular();

        // Para los colores de las celdas
        private void CambiarColorCelda(int fila, int columna, Color color)
        {
            if (fila < 0 || columna < 0 || fila >= dataGridView1.Rows.Count || columna >= dataGridView1.Columns.Count)
            {
                MessageBox.Show("Índice de fila o columna fuera de rango.");
                return;
            }

            dataGridView1.Rows[fila].Cells[columna].Style.BackColor = color;
        }


        // Para los colores de las celdas
        private bool PintarCeldas(int totaldememoria) 
        {
            for (int i = 0; i < totaldememoria; i++)
            {
                // Determinar fila y columna basado en i
                int fila = i / dataGridView1.Columns.Count;
                int columna = i % dataGridView1.Columns.Count;

                if (fila >= dataGridView1.Rows.Count)
                {
                    MessageBox.Show("No hay suficientes celdas para pintar.");
                    return false;
                }
   
                CambiarColorCelda(fila, columna, Color.Red);

            }
            return true;
        }


        public void EstablecerConfiguraciones()
        {
            configMemoria = int.Parse(memoria.Text);
            configCiclos = int.Parse(numericUpDown3.Text);
            
            for (int i = 0; i < int.Parse(procesadores.Text); i++)
            {
                lista.Añadir(i);
            }

            for (int i = 0; i < procesosLista.Count; i++)
            {
                SetearNombres(procesosLista[i][0] + " -->" , int.Parse(procesosLista[i][1]));
            }


        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstablecerConfiguraciones();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1.ShowDialog();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Nombre Proceso");
                dataTable.Columns.Add("Ciclos");
                dataTable.Columns.Add("Cantidad de Memoria");
                dataTable.Columns.Add("Ejecutado");

                string line = sr.ReadLine();

                while (line != null)
                {
                    // Dividir la línea por comas
                    List<string> listaTemporal = new List<string> (line.Split(','));


                    // Verificar si hay suficientes elementos en la línea dividida
                    if (listaTemporal.Count >= 3)
                    {
                        // Agregar una nueva fila al DataTable con los valores correspondientes
                        dataTable.Rows.Add(listaTemporal[0], listaTemporal[1], listaTemporal[2], "No");

                        //Llenar la lista
                        procesosLista.Add(listaTemporal);
                        totaldememoria += int.Parse(listaTemporal[2]);
                    }

                    line = sr.ReadLine(); // Leer la siguiente línea

                }
                dataGridView2.DataSource = dataTable;
                sr.Close();

                for (int i = 0; i <= totaldememoria; i++)
                {
                    if (PintarCeldas(i))
                    {
                        continue;
                    }else break;
                    
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine(e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar una columna al DataGridView
            DataGridViewTextBoxColumn columnaMemoria = new DataGridViewTextBoxColumn();
            columnaMemoria.HeaderText = "Memoria";
            dataGridView1.Columns.Add(columnaMemoria);


            // Mostrar los procesadores disponibles en el ComboBox
            procesadores.DataSource = procesadores_disponibles.Select(p => p.ToString()).ToList();

            // Mostrar la memoria disponible en el ComboBox
            memoria.DataSource = memoria_disponible.Select(m => m.ToString()).ToList();


        }

        private void procesadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidadProcesadores = int.Parse(procesadores.SelectedItem.ToString());


            // Cambiar color de los labels según la cantidad de procesadores seleccionados
            for (int i = 1; i <= 16; i++)
            {
                System.Windows.Forms.Label label = (System.Windows.Forms.Label)this.Controls.Find("procesador" + i, true).FirstOrDefault();
                if (label != null)
                {
                    if (i <= cantidadProcesadores)
                    {
                        label.BackColor = Color.Yellow;
                    }
                    else
                    {
                        label.BackColor = SystemColors.Control; // Color predeterminado
                    }
                }
            }
            procesadores.SelectedItem = cantidadProcesadores.ToString();
        }



        private void memoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int memoriaSeleccionada = int.Parse(comboBox.SelectedItem.ToString());

            // Calcula las dimensiones de la matriz
            int filas = 0;
            int columnas = 0;
            if (memoriaSeleccionada == 128)
            {
                filas = 8;
                columnas = 16;
            }
            else if (memoriaSeleccionada == 256)
            {
                filas = 16;
                columnas = 16;
            }
            else if (memoriaSeleccionada == 512)
            {
                filas = 16;
                columnas = 32;
            }
            else if (memoriaSeleccionada == 1024)
            {
                filas = 32;
                columnas = 32;
            }

            // Define el tamaño de la matriz en el DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.RowHeadersVisible = false; // Ocultar encabezados de fila
            dataGridView1.ColumnHeadersVisible = false; // Ocultar encabezados de columna
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar tamaño de columnas
            for (int c = 0; c < columnas; c++)
            {
                dataGridView1.Columns.Add("Columna" + c, (c + 1).ToString());
            }
            for (int r = 0; r < filas; r++)
            {
                dataGridView1.Rows.Add();
            }

            // Llena la matriz con los valores correspondientes
            int memoriaActual = 1;
            for (int r = 0; r < filas; r++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (memoriaActual <= memoriaSeleccionada)
                    {
                        dataGridView1.Rows[r].Cells[c].Value = memoriaActual.ToString();
                        dataGridView1.Rows[r].Cells[c].ReadOnly = true; // Establecer celda como de solo lectura
                        memoriaActual++;
                    }
                    else
                    {
                        break; // Salir del bucle si se han llenado todas las posiciones de memoria
                    }
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void procesador3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SetearNombres(string nombre, int maximoValorPro)
        {
            if (label9.Text == "Proceso 1")
            {
                label9.Text = nombre;
                progressBar1.Maximum = maximoValorPro;
            }
            else if (label10.Text == "Proceso 2")
            {
                label10.Text = nombre;
                progressBar2.Maximum = maximoValorPro;
            }
            else if (label11.Text == "Proceso 3")
            {
                label11.Text = nombre;
                progressBar3.Maximum = maximoValorPro;
            }
            else if (label12.Text == "Proceso 4")
            {
                label12.Text = nombre;
                progressBar4.Maximum = maximoValorPro;
            }
            else if (label13.Text == "Proceso 5")
            {
                label13.Text = nombre;
                progressBar5.Maximum = maximoValorPro;
            }
            else if (label14.Text == "Proceso 6")
            {
                label14.Text = nombre;
                progressBar6.Maximum = maximoValorPro;
            }
            else if (label15.Text == "Proceso 7")
            {
                label15.Text = nombre;
                progressBar7.Maximum = maximoValorPro;
            }
            else if (label16.Text == "Proceso 8")
            {
                label16.Text = nombre;
                progressBar8.Maximum = maximoValorPro;
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

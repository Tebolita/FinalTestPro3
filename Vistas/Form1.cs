using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalTestProgra3
{
    public partial class Form1 : Form
    {

        int[] procesadores_disponibles = { 2, 4, 8, 16 };
        int[] memoria_disponible = { 128, 256, 512, 1024 };

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Console.WriteLine(openFileDialog1.FileName);

            StreamReader sr = new StreamReader(openFileDialog1.FileName);

            string line = sr.ReadLine();

            while(line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        

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
            ComboBox comboBox = (ComboBox)sender;
            comboBox.DataSource = procesadores_disponibles;
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


    }
}

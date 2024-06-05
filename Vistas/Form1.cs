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
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Collections;

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
        List<List<string>> listaPrioridad = new List<List<string>>();

        List<List<string>> procesosAEjecutar = new List<List<string>>();
        List<List<string>> procesoPrioridadAEjecutar = new List<List<string>>();


        List<List<string>> listaTerminada = new List<List<string>>();
        List<List<string>> listaPendiente = new List<List<string>>();

        List<List<string>> listaNuncaEjecutar = new List<List<string>>();

        List<List<string>> listaNodo = new List<List<string>>();

        List<int> contarProcesos = new List<int>();

        int ciclosfinales = 0;
       

        ListaCircular listaCola;

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
            listaCola = new ListaCircular(int.Parse(procesadores.Text));
            totaldememoria = int.Parse(memoria.Text);
            for (int i = 0; i < 16; i++)
            {
                contarProcesos.Add(0);
            }
            
            //for (int i = 0; i < procesosLista.Count; i++)
            //{
            //    SetearNombres(procesosLista[i][0] + " -->" , int.Parse(procesosLista[i][1]));
            //}


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
                    List<string> listaTemporal = new List<string>(line.Split(','));


                    // Verificar si hay suficientes elementos en la línea dividida
                    if (listaTemporal.Count >= 3)
                    {
                        // Agregar una nueva fila al DataTable con los valores correspondientes
                        dataTable.Rows.Add(listaTemporal[0], listaTemporal[1], listaTemporal[2], "No");
                        //Llenar la lista
                        procesosLista.Add(listaTemporal);
                        //totaldememoria += int.Parse(listaTemporal[2]);
                    }

                    line = sr.ReadLine(); // Leer la siguiente línea

                }
                dataGridView2.DataSource = dataTable;
                sr.Close();

                //for (int i = 0; i <= totaldememoria; i++)
                //{
                //    if (PintarCeldas(i))
                //    {
                //        continue;
                //    }else break;

                //}

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


        private void AsignarProcesos(bool primeraVuelta, int indexRemplazo)
        {

            if (primeraVuelta)
            {
                // Quitar los procesos que ocupen mas memoria de la establecida
                for (int i = 0; i < procesosLista.Count; i++)
                {
                    if (listaCola.HayEspacioDisponible())
                    {
                        if (int.Parse(procesosLista[i][2]) > totaldememoria)
                        {
                            listaNuncaEjecutar.Add(procesosLista[i]);
                            procesosLista.Remove(procesosLista[i]);
                            i = 0;
                        }
                    }

                }

                while (procesosLista.Count > 0)
                {
                    for (int i = 0; i < procesosLista.Count; i++)
                    {
                        if (int.Parse(procesosLista[i][2]) < totaldememoria && listaCola.HayEspacioDisponible())
                        {
                            listaCola.Añadir(procesosLista[i][0].ToString());
                            totaldememoria -= int.Parse(procesosLista[i][2]);
                            listaNodo.Add(procesosLista[i]);
                            procesosLista.Remove(procesosLista[i]);

                            break;
                        }
                        else
                        {
                            listaPrioridad.Add(procesosLista[i]);
                            procesosLista.Remove(procesosLista[i]);
                            break;
                        }
                    }

                }
            }
            else if (!primeraVuelta)
            {
                for (int i = 0; i < listaPrioridad.Count; i++)
                {
                    if (int.Parse(listaPrioridad[i][2]) < totaldememoria && listaCola.HayEspacioDisponible())
                    {
                        listaCola.Añadir(listaPrioridad[i][0].ToString());
                        totaldememoria -= int.Parse(listaPrioridad[i][2]);
                        listaNodo[indexRemplazo] = listaPrioridad[i];
                        listaPrioridad.Remove(listaPrioridad[i]);
                    }
                }

            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            AsignarProcesos(true, 0);
            TareasProcesosAsync();

            DataTable dataTableTerminado = new DataTable();
            dataTableTerminado.Columns.Add("Nombre Proceso");
            dataTableTerminado.Columns.Add("Ciclos");
            dataTableTerminado.Columns.Add("Cantidad de Memoria");

            DataTable dataTablePendiente = new DataTable();
            dataTablePendiente.Columns.Add("Nombre Proceso");
            dataTablePendiente.Columns.Add("Ciclos");
            dataTablePendiente.Columns.Add("Cantidad de Memoria");

            DataTable dataTableNoEjecutados = new DataTable();
            dataTableNoEjecutados.Columns.Add("Nombre Proceso");
            dataTableNoEjecutados.Columns.Add("Ciclos");
            dataTableNoEjecutados.Columns.Add("Cantidad de Memoria");

            Console.WriteLine("Terminadas: ");
            for (int i = 0; i < listaTerminada.Count; i++)
            {
                dataTableTerminado.Rows.Add(listaTerminada[i][0], listaTerminada[i][1], listaTerminada[i][2]);
            }

            Console.WriteLine("Pendientes: ");
            for (int i = 0; i < listaPendiente.Count; i++)
            {
                dataTablePendiente.Rows.Add(listaPendiente[i][0], listaPendiente[i][1], listaPendiente[i][2]);
            }

            for (int i = 0; i < listaNuncaEjecutar.Count; i++)
            {
                dataTableNoEjecutados.Rows.Add(listaNuncaEjecutar[i][0], listaNuncaEjecutar[i][1], listaNuncaEjecutar[i][2]);
            }

            dataGridView4.DataSource = dataTableTerminado;
            dataGridView5.DataSource = dataTablePendiente;
            dataGridView3.DataSource = dataTableNoEjecutados;

            label22.Text = ciclosfinales.ToString();
            label23.Text = totaldememoria.ToString();
        }
        private void TareasProcesosAsync()
        {
            //comparar = comparar.Replace("-->", "").Trim();
            for (int j = configCiclos; 0 <= j; j--)
            {

                for (int i = 0; i < listaNodo.Count; i++)
                {
                    if (listaCola.ImprimirNodo(listaNodo[i][0]).Contains(listaNodo[i][0]))
                    {
                        if (int.Parse(listaNodo[i][1]) == contarProcesos[i])
                        {
                            totaldememoria += int.Parse(listaNodo[i][2]);
                            listaTerminada.Add(listaNodo[i]);
                            listaCola.Eliminar(listaNodo[i][0]);
                            //procesosAEjecutar.Remove(procesosAEjecutar[i]);
                            AsignarProcesos(false, i);
                            contarProcesos[i] = 0;
                            break;
                        }
                        else
                        {
                            contarProcesos[i] += 1;
                        }
                    }
                }

                if (j == 0 || listaCola.retornarContador() == 0)
                {
                    // Agregar elementos a listaPendiente si cumplen la condición
                    for (int i = 0; i <= int.Parse(procesadores.Text); i++)
                    {
                        if (contarProcesos[i] > 0)
                        {
                            textBox1.Text += Environment.NewLine + listaNodo[i][0] + " -> ocupo procesador " + i + " con " + contarProcesos[i].ToString() + " ciclos";

                            listaNodo[i][0] = listaNodo[i][0] + " -> quedo pendiente en el proceso " + i;
                            listaPendiente.Add(listaNodo[i]);

                            
                        }
                        else if (contarProcesos[i] == 0)
                        {
                            textBox1.Text += Environment.NewLine + "Procesador " + i + " Quedo libre";
                        }
                    }

                    // Crear un HashSet para almacenar elementos únicos ya presentes en listaPendiente
                    var itemsAlreadyInList = new HashSet<string>();

                    foreach (var pendiente in listaPendiente)
                    {
                        itemsAlreadyInList.Add(pendiente[0]);  // Asume que `pendiente[0]` es único para cada sublista
                    }

                    // Crear un HashSet para almacenar elementos únicos ya presentes en listaTerminada
                    var itemsAlreadyInTerminada = new HashSet<string>();

                    foreach (var terminado in listaTerminada)
                    {
                        itemsAlreadyInTerminada.Add(terminado[0]);  // Asume que `terminado[0]` es único para cada sublista
                    }

                    // Verificar y agregar elementos de procesoPrioridadAEjecutar a listaPendiente sin duplicados y no en listaTerminada
                    foreach (var item in listaPrioridad)
                    {
                        if (!itemsAlreadyInList.Contains(item[0]) && !itemsAlreadyInTerminada.Contains(item[0]))
                        {
                            listaPendiente.Add(item);
                            itemsAlreadyInList.Add(item[0]);
                        }
                    }
                }

                ciclosfinales = j;



                if (listaCola.retornarContador() == 0)
                {
                    break;
                }

            }
        }



        private void SetearNombres(string nombre, int maximoValorPro)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            procesadores.SelectedIndex = 0;
            memoria.SelectedIndex = 0;
            numericUpDown3.Value = 1;
            dataGridView2.DataSource = "";
            dataGridView3.DataSource = "";
            dataGridView4.DataSource = "";
            dataGridView5.DataSource = "";
            textBox1.Text = "";
        }
    }
}

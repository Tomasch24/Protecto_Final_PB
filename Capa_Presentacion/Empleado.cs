using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Empleado : Form
    {

        public Empleado()
        {
            InitializeComponent();


        }

        List<IEmpleado> empleados = new List<IEmpleado>();

        private void Empleados_Load(object sender, EventArgs e)
        {
            empleados.Add(new EmpleadoIA { Nombre = "IA KORVI:", Rol = "Cajero Automático." });

            empleados.Add(new Administrador { Nombre = "Dubenny:", Rol = "Administrador Maestro." });



            foreach (var emp in empleados)
            {


                listBox1.Items.Add(emp.DescribirTrabajo());
                listBox1.Items.Add("");

            }

            listBox1.Items.Add("Cree este form con el fin de dar a conocer quien estan detras.");
            
            listBox1.Items.Add("Yo 'Dubenny' el creador de todo esto, administro y arreglo todo.");
            
            listBox1.Items.Add("Mientras que la IA 'KORVi' Esta aqui para agregar, eliminar y editar cada pedido.");



        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconoCerrarEmp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconoMinimizarEmp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloEmp_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

public interface IEmpleado
{
    string Nombre { get; set; }
    string Rol { get; set; }
    string DescribirTrabajo();
}

public class EmpleadoIA : IEmpleado
{
    public string Nombre { get; set; }
    public string Rol { get; set; }

    public string DescribirTrabajo()
    {
        return $"{Nombre} trabaja como {Rol}.";
    }
}

public class Administrador : IEmpleado
{
    public string Nombre { get; set; }
    public string Rol { get; set; }

    public string DescribirTrabajo()
    {
        return $"{Nombre} es un {Rol}.";
    }
}


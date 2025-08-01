using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios; 

namespace Capa_Presentacion
{
    public partial class Pedidos : Form
    {
           PedidosNegocio PEDIDOS = new PedidosNegocio();
        public Pedidos()
        {
            InitializeComponent();
            tabPedidos.DrawMode = TabDrawMode.OwnerDrawFixed;

            
        }

        private void tabPedidos_DrawItem(object sender, DrawItemEventArgs e)
        {
            //TODO Dibujar las pestañas del TabControl con colores personalizados
            TabControl tabControl = (TabControl)sender;
            TabPage page = tabControl.TabPages[e.Index];
            Rectangle rect = tabControl.GetTabRect(e.Index);


            Color selectedColor = Color.FromArgb(41, 76, 37);    // Verde seleccionado
            Color defaultColor = Color.FromArgb(110, 190, 125);   // Verde claro texto
            Color textColor = Color.White;

            // Verificar si la pestaña está seleccionada
            bool isSelected = (e.Index == tabControl.SelectedIndex);

            // Fondo según si está seleccionada o no
            using (Brush b = new SolidBrush(isSelected ? selectedColor : defaultColor))
            {
                e.Graphics.FillRectangle(b, rect);
            }

            TextRenderer.DrawText(     // Dibujar texto centrado
                e.Graphics,
                page.Text,
                page.Font,
                rect,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            if (tabPedidos.SelectedTab == tabExistentes) // EXISTENTES
            {
                if (dgvExistentes.CurrentRow != null && dgvExistentes.SelectedRows.Count > 0)
                {
                    string nombreProducto = dgvExistentes.CurrentRow.Cells[0].Value.ToString();
                    Btn_HacerPedido hacerPedidoForm = new Btn_HacerPedido(nombreProducto);
                    hacerPedidoForm.ShowDialog();
                    dgvExistentes.ClearSelection(); // Opcional
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un producto existente para hacer el pedido.");
                }
            }
            else if (tabPedidos.SelectedTab == tabAgotados) // AGOTADOS
            {
                if (dgvAgotados.CurrentRow != null && dgvAgotados.SelectedRows.Count > 0)
                {
                    string nombreProducto = dgvAgotados.CurrentRow.Cells["Nombre"].Value.ToString();
                    Btn_HacerPedido hacerPedidoForm = new Btn_HacerPedido(nombreProducto);
                    hacerPedidoForm.ShowDialog();
                    dgvAgotados.ClearSelection(); // Opcional
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un producto agotado para hacer el pedido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para hacer el pedido.");
            }

        }

        private void btnRegistroPedidos_Click(object sender, EventArgs e)
        {
            //TODO Se abre el formulario de registro de pedidos
            Registro_Pedidos registroPedidosForm = new Registro_Pedidos();
            registroPedidosForm.ShowDialog();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            CargarProductos();

        }

        
         private void CargarProductos()
        {
            dgvExistentes.DataSource = PEDIDOS.ObtenerProductosExistentes();
            dgvAgotados.DataSource = PEDIDOS.ObtenerProductosAgotados();
        
            dgvExistentes.ReadOnly = true;
            dgvAgotados.ReadOnly = true;
        }
        


    }
}

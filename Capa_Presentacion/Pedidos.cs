using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            tabPedidos.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        private void tabPedidos_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage page = tabControl.TabPages[e.Index];
            Rectangle rect = tabControl.GetTabRect(e.Index);

            // Definir colores
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

            // Dibujar texto centrado
            TextRenderer.DrawText(
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
            //TODO: Se abre el formulario de hacer pedido
            Btn_HacerPedido hacerPedidoForm = new Btn_HacerPedido();
            hacerPedidoForm.ShowDialog();

        }

        private void btnRegistroPedidos_Click(object sender, EventArgs e)
        {
            //TODO: Se abre el formulario de registro de pedidos
            Registro_Pedidos registroPedidosForm = new Registro_Pedidos();
            registroPedidosForm.ShowDialog();
        }
    }
}

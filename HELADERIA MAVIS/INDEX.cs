using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELADERIA_MAVIS
{
    public partial class INDEX : Form
    {
        public INDEX()
        {
            InitializeComponent();
        }

        private void MENU_BTN_MouseHover(object sender, EventArgs e)
        {
            MENU_BTN.ForeColor = Color.Black;
            MENU_BTN.BackColor = Color.White;
            
        }

        private void MENU_BTN_MouseMove(object sender, MouseEventArgs e)
        {
            MENU_BTN.BackColor = Color.FromArgb(67, 80, 100);
            MENU_BTN.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            INVENTARIO_BTN.ForeColor = Color.Black;
            INVENTARIO_BTN.BackColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            INVENTARIO_BTN.BackColor = Color.FromArgb(67, 80, 100);
            INVENTARIO_BTN.ForeColor = Color.White;
        }

        private void REGISTRO_PRODUCTOS_BTN_MouseHover(object sender, EventArgs e)
        {
            REGISTRO_PRODUCTOS_BTN.ForeColor = Color.Black;
            REGISTRO_PRODUCTOS_BTN.BackColor = Color.White;
        }

        private void REGISTRO_PRODUCTOS_BTN_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void EDITAR_INVENTARIO_BTN_MouseHover(object sender, EventArgs e)
        {
            EDITAR_INVENTARIO_BTN.ForeColor = Color.Black;
            EDITAR_INVENTARIO_BTN.BackColor = Color.White;
        }

        private void EDITAR_INVENTARIO_BTN_MouseMove(object sender, MouseEventArgs e)
        {
            EDITAR_INVENTARIO_BTN.BackColor = Color.FromArgb(67, 80, 100);
            EDITAR_INVENTARIO_BTN.ForeColor = Color.White;
        }

        private void VENTAS_BTN_MouseHover(object sender, EventArgs e)
        {
            VENTAS_BTN.ForeColor = Color.Black;
            VENTAS_BTN.BackColor = Color.White;
        }

        private void VENTAS_BTN_MouseMove(object sender, MouseEventArgs e)
        {
            VENTAS_BTN.BackColor = Color.FromArgb(67, 80, 100);
            VENTAS_BTN.ForeColor = Color.White;
        }

        private void REPORTES_BTN_MouseHover(object sender, EventArgs e)
        {
            REPORTES_BTN.ForeColor = Color.Black;
            REPORTES_BTN.BackColor = Color.White;
        }

        private void REPORTES_BTN_MouseMove(object sender, MouseEventArgs e)
        {
            REPORTES_BTN.BackColor = Color.FromArgb(67, 80, 100);
            REPORTES_BTN.ForeColor = Color.White;
        }

        private void INDEX_Load(object sender, EventArgs e)
        {
            REGISTRO_PRODUCTOS_BTN.BackColor = Color.White;
            REGISTRO_PRODUCTOS_BTN.ForeColor = Color.Black;
        }

        private void VACIAR_FORMULARIO_BTN_Click(object sender, EventArgs e)
        {
            NOMBRE_PRODUCTO_TXT.Text = CANTIDAD_PRODUCTO_TXT.Text = PRECIO_COSTO_TXT.Text = PRECIO_VENTA_TXT.Text = string.Empty;
        }
    }
}

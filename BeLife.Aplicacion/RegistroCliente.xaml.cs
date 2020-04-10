using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BeLife.Aplicacion
{
    /// <summary>
    /// Lógica de interacción para RegistroCliente.xaml
    /// </summary>
    public partial class RegistroCliente : Window
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                rut = int.Parse(txtRut.Text),
            };
            if (cliente.Read())
            {
                txtNombre.Text = cliente.nombre;
                txtApellidos.Text = cliente.apellido;
            }
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.rut = int.Parse(txtRut.Text);
            cliente.dv = txtDv.Text;
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellidos.Text;
            cliente.sexo = cmbGenero.Text;
            cliente.estadoCivil = cmbEstadoCivil.Text;
            cliente.fechaNac = (DateTime)dtFecha.SelectedDate;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

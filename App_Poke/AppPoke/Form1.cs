using Modelo;
using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPoke
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listPokemon;

        private List<Pokemon> listActivePokemon;

        

        public Form1()
        {
            InitializeComponent();
            Text = "APP POKEMON";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();

            //Cargamos los desplegables del Filtro Avanzado:
            cboCampo.Items.Add("Numero");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");

            //Permite que siempre se seleccione un valor (Primero):
            cboCampo.SelectedIndex = 0;
            cboCriterio.SelectedIndex = 0;

        }

        private void cargar()
        {
            try
            {
                ControladorPokemon ctroPoke = new ControladorPokemon();

                listPokemon = ctroPoke.allPokeTipoDebilidad();

                listActivePokemon = new List<Pokemon>();

                //Verificamos los Pokemons Activos:
                foreach (Pokemon item in listPokemon)
                {
                    if (item.Activo == true)
                    {
                        listActivePokemon.Add(item);
                    }
                }

                dataGrid.DataSource = listActivePokemon;

                cargarImagen(listPokemon[0].UrlImag);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error. " + ex.ToString());

            }
        }


        //Con este metodo lanzamos el evento selector de fila y capturamos el valor de la URL imagen:
        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon poke = (Pokemon)dataGrid.CurrentRow.DataBoundItem;
            cargarImagen(poke.UrlImag);
        }

        //Funcion Creada para cargar una imagen y atrapar una excepcion:
        private void cargarImagen(string imagen)
        {
            try
            {

                if (imagen != null && imagen != "")
                {
                    picture.Load(imagen);
                }
                else
                {
                    picture.Load("https://dinahosting.com/blog/wp-content/uploads/2021/03/error-404.jpg");
                }
                
            }
            catch (Exception ex)
            {
                picture.Load("https://dinahosting.com/blog/wp-content/uploads/2021/03/error-404.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Abrir Formulario en evento Click:
            FrmInsertPokemon frmInsertPokemon = new FrmInsertPokemon();
            frmInsertPokemon.ShowDialog(); //Solo abre una ventana y bloquea
            cargar(); //refresca la pagina actualizada
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Pasamos por parametro los datos del pokemon seleccionado:
            Pokemon poke = (Pokemon)dataGrid.CurrentRow.DataBoundItem;

            //Abrir Formulario en evento Click:
            FrmInsertPokemon frmModificarPokemon = new FrmInsertPokemon(poke);
            frmModificarPokemon.ShowDialog(); //Solo abre una ventana y bloquea
            cargar();

        }

        private void btnEliFis_Click(object sender, EventArgs e)
        {

            ControladorPokemon control = new ControladorPokemon();

            //Seleccionamos el Pokemon del Grid:
            Pokemon poke = (Pokemon)dataGrid.CurrentRow.DataBoundItem;

            try
            {
                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    control.deleteFisicoPoke(poke.Num);

                    MessageBox.Show("Registro seleccionado eliminado con Exito");

                    cargar();

                }
                else
                {
                    MessageBox.Show("Se procede a cancelar la operacion de borrado fisico.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error." + ex.ToString());

            }
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            ControladorPokemon control = new ControladorPokemon();

            //Seleccionamos el Pokemon del Grid:
            Pokemon poke = (Pokemon)dataGrid.CurrentRow.DataBoundItem;

            try
            {
                //Permite una segunda validacion de eliminacion:
                DialogResult respuesta = MessageBox.Show("Estas seguro de continuar con la eliminacion del registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    control.deleteLogPoke(poke.Num);

                    MessageBox.Show("Registro seleccionado eliminado con Exito");

                    cargar();

                }
                else
                {
                    MessageBox.Show("Se procede a cancelar la operacion de borrado del registro.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error." + ex.ToString());

            }
        }

        //Funcion que nos permite gestionar la busqueda de Filtro Avanzado:
        private void btnSearch_Click(object sender, EventArgs e)
        {

            ControladorPokemon controlador = new ControladorPokemon();
            List<Pokemon> listPoke = new List<Pokemon>();

            try
            {

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtBuscar.Text;
                bool isNumber = false;

                
                //Si el Filtro es Vacio que traiga todos los Pokemons:
                if (filtro != "")
                {
                    //Validar si el string ingresado es un numero:

                    if (campo == "Numero")
                    {

                        int numericValue;
                        isNumber = int.TryParse(filtro, out numericValue);

                        if (isNumber)
                        {
                            listPoke = controlador.filtroAvanzado(campo, criterio, filtro);

                            dataGrid.DataSource = listPoke;

                            cargarImagen(listPoke[0].UrlImag);

                        }
                        else
                        {
                            MessageBox.Show("Error. No se pueden ingresar caracteres de texto");
                            cargar();
                        }

                    }
                    else
                    {

                        listPoke = controlador.filtroAvanzado(campo, criterio, filtro);

                        dataGrid.DataSource = listPoke;

                        cargarImagen(listPoke[0].UrlImag);

                    }

                }
                else
                {

                    cargar();

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. No se encuentran Pokemones para el Filtro Ingresado." + ex.Message);
                cargar();
            }

        }

        //Evento de busqueda con actualizacion de caracteres TextBox Search:
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listFiltrada;
            string filtro = textSearch.Text;

            if (filtro != "")
            {
                listFiltrada = listPokemon.FindAll(p => p.Name.ToLower().Contains(filtro.ToLower()));

                dataGrid.DataSource = null;
                dataGrid.DataSource = listFiltrada;

                cargarImagen(listFiltrada[0].UrlImag);
            }
            else
            {

                dataGrid.DataSource = null;
                dataGrid.DataSource = listPokemon;

                cargarImagen(listPokemon[0].UrlImag);

            }
        }

        //Metodo del evento seleccion de ComboBox Filtro Avanzado Activa nuevas opciones en Criterio:
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string campo = cboCampo.SelectedItem.ToString();

            if (campo == "Numero")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.SelectedIndex = 0;

            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene a");
                cboCriterio.SelectedIndex = 0;

            }


        }



    }
}

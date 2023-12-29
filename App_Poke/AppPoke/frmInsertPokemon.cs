using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppPoke
{
    public partial class FrmInsertPokemon : Form
    {
        private Pokemon poke = null;

        //Sobrecarga de Metodo Constructor:
        public FrmInsertPokemon()
        {
            InitializeComponent();
            Text = "ALTA DE POKEMON";
        }

        //Le pasamos por parametro el objeto pokemon que recibe:
        public FrmInsertPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.poke = pokemon;
            Text = "MODIFICAR POKEMON";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cerramos el Form:
            this.Close();
        }


        //Evento de boton Carga de Pokemon:
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ControladorPokemon control = new ControladorPokemon();

            List<Pokemon> list = control.allPoke();

            bool bandera = false;

            try
            {
                //Verificamos si el Objeto Pokemon es null:
                if (poke == null) 
                {

                    //Procedemos a un INSERT:

                    //Si existe alguna validacion erronea aborta la carga de datos:
                    if (validarDatos())
                    {
                        MessageBox.Show("Error, Faltan Datos Verificar.");
                        return;
                    }


                    poke = new Pokemon();

                    //Obtenemos o Capturamos los valores Ingresados con el evento Click:
                    int numero = int.Parse(txtNum.Text);
                    string nombre = txtNom.Text;
                    string descripcion = txtDesc.Text;
                    string url = txtUrl.Text;
                    Elemento tipo = (Elemento)cboTipo.SelectedItem;
                    Elemento debilidad = (Elemento)cboDebi.SelectedItem;

                    poke.Num = numero;
                    poke.Name = nombre;
                    poke.Descrip = descripcion;
                    poke.UrlImag = url;
                    poke.Tipo = tipo;
                    poke.Debilidad = debilidad;

         

                    //Verificamos si el Pokemon Existe en la BD:
                    foreach (Pokemon item in list)
                    {
                        if (item.Num == poke.Num)
                        {
                            bandera = true;
                        }
                    }

                    if (bandera == true)
                    {
                        MessageBox.Show("Error. El Pokemon ya se encuentra ingresado en la BD.");
                    }
                    else
                    {
                        
                        control.insertPoke(poke);

                        MessageBox.Show("La carga de Pokemon fue exitosa.");
                    }


                    this.Close();

                }
                else
                {

                    //Procedemos a un UPDATE:

                    //Si existe alguna validacion erronea aborta la carga de datos:
                    if (validarDatos())
                    {
                        MessageBox.Show("Error, Faltan Datos Verificar.");
                        return;
                    }

                    //Obtenemos o Capturamos los valores Ingresados con el evento Click:
                    int numero = int.Parse(txtNum.Text);
                    string nombre = txtNom.Text;
                    string descripcion = txtDesc.Text;
                    string url = txtUrl.Text;
                    Elemento tipo = (Elemento)cboTipo.SelectedItem;
                    Elemento debilidad = (Elemento)cboDebi.SelectedItem;

                    poke.Num = numero;
                    poke.Name = nombre;
                    poke.Descrip = descripcion;
                    poke.UrlImag = url;
                    poke.Tipo = tipo;
                    poke.Debilidad = debilidad;

                    control.updatePoke(poke);

                    MessageBox.Show("La actualizacion de Pokemon fue exitosa.");

                    this.Close();


                }

                

            }   
            catch (Exception ex){

                MessageBox.Show("Error, no fue posible la carga de Pokemon." + ex.ToString());

            }

        }


        //Gestiona la Validacion de todos los metodos:
        private bool validarDatos()
        {

            bool bandera = false;

            if (cboTipo.SelectedIndex < 0)
            {
                lblErrDeb.Text = "*";
                cboTipo.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrDeb.Text = "";
                cboTipo.BackColor = Color.White;
                
            }

            if (cboDebi.SelectedIndex < 0)
            {
                lblErrDeb.Text = "*";
                cboDebi.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrDeb.Text = "";
                cboDebi.BackColor = Color.White;
                
            }

          

            if (string.IsNullOrEmpty(txtNum.Text))
            {
                lblErrNum.Text = "*";
                txtNum.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrNum.Text = "";
                txtNum.BackColor = Color.White;

                if (soloNumeros(txtNum.Text))
                {
                    
                    lblErrNum.Text = "*";
                    txtNum.BackColor = Color.Red;
                    bandera = true;
                }
                else
                {
                    
                    lblErrNum.Text = "";
                    txtNum.BackColor = Color.White;

                }

            }

            if (string.IsNullOrEmpty(txtNom.Text))
            {
                lblErrNom.Text = "*";
                txtNom.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrNom.Text = "";
                txtNom.BackColor = Color.White;
                
            }

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                lblErrDes.Text = "*";
                txtDesc.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrDes.Text = "";
                txtDesc.BackColor = Color.White;
                
            }

            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                lblErrImg.Text = "*";
                txtUrl.BackColor = Color.Red;
                bandera = true;
            }
            else
            {
                lblErrImg.Text = "";
                txtUrl.BackColor = Color.White;
               
            }

            return bandera;
        }

        //Metodo para validar que el dato ingresado sea numero:
        private bool soloNumeros(string cadena)
        {
            Console.WriteLine("Ingreso al metodo soloNumeros: ");

            bool bandera = false;

            foreach (char item in cadena)
            {
                //Si algun caracter NO es numero:
                if (!(char.IsNumber(item)))
                {
                    bandera = true;
                    break;
                }
            }


            Console.WriteLine("Valor Bandera: " + bandera);

            return bandera;

        }

        //Al cargar el Form Actualizamos los datos que traemos por objeto parametro:
        private void FrmInsertPokemon_Load(object sender, EventArgs e)
        {
            //Evento Load Form Insert Poke, acarga los comboBox:
            ControladorElemento control = new ControladorElemento();

            try
            {

                //Cargamos los comboBox:
                cboTipo.DataSource = control.allElementos();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";

                cboDebi.DataSource = control.allElementos();
                cboDebi.ValueMember = "Id";
                cboDebi.DisplayMember = "Descripcion";

                //Verificamos si hay datos por parametro y los traemos:
                if (poke != null)
                {
                    txtNum.Text = poke.Num.ToString();
                    txtNom.Text = poke.Name;
                    txtDesc.Text = poke.Descrip;
                    txtUrl.Text = poke.UrlImag;
                    cboTipo.SelectedValue = poke.Tipo.Id;
                    cboDebi.SelectedValue = poke.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error." + ex.ToString());

            }


        }

        //Evento al cambiar el texto en el TxtUrl:
        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            
            if (txtUrl.Text != "")
            {
                string img = txtUrl.Text;
                cargarImagen(img);
            }
            else
            {
                pictureImg.Load("https://dinahosting.com/blog/wp-content/uploads/2021/03/error-404.jpg");
            }

        }

        //Funcion Creada para cargar una imagen y atrapar una excepcion:
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureImg.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureImg.Load("https://dinahosting.com/blog/wp-content/uploads/2021/03/error-404.jpg");
            }
        }

        //Agregar Imagenes desde Carpeta en Proyecto:
        private void btnImg_Click(object sender, EventArgs e)
        {

            //Importante se recomienda que las imagenes de la APP se encuentren en alojamiento Nube DropBox o Drive:

            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            //Si se selecciona imagen:
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = archivo.FileName; //Guardo la Ruta Absoluta en la caja de Texto
                cargarImagen(archivo.FileName);
            }
        }
    }
}

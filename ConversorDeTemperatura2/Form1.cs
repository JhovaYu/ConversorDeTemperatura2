using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperatura2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            //Damos doble click sobre el Btn_Close y se crea automaticamente el evento click
            //El this hace referencia al padre y la funcion Close cierra el Padre en este caso el Form.
            this.Close();
        }

        private void TB_GradosCelsius_KeyDown(object sender, KeyEventArgs e)
        {
            //Creamos un if que tendra como condicional que cuando se deje de presionar la tecla [Enter] se ejecute el codigo
            if (e.KeyCode == Keys.Enter)
            {
                /*Creamos una nueva variable llamada Celsius de tipo Float la cual almacenara los valores de tipo Sting que le
                ingresemos a tipo float mediante la funcion de .Parse*/
                float Celsius = float.Parse(TB_GradosCelsius.Text);
                //Creamos una variable tipo float que almacenara el calculo de convertir de Celsius a Farenheit
                float Farenheit = (Celsius * 9f / 5f) + 32;
                /*Modificamos la propiedad de Text del TextBox de Grados Farenheit, usamos .toSting() dado que solo se puede poner
                valores en cadenas y calculamos todo esto en tipo float*/
                TB_GradosFarenheit.Text = Farenheit.ToString();
            }

        }

        private void TB_GradosFarenheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float Farenheit = float.Parse(TB_GradosFarenheit.Text);
                float Celsius = (Farenheit * 9f / 5f) + 32;
                TB_GradosCelsius.Text = Celsius.ToString();
            }
        }

        private void TB_GradosCelsius_Click(object sender, EventArgs e)
        {
            //Agreamos un .Text = "" para hacer que alk momento de darle click se limpie el TextBox
            TB_GradosCelsius.Text = "";
        }

        private void TB_GradosFarenheit_Click(object sender, EventArgs e)
        {
            TB_GradosFarenheit.Text = "";
        }

        private void TB_GradosCelsius_Leave(object sender, EventArgs e)
        {
            /*Creamos una sentencia if la cual verifica que si el Texto dentro del TextBox esta vacio entoces ejecuta el 
            codigo que le devuelve su valor que le colocamos originalmente*/
            if(TB_GradosCelsius.Text == "")
            {
                TB_GradosCelsius.Text = "Ingrese grados celsius";
            }
        }

        private void TB_GradosFarenheit_Leave(object sender, EventArgs e)
        {
            if (TB_GradosFarenheit.Text == "")
            {
                TB_GradosFarenheit.Text = "Ingrese grados Farenheit";
            }
        }

        private void Img_Clean_Click(object sender, EventArgs e)
        {
            //Al hacer click sobre el icono de Clean, limpiara ambos TextBox y colocara su valor por defecto
            TB_GradosCelsius.Text = "Ingrese grados celsius";
            TB_GradosFarenheit.Text = "Ingrese grados Farenheit";
        }
    }
}

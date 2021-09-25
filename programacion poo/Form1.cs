using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacion_poo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creamos la instancia
            Periodico periodico = new Periodico();

            //creamos un objeto
            periodico.setPeriodicoId(1);
            periodico.setNombre("seguridad en SGDB");
            periodico.setFechas("seguridad de datos");

           
          

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Periodico Periodico = new Periodico();
            Periodico.setPeriodicoId(Convert.ToInt32(txtId.Text));
            Periodico.setNombre(txtTitle.Text);
            Periodico.setFechas(txtFechas.Text);
            Periodico.setDescripcion(txtDescripcion.Text);

            lstPeriodicoInfo.Items.Add(Periodico.getPeriodicoInfo());


        }




        
    } 
}

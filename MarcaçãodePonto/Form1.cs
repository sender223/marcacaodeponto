using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarcaçãodePonto {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        TimeSpan horaEntrada = new TimeSpan();     
        TimeSpan horaAlmoco = new TimeSpan();
        TimeSpan qntHoraAlmoco = new TimeSpan();
        TimeSpan qntHorasDiarias = new TimeSpan(8, 48, 00);
        
        TimeSpan retornoAlmoco = new TimeSpan();


        private void label1_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            string hEntrada = mskHoraEntrada.Text;
            horaEntrada = TimeSpan.Parse(hEntrada);

            string hAlmoco = mskHoraAlmoco.Text;
            horaAlmoco = TimeSpan.Parse(hAlmoco);

            string qntHAlmoco = mskQntHoraAlmoco.Text;
            qntHoraAlmoco = TimeSpan.Parse(qntHAlmoco);

            TimeSpan expedienteDiario = qntHorasDiarias.Add(qntHoraAlmoco);
            TimeSpan expedienteTotal = horaEntrada.Add(expedienteDiario);

            TimeSpan retornoAlmoco = horaAlmoco.Add(qntHoraAlmoco);

            lblAlmoco.Text = retornoAlmoco.ToString();
            lblSaidaExp.Text = expedienteTotal.ToString();
            


        }

        private void lblSaidaExp_Click(object sender, EventArgs e) {
            
        }
    }
}

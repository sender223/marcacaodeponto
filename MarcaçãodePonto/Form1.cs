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
        
        //TimeSpan expedienteDiario = qntHorasDiarias.Add(qntHoraAlmoco);
        TimeSpan retornoAlmoco = new TimeSpan();
        TimeSpan saidaExpediente = new TimeSpan();

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            string hEntrada = tbHoraEntrada.Text;
            horaEntrada = TimeSpan.Parse(hEntrada);

            string hAlmoco = tbHoraAlmoco.Text;
            horaAlmoco = TimeSpan.Parse(hAlmoco);

            string qntHAlmoco = tbQntHoraAlmoco.Text;
            qntHoraAlmoco = TimeSpan.Parse(hAlmoco);

            TimeSpan expedienteDiario = qntHorasDiarias.Add(qntHoraAlmoco);

            TimeSpan subExpediente = horaEntrada.Add(expedienteDiario);


            lblSaidaExp.Text = subExpediente.ToString();



        }

        private void lblSaidaExp_Click(object sender, EventArgs e) {
            
        }
    }
}

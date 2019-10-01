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
        TimeSpan minutoEntrada = new TimeSpan();
        TimeSpan horaAlmoco = new TimeSpan();
        TimeSpan minutoAlmoco = new TimeSpan();
        TimeSpan qntHoraAlmoco = new TimeSpan();
        TimeSpan qntMinutoAlmoco = new TimeSpan();

        TimeSpan expedienteDiario = new TimeSpan(8, 40, 00);

        

        TimeSpan retornoAlmoco = new TimeSpan();
        TimeSpan saidaExpediente = new TimeSpan();

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            string hEntrada = tbHoraEntrada.Text;
            horaEntrada = TimeSpan.Parse(hEntrada);
            string mEntrada = tbMinutoEntrada.Text;
            minutoEntrada = TimeSpan.Parse(mEntrada);

            string hAlmoco = tbHoraAlmoco.Text;
            horaAlmoco = TimeSpan.Parse(hAlmoco);
            string mAlmoco = tbMinutoAlmoco.Text;
            minutoAlmoco = TimeSpan.Parse(mAlmoco);

            string qntHAlmoco = tbQntHoraAlmoco.Text;
            qntHoraAlmoco = TimeSpan.Parse(hAlmoco);
            string qntMAlmoco = tbQntMinutoAlmoco.Text;
            qntMinutoAlmoco = TimeSpan.Parse(mAlmoco);

            TimeSpan somaExpediente = horaEntrada + minutoEntrada - expedienteDiario;


            lblSaidaExp.Text = somaExpediente.ToString();



        }

        private void lblSaidaExp_Click(object sender, EventArgs e) {
            
        }
    }
}

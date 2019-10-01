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
        TimeSpan qntHorasDiarias1 = new TimeSpan(8, 48, 00);
        TimeSpan qntHorasDiarias2 = new TimeSpan(8, 00, 00);

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            if (cbCargaHoraria.Text == "8h") {                

                string hEntrada = mskHoraEntrada.Text;
                horaEntrada = TimeSpan.Parse(hEntrada);

                string hAlmoco = mskHoraAlmoco.Text;
                horaAlmoco = TimeSpan.Parse(hAlmoco);

                string qntHAlmoco = mskQntHoraAlmoco.Text;
                qntHoraAlmoco = TimeSpan.Parse(qntHAlmoco);

                TimeSpan expedienteDiario = qntHorasDiarias2.Add(qntHoraAlmoco);
                TimeSpan expedienteTotal = horaEntrada.Add(expedienteDiario);

                TimeSpan retornoAlmoco = horaAlmoco.Add(qntHoraAlmoco);

                lblAlmoco.Text = retornoAlmoco.ToString();
                lblSaidaExp.Text = expedienteTotal.ToString();

                label3.Text = " ";

            }else if (cbCargaHoraria.Text == "8.48h") {
                string hEntrada = mskHoraEntrada.Text;
                horaEntrada = TimeSpan.Parse(hEntrada);

                string hAlmoco = mskHoraAlmoco.Text;
                horaAlmoco = TimeSpan.Parse(hAlmoco);

                string qntHAlmoco = mskQntHoraAlmoco.Text;
                qntHoraAlmoco = TimeSpan.Parse(qntHAlmoco);

                TimeSpan expedienteDiario = qntHorasDiarias1.Add(qntHoraAlmoco);
                TimeSpan expedienteTotal = horaEntrada.Add(expedienteDiario);

                TimeSpan retornoAlmoco = horaAlmoco.Add(qntHoraAlmoco);

                lblAlmoco.Text = retornoAlmoco.ToString();
                lblSaidaExp.Text = expedienteTotal.ToString();

                label3.Text = " ";
            }
            else { label3.Text = "Por favor Selecione a Carga Horaria para continuar!"; }            
            
        }

        private void lblSaidaExp_Click(object sender, EventArgs e) {
            
        }
    }
}

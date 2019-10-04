using System;
using System.Windows.Forms;

namespace MarcaçãodePonto {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        TimeSpan horaEntrada = new TimeSpan();     
        TimeSpan horaAlmoco = new TimeSpan();
        TimeSpan retornoHoraAlmoco = new TimeSpan();
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

                string retornoHAlmoco = mskQntHoraAlmoco.Text;
                retornoHoraAlmoco = TimeSpan.Parse(retornoHAlmoco);

                TimeSpan totalAlmoco = retornoHoraAlmoco.Subtract(horaAlmoco);

                TimeSpan expedienteDiario = qntHorasDiarias2.Add(totalAlmoco);
                TimeSpan expedienteTotal = horaEntrada.Add(expedienteDiario);

                lblAlmoco.Text = totalAlmoco.ToString();
                lblSaidaExp.Text = expedienteTotal.ToString();

                label3.Text = " ";

            }else if (cbCargaHoraria.Text == "8.48h") {
                string hEntrada = mskHoraEntrada.Text;
                horaEntrada = TimeSpan.Parse(hEntrada);

                string hAlmoco = mskHoraAlmoco.Text;
                horaAlmoco = TimeSpan.Parse(hAlmoco);

                string qntHAlmoco = mskQntHoraAlmoco.Text;
                retornoHoraAlmoco = TimeSpan.Parse(qntHAlmoco);

                TimeSpan totalAlmoco = retornoHoraAlmoco.Subtract(horaAlmoco);

                TimeSpan expedienteDiario = qntHorasDiarias1.Add(totalAlmoco);
                TimeSpan expedienteTotal = horaEntrada.Add(expedienteDiario);                

                lblAlmoco.Text = totalAlmoco.ToString();
                lblSaidaExp.Text = expedienteTotal.ToString();

                label3.Text = " ";
            }
            else { label3.Text = "Por favor, Selecione a Carga Horaria para continuar!"; }            
            
        }

        private void lblSaidaExp_Click(object sender, EventArgs e) {
            
        }
    }
}

namespace MarcaçãodePonto {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAlmoco = new System.Windows.Forms.Label();
            this.lblSaidaExp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mskHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.mskQntHoraAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.cbCargaHoraria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Horario de Entrada:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Digite o Horario de saida para o almoço:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Horas feitas de almoço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Seu Expediente Termina as:  ";
            // 
            // lblAlmoco
            // 
            this.lblAlmoco.AutoSize = true;
            this.lblAlmoco.Location = new System.Drawing.Point(251, 293);
            this.lblAlmoco.Name = "lblAlmoco";
            this.lblAlmoco.Size = new System.Drawing.Size(62, 13);
            this.lblAlmoco.TabIndex = 12;
            this.lblAlmoco.Text = "xxxxxxxxxxx";
            // 
            // lblSaidaExp
            // 
            this.lblSaidaExp.AutoSize = true;
            this.lblSaidaExp.Location = new System.Drawing.Point(251, 317);
            this.lblSaidaExp.Name = "lblSaidaExp";
            this.lblSaidaExp.Size = new System.Drawing.Size(62, 13);
            this.lblSaidaExp.TabIndex = 13;
            this.lblSaidaExp.Text = "xxxxxxxxxxx";
            this.lblSaidaExp.Click += new System.EventHandler(this.lblSaidaExp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Digite o Horario de Retorno do almoço:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(148, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mskHoraEntrada
            // 
            this.mskHoraEntrada.Location = new System.Drawing.Point(170, 86);
            this.mskHoraEntrada.Mask = "00:00";
            this.mskHoraEntrada.Name = "mskHoraEntrada";
            this.mskHoraEntrada.Size = new System.Drawing.Size(37, 20);
            this.mskHoraEntrada.TabIndex = 20;
            this.mskHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // mskHoraAlmoco
            // 
            this.mskHoraAlmoco.Location = new System.Drawing.Point(170, 153);
            this.mskHoraAlmoco.Mask = "00:00";
            this.mskHoraAlmoco.Name = "mskHoraAlmoco";
            this.mskHoraAlmoco.Size = new System.Drawing.Size(37, 20);
            this.mskHoraAlmoco.TabIndex = 21;
            this.mskHoraAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // mskQntHoraAlmoco
            // 
            this.mskQntHoraAlmoco.Location = new System.Drawing.Point(170, 214);
            this.mskQntHoraAlmoco.Mask = "00:00";
            this.mskQntHoraAlmoco.Name = "mskQntHoraAlmoco";
            this.mskQntHoraAlmoco.Size = new System.Drawing.Size(37, 20);
            this.mskQntHoraAlmoco.TabIndex = 22;
            this.mskQntHoraAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // cbCargaHoraria
            // 
            this.cbCargaHoraria.FormattingEnabled = true;
            this.cbCargaHoraria.Items.AddRange(new object[] {
            "8h",
            "8.48h"});
            this.cbCargaHoraria.Location = new System.Drawing.Point(195, 11);
            this.cbCargaHoraria.Name = "cbCargaHoraria";
            this.cbCargaHoraria.Size = new System.Drawing.Size(121, 21);
            this.cbCargaHoraria.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Selecione a Carga Horaria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCargaHoraria);
            this.Controls.Add(this.mskQntHoraAlmoco);
            this.Controls.Add(this.mskHoraAlmoco);
            this.Controls.Add(this.mskHoraEntrada);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSaidaExp);
            this.Controls.Add(this.lblAlmoco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAlmoco;
        private System.Windows.Forms.Label lblSaidaExp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mskHoraEntrada;
        private System.Windows.Forms.MaskedTextBox mskHoraAlmoco;
        private System.Windows.Forms.MaskedTextBox mskQntHoraAlmoco;
        private System.Windows.Forms.ComboBox cbCargaHoraria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


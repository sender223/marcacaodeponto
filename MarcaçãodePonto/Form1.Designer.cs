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
            this.tbHoraEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHoraAlmoco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAlmoco = new System.Windows.Forms.Label();
            this.lblSaidaExp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbQntHoraAlmoco = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHoraEntrada
            // 
            this.tbHoraEntrada.Location = new System.Drawing.Point(167, 86);
            this.tbHoraEntrada.Name = "tbHoraEntrada";
            this.tbHoraEntrada.Size = new System.Drawing.Size(43, 20);
            this.tbHoraEntrada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Horario de Entrada, ex: 7:30";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Digite o Horario de saida para o almoço:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbHoraAlmoco
            // 
            this.tbHoraAlmoco.Location = new System.Drawing.Point(167, 151);
            this.tbHoraAlmoco.Name = "tbHoraAlmoco";
            this.tbHoraAlmoco.Size = new System.Drawing.Size(43, 20);
            this.tbHoraAlmoco.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Você deve retornar do almoço as:  ";
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
            this.label13.Location = new System.Drawing.Point(86, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Quantas Horas de Almoço Você tem Direito?";
            // 
            // tbQntHoraAlmoco
            // 
            this.tbQntHoraAlmoco.Location = new System.Drawing.Point(167, 212);
            this.tbQntHoraAlmoco.Name = "tbQntHoraAlmoco";
            this.tbQntHoraAlmoco.Size = new System.Drawing.Size(43, 20);
            this.tbQntHoraAlmoco.TabIndex = 14;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 339);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbQntHoraAlmoco);
            this.Controls.Add(this.lblSaidaExp);
            this.Controls.Add(this.lblAlmoco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHoraAlmoco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHoraEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHoraEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHoraAlmoco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAlmoco;
        private System.Windows.Forms.Label lblSaidaExp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbQntHoraAlmoco;
        private System.Windows.Forms.Button btnCalcular;
    }
}


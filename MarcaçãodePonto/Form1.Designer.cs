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
            this.tbMinutoEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMinutoAlmoco = new System.Windows.Forms.TextBox();
            this.tbHoraAlmoco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAlmoco = new System.Windows.Forms.Label();
            this.lblSaidaExp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbQntMinutoAlmoco = new System.Windows.Forms.TextBox();
            this.tbQntHoraAlmoco = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHoraEntrada
            // 
            this.tbHoraEntrada.Location = new System.Drawing.Point(153, 97);
            this.tbHoraEntrada.Name = "tbHoraEntrada";
            this.tbHoraEntrada.Size = new System.Drawing.Size(27, 20);
            this.tbHoraEntrada.TabIndex = 0;
            // 
            // tbMinutoEntrada
            // 
            this.tbMinutoEntrada.Location = new System.Drawing.Point(196, 97);
            this.tbMinutoEntrada.Name = "tbMinutoEntrada";
            this.tbMinutoEntrada.Size = new System.Drawing.Size(27, 20);
            this.tbMinutoEntrada.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Horas";
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
            // tbMinutoAlmoco
            // 
            this.tbMinutoAlmoco.Location = new System.Drawing.Point(190, 161);
            this.tbMinutoAlmoco.Name = "tbMinutoAlmoco";
            this.tbMinutoAlmoco.Size = new System.Drawing.Size(40, 20);
            this.tbMinutoAlmoco.TabIndex = 6;
            // 
            // tbHoraAlmoco
            // 
            this.tbHoraAlmoco.Location = new System.Drawing.Point(147, 161);
            this.tbHoraAlmoco.Name = "tbHoraAlmoco";
            this.tbHoraAlmoco.Size = new System.Drawing.Size(40, 20);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Minutos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Horas";
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
            // tbQntMinutoAlmoco
            // 
            this.tbQntMinutoAlmoco.Location = new System.Drawing.Point(190, 220);
            this.tbQntMinutoAlmoco.Name = "tbQntMinutoAlmoco";
            this.tbQntMinutoAlmoco.Size = new System.Drawing.Size(40, 20);
            this.tbQntMinutoAlmoco.TabIndex = 15;
            // 
            // tbQntHoraAlmoco
            // 
            this.tbQntHoraAlmoco.Location = new System.Drawing.Point(147, 220);
            this.tbQntHoraAlmoco.Name = "tbQntHoraAlmoco";
            this.tbQntHoraAlmoco.Size = new System.Drawing.Size(40, 20);
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
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbQntMinutoAlmoco);
            this.Controls.Add(this.tbQntHoraAlmoco);
            this.Controls.Add(this.lblSaidaExp);
            this.Controls.Add(this.lblAlmoco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMinutoAlmoco);
            this.Controls.Add(this.tbHoraAlmoco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMinutoEntrada);
            this.Controls.Add(this.tbHoraEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHoraEntrada;
        private System.Windows.Forms.TextBox tbMinutoEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMinutoAlmoco;
        private System.Windows.Forms.TextBox tbHoraAlmoco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAlmoco;
        private System.Windows.Forms.Label lblSaidaExp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbQntMinutoAlmoco;
        private System.Windows.Forms.TextBox tbQntHoraAlmoco;
        private System.Windows.Forms.Button btnCalcular;
    }
}


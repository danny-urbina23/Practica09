namespace Practica09
{
    partial class TemperaturaSensor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllimtem = new System.Windows.Forms.Label();
            this.lbltem = new System.Windows.Forms.Label();
            this.lblcon = new System.Windows.Forms.Label();
            this.lbltemperatura = new System.Windows.Forms.Label();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.btnconectar = new System.Windows.Forms.Button();
            this.txtescribir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllimtem
            // 
            this.lbllimtem.AutoSize = true;
            this.lbllimtem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllimtem.Location = new System.Drawing.Point(58, 108);
            this.lbllimtem.Name = "lbllimtem";
            this.lbllimtem.Size = new System.Drawing.Size(177, 35);
            this.lbllimtem.TabIndex = 0;
            this.lbllimtem.Text = "Limete De Temperatura";
            // 
            // lbltem
            // 
            this.lbltem.AutoSize = true;
            this.lbltem.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltem.Location = new System.Drawing.Point(445, 97);
            this.lbltem.Name = "lbltem";
            this.lbltem.Size = new System.Drawing.Size(111, 39);
            this.lbltem.TabIndex = 1;
            this.lbltem.Text = "Temperatura";
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon.Location = new System.Drawing.Point(89, 212);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(146, 50);
            this.lblcon.TabIndex = 2;
            this.lblcon.Text = "Sin Conexion";
            // 
            // lbltemperatura
            // 
            this.lbltemperatura.AutoSize = true;
            this.lbltemperatura.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemperatura.Location = new System.Drawing.Point(437, 136);
            this.lbltemperatura.Name = "lbltemperatura";
            this.lbltemperatura.Size = new System.Drawing.Size(133, 86);
            this.lbltemperatura.TabIndex = 3;
            this.lbltemperatura.Text = "0.0";
            // 
            // btndesconectar
            // 
            this.btndesconectar.BackColor = System.Drawing.Color.Red;
            this.btndesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesconectar.Location = new System.Drawing.Point(325, 288);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(142, 38);
            this.btndesconectar.TabIndex = 4;
            this.btndesconectar.Text = "DESCONECTAR";
            this.btndesconectar.UseVisualStyleBackColor = false;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // btnconectar
            // 
            this.btnconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconectar.Location = new System.Drawing.Point(157, 288);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(142, 38);
            this.btnconectar.TabIndex = 5;
            this.btnconectar.Text = "CONECTAR";
            this.btnconectar.UseVisualStyleBackColor = false;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // txtescribir
            // 
            this.txtescribir.Location = new System.Drawing.Point(86, 157);
            this.txtescribir.Name = "txtescribir";
            this.txtescribir.Size = new System.Drawing.Size(124, 20);
            this.txtescribir.TabIndex = 6;
            this.txtescribir.TextChanged += new System.EventHandler(this.txtescribir_TextChanged);
            // 
            // TemperaturaSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.txtescribir);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.lbltemperatura);
            this.Controls.Add(this.lblcon);
            this.Controls.Add(this.lbltem);
            this.Controls.Add(this.lbllimtem);
            this.Name = "TemperaturaSensor";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllimtem;
        private System.Windows.Forms.Label lbltem;
        private System.Windows.Forms.Label lblcon;
        private System.Windows.Forms.Label lbltemperatura;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.TextBox txtescribir;
    }
}


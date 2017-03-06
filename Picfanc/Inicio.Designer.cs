namespace Picfanc
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxCerrar = new System.Windows.Forms.PictureBox();
            this.boxMinimizar = new System.Windows.Forms.PictureBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.btnAutomatico = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.sepAutomatico = new System.Windows.Forms.Panel();
            this.sepManual = new System.Windows.Forms.Panel();
            this.panelAuto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAutoTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAutomatico = new System.Windows.Forms.PictureBox();
            this.lblAutoEstado = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManualestado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblManualTemp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picManual = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimizar)).BeginInit();
            this.panelBorder.SuspendLayout();
            this.panelAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAutomatico)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManual)).BeginInit();
            this.SuspendLayout();
            // 
            // boxCerrar
            // 
            this.boxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxCerrar.BackgroundImage = global::Picfanc.Properties.Resources.cancel;
            this.boxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxCerrar.Location = new System.Drawing.Point(699, 3);
            this.boxCerrar.Name = "boxCerrar";
            this.boxCerrar.Size = new System.Drawing.Size(37, 37);
            this.boxCerrar.TabIndex = 0;
            this.boxCerrar.TabStop = false;
            this.boxCerrar.Click += new System.EventHandler(this.boxCerrar_Click);
            // 
            // boxMinimizar
            // 
            this.boxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxMinimizar.BackgroundImage = global::Picfanc.Properties.Resources.minimize;
            this.boxMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxMinimizar.Location = new System.Drawing.Point(655, 3);
            this.boxMinimizar.Name = "boxMinimizar";
            this.boxMinimizar.Size = new System.Drawing.Size(37, 37);
            this.boxMinimizar.TabIndex = 1;
            this.boxMinimizar.TabStop = false;
            this.boxMinimizar.Click += new System.EventHandler(this.boxMinimizar_Click);
            // 
            // panelBorder
            // 
            this.panelBorder.Controls.Add(this.boxCerrar);
            this.panelBorder.Controls.Add(this.boxMinimizar);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(742, 45);
            this.panelBorder.TabIndex = 2;
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.FlatAppearance.BorderSize = 0;
            this.btnAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomatico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomatico.ForeColor = System.Drawing.Color.White;
            this.btnAutomatico.Location = new System.Drawing.Point(29, 66);
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.Size = new System.Drawing.Size(159, 37);
            this.btnAutomatico.TabIndex = 3;
            this.btnAutomatico.Text = "Automatico";
            this.btnAutomatico.UseVisualStyleBackColor = true;
            this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
            // 
            // btnManual
            // 
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(195, 66);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(159, 37);
            this.btnManual.TabIndex = 4;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // sepAutomatico
            // 
            this.sepAutomatico.BackColor = System.Drawing.Color.Teal;
            this.sepAutomatico.Location = new System.Drawing.Point(29, 105);
            this.sepAutomatico.Name = "sepAutomatico";
            this.sepAutomatico.Size = new System.Drawing.Size(159, 5);
            this.sepAutomatico.TabIndex = 5;
            // 
            // sepManual
            // 
            this.sepManual.Location = new System.Drawing.Point(195, 105);
            this.sepManual.Name = "sepManual";
            this.sepManual.Size = new System.Drawing.Size(159, 5);
            this.sepManual.TabIndex = 6;
            // 
            // panelAuto
            // 
            this.panelAuto.Controls.Add(this.lblAutoEstado);
            this.panelAuto.Controls.Add(this.label11);
            this.panelAuto.Controls.Add(this.label3);
            this.panelAuto.Controls.Add(this.lblAutoTemp);
            this.panelAuto.Controls.Add(this.label1);
            this.panelAuto.Controls.Add(this.picAutomatico);
            this.panelAuto.Location = new System.Drawing.Point(29, 133);
            this.panelAuto.Name = "panelAuto";
            this.panelAuto.Size = new System.Drawing.Size(324, 373);
            this.panelAuto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "o";
            // 
            // lblAutoTemp
            // 
            this.lblAutoTemp.AutoSize = true;
            this.lblAutoTemp.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoTemp.ForeColor = System.Drawing.Color.White;
            this.lblAutoTemp.Location = new System.Drawing.Point(24, 218);
            this.lblAutoTemp.Name = "lblAutoTemp";
            this.lblAutoTemp.Size = new System.Drawing.Size(107, 86);
            this.lblAutoTemp.TabIndex = 2;
            this.lblAutoTemp.Text = "32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura";
            // 
            // picAutomatico
            // 
            this.picAutomatico.Location = new System.Drawing.Point(24, 13);
            this.picAutomatico.Name = "picAutomatico";
            this.picAutomatico.Size = new System.Drawing.Size(212, 150);
            this.picAutomatico.TabIndex = 0;
            this.picAutomatico.TabStop = false;
            // 
            // lblAutoEstado
            // 
            this.lblAutoEstado.AutoSize = true;
            this.lblAutoEstado.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoEstado.ForeColor = System.Drawing.Color.White;
            this.lblAutoEstado.Location = new System.Drawing.Point(165, 218);
            this.lblAutoEstado.Name = "lblAutoEstado";
            this.lblAutoEstado.Size = new System.Drawing.Size(133, 86);
            this.lblAutoEstado.TabIndex = 5;
            this.lblAutoEstado.Text = "ON";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(175, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "FAN";
            // 
            // btnOnOff
            // 
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.Location = new System.Drawing.Point(39, 316);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(256, 38);
            this.btnOnOff.TabIndex = 4;
            this.btnOnOff.Text = "Encender";
            this.btnOnOff.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblManualestado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnOnOff);
            this.panel1.Controls.Add(this.lblManualTemp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.picManual);
            this.panel1.Location = new System.Drawing.Point(384, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 373);
            this.panel1.TabIndex = 8;
            // 
            // lblManualestado
            // 
            this.lblManualestado.AutoSize = true;
            this.lblManualestado.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualestado.ForeColor = System.Drawing.Color.White;
            this.lblManualestado.Location = new System.Drawing.Point(165, 218);
            this.lblManualestado.Name = "lblManualestado";
            this.lblManualestado.Size = new System.Drawing.Size(147, 86);
            this.lblManualestado.TabIndex = 5;
            this.lblManualestado.Text = "OFF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(175, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "FAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "o";
            // 
            // lblManualTemp
            // 
            this.lblManualTemp.AutoSize = true;
            this.lblManualTemp.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualTemp.ForeColor = System.Drawing.Color.White;
            this.lblManualTemp.Location = new System.Drawing.Point(24, 218);
            this.lblManualTemp.Name = "lblManualTemp";
            this.lblManualTemp.Size = new System.Drawing.Size(107, 86);
            this.lblManualTemp.TabIndex = 2;
            this.lblManualTemp.Text = "32";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Temperatura";
            // 
            // picManual
            // 
            this.picManual.Location = new System.Drawing.Point(24, 13);
            this.picManual.Name = "picManual";
            this.picManual.Size = new System.Drawing.Size(212, 150);
            this.picManual.TabIndex = 0;
            this.picManual.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(742, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAuto);
            this.Controls.Add(this.sepManual);
            this.Controls.Add(this.sepAutomatico);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnAutomatico);
            this.Controls.Add(this.panelBorder);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picfanc";
            ((System.ComponentModel.ISupportInitialize)(this.boxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimizar)).EndInit();
            this.panelBorder.ResumeLayout(false);
            this.panelAuto.ResumeLayout(false);
            this.panelAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAutomatico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boxCerrar;
        private System.Windows.Forms.PictureBox boxMinimizar;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Button btnAutomatico;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel sepAutomatico;
        private System.Windows.Forms.Panel sepManual;
        private System.Windows.Forms.Panel panelAuto;
        private System.Windows.Forms.PictureBox picAutomatico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAutoTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutoEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManualestado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblManualTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picManual;
    }
}


﻿namespace Picfanc
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.btnAutomatico = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.sepAutomatico = new System.Windows.Forms.Panel();
            this.sepManual = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.lblAutoEstado = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAutoTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizarPuertos = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boxCerrar = new System.Windows.Forms.PictureBox();
            this.boxMinimizar = new System.Windows.Forms.PictureBox();
            this.panelBorder.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.Controls.Add(this.button1);
            this.panelBorder.Controls.Add(this.boxCerrar);
            this.panelBorder.Controls.Add(this.boxMinimizar);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(382, 37);
            this.panelBorder.TabIndex = 2;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.Enabled = false;
            this.btnAutomatico.FlatAppearance.BorderSize = 0;
            this.btnAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomatico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomatico.ForeColor = System.Drawing.Color.White;
            this.btnAutomatico.Location = new System.Drawing.Point(29, 94);
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.Size = new System.Drawing.Size(159, 37);
            this.btnAutomatico.TabIndex = 3;
            this.btnAutomatico.Text = "Automatico";
            this.btnAutomatico.UseVisualStyleBackColor = true;
            this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
            // 
            // btnManual
            // 
            this.btnManual.Enabled = false;
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(195, 94);
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
            this.sepAutomatico.Location = new System.Drawing.Point(29, 133);
            this.sepAutomatico.Name = "sepAutomatico";
            this.sepAutomatico.Size = new System.Drawing.Size(159, 5);
            this.sepAutomatico.TabIndex = 5;
            // 
            // sepManual
            // 
            this.sepManual.Location = new System.Drawing.Point(195, 133);
            this.sepManual.Name = "sepManual";
            this.sepManual.Size = new System.Drawing.Size(159, 5);
            this.sepManual.TabIndex = 6;
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.lblAutoEstado);
            this.contenedor.Controls.Add(this.label11);
            this.contenedor.Controls.Add(this.label3);
            this.contenedor.Controls.Add(this.btnOnOff);
            this.contenedor.Controls.Add(this.lblAutoTemp);
            this.contenedor.Controls.Add(this.label1);
            this.contenedor.Controls.Add(this.imagen);
            this.contenedor.Location = new System.Drawing.Point(29, 161);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(324, 401);
            this.contenedor.TabIndex = 7;
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
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.White;
            this.lblSalida.Location = new System.Drawing.Point(24, 567);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(28, 30);
            this.lblSalida.TabIndex = 9;
            this.lblSalida.Text = "...";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(29, 62);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(89, 23);
            this.cmbPuertos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puertos";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(195, 62);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(50, 23);
            this.txtTemp.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(192, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sensibilidad temperatura";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Picfanc.Properties.Resources.Thermometer_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(251, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 26);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizarPuertos
            // 
            this.btnActualizarPuertos.BackColor = System.Drawing.Color.White;
            this.btnActualizarPuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPuertos.Image = global::Picfanc.Properties.Resources.RS_232_Female_32px;
            this.btnActualizarPuertos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPuertos.Location = new System.Drawing.Point(124, 59);
            this.btnActualizarPuertos.Name = "btnActualizarPuertos";
            this.btnActualizarPuertos.Size = new System.Drawing.Size(43, 26);
            this.btnActualizarPuertos.TabIndex = 12;
            this.btnActualizarPuertos.UseVisualStyleBackColor = false;
            this.btnActualizarPuertos.Click += new System.EventHandler(this.btnActualizarPuertos_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Enabled = false;
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.Image = global::Picfanc.Properties.Resources.Flash_Off_24px;
            this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnOff.Location = new System.Drawing.Point(24, 336);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(274, 53);
            this.btnOnOff.TabIndex = 4;
            this.btnOnOff.Text = "Encender";
            this.btnOnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(24, 13);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(212, 150);
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Picfanc.Properties.Resources.Restart_32px;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxCerrar
            // 
            this.boxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxCerrar.BackgroundImage = global::Picfanc.Properties.Resources.Close_Window_32px;
            this.boxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxCerrar.Location = new System.Drawing.Point(339, 3);
            this.boxCerrar.Name = "boxCerrar";
            this.boxCerrar.Size = new System.Drawing.Size(37, 35);
            this.boxCerrar.TabIndex = 0;
            this.boxCerrar.TabStop = false;
            this.boxCerrar.Click += new System.EventHandler(this.boxCerrar_Click);
            // 
            // boxMinimizar
            // 
            this.boxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxMinimizar.BackgroundImage = global::Picfanc.Properties.Resources.Minimize_Window_32px;
            this.boxMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxMinimizar.Location = new System.Drawing.Point(301, 3);
            this.boxMinimizar.Name = "boxMinimizar";
            this.boxMinimizar.Size = new System.Drawing.Size(37, 35);
            this.boxMinimizar.TabIndex = 1;
            this.boxMinimizar.TabStop = false;
            this.boxMinimizar.Click += new System.EventHandler(this.boxMinimizar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnActualizarPuertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.contenedor);
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
            this.panelBorder.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxCerrar;
        private System.Windows.Forms.PictureBox boxMinimizar;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Button btnAutomatico;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel sepAutomatico;
        private System.Windows.Forms.Panel sepManual;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAutoTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutoEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarPuertos;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}


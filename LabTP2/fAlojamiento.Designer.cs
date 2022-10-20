namespace LabTP2
{
    partial class fAlojamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBDIreccion = new System.Windows.Forms.TextBox();
            this.gbCasa = new System.Windows.Forms.GroupBox();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chBCochera = new System.Windows.Forms.CheckBox();
            this.chBPileta = new System.Windows.Forms.CheckBox();
            this.chBWifi = new System.Windows.Forms.CheckBox();
            this.chBLimpieza = new System.Windows.Forms.CheckBox();
            this.chBDesayuno = new System.Windows.Forms.CheckBox();
            this.chBMascotas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cbAlojamientos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBNumHab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModif = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.gbCasa.SuspendLayout();
            this.gbHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Habitacion",
            "Casa"});
            this.comboBox1.Location = new System.Drawing.Point(122, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBDIreccion
            // 
            this.tBDIreccion.Location = new System.Drawing.Point(122, 122);
            this.tBDIreccion.Name = "tBDIreccion";
            this.tBDIreccion.Size = new System.Drawing.Size(121, 20);
            this.tBDIreccion.TabIndex = 2;
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.numericUpDown2);
            this.gbCasa.Controls.Add(this.chBMascotas);
            this.gbCasa.Controls.Add(this.label4);
            this.gbCasa.Controls.Add(this.chBWifi);
            this.gbCasa.Controls.Add(this.chBDesayuno);
            this.gbCasa.Controls.Add(this.chBPileta);
            this.gbCasa.Controls.Add(this.chBLimpieza);
            this.gbCasa.Controls.Add(this.chBCochera);
            this.gbCasa.Location = new System.Drawing.Point(44, 192);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Size = new System.Drawing.Size(200, 207);
            this.gbCasa.TabIndex = 3;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            // 
            // gbHotel
            // 
            this.gbHotel.Controls.Add(this.label5);
            this.gbHotel.Controls.Add(this.comboBox2);
            this.gbHotel.Controls.Add(this.label6);
            this.gbHotel.Controls.Add(this.tBNumHab);
            this.gbHotel.Controls.Add(this.label7);
            this.gbHotel.Location = new System.Drawing.Point(44, 180);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Size = new System.Drawing.Size(212, 100);
            this.gbHotel.TabIndex = 4;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 86);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chBCochera
            // 
            this.chBCochera.AutoSize = true;
            this.chBCochera.Location = new System.Drawing.Point(22, 25);
            this.chBCochera.Name = "chBCochera";
            this.chBCochera.Size = new System.Drawing.Size(66, 17);
            this.chBCochera.TabIndex = 7;
            this.chBCochera.Text = "Cochera";
            this.chBCochera.UseVisualStyleBackColor = true;
            // 
            // chBPileta
            // 
            this.chBPileta.AutoSize = true;
            this.chBPileta.Location = new System.Drawing.Point(22, 48);
            this.chBPileta.Name = "chBPileta";
            this.chBPileta.Size = new System.Drawing.Size(52, 17);
            this.chBPileta.TabIndex = 7;
            this.chBPileta.Text = "Pileta";
            this.chBPileta.UseVisualStyleBackColor = true;
            // 
            // chBWifi
            // 
            this.chBWifi.AutoSize = true;
            this.chBWifi.Location = new System.Drawing.Point(22, 71);
            this.chBWifi.Name = "chBWifi";
            this.chBWifi.Size = new System.Drawing.Size(44, 17);
            this.chBWifi.TabIndex = 7;
            this.chBWifi.Text = "Wifi";
            this.chBWifi.UseVisualStyleBackColor = true;
            // 
            // chBLimpieza
            // 
            this.chBLimpieza.AutoSize = true;
            this.chBLimpieza.Location = new System.Drawing.Point(22, 94);
            this.chBLimpieza.Name = "chBLimpieza";
            this.chBLimpieza.Size = new System.Drawing.Size(95, 17);
            this.chBLimpieza.TabIndex = 7;
            this.chBLimpieza.Text = "Serv. Limpieza";
            this.chBLimpieza.UseVisualStyleBackColor = true;
            // 
            // chBDesayuno
            // 
            this.chBDesayuno.AutoSize = true;
            this.chBDesayuno.Location = new System.Drawing.Point(22, 117);
            this.chBDesayuno.Name = "chBDesayuno";
            this.chBDesayuno.Size = new System.Drawing.Size(74, 17);
            this.chBDesayuno.TabIndex = 7;
            this.chBDesayuno.Text = "Desayuno";
            this.chBDesayuno.UseVisualStyleBackColor = true;
            // 
            // chBMascotas
            // 
            this.chBMascotas.AutoSize = true;
            this.chBMascotas.Location = new System.Drawing.Point(22, 140);
            this.chBMascotas.Name = "chBMascotas";
            this.chBMascotas.Size = new System.Drawing.Size(72, 17);
            this.chBMascotas.TabIndex = 7;
            this.chBMascotas.Text = "Mascotas";
            this.chBMascotas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dias Minimos";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(111, 168);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbAlojamientos
            // 
            this.cbAlojamientos.FormattingEnabled = true;
            this.cbAlojamientos.Location = new System.Drawing.Point(122, 12);
            this.cbAlojamientos.Name = "cbAlojamientos";
            this.cbAlojamientos.Size = new System.Drawing.Size(121, 21);
            this.cbAlojamientos.TabIndex = 7;
            this.cbAlojamientos.SelectedIndexChanged += new System.EventHandler(this.cbAlojamientos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-29, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "⭐⭐",
            "⭐⭐⭐"});
            this.comboBox2.Location = new System.Drawing.Point(65, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estrellas";
            // 
            // tBNumHab
            // 
            this.tBNumHab.Location = new System.Drawing.Point(65, 71);
            this.tBNumHab.Name = "tBNumHab";
            this.tBNumHab.Size = new System.Drawing.Size(96, 20);
            this.tBNumHab.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Num Habitacion";
            // 
            // bAgregar
            // 
            this.bAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAgregar.Location = new System.Drawing.Point(262, 105);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModif
            // 
            this.bModif.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bModif.Location = new System.Drawing.Point(262, 105);
            this.bModif.Name = "bModif";
            this.bModif.Size = new System.Drawing.Size(75, 23);
            this.bModif.TabIndex = 8;
            this.bModif.Text = "Modificar";
            this.bModif.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(262, 58);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bEliminar.Location = new System.Drawing.Point(262, 13);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Dar Baja";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // fAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModif);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.cbAlojamientos);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbHotel);
            this.Controls.Add(this.gbCasa);
            this.Controls.Add(this.tBDIreccion);
            this.Controls.Add(this.comboBox1);
            this.Name = "fAlojamiento";
            this.Text = "fAlojamiento";
            this.Load += new System.EventHandler(this.fAlojamiento_Load);
            this.gbCasa.ResumeLayout(false);
            this.gbCasa.PerformLayout();
            this.gbHotel.ResumeLayout(false);
            this.gbHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tBDIreccion;
        private System.Windows.Forms.GroupBox gbCasa;
        private System.Windows.Forms.GroupBox gbHotel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox chBMascotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chBWifi;
        private System.Windows.Forms.CheckBox chBDesayuno;
        private System.Windows.Forms.CheckBox chBPileta;
        private System.Windows.Forms.CheckBox chBLimpieza;
        private System.Windows.Forms.CheckBox chBCochera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbAlojamientos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBNumHab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bModif;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bEliminar;
    }
}
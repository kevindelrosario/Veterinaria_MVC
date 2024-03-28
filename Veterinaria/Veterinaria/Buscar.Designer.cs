
namespace Veterinaria
{
    partial class Buscar
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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtDniDuenio = new System.Windows.Forms.TextBox();
            this.comboAlergia = new System.Windows.Forms.ComboBox();
            this.richObservacion = new System.Windows.Forms.RichTextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboAtencion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.id_mascota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(30, 258);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(936, 419);
            this.grilla.TabIndex = 0;
            this.grilla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grilla_CellMouseClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(362, 222);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 30);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(53, 69);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(177, 22);
            this.txtRaza.TabIndex = 8;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(53, 114);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(177, 22);
            this.txtColor.TabIndex = 9;
            // 
            // txtDniDuenio
            // 
            this.txtDniDuenio.Location = new System.Drawing.Point(362, 25);
            this.txtDniDuenio.Name = "txtDniDuenio";
            this.txtDniDuenio.Size = new System.Drawing.Size(177, 22);
            this.txtDniDuenio.TabIndex = 11;
            // 
            // comboAlergia
            // 
            this.comboAlergia.FormattingEnabled = true;
            this.comboAlergia.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboAlergia.Location = new System.Drawing.Point(54, 161);
            this.comboAlergia.Name = "comboAlergia";
            this.comboAlergia.Size = new System.Drawing.Size(55, 24);
            this.comboAlergia.TabIndex = 12;
            // 
            // richObservacion
            // 
            this.richObservacion.Location = new System.Drawing.Point(362, 79);
            this.richObservacion.Name = "richObservacion";
            this.richObservacion.Size = new System.Drawing.Size(310, 126);
            this.richObservacion.TabIndex = 14;
            this.richObservacion.Text = "";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(459, 222);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 30);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(565, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "DNI Dueño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Atención Especial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Alergico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Raza";
            // 
            // comboAtencion
            // 
            this.comboAtencion.FormattingEnabled = true;
            this.comboAtencion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboAtencion.Location = new System.Drawing.Point(54, 208);
            this.comboAtencion.Name = "comboAtencion";
            this.comboAtencion.Size = new System.Drawing.Size(55, 24);
            this.comboAtencion.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ver Dueño";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_mascota
            // 
            this.id_mascota.AutoSize = true;
            this.id_mascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id_mascota.Location = new System.Drawing.Point(590, 27);
            this.id_mascota.Name = "id_mascota";
            this.id_mascota.Size = new System.Drawing.Size(0, 17);
            this.id_mascota.TabIndex = 28;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1004, 690);
            this.Controls.Add(this.id_mascota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboAtencion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.richObservacion);
            this.Controls.Add(this.comboAlergia);
            this.Controls.Add(this.txtDniDuenio);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.grilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtDniDuenio;
        private System.Windows.Forms.ComboBox comboAlergia;
        private System.Windows.Forms.RichTextBox richObservacion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboAtencion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_mascota;
    }
}
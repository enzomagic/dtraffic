
namespace VaidrollTeamWindowsFormsApp1
{
    partial class Estacionamiento
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.seleccionare = new System.Windows.Forms.Button();
            this.sectore = new System.Windows.Forms.ComboBox();
            this.imagene = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagene)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.Location = new System.Drawing.Point(639, 298);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(91, 27);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.Text = "Regresar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESTACIONAMIENTOS :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "00",
            "15",
            "21",
            "22",
            "30",
            "48",
            "50",
            "51",
            "55"});
            this.comboBox1.Location = new System.Drawing.Point(30, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(30, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // seleccionare
            // 
            this.seleccionare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.seleccionare.Cursor = System.Windows.Forms.Cursors.Default;
            this.seleccionare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionare.ForeColor = System.Drawing.Color.Green;
            this.seleccionare.Location = new System.Drawing.Point(30, 127);
            this.seleccionare.Name = "seleccionare";
            this.seleccionare.Size = new System.Drawing.Size(106, 27);
            this.seleccionare.TabIndex = 12;
            this.seleccionare.Text = "Seleccionar";
            this.seleccionare.UseVisualStyleBackColor = false;
            this.seleccionare.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sectore
            // 
            this.sectore.FormattingEnabled = true;
            this.sectore.Items.AddRange(new object[] {
            "SECTOR A",
            "SECTOR B",
            "SECTOR C"});
            this.sectore.Location = new System.Drawing.Point(30, 91);
            this.sectore.Name = "sectore";
            this.sectore.Size = new System.Drawing.Size(121, 21);
            this.sectore.TabIndex = 13;
            this.sectore.SelectedIndexChanged += new System.EventHandler(this.sectore_SelectedIndexChanged);
            // 
            // imagene
            // 
            this.imagene.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.imagene.Location = new System.Drawing.Point(241, 53);
            this.imagene.Name = "imagene";
            this.imagene.Size = new System.Drawing.Size(459, 221);
            this.imagene.TabIndex = 14;
            this.imagene.TabStop = false;
            // 
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VaidrollTeamWindowsFormsApp1.Properties.Resources.Logo_d_traffic_final2;
            this.ClientSize = new System.Drawing.Size(771, 337);
            this.Controls.Add(this.imagene);
            this.Controls.Add(this.sectore);
            this.Controls.Add(this.seleccionare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrar);
            this.Name = "Estacionamiento";
            this.Text = "Estacionamientos";
            this.Load += new System.EventHandler(this.Estacionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button seleccionare;
        private System.Windows.Forms.ComboBox sectore;
        private System.Windows.Forms.PictureBox imagene;
    }
}
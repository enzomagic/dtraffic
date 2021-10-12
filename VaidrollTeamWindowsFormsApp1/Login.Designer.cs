
namespace VaidrollTeamWindowsFormsApp1
{
    partial class Login
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
            this.btniniciar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rut = new System.Windows.Forms.Label();
            this.txrut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btniniciar.Location = new System.Drawing.Point(106, 232);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(76, 27);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "Iniciar Sesion";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.Location = new System.Drawing.Point(212, 232);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(91, 27);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txpass
            // 
            this.txpass.Location = new System.Drawing.Point(139, 143);
            this.txpass.Name = "txpass";
            this.txpass.PasswordChar = '*';
            this.txpass.Size = new System.Drawing.Size(123, 20);
            this.txpass.TabIndex = 3;
            this.txpass.TextChanged += new System.EventHandler(this.txpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pass";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "D-TRAFFIC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rut
            // 
            this.rut.AutoSize = true;
            this.rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut.Location = new System.Drawing.Point(43, 100);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(38, 20);
            this.rut.TabIndex = 7;
            this.rut.Text = "Rut";
            this.rut.Click += new System.EventHandler(this.label4_Click);
            // 
            // txrut
            // 
            this.txrut.Location = new System.Drawing.Point(139, 100);
            this.txrut.Name = "txrut";
            this.txrut.Size = new System.Drawing.Size(123, 20);
            this.txrut.TabIndex = 8;
            this.txrut.TextChanged += new System.EventHandler(this.txrut_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::VaidrollTeamWindowsFormsApp1.Properties.Resources.Logo_d_traffic_final2;
            this.ClientSize = new System.Drawing.Size(489, 299);
            this.Controls.Add(this.txrut);
            this.Controls.Add(this.rut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txpass);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciar);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rut;
        private System.Windows.Forms.TextBox txrut;
    }
}
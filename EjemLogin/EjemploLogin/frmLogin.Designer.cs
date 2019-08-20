namespace EjemploLogin
{
    partial class frmLogin
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
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbln_Usuario = new System.Windows.Forms.Label();
            this.lbln_Contraseña = new System.Windows.Forms.Label();
            this.txt_Cotraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(92, 189);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 0;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(173, 189);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // lbln_Usuario
            // 
            this.lbln_Usuario.AutoSize = true;
            this.lbln_Usuario.Location = new System.Drawing.Point(32, 34);
            this.lbln_Usuario.Name = "lbln_Usuario";
            this.lbln_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbln_Usuario.TabIndex = 2;
            this.lbln_Usuario.Text = "Usuario";
            // 
            // lbln_Contraseña
            // 
            this.lbln_Contraseña.AutoSize = true;
            this.lbln_Contraseña.Location = new System.Drawing.Point(32, 94);
            this.lbln_Contraseña.Name = "lbln_Contraseña";
            this.lbln_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbln_Contraseña.TabIndex = 3;
            this.lbln_Contraseña.Text = "Contraseña";
            // 
            // txt_Cotraseña
            // 
            this.txt_Cotraseña.Location = new System.Drawing.Point(105, 87);
            this.txt_Cotraseña.Name = "txt_Cotraseña";
            this.txt_Cotraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_Cotraseña.TabIndex = 4;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(105, 34);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Cotraseña);
            this.Controls.Add(this.lbln_Contraseña);
            this.Controls.Add(this.lbln_Usuario);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ingresar);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbln_Usuario;
        private System.Windows.Forms.Label lbln_Contraseña;
        private System.Windows.Forms.TextBox txt_Cotraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
    }
}
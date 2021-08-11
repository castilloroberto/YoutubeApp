
namespace YoutubeApp
{
    partial class Main
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.btn_getUsuario = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(59, 163);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowHeadersWidth = 51;
            this.dgv_usuarios.RowTemplate.Height = 24;
            this.dgv_usuarios.Size = new System.Drawing.Size(762, 336);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombreUsuario.Location = new System.Drawing.Point(343, 526);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(231, 30);
            this.txt_nombreUsuario.TabIndex = 1;
            // 
            // btn_getUsuario
            // 
            this.btn_getUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_getUsuario.Location = new System.Drawing.Point(618, 522);
            this.btn_getUsuario.Name = "btn_getUsuario";
            this.btn_getUsuario.Size = new System.Drawing.Size(203, 34);
            this.btn_getUsuario.TabIndex = 2;
            this.btn_getUsuario.Text = "Obtener Usuario";
            this.btn_getUsuario.UseVisualStyleBackColor = true;
            this.btn_getUsuario.Click += new System.EventHandler(this.btn_getUsuario_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_agregar.Location = new System.Drawing.Point(618, 113);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(203, 34);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar Usuario";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 675);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_getUsuario);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.dgv_usuarios);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Button btn_getUsuario;
        private System.Windows.Forms.Button btn_agregar;
    }
}


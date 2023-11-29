namespace PantallaExpediente
{
    partial class FormPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelchildForm = new System.Windows.Forms.Panel();
            this.lstbPacientes = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.ptbCerrarSesion = new System.Windows.Forms.PictureBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelchildForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 868);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::PantallaExpediente.Properties.Resources.Home1;
            this.btnHome.Location = new System.Drawing.Point(-15, 47);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Image = global::PantallaExpediente.Properties.Resources.Perfil3;
            this.btnPerfil.Location = new System.Drawing.Point(-15, 95);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 50);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(93)))), ((int)(((byte)(112)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::PantallaExpediente.Properties.Resources.Settings1;
            this.btnSettings.Location = new System.Drawing.Point(-15, 143);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 50);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelchildForm
            // 
            this.panelchildForm.Controls.Add(this.lstbPacientes);
            this.panelchildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildForm.Location = new System.Drawing.Point(50, 46);
            this.panelchildForm.Name = "panelchildForm";
            this.panelchildForm.Size = new System.Drawing.Size(1694, 822);
            this.panelchildForm.TabIndex = 2;
            // 
            // lstbPacientes
            // 
            this.lstbPacientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbPacientes.FormattingEnabled = true;
            this.lstbPacientes.ItemHeight = 17;
            this.lstbPacientes.Location = new System.Drawing.Point(60, 6);
            this.lstbPacientes.Name = "lstbPacientes";
            this.lstbPacientes.Size = new System.Drawing.Size(256, 225);
            this.lstbPacientes.TabIndex = 0;
            this.lstbPacientes.Visible = false;
            this.lstbPacientes.SelectedIndexChanged += new System.EventHandler(this.lstbPacientes_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnPacientes);
            this.panel2.Controls.Add(this.ptbCerrarSesion);
            this.panel2.Controls.Add(this.lbNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1694, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(60, 9);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(92, 30);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // ptbCerrarSesion
            // 
            this.ptbCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCerrarSesion.Image = global::PantallaExpediente.Properties.Resources.cerrar_sesion;
            this.ptbCerrarSesion.Location = new System.Drawing.Point(1323, 6);
            this.ptbCerrarSesion.Name = "ptbCerrarSesion";
            this.ptbCerrarSesion.Size = new System.Drawing.Size(32, 37);
            this.ptbCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrarSesion.TabIndex = 0;
            this.ptbCerrarSesion.TabStop = false;
            this.ptbCerrarSesion.Click += new System.EventHandler(this.ptbCerrarSesion_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(1382, 13);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 21);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::PantallaExpediente.Properties.Resources.Home1;
            this.button5.Location = new System.Drawing.Point(-287, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 50);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 868);
            this.Controls.Add(this.panelchildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1760, 907);
            this.Name = "FormPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPadre_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panelchildForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelchildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox ptbCerrarSesion;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.ListBox lstbPacientes;
    }
}


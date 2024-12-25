namespace Views
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            btnGuardar = new Button();
            txbNome = new TextBox();
            txbNumero = new TextBox();
            CmbGenero = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            CmbParentesco = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ControlLightLight;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.AppWorkspace;
            btnGuardar.Location = new Point(385, 353);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 43);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txbNome
            // 
            txbNome.BackColor = SystemColors.AppWorkspace;
            txbNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNome.ForeColor = Color.Black;
            txbNome.Location = new Point(242, 122);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(416, 37);
            txbNome.TabIndex = 1;
            txbNome.Text = "Nome";
            txbNome.Enter += txbNome_Enter;
            txbNome.Leave += txbNome_Leave;
            // 
            // txbNumero
            // 
            txbNumero.BackColor = SystemColors.AppWorkspace;
            txbNumero.Font = new Font("Century Gothic", 12F);
            txbNumero.ForeColor = Color.Black;
            txbNumero.Location = new Point(242, 179);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(416, 37);
            txbNumero.TabIndex = 2;
            txbNumero.Text = "Número";
            txbNumero.TextChanged += txbNumero_TextChanged;
            // 
            // CmbGenero
            // 
            CmbGenero.BackColor = SystemColors.AppWorkspace;
            CmbGenero.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbGenero.FormattingEnabled = true;
            CmbGenero.Items.AddRange(new object[] { "MASCULINO", "FEMININO" });
            CmbGenero.Location = new Point(242, 296);
            CmbGenero.Name = "CmbGenero";
            CmbGenero.Size = new Size(229, 31);
            CmbGenero.TabIndex = 3;
            CmbGenero.Text = "Genero";
            CmbGenero.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(303, 43);
            label4.Name = "label4";
            label4.Size = new Size(302, 33);
            label4.TabIndex = 7;
            label4.Text = "GUARDAR CONTACTO";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 450);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(650, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // CmbParentesco
            // 
            CmbParentesco.BackColor = SystemColors.AppWorkspace;
            CmbParentesco.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbParentesco.FormattingEnabled = true;
            CmbParentesco.Items.AddRange(new object[] { "AMIGO(A)", "FAMILIA", "TRABALHO", "UNIVERSIDADE", "OUTROS" });
            CmbParentesco.Location = new Point(242, 242);
            CmbParentesco.Name = "CmbParentesco";
            CmbParentesco.Size = new Size(229, 31);
            CmbParentesco.TabIndex = 10;
            CmbParentesco.Text = "Parentesco";
            // 
            // FormAgenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(694, 450);
            Controls.Add(CmbParentesco);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(CmbGenero);
            Controls.Add(txbNumero);
            Controls.Add(txbNome);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgenda";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgenda";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txbNome;
        private TextBox txbNumero;
        private ComboBox CmbGenero;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox CmbParentesco;
    }
}
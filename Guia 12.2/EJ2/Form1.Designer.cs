namespace EJ2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GBdatosIngreso = new GroupBox();
            TBmodelo = new TextBox();
            CBXtipo = new ComboBox();
            TBpatente = new TextBox();
            CBelectrico = new CheckBox();
            BTNregistrar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BTNestadistica = new Button();
            GBdatosIngreso.SuspendLayout();
            SuspendLayout();
            // 
            // GBdatosIngreso
            // 
            GBdatosIngreso.Controls.Add(TBmodelo);
            GBdatosIngreso.Controls.Add(CBXtipo);
            GBdatosIngreso.Controls.Add(TBpatente);
            GBdatosIngreso.Controls.Add(CBelectrico);
            GBdatosIngreso.Controls.Add(BTNregistrar);
            GBdatosIngreso.Controls.Add(label3);
            GBdatosIngreso.Controls.Add(label2);
            GBdatosIngreso.Controls.Add(label1);
            GBdatosIngreso.Location = new Point(12, 12);
            GBdatosIngreso.Name = "GBdatosIngreso";
            GBdatosIngreso.Size = new Size(326, 255);
            GBdatosIngreso.TabIndex = 0;
            GBdatosIngreso.TabStop = false;
            GBdatosIngreso.Text = "a";
            // 
            // TBmodelo
            // 
            TBmodelo.Location = new Point(130, 110);
            TBmodelo.Name = "TBmodelo";
            TBmodelo.Size = new Size(190, 27);
            TBmodelo.TabIndex = 8;
            // 
            // CBXtipo
            // 
            CBXtipo.FormattingEnabled = true;
            CBXtipo.Items.AddRange(new object[] { "Automovil", "Motocicleta", "Camión ", "Camioneta" });
            CBXtipo.Location = new Point(130, 76);
            CBXtipo.Name = "CBXtipo";
            CBXtipo.Size = new Size(190, 28);
            CBXtipo.TabIndex = 7;
            // 
            // TBpatente
            // 
            TBpatente.Location = new Point(130, 43);
            TBpatente.Name = "TBpatente";
            TBpatente.Size = new Size(190, 27);
            TBpatente.TabIndex = 6;
            // 
            // CBelectrico
            // 
            CBelectrico.AutoSize = true;
            CBelectrico.Location = new Point(196, 143);
            CBelectrico.Name = "CBelectrico";
            CBelectrico.Size = new Size(124, 24);
            CBelectrico.TabIndex = 5;
            CBelectrico.Text = "¿Es electrico ?";
            CBelectrico.UseVisualStyleBackColor = true;
            // 
            // BTNregistrar
            // 
            BTNregistrar.Location = new Point(85, 185);
            BTNregistrar.Name = "BTNregistrar";
            BTNregistrar.Size = new Size(133, 44);
            BTNregistrar.TabIndex = 4;
            BTNregistrar.Text = "Registrar";
            BTNregistrar.UseVisualStyleBackColor = true;
            BTNregistrar.Click += BTNregistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 113);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Modelo (Año)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 79);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de vehiculo ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 46);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Patente";
            // 
            // BTNestadistica
            // 
            BTNestadistica.Location = new Point(344, 46);
            BTNestadistica.Name = "BTNestadistica";
            BTNestadistica.Size = new Size(123, 67);
            BTNestadistica.TabIndex = 1;
            BTNestadistica.Text = "Ver estadistica";
            BTNestadistica.UseVisualStyleBackColor = true;
            BTNestadistica.Click += BTNestadistica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 274);
            Controls.Add(BTNestadistica);
            Controls.Add(GBdatosIngreso);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            GBdatosIngreso.ResumeLayout(false);
            GBdatosIngreso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GBdatosIngreso;
        private Button BTNregistrar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BTNestadistica;
        private TextBox TBmodelo;
        private ComboBox CBXtipo;
        private TextBox TBpatente;
        private CheckBox CBelectrico;
    }
}

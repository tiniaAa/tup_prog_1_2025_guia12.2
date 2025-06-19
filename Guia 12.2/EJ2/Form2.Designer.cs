namespace EJ2
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            LBresultados = new ListBox();
            BTNcancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LBresultados);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 229);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            // 
            // LBresultados
            // 
            LBresultados.FormattingEnabled = true;
            LBresultados.Location = new Point(22, 42);
            LBresultados.Name = "LBresultados";
            LBresultados.Size = new Size(282, 164);
            LBresultados.TabIndex = 0;
            // 
            // BTNcancelar
            // 
            BTNcancelar.DialogResult = DialogResult.Cancel;
            BTNcancelar.Location = new Point(107, 247);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(122, 54);
            BTNcancelar.TabIndex = 1;
            BTNcancelar.Text = "Cancelar";
            BTNcancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 319);
            Controls.Add(BTNcancelar);
            Controls.Add(groupBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BTNcancelar;
        public ListBox LBresultados;
    }
}
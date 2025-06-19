namespace Ej1
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
            BTNagregarComp = new Button();
            BTNcargarTiempo = new Button();
            BTNresultados = new Button();
            SuspendLayout();
            // 
            // BTNagregarComp
            // 
            BTNagregarComp.Location = new Point(12, 12);
            BTNagregarComp.Name = "BTNagregarComp";
            BTNagregarComp.Size = new Size(286, 58);
            BTNagregarComp.TabIndex = 0;
            BTNagregarComp.Text = "Agregar competidor";
            BTNagregarComp.UseVisualStyleBackColor = true;
            BTNagregarComp.Click += BTNagregarComp_Click;
            // 
            // BTNcargarTiempo
            // 
            BTNcargarTiempo.Location = new Point(12, 106);
            BTNcargarTiempo.Name = "BTNcargarTiempo";
            BTNcargarTiempo.Size = new Size(286, 58);
            BTNcargarTiempo.TabIndex = 1;
            BTNcargarTiempo.Text = "Cargar tiempo de Competidores";
            BTNcargarTiempo.UseVisualStyleBackColor = true;
            BTNcargarTiempo.Click += BTNcargarTiempo_Click;
            // 
            // BTNresultados
            // 
            BTNresultados.Location = new Point(12, 199);
            BTNresultados.Name = "BTNresultados";
            BTNresultados.Size = new Size(286, 58);
            BTNresultados.TabIndex = 2;
            BTNresultados.Text = "Resultados";
            BTNresultados.UseVisualStyleBackColor = true;
            BTNresultados.Click += BTNresultados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 280);
            Controls.Add(BTNresultados);
            Controls.Add(BTNcargarTiempo);
            Controls.Add(BTNagregarComp);
            Name = "Form1";
            Text = "Ejercicio 1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BTNagregarComp;
        private Button BTNcargarTiempo;
        private Button BTNresultados;
    }
}

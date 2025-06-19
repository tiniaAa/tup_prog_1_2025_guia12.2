namespace Ej1
{
    partial class Form4
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
            LBXresultados = new ListBox();
            Cerrar = new Button();
            SuspendLayout();
            // 
            // LBXresultados
            // 
            LBXresultados.FormattingEnabled = true;
            LBXresultados.Location = new Point(12, 12);
            LBXresultados.Name = "LBXresultados";
            LBXresultados.Size = new Size(267, 104);
            LBXresultados.TabIndex = 0;
            // 
            // Cerrar
            // 
            Cerrar.DialogResult = DialogResult.Cancel;
            Cerrar.Location = new Point(79, 122);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(122, 61);
            Cerrar.TabIndex = 1;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 194);
            Controls.Add(Cerrar);
            Controls.Add(LBXresultados);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        public ListBox LBXresultados;
        private Button Cerrar;
    }
}
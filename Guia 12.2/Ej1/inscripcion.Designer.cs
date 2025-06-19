namespace Ej1
{
    partial class inscripcion
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
            label1 = new Label();
            TBnombre = new TextBox();
            BTNagregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(107, 25);
            TBnombre.Name = "TBnombre";
            TBnombre.Size = new Size(125, 27);
            TBnombre.TabIndex = 1;
            // 
            // BTNagregar
            // 
            BTNagregar.DialogResult = DialogResult.OK;
            BTNagregar.Location = new Point(32, 67);
            BTNagregar.Name = "BTNagregar";
            BTNagregar.Size = new Size(200, 29);
            BTNagregar.TabIndex = 2;
            BTNagregar.Text = "Agregar";
            BTNagregar.UseVisualStyleBackColor = true;
            // 
            // inscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 113);
            Controls.Add(BTNagregar);
            Controls.Add(TBnombre);
            Controls.Add(label1);
            Name = "inscripcion";
            Text = "inscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox TBnombre;
        private Button BTNagregar;
    }
}
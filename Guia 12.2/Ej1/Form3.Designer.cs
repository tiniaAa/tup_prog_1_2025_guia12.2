namespace Ej1
{
    partial class Form3
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
            label2 = new Label();
            LBnumeroComp = new Label();
            TBhoras = new TextBox();
            TBminutos = new TextBox();
            BTNagregar = new Button();
            label3 = new Label();
            LBnombreComp = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 59);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Tiempo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 21);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de competidor ";
            // 
            // LBnumeroComp
            // 
            LBnumeroComp.AutoSize = true;
            LBnumeroComp.Location = new Point(240, 21);
            LBnumeroComp.Name = "LBnumeroComp";
            LBnumeroComp.Size = new Size(0, 20);
            LBnumeroComp.TabIndex = 2;
            // 
            // TBhoras
            // 
            TBhoras.Location = new Point(119, 56);
            TBhoras.Name = "TBhoras";
            TBhoras.Size = new Size(33, 27);
            TBhoras.TabIndex = 3;
            // 
            // TBminutos
            // 
            TBminutos.Location = new Point(158, 56);
            TBminutos.Name = "TBminutos";
            TBminutos.Size = new Size(33, 27);
            TBminutos.TabIndex = 4;
            // 
            // BTNagregar
            // 
            BTNagregar.DialogResult = DialogResult.OK;
            BTNagregar.Location = new Point(58, 89);
            BTNagregar.Name = "BTNagregar";
            BTNagregar.Size = new Size(182, 52);
            BTNagregar.TabIndex = 5;
            BTNagregar.Text = "Agregar";
            BTNagregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 59);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // LBnombreComp
            // 
            LBnombreComp.AutoSize = true;
            LBnombreComp.Location = new Point(187, 21);
            LBnombreComp.Name = "LBnombreComp";
            LBnombreComp.Size = new Size(0, 20);
            LBnombreComp.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 156);
            Controls.Add(LBnombreComp);
            Controls.Add(label3);
            Controls.Add(BTNagregar);
            Controls.Add(TBminutos);
            Controls.Add(TBhoras);
            Controls.Add(LBnumeroComp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BTNagregar;
        private Label label3;
        public TextBox TBhoras;
        public TextBox TBminutos;
        public Label LBnumeroComp;
        public Label LBnombreComp;
    }
}
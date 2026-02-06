namespace Calculadora
{
    partial class frmBurbuja
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
            dgvDesardenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvOrdenado = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDesardenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgvDesardenado
            // 
            dgvDesardenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesardenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvDesardenado.Location = new Point(78, 79);
            dgvDesardenado.Name = "dgvDesardenado";
            dgvDesardenado.RowHeadersWidth = 51;
            dgvDesardenado.Size = new Size(177, 316);
            dgvDesardenado.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dgvOrdenado
            // 
            dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            dgvOrdenado.Location = new Point(289, 79);
            dgvOrdenado.Name = "dgvOrdenado";
            dgvOrdenado.RowHeadersWidth = 51;
            dgvOrdenado.Size = new Size(179, 316);
            dgvOrdenado.TabIndex = 1;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ordenado";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(87, 24);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 29);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // frmBurbuja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenado);
            Controls.Add(dgvDesardenado);
            Name = "frmBurbuja";
            Text = "Ordenamiento Burbuja";
            ((System.ComponentModel.ISupportInitialize)dgvDesardenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDesardenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvOrdenado;
        private DataGridViewTextBoxColumn Column2;
        private Button btnOrdenar;
    }
}
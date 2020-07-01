namespace GarageProject
{
    partial class Eigenaar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cboMaand = new System.Windows.Forms.ComboBox();
            this.dgEigenaar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licence_plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOmzetPerMaand = new System.Windows.Forms.Label();
            this.btnZoekenOpMaand = new System.Windows.Forms.Button();
            this.lblTotaleMaandOmzet = new System.Windows.Forms.Label();
            this.chartEigenaar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgEigenaar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEigenaar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaand
            // 
            this.cboMaand.FormattingEnabled = true;
            this.cboMaand.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maart",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Augustus",
            "September",
            "Oktober",
            "November",
            "December"});
            this.cboMaand.Location = new System.Drawing.Point(163, 41);
            this.cboMaand.Name = "cboMaand";
            this.cboMaand.Size = new System.Drawing.Size(219, 21);
            this.cboMaand.TabIndex = 0;
            // 
            // dgEigenaar
            // 
            this.dgEigenaar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEigenaar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.licence_plate,
            this.created_at,
            this.total_price});
            this.dgEigenaar.Location = new System.Drawing.Point(59, 83);
            this.dgEigenaar.Name = "dgEigenaar";
            this.dgEigenaar.Size = new System.Drawing.Size(494, 141);
            this.dgEigenaar.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // licence_plate
            // 
            this.licence_plate.HeaderText = "Nummerplaat";
            this.licence_plate.Name = "licence_plate";
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Reparatiedatum";
            this.created_at.Name = "created_at";
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Omzet";
            this.total_price.Name = "total_price";
            // 
            // lblOmzetPerMaand
            // 
            this.lblOmzetPerMaand.AutoSize = true;
            this.lblOmzetPerMaand.Location = new System.Drawing.Point(59, 43);
            this.lblOmzetPerMaand.Name = "lblOmzetPerMaand";
            this.lblOmzetPerMaand.Size = new System.Drawing.Size(90, 13);
            this.lblOmzetPerMaand.TabIndex = 2;
            this.lblOmzetPerMaand.Text = "Omzet per maand";
            // 
            // btnZoekenOpMaand
            // 
            this.btnZoekenOpMaand.Location = new System.Drawing.Point(408, 32);
            this.btnZoekenOpMaand.Name = "btnZoekenOpMaand";
            this.btnZoekenOpMaand.Size = new System.Drawing.Size(122, 37);
            this.btnZoekenOpMaand.TabIndex = 3;
            this.btnZoekenOpMaand.Text = "Zoeken op Maand";
            this.btnZoekenOpMaand.UseVisualStyleBackColor = true;
            this.btnZoekenOpMaand.Click += new System.EventHandler(this.btnZoekenOpMaand_Click);
            // 
            // lblTotaleMaandOmzet
            // 
            this.lblTotaleMaandOmzet.AutoSize = true;
            this.lblTotaleMaandOmzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaleMaandOmzet.Location = new System.Drawing.Point(59, 247);
            this.lblTotaleMaandOmzet.Name = "lblTotaleMaandOmzet";
            this.lblTotaleMaandOmzet.Size = new System.Drawing.Size(0, 20);
            this.lblTotaleMaandOmzet.TabIndex = 4;
            // 
            // chartEigenaar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEigenaar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEigenaar.Legends.Add(legend1);
            this.chartEigenaar.Location = new System.Drawing.Point(57, 313);
            this.chartEigenaar.Name = "chartEigenaar";
            this.chartEigenaar.Size = new System.Drawing.Size(543, 235);
            this.chartEigenaar.TabIndex = 5;
            this.chartEigenaar.Text = "chart1";
            // 
            // Eigenaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.chartEigenaar);
            this.Controls.Add(this.lblTotaleMaandOmzet);
            this.Controls.Add(this.btnZoekenOpMaand);
            this.Controls.Add(this.lblOmzetPerMaand);
            this.Controls.Add(this.dgEigenaar);
            this.Controls.Add(this.cboMaand);
            this.Name = "Eigenaar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eigenaar";
            this.Load += new System.EventHandler(this.Eigenaar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEigenaar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEigenaar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaand;
        private System.Windows.Forms.DataGridView dgEigenaar;
        private System.Windows.Forms.Label lblOmzetPerMaand;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn licence_plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.Button btnZoekenOpMaand;
        private System.Windows.Forms.Label lblTotaleMaandOmzet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEigenaar;
    }
}
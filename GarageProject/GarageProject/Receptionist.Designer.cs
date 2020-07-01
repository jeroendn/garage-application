namespace GarageProject
{
    partial class Receptionist
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
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpPlanningDag = new System.Windows.Forms.DateTimePicker();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnToonAlles = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.tbxOpmerking = new System.Windows.Forms.TextBox();
            this.lblOpmerking = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.cboMonteur = new System.Windows.Forms.ComboBox();
            this.lblMonteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAgenda
            // 
            this.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.comment,
            this.license_plate,
            this.hours,
            this.total_price,
            this.created_at,
            this.status,
            this.firstname,
            this.lastname});
            this.dgAgenda.Location = new System.Drawing.Point(22, 75);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAgenda.Size = new System.Drawing.Size(1058, 359);
            this.dgAgenda.TabIndex = 0;
            this.dgAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAgenda_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // comment
            // 
            this.comment.HeaderText = "comment";
            this.comment.Name = "comment";
            // 
            // license_plate
            // 
            this.license_plate.HeaderText = "license_plate";
            this.license_plate.Name = "license_plate";
            // 
            // hours
            // 
            this.hours.HeaderText = "hours";
            this.hours.Name = "hours";
            // 
            // total_price
            // 
            this.total_price.HeaderText = "total_price";
            this.total_price.Name = "total_price";
            // 
            // created_at
            // 
            this.created_at.HeaderText = "created_on";
            this.created_at.Name = "created_at";
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "firstname";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "lastname";
            this.lastname.Name = "lastname";
            // 
            // dtpPlanningDag
            // 
            this.dtpPlanningDag.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtpPlanningDag.Location = new System.Drawing.Point(91, 25);
            this.dtpPlanningDag.Name = "dtpPlanningDag";
            this.dtpPlanningDag.Size = new System.Drawing.Size(183, 20);
            this.dtpPlanningDag.TabIndex = 1;
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(280, 22);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(110, 31);
            this.btnZoeken.TabIndex = 2;
            this.btnZoeken.Text = "Zoeken per dag";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnToonAlles
            // 
            this.btnToonAlles.Location = new System.Drawing.Point(396, 22);
            this.btnToonAlles.Name = "btnToonAlles";
            this.btnToonAlles.Size = new System.Drawing.Size(110, 31);
            this.btnToonAlles.TabIndex = 3;
            this.btnToonAlles.Text = "Toon alles";
            this.btnToonAlles.UseVisualStyleBackColor = true;
            this.btnToonAlles.Click += new System.EventHandler(this.btnToonAlles_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 469);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(74, 466);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(259, 21);
            this.cboStatus.TabIndex = 5;
            // 
            // tbxOpmerking
            // 
            this.tbxOpmerking.Location = new System.Drawing.Point(74, 493);
            this.tbxOpmerking.Multiline = true;
            this.tbxOpmerking.Name = "tbxOpmerking";
            this.tbxOpmerking.Size = new System.Drawing.Size(1006, 93);
            this.tbxOpmerking.TabIndex = 6;
            // 
            // lblOpmerking
            // 
            this.lblOpmerking.AutoSize = true;
            this.lblOpmerking.Location = new System.Drawing.Point(12, 496);
            this.lblOpmerking.Name = "lblOpmerking";
            this.lblOpmerking.Size = new System.Drawing.Size(61, 13);
            this.lblOpmerking.TabIndex = 7;
            this.lblOpmerking.Text = "Opmerking:";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(74, 592);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(113, 25);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // cboMonteur
            // 
            this.cboMonteur.FormattingEnabled = true;
            this.cboMonteur.Location = new System.Drawing.Point(74, 440);
            this.cboMonteur.Name = "cboMonteur";
            this.cboMonteur.Size = new System.Drawing.Size(259, 21);
            this.cboMonteur.TabIndex = 9;
            this.cboMonteur.Tag = "rtertert";
            // 
            // lblMonteur
            // 
            this.lblMonteur.AutoSize = true;
            this.lblMonteur.Location = new System.Drawing.Point(24, 443);
            this.lblMonteur.Name = "lblMonteur";
            this.lblMonteur.Size = new System.Drawing.Size(49, 13);
            this.lblMonteur.TabIndex = 10;
            this.lblMonteur.Text = "Monteur:";
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 648);
            this.Controls.Add(this.lblMonteur);
            this.Controls.Add(this.cboMonteur);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lblOpmerking);
            this.Controls.Add(this.tbxOpmerking);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnToonAlles);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.dtpPlanningDag);
            this.Controls.Add(this.dgAgenda);
            this.Name = "Receptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAgenda;
        private System.Windows.Forms.DateTimePicker dtpPlanningDag;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Button btnToonAlles;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox tbxOpmerking;
        private System.Windows.Forms.Label lblOpmerking;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.ComboBox cboMonteur;
        private System.Windows.Forms.Label lblMonteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
    }
}
namespace GarageProject
{
    partial class Monteur
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
            this.dgMonteur = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licence_plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboOnderdeel = new System.Windows.Forms.ComboBox();
            this.lblOnderdeel = new System.Windows.Forms.Label();
            this.btnOnderdeelToevoegen = new System.Windows.Forms.Button();
            this.dgOnderdelen = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPlanning = new System.Windows.Forms.Label();
            this.cboMonteur = new System.Windows.Forms.ComboBox();
            this.lblMonteur = new System.Windows.Forms.Label();
            this.cboWerkplaatsStatus = new System.Windows.Forms.ComboBox();
            this.tbxOpmerking = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnderdelen = new System.Windows.Forms.Label();
            this.dtpPlanningDag = new System.Windows.Forms.DateTimePicker();
            this.btnToonAlles = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.tbxAantal = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnOnderdeelverwijderen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOnderdelen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMonteur
            // 
            this.dgMonteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.created_at,
            this.Status,
            this.licence_plate,
            this.comment,
            this.firstname,
            this.lastname});
            this.dgMonteur.Location = new System.Drawing.Point(18, 224);
            this.dgMonteur.Name = "dgMonteur";
            this.dgMonteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMonteur.Size = new System.Drawing.Size(767, 191);
            this.dgMonteur.TabIndex = 0;
            this.dgMonteur.SelectionChanged += new System.EventHandler(this.dgMonteur_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Planningsdatum";
            this.created_at.Name = "created_at";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // licence_plate
            // 
            this.licence_plate.HeaderText = "Nummerplaat";
            this.licence_plate.Name = "licence_plate";
            // 
            // comment
            // 
            this.comment.HeaderText = "Kommentaar";
            this.comment.Name = "comment";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Voornaam";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Achternaam Monteur";
            this.lastname.Name = "lastname";
            // 
            // cboOnderdeel
            // 
            this.cboOnderdeel.FormattingEnabled = true;
            this.cboOnderdeel.Location = new System.Drawing.Point(129, 421);
            this.cboOnderdeel.Name = "cboOnderdeel";
            this.cboOnderdeel.Size = new System.Drawing.Size(372, 21);
            this.cboOnderdeel.TabIndex = 1;
            // 
            // lblOnderdeel
            // 
            this.lblOnderdeel.AutoSize = true;
            this.lblOnderdeel.Location = new System.Drawing.Point(15, 424);
            this.lblOnderdeel.Name = "lblOnderdeel";
            this.lblOnderdeel.Size = new System.Drawing.Size(113, 13);
            this.lblOnderdeel.TabIndex = 2;
            this.lblOnderdeel.Text = "Onderdeel toevoegen:";
            // 
            // btnOnderdeelToevoegen
            // 
            this.btnOnderdeelToevoegen.Location = new System.Drawing.Point(129, 476);
            this.btnOnderdeelToevoegen.Name = "btnOnderdeelToevoegen";
            this.btnOnderdeelToevoegen.Size = new System.Drawing.Size(145, 34);
            this.btnOnderdeelToevoegen.TabIndex = 3;
            this.btnOnderdeelToevoegen.Text = "Onderdeel Toevoegen";
            this.btnOnderdeelToevoegen.UseVisualStyleBackColor = true;
            this.btnOnderdeelToevoegen.Click += new System.EventHandler(this.btnOnderdeelToevoegen_Click);
            // 
            // dgOnderdelen
            // 
            this.dgOnderdelen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOnderdelen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.name,
            this.price,
            this.amount});
            this.dgOnderdelen.Location = new System.Drawing.Point(12, 525);
            this.dgOnderdelen.Name = "dgOnderdelen";
            this.dgOnderdelen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOnderdelen.Size = new System.Drawing.Size(576, 105);
            this.dgOnderdelen.TabIndex = 4;
            this.dgOnderdelen.SelectionChanged += new System.EventHandler(this.dgOnderdelen_SelectionChanged);
            // 
            // PartID
            // 
            this.PartID.HeaderText = "ID";
            this.PartID.Name = "PartID";
            // 
            // name
            // 
            this.name.HeaderText = "Product";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "Prijs";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "Aantal";
            this.amount.Name = "amount";
            // 
            // lblPlanning
            // 
            this.lblPlanning.AutoSize = true;
            this.lblPlanning.Location = new System.Drawing.Point(19, 208);
            this.lblPlanning.Name = "lblPlanning";
            this.lblPlanning.Size = new System.Drawing.Size(51, 13);
            this.lblPlanning.TabIndex = 5;
            this.lblPlanning.Text = "Planning:";
            // 
            // cboMonteur
            // 
            this.cboMonteur.FormattingEnabled = true;
            this.cboMonteur.Location = new System.Drawing.Point(18, 82);
            this.cboMonteur.Name = "cboMonteur";
            this.cboMonteur.Size = new System.Drawing.Size(158, 21);
            this.cboMonteur.TabIndex = 7;
            // 
            // lblMonteur
            // 
            this.lblMonteur.AutoSize = true;
            this.lblMonteur.Location = new System.Drawing.Point(15, 68);
            this.lblMonteur.Name = "lblMonteur";
            this.lblMonteur.Size = new System.Drawing.Size(46, 13);
            this.lblMonteur.TabIndex = 8;
            this.lblMonteur.Text = "Monteur";
            // 
            // cboWerkplaatsStatus
            // 
            this.cboWerkplaatsStatus.FormattingEnabled = true;
            this.cboWerkplaatsStatus.Location = new System.Drawing.Point(471, 34);
            this.cboWerkplaatsStatus.Name = "cboWerkplaatsStatus";
            this.cboWerkplaatsStatus.Size = new System.Drawing.Size(151, 21);
            this.cboWerkplaatsStatus.TabIndex = 9;
            // 
            // tbxOpmerking
            // 
            this.tbxOpmerking.Location = new System.Drawing.Point(471, 87);
            this.tbxOpmerking.Multiline = true;
            this.tbxOpmerking.Name = "tbxOpmerking";
            this.tbxOpmerking.Size = new System.Drawing.Size(317, 119);
            this.tbxOpmerking.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(468, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Opmerking:";
            // 
            // lblOnderdelen
            // 
            this.lblOnderdelen.AutoSize = true;
            this.lblOnderdelen.Location = new System.Drawing.Point(19, 509);
            this.lblOnderdelen.Name = "lblOnderdelen";
            this.lblOnderdelen.Size = new System.Drawing.Size(65, 13);
            this.lblOnderdelen.TabIndex = 14;
            this.lblOnderdelen.Text = "Onderdelen:";
            // 
            // dtpPlanningDag
            // 
            this.dtpPlanningDag.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtpPlanningDag.Location = new System.Drawing.Point(18, 45);
            this.dtpPlanningDag.Name = "dtpPlanningDag";
            this.dtpPlanningDag.Size = new System.Drawing.Size(114, 20);
            this.dtpPlanningDag.TabIndex = 15;
            // 
            // btnToonAlles
            // 
            this.btnToonAlles.Location = new System.Drawing.Point(305, 34);
            this.btnToonAlles.Name = "btnToonAlles";
            this.btnToonAlles.Size = new System.Drawing.Size(110, 31);
            this.btnToonAlles.TabIndex = 17;
            this.btnToonAlles.Text = "Toon alles";
            this.btnToonAlles.UseVisualStyleBackColor = true;
            this.btnToonAlles.Click += new System.EventHandler(this.btnToonAlles_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(187, 34);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(110, 31);
            this.btnZoeken.TabIndex = 16;
            this.btnZoeken.Text = "Zoeken per dag";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Planning:";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(15, 453);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(40, 13);
            this.lblAantal.TabIndex = 20;
            this.lblAantal.Text = "Aantal:";
            // 
            // tbxAantal
            // 
            this.tbxAantal.Location = new System.Drawing.Point(129, 450);
            this.tbxAantal.Name = "tbxAantal";
            this.tbxAantal.Size = new System.Drawing.Size(135, 20);
            this.tbxAantal.TabIndex = 21;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(814, 170);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(146, 36);
            this.btnOpslaan.TabIndex = 13;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnOnderdeelverwijderen
            // 
            this.btnOnderdeelverwijderen.Location = new System.Drawing.Point(296, 476);
            this.btnOnderdeelverwijderen.Name = "btnOnderdeelverwijderen";
            this.btnOnderdeelverwijderen.Size = new System.Drawing.Size(145, 34);
            this.btnOnderdeelverwijderen.TabIndex = 22;
            this.btnOnderdeelverwijderen.Text = "Onderdeel Verwijderen";
            this.btnOnderdeelverwijderen.UseVisualStyleBackColor = true;
            this.btnOnderdeelverwijderen.Click += new System.EventHandler(this.btnOnderdeelverwijderen_Click);
            // 
            // Monteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 730);
            this.Controls.Add(this.btnOnderdeelverwijderen);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.tbxAantal);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnToonAlles);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.dtpPlanningDag);
            this.Controls.Add(this.lblOnderdelen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxOpmerking);
            this.Controls.Add(this.cboWerkplaatsStatus);
            this.Controls.Add(this.lblMonteur);
            this.Controls.Add(this.cboMonteur);
            this.Controls.Add(this.lblPlanning);
            this.Controls.Add(this.dgOnderdelen);
            this.Controls.Add(this.btnOnderdeelToevoegen);
            this.Controls.Add(this.lblOnderdeel);
            this.Controls.Add(this.cboOnderdeel);
            this.Controls.Add(this.dgMonteur);
            this.Name = "Monteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monteur";
            this.Load += new System.EventHandler(this.Monteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMonteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOnderdelen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMonteur;
        private System.Windows.Forms.ComboBox cboOnderdeel;
        private System.Windows.Forms.Label lblOnderdeel;
        private System.Windows.Forms.Button btnOnderdeelToevoegen;
        private System.Windows.Forms.DataGridView dgOnderdelen;
        private System.Windows.Forms.Label lblPlanning;
        private System.Windows.Forms.ComboBox cboMonteur;
        private System.Windows.Forms.Label lblMonteur;
        private System.Windows.Forms.ComboBox cboWerkplaatsStatus;
        private System.Windows.Forms.TextBox tbxOpmerking;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnderdelen;
        private System.Windows.Forms.DateTimePicker dtpPlanningDag;
        private System.Windows.Forms.Button btnToonAlles;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn licence_plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox tbxAantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnOnderdeelverwijderen;
    }
}
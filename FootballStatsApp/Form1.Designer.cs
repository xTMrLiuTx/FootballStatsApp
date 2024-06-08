namespace FootballStatsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamCountry = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.txtHomeTeam = new System.Windows.Forms.TextBox();
            this.txtAwayTeam = new System.Windows.Forms.TextBox();
            this.txtHomeGoals = new System.Windows.Forms.TextBox();
            this.txtAwayGoals = new System.Windows.Forms.TextBox();
            this.txtStadium = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamCountry = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeGoals = new System.Windows.Forms.Label();
            this.lblAwayGoals = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewTeams.TabIndex = 0;
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatches.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewMatches.TabIndex = 1;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(500, 20);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 2;
            // 
            // txtTeamCountry
            // 
            this.txtTeamCountry.Location = new System.Drawing.Point(500, 50);
            this.txtTeamCountry.Name = "txtTeamCountry";
            this.txtTeamCountry.Size = new System.Drawing.Size(100, 20);
            this.txtTeamCountry.TabIndex = 3;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(500, 80);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(100, 23);
            this.btnAddTeam.TabIndex = 4;
            this.btnAddTeam.Text = "Agregar Equipo";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Location = new System.Drawing.Point(500, 110);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(100, 23);
            this.btnEditTeam.TabIndex = 5;
            this.btnEditTeam.Text = "Editar Equipo";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(500, 140);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteTeam.TabIndex = 6;
            this.btnDeleteTeam.Text = "Eliminar Equipo";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // txtHomeTeam
            // 
            this.txtHomeTeam.Location = new System.Drawing.Point(500, 220);
            this.txtHomeTeam.Name = "txtHomeTeam";
            this.txtHomeTeam.Size = new System.Drawing.Size(100, 20);
            this.txtHomeTeam.TabIndex = 7;
            // 
            // txtAwayTeam
            // 
            this.txtAwayTeam.Location = new System.Drawing.Point(500, 250);
            this.txtAwayTeam.Name = "txtAwayTeam";
            this.txtAwayTeam.Size = new System.Drawing.Size(100, 20);
            this.txtAwayTeam.TabIndex = 8;
            // 
            // txtHomeGoals
            // 
            this.txtHomeGoals.Location = new System.Drawing.Point(500, 280);
            this.txtHomeGoals.Name = "txtHomeGoals";
            this.txtHomeGoals.Size = new System.Drawing.Size(100, 20);
            this.txtHomeGoals.TabIndex = 9;
            // 
            // txtAwayGoals
            // 
            this.txtAwayGoals.Location = new System.Drawing.Point(500, 310);
            this.txtAwayGoals.Name = "txtAwayGoals";
            this.txtAwayGoals.Size = new System.Drawing.Size(100, 20);
            this.txtAwayGoals.TabIndex = 10;
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(500, 340);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(100, 20);
            this.txtStadium.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(500, 370);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 12;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(500, 400);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(100, 23);
            this.btnAddMatch.TabIndex = 13;
            this.btnAddMatch.Text = "Agregar Partido";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.Location = new System.Drawing.Point(500, 430);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(100, 23);
            this.btnEditMatch.TabIndex = 14;
            this.btnEditMatch.Text = "Editar Partido";
            this.btnEditMatch.UseVisualStyleBackColor = true;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Location = new System.Drawing.Point(500, 460);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteMatch.TabIndex = 15;
            this.btnDeleteMatch.Text = "Eliminar Partido";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(420, 20);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(44, 13);
            this.lblTeamName.TabIndex = 16;
            this.lblTeamName.Text = "Nombre";
            // 
            // lblTeamCountry
            // 
            this.lblTeamCountry.AutoSize = true;
            this.lblTeamCountry.Location = new System.Drawing.Point(420, 50);
            this.lblTeamCountry.Name = "lblTeamCountry";
            this.lblTeamCountry.Size = new System.Drawing.Size(27, 13);
            this.lblTeamCountry.TabIndex = 17;
            this.lblTeamCountry.Text = "País";
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(420, 220);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(71, 13);
            this.lblHomeTeam.TabIndex = 18;
            this.lblHomeTeam.Text = "Equipo Local";
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Location = new System.Drawing.Point(420, 250);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(66, 13);
            this.lblAwayTeam.TabIndex = 19;
            this.lblAwayTeam.Text = "Equipo Visitante";
            // 
            // lblHomeGoals
            // 
            this.lblHomeGoals.AutoSize = true;
            this.lblHomeGoals.Location = new System.Drawing.Point(420, 280);
            this.lblHomeGoals.Name = "lblHomeGoals";
            this.lblHomeGoals.Size = new System.Drawing.Size(35, 13);
            this.lblHomeGoals.TabIndex = 20;
            this.lblHomeGoals.Text = "Goles Local";
            // 
            // lblAwayGoals
            // 
            this.lblAwayGoals.AutoSize = true;
            this.lblAwayGoals.Location = new System.Drawing.Point(420, 310);
            this.lblAwayGoals.Name = "lblAwayGoals";
            this.lblAwayGoals.Size = new System.Drawing.Size(30, 13);
            this.lblAwayGoals.TabIndex = 21;
            this.lblAwayGoals.Text = "Goles Visitante";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(420, 340);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(42, 13);
            this.lblStadium.TabIndex = 22;
            this.lblStadium.Text = "Estadio";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(420, 370);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Fecha";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(624, 501);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblAwayGoals);
            this.Controls.Add(this.lblHomeGoals);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblTeamCountry);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.btnDeleteMatch);
            this.Controls.Add(this.btnEditMatch);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtStadium);
            this.Controls.Add(this.txtAwayGoals);
            this.Controls.Add(this.txtHomeGoals);
            this.Controls.Add(this.txtAwayTeam);
            this.Controls.Add(this.txtHomeTeam);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.txtTeamCountry);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.dataGridViewMatches);
            this.Controls.Add(this.dataGridViewTeams);
            this.Name = "Form1";
            this.Text = "Football Stats App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewTeams;
        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamCountry;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.TextBox txtHomeTeam;
        private System.Windows.Forms.TextBox txtAwayTeam;
        private System.Windows.Forms.TextBox txtHomeGoals;
        private System.Windows.Forms.TextBox txtAwayGoals;
        private System.Windows.Forms.TextBox txtStadium;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamCountry;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeGoals;
        private System.Windows.Forms.Label lblAwayGoals;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblDate;
    }
}

using System;
using System.Windows.Forms;
using FootballStatsApp;

namespace FootballStatsApp
{
    public partial class Form1 : Form
    {
        private DataManager dataManager;

        public Form1()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos desde archivos de texto
            dataManager.LoadData("teams.txt", "players.txt", "matchStats.txt");

            // Mostrar los equipos en el DataGridView
            dataGridViewTeams.DataSource = dataManager.GetTeams();

            // Mostrar los partidos en el DataGridView
            dataGridViewMatches.DataSource = dataManager.GetMatches();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            // Crear un nuevo equipo con los datos ingresados en los controles
            Team newTeam = new Team
            {
                Name = txtTeamName.Text,
                Country = txtTeamCountry.Text
                // Agregar otros datos según sea necesario
            };

            // Agregar el nuevo equipo usando el DataManager
            dataManager.AddTeam(newTeam);

            // Actualizar la visualización en el DataGridView
            dataGridViewTeams.DataSource = dataManager.GetTeams();

            // Limpiar los controles después de agregar el equipo
            ClearTeamControls();
        }

        private void ClearTeamControls()
        {
            txtTeamName.Text = "";
            txtTeamCountry.Text = "";
            // Limpiar otros controles según sea necesario
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            string selectedTeamName = dataGridViewTeams.CurrentRow.Cells[0].Value.ToString();

            Team updatedTeam = new()
            {
                Name = txtTeamName.Text,
                Country = txtTeamCountry.Text
                // Agregar otros datos según sea necesario
            };

            dataManager.EditTeam(selectedTeamName, updatedTeam);

            dataGridViewTeams.DataSource = dataManager.GetTeams();

            ClearTeamControls();
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada en el DataGridView
            if (dataGridViewTeams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un equipo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el índice de la fila seleccionada en el DataGridView
            int selectedIndex = dataGridViewTeams.SelectedRows[0].Index;

            // Obtener el nombre del equipo seleccionado en el DataGridView
            string selectedTeamName = dataGridViewTeams.Rows[selectedIndex].Cells[0].Value.ToString();

            // Confirmar con el usuario antes de eliminar el equipo
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este equipo?", "Eliminar equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Eliminar el equipo usando el DataManager
                dataManager.DeleteTeam(selectedTeamName);

                // Actualizar la visualización en el DataGridView
                dataGridViewTeams.DataSource = dataManager.GetTeams();

                // Limpiar los controles después de eliminar el equipo
                ClearTeamControls();
            }
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            // Verificar si los campos de entrada están vacíos
            if (string.IsNullOrWhiteSpace(txtHomeTeam.Text) ||
                string.IsNullOrWhiteSpace(txtAwayTeam.Text) ||
                string.IsNullOrWhiteSpace(txtHomeGoals.Text) ||
                string.IsNullOrWhiteSpace(txtAwayGoals.Text) ||
                string.IsNullOrWhiteSpace(txtStadium.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir los goles en enteros
            if (!int.TryParse(txtHomeGoals.Text, out int homeGoals) || !int.TryParse(txtAwayGoals.Text, out int awayGoals))
            {
                MessageBox.Show("Por favor, ingrese un número válido para los goles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir la fecha
            if (!DateTime.TryParse(txtDate.Text, out DateTime date))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una nueva instancia de MatchStats
            MatchStats match = new MatchStats(txtHomeTeam.Text, txtAwayTeam.Text, homeGoals, awayGoals, date, txtStadium.Text);

            // Agregar el partido usando el DataManager
            dataManager.AddMatch(match);

            // Actualizar la visualización en el DataGridView
            dataGridViewMatches.DataSource = dataManager.GetMatchStats();

            // Limpiar los controles después de agregar el partido
            ClearMatchControls();
        }

        private void ClearMatchControls()
        {
            txtHomeTeam.Text = "";
            txtAwayTeam.Text = "";
            txtHomeGoals.Text = "";
            txtAwayGoals.Text = "";
            txtStadium.Text = "";
            txtDate.Text = "";
            // Limpiar otros controles según sea necesario
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewMatches.CurrentRow.Index;

            MatchStats updatedMatch = new MatchStats
            {
                HomeTeam = txtHomeTeam.Text,
                AwayTeam = txtAwayTeam.Text,
                HomeGoals = int.Parse(txtHomeGoals.Text),
                AwayGoals = int.Parse(txtAwayGoals.Text),
                Stadium = txtStadium.Text,
                Date = DateTime.Parse(txtDate.Text)
                // Agregar otros datos según sea necesario
            };

            dataManager.EditMatch(selectedIndex, updatedMatch);

            dataGridViewMatches.DataSource = dataManager.GetMatches();

            ClearMatchControls();
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada en el DataGridView
            if (dataGridViewMatches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un partido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el índice de la fila seleccionada en el DataGridView
            int selectedIndex = dataGridViewMatches.SelectedRows[0].Index;

            // Confirmar con el usuario antes de eliminar el partido
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este partido?", "Eliminar partido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Eliminar el partido usando el DataManager
                dataManager.DeleteMatch(selectedIndex);

                // Actualizar la visualización en el DataGridView
                dataGridViewMatches.DataSource = dataManager.GetMatches();

                // Limpiar los controles después de eliminar el partido
                ClearMatchControls();
            }
        }
    }
}

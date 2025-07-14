using Npgsql;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Library_maintenance
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void entbutton_Click(object sender, EventArgs e)
        {
            await ReadDataFromDBAsync();
        }

        public async Task ReadDataFromDBAsync()
        {
            // ���������� TextBox ��� ������ �����������
            resultsTextBox.Clear();
            resultsTextBox.AppendText("������� ����������� � ��...\r\n");

            try
            {
                // ���������� ������ ����������� ��� ��������� ��
                var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=4suh12iiyu;Database=postgres";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    resultsTextBox.AppendText("����������� �������!\r\n");

                    string sql = "SELECT full_name FROM Employees";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        resultsTextBox.AppendText("����������:\r\n");

                        while (await reader.ReadAsync())
                        {
                            // ��������� ������ � TextBox
                            resultsTextBox.AppendText($"ID: {reader["full_name"]}\r\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ���������� ������ ������������
                resultsTextBox.AppendText($"������: {ex.Message}\r\n");

                // ��� ������� � Visual Studio
                Debug.WriteLine($"DB ERROR: {ex}");
            }
        }
    }
}
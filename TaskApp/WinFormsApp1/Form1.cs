using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string filePath = "tasks.txt";
        public Form1()
        {

            InitializeComponent();
            LoadTasksFromFile();
        }

        private void LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                foreach (var line in lines)
                {
                    string[] taskParts = line.Split('|');
                    if (taskParts.Length == 3)
                    {
                        string taskName = taskParts[0];
                        string taskDescription = taskParts[1];
                        bool isCompleted = bool.Parse(taskParts[2]);

                        string taskDisplay = $"{taskName} - {taskDescription}";
                        checkedListBox1.Items.Add(taskDisplay, isCompleted);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text;
            string taskDescription = richTextBox1.Text;

            if (!string.IsNullOrEmpty(taskName) && !string.IsNullOrEmpty(taskDescription))
            {
                string taskDisplay = $"{taskName} - {taskDescription}";
                checkedListBox1.Items.Add(taskDisplay, false);

                SaveTaskToFile(taskName, taskDescription, false);
                MessageBox.Show("Tarefa adicionada com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha o nome e a descrição da tarefa.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBox1.SelectedIndex;

            if (selectedIndex >= 0)
            {
                checkedListBox1.Items.RemoveAt(selectedIndex);
                SaveAllTasksToFile();
                MessageBox.Show("Tarefa removida com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
        }

        private void SaveTaskToFile(string name, string description, bool isCompleted)
        {
            string taskLine = $"{name}|{description}|{isCompleted}";
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                sw.WriteLine(taskLine);
            }
        }
        private void SaveAllTasksToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var item in checkedListBox1.Items)
                {
                    string task = item.ToString();
                    string[] taskParts = task.Split(" - ");
                    if (taskParts.Length == 2)
                    {
                        string taskName = taskParts[0];
                        string taskDescription = taskParts[1];
                        bool isCompleted = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));

                        string taskLine = $"{taskName}|{taskDescription}|{isCompleted}";
                        sw.WriteLine(taskLine);
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveAllTasksToFile();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Click += button2_Click;
            if (checkedListBox1.Items.Count > 0)
            {
                // Verifica se todas as tarefas estão selecionadas
                bool allSelected = true;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (!checkedListBox1.GetItemChecked(i))
                    {
                        allSelected = false;
                        break;
                    }
                }

                if (allSelected)
                {
                    // Se todas as tarefas estiverem marcadas, remove todas
                    checkedListBox1.Items.Clear();
                    File.WriteAllText(filePath, string.Empty); // Limpa o arquivo
                    MessageBox.Show("Todas as tarefas foram removidas.");
                }
                else
                {
                    // Remove apenas as tarefas marcadas
                    for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
                    {
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            checkedListBox1.Items.RemoveAt(i);
                        }
                    }

                    SaveAllTasksToFile(); // Atualiza o arquivo após a remoção
                }
            }
            else
            {
                MessageBox.Show("Não há tarefas para remover.");
            }

            // Após a remoção, desabilita o botão de remover até que haja novas tarefas
            button2.Enabled = false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasianchuk_task_2
{
    public partial class VisitorPanel : Form
    {
        Visitor visitor = new Visitor();
        public VisitorPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка наявності даних у полях
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                numericUpDown1.Value == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            visitor.name = textBox1.Text;
            visitor.surname = textBox2.Text;
            visitor.sex = comboBox1.Text;
            visitor.age = (int)numericUpDown1.Value;
            visitor.chosenConcert = comboBox2.Text;

            // Записуємо дані в файл
            using (StreamWriter writer = new StreamWriter("RegisteredVisitors.txt", true))
            {
                writer.WriteLine($"Ім'я: {visitor.name}, Прізвище: {visitor.surname}, Стать: {visitor.sex}, Вік: {visitor.age}, Обраний концерт: {visitor.chosenConcert}, ID: {visitor.GenerateTicketId()}");
            }

            MessageBox.Show("Успішно зареєстровано", "Реєстрація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VisitorPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

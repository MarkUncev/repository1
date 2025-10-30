using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace Rimrabic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Инициализация элементов интерфейса (кнопки, поля и т.д.)
            InitializeTooltips(); // Включаем всплывающие подсказки
        }

        // Список для хранения истории конвертаций
        private List<string> history = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //работа всплывающих подсказок
        private void InitializeTooltips()
        {
            toolTip = new ToolTip();

            toolTip.SetToolTip(txtRoman, "Введите римское число (например, MCMXCIX)");
            toolTip.SetToolTip(txtArabic, "Введите арабское число от 1 до 3999");
            toolTip.SetToolTip(btnConvertToArabic, "Конвертировать римское число в арабское");
            toolTip.SetToolTip(btnConvertToRoman, "Конвертировать арабское число в римское");
            toolTip.SetToolTip(btnLoadFromFile, "Загрузить число из текстового файла");
            toolTip.SetToolTip(btnExportHistory, "Экспортировать историю конвертаций в файл");
            toolTip.SetToolTip(btnClear, "Очистить все поля");
        }

        // Кнопка: конвертировать римское число в арабское
        private void btnConvertToArabic_Click(object sender, EventArgs e)
        {
            string romanInput = txtRoman.Text.ToUpper().Trim();// Получаем ввод

            if (Validator.IsValidRoman(romanInput))// Проверяем корректность
            {
                int arabic = Converter.RomanToArabic(romanInput);// Конвертируем
                txtResult.Text = arabic.ToString();// Отображаем результат
                AddToHistory($"{romanInput} → {arabic}");// Добавляем в историю
            }
            else
            {
                MessageBox.Show("Ошибка: Некорректное римское число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка: конвертировать арабское число в римское
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArabic.Text, out int arabic) && arabic > 0 && arabic <= 3999)
            {
                string roman = Converter.ArabicToRoman(arabic);
                txtResult.Text = roman;
                AddToHistory($"{arabic} → {roman}");
            }
            else
            {
                MessageBox.Show("Ошибка: Введите целое число от 1 до 3999.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка: загрузить число из файла
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(ofd.FileName).Trim();// Читаем файл

                    ProcessFileContent(content);// Автоматически определяем тип числа
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Кнопка: экспортировать историю в файл .txt
        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    HistoryManager.ExportHistoryToFile(history, sfd.FileName);// Сохраняем историю
                    MessageBox.Show("История успешно сохранена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        // Добавляет запись в историю
        private void AddToHistory(string entry)
        {
            history.Add(entry);// Добавляем в список
            lstHistory.Items.Add(entry);// Отображаем в ListBox
        }
        // Кнопка: очистить все поля
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoman.Clear();
            txtArabic.Clear();
            txtResult.Clear();
        }
        //  автоматическоее распознавание формата числа из файла
        private void ProcessFileContent(string content)
        {
            // Проверяем, является ли содержимое арабским числом
            if (int.TryParse(content, out int arabicValue))
            {
                if (arabicValue >= 1 && arabicValue <= 3999)
                {
                    string roman = Converter.ArabicToRoman(arabicValue);
                    txtArabic.Text = arabicValue.ToString();
                    txtResult.Text = roman;
                    AddToHistory($"{arabicValue} → {roman}");
                }
                else
                {
                    MessageBox.Show("Число вне диапазона (1–3999)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Предполагаем, что это римское число
                string romanInput = content.ToUpper();
                if (Validator.IsValidRoman(romanInput))
                {
                    int arabic = Converter.RomanToArabic(romanInput);
                    txtRoman.Text = romanInput;
                    txtResult.Text = arabic.ToString();
                    AddToHistory($"{romanInput} → {arabic}");
                }
                else
                {
                    MessageBox.Show("Файл содержит некорректное римское число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"help.chm", HelpNavigator.Topic, "Second_topic.htm#SECONDTOPIC");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpFilePath = @"helparabic.chm";

            try
            {
                System.Diagnostics.Process.Start("hh.exe", helpFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл справки: " + ex.Message);
            }
        }
    }
}

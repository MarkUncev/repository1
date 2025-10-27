
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class TaskManagementWindow : Window
    {
        private TaskManager taskManager;

        public TaskManagementWindow()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            taskManager.SetListBox(TaskList);  // Связываем ListBox с TaskManager для обновлений
            AddText(null, null); // Устанавливаем текст-подсказку при запуске
        }

        // Убираем текст-подсказку при получении фокуса
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            if (TaskDescription.Text == "Введите описание задачи")
            {
                TaskDescription.Text = "";
                TaskDescription.Foreground = Brushes.Black;
            }
        }

        // Добавляем текст-подсказку, если поле пустое
        private void AddText(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskDescription.Text))
            {
                TaskDescription.Text = "Введите описание задачи";
                TaskDescription.Foreground = Brushes.Gray;
            }
        }

        // Добавляем задачу и выполняем выбранный делегат
        private void AddTask(object sender, RoutedEventArgs e)
        {
            string taskDescription = TaskDescription.Text;
            if (string.IsNullOrWhiteSpace(taskDescription) || taskDescription == "Введите описание задачи")
            {
                MessageBox.Show("Введите описание задачи.");
                return;
            }

            // Проверяем, выбрал ли пользователь делегат
            if (DelegateSelector.SelectedIndex == 0) // Отправить уведомление
            {
                TaskDelegate taskDelegate = new TaskDelegate(taskManager.SendNotification);
                taskDelegate(taskDescription);
            }
            else if (DelegateSelector.SelectedIndex == 1) // Записать в лог
            {
                TaskDelegate taskDelegate = new TaskDelegate(taskManager.LogTask);
                taskDelegate(taskDescription);
            }
            else
            {
                MessageBox.Show("Выберите действие для задачи");
            }

            // Очищаем поле после добавления
            TaskDescription.Text = "";
            TaskDescription.Foreground = Brushes.Black;
        }
    }

    // Определение делегата для задач
    public delegate void TaskDelegate(string task);

    // Класс для управления задачами
    public class TaskManager
    {
        private List<string> _tasks = new List<string>();
        private ListBox _listBox;

        // Связываем ListBox для обновлений
        public void SetListBox(ListBox listBox)
        {
            _listBox = listBox;
            RefreshList();
        }

        // Записать в лог — добавляет задачу в список
        public void LogTask(string task)
        {
            _tasks.Add($"Logged: {task}");
            RefreshList();
        }

        // Отправить уведомление — добавляет задачу в список
        public void SendNotification(string task)
        {
            _tasks.Add($"Notified: {task}");
            RefreshList();
        }

        // Обновляет ListBox
        private void RefreshList()
        {
            if (_listBox != null)
            {
                _listBox.ItemsSource = null;
                _listBox.ItemsSource = _tasks;
            }
        }
    }
}
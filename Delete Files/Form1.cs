using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Что я добавил

using System.IO;//для управлениями файлами
using System.Diagnostics;//для управлениями процесамми

namespace Delete_Files
{
    public partial class Form1 : Form
    {
        //переменные

        public string path = "";//путь
        public int error = 0;//сколько ошибок?
        public int deletes;//сколько успешно удалено?

        //разное

        StreamWriter rd = new StreamWriter(@"C:\LogDeleteFiles.txt");//где хранить лог файл

        public Form1()
        {
            InitializeComponent();
        }

        private async void Btstart_Click(object sender, EventArgs e)
        {
            await Work();
        }

        public async Task Work()
        {
            lsLog.Items.Clear();
            FolderBrowserDialog l = new FolderBrowserDialog();
            if (l.ShowDialog() == DialogResult.OK)
            {
                this.Invoke(new Action(() => { lsLog.Items.Add($"Начало очистки!"); }));
                rd.WriteLine($"Начало очистки!");
                path = l.SelectedPath;
                string[] delete = Directory.GetFiles(path, tbdelete.Text, SearchOption.AllDirectories);
                this.Invoke(new Action(() => { lsLog.Items.Add($"Всё нашёл! Всего файлов: {delete.Length}"); }));
                rd.WriteLine($"Всё нашёл! Всего файлов: {delete.Length}");
                progressDelete.Maximum = delete.Length;
                //rd.Close();
                foreach (string name in delete)
                {
                    try
                    {
                        File.Delete(name);
                        this.Invoke(new Action(() => { lsLog.Items.Add($"Удалил файл по пути: {name}"); }));
                        rd.WriteLine($"Удалил файл по пути: {name}");
                        deletes++;
                        progressDelete.Value++;
                        //rd.Close();
                    }
                    catch(Exception ex)
                    {
                        this.Invoke(new Action(() => { lsLog.Items.Add($"Ошибка удаление по пути: {name}. Ошибка {ex.Message}"); }));
                        rd.WriteLine($"Ошибка удаление по пути: {name}. Ошибка {ex.Message}");
                        error++;
                        progressDelete.Value++;
                        //rd.Close();
                    }
                }
                this.Invoke(new Action(() => { lsLog.Items.Add($"Очистка завершина! Всего {delete.Length}, успешно {deletes}, ошибка {error}"); }));
                rd.WriteLine($"Очистка завершина! Всего {delete.Length}, успешно {deletes}, ошибка {error}");
                //rd.Close();
                deletes = 0;
                error = 0;
                progressDelete.Value = 0;
                progressDelete.Maximum = 100;
            }
            //rd.Close();
        }

        private void ЗапускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btstart.PerformClick();
        }

        private void ПоказатьЛогиКакФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { Process.Start(@"C:\LogDeleteFiles.txt"); }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка открытие логов! Ошибка: {ex.Message}");
                lsLog.Items.Add($"Ошибка открытие логов! Ошибка: {ex.Message}");
                rd.WriteLine($"Ошибка открытие логов! Ошибка: {ex.Message}");
                //rd.Close();
            }
        }
    }
}

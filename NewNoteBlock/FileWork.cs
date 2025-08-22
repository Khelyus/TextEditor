using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace NewNoteBlock
{
    public class FileWork
    {
        public static void MenuCreateFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Создать новый документ"
        {
            string newDocName = Properties.Settings.Default.newDocName;
            string programmName = Properties.Settings.Default.programmName;
            notebox.Clear();
            docPath = "";
            tbChange = false;
            MainForm.ActiveForm.Text = newDocName + " — " + programmName;
        }

        public static void OpenFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Открыть документ"
        {
            string programmName = Properties.Settings.Default.programmName;
            OpenFileDialog openDocument = new OpenFileDialog();
            openDocument.Title = "Открыть текстовый документ";
            // Include both .txt and .rtf in the filter
            openDocument.Filter = "Текстовые файлы (*.txt)|*.txt|RTF файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openDocument.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file, Encoding.Default);
                notebox.Text = reader.ReadToEnd();
                reader.Close();
                docPath = openDocument.FileName;
                tbChange = false;
                MainForm.ActiveForm.Text = openDocument.SafeFileName + " — " + programmName;
            }
        }

        public static void SaveFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Сохранить документ"
        {
            FileStream file = new FileStream(docPath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.Default);
            writer.Write(notebox.Text);
            writer.Close();
            tbChange = false;
        }

        public static void SaveAsFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Сохранить документ как..."
        {
            string programmName = Properties.Settings.Default.programmName;
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить документ как...";
            saveAsDocument.FileName = "Текстовый документ";
            // Include both .txt and .rtf in the filter
            saveAsDocument.Filter = "Текстовые файлы (*.txt)|*.txt|RTF файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*";

            if (saveAsDocument.ShowDialog() == DialogResult.OK) //Если пользователь подтвердил сохранение
            {
                // Determine the file format based on the file extension
                string fileExtension = Path.GetExtension(saveAsDocument.FileName).ToLower();
                Encoding encoding = Encoding.Default;
                if (fileExtension == ".rtf")
                {
                    // If the user wants to save as .rtf, you might need to handle it differently
                    // For example, if your TextBox supports RTF content, you would save that content.
                    // This example assumes plain text is being saved, similar to .txt handling.
                    // Adjust this section if your application supports rich text in the TextBox.
                }

                //Создаем файл по пути, выбранному в окне сохранения
                FileStream file = new FileStream(saveAsDocument.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, encoding);
                writer.Write(notebox.Text); //записываем содержимое в файл
                writer.Close(); //закрываем поток
                tbChange = false;
                docPath = saveAsDocument.FileName;
                MainForm.ActiveForm.Text = Path.GetFileName(saveAsDocument.FileName) + " — " + programmName;
            }
            else
            {
                tbChange = true;
                return;
            }
        }
    }
}

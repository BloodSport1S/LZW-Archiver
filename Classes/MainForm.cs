using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LZWAlgorithms
{
    public partial class MainForm : Form
    {
        private readonly string passwordRegex = "^[a-zA-Z0-9,.;:!@#%+^$*/-]+$";
        Match matcher;

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select files to compress";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    matcher = Regex.Match(textBox3.Text, passwordRegex);
                    if (textBox3.Text != "" && !matcher.Success)
                    {
                        MessageBox.Show("Введеный пароль для создания архива неверный");
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        return;
                    }

                    long uncompressedfiles = 0, compressedfiles = 0;
                    var countFiles = openFileDialog.FileNames.Length;
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "LZW Archive (*.lzw)|*.lzw|All files (*.*)|*.*";
                        saveFileDialog.FileName = "archive.lzw";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            textBox2.Text += "Файлы сжимаются..." + Environment.NewLine;

                            using (MemoryStream archiveStream = new MemoryStream())
                            using (BinaryWriter writer = new BinaryWriter(archiveStream))
                            {
                                var password = textBox3.Text;

                                var encryptedPassword = password.CreateSHA256();
                                writer.Write(encryptedPassword.Length);
                                writer.Write(encryptedPassword);

                                foreach (string filePath in openFileDialog.FileNames)
                                {
                                    var fileLength = new FileInfo(filePath).Length;
                                    string fileName = Path.GetFileName(filePath);

                                    textBox2.Text += $"Файл {fileName} открыт. Размер = {fileLength} Байт" + Environment.NewLine;

                                    uncompressedfiles += fileLength;

                                    byte[] fileBytes = File.ReadAllBytes(filePath);

                                    writer.Write(fileName);
                                    writer.Write(fileBytes.Length);
                                    writer.Write(fileBytes);
                                }

                                var compressedData = LZW.Compress(archiveStream.ToArray(), password);


                                File.WriteAllBytes(saveFileDialog.FileName, compressedData.SelectMany(BitConverter.GetBytes).ToArray());

                                compressedfiles = new FileInfo(saveFileDialog.FileName).Length;

                                textBox2.Text += $"Файлы успешно сжаты в каталог ( {saveFileDialog.FileName} )" + Environment.NewLine;
                            }


                            double result = ((uncompressedfiles - compressedfiles) / (double)uncompressedfiles) * 100; ;
                            textBox2.Text += $"Процент сжатия = {Math.Round(result, 2)}" + "%" + Environment.NewLine;

                            if (result < 0)
                            {
                                textBox2.SelectionStart = textBox2.TextLength; // Устанавливаем курсор в конец
                                textBox2.SelectionLength = 0; // Снимаем выделение
                                textBox2.SelectionColor = Color.Red; // Устанавливаем цвет текста
                                textBox2.AppendText("Сжатие было неэффективно");
                                textBox2.SelectionColor = textBox2.ForeColor; // Возвращаем цвет текста по умолчанию
                            }
                        }
                    }
                }
            }
        }

        private void decompressingFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "LZW Archive (*.lzw)|*.lzw|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    matcher = Regex.Match(textBox3.Text, passwordRegex);
                    if (textBox3.Text != "" && !matcher.Success)
                    {
                        MessageBox.Show("Введеный пароль для раcжатия архива неверный");
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        return;
                    }

                    foreach (string filename in openFileDialog.FileNames)
                    {
                        textBox2.Text += $"Архив {Path.GetFileName(filename)} открыт. Размер = {new FileInfo(filename).Length} Байт" + Environment.NewLine;
                        textBox2.Text += $"Архив {Path.GetFileName(filename)} сейчас раcжимается...." + Environment.NewLine;

                        var compressedBytes = File.ReadAllBytes(filename);

                        List<ushort> compressedData = new List<ushort>();
                        for (int i = 0; i < compressedBytes.Length; i += sizeof(ushort))
                        {
                            compressedData.Add(BitConverter.ToUInt16(compressedBytes, i));
                        }
                        try
                        {
                            var password = textBox3.Text;
                            byte[] decompressedArchive = LZW.Decompress(compressedData, password);

                            using (MemoryStream archiveStream = new MemoryStream(decompressedArchive))
                            using (BinaryReader reader = new BinaryReader(archiveStream))
                            {
                                var passwordLength = reader.ReadInt32();
                                byte[] passwordSequnce = reader.ReadBytes(passwordLength);
                                while (archiveStream.Position < archiveStream.Length)
                                {
                                    string fileName = reader.ReadString();
                                    int fileSize = reader.ReadInt32();
                                    byte[] fileData = reader.ReadBytes(fileSize);

                                    File.WriteAllBytes($"{Path.GetDirectoryName(filename)}/{fileName}", fileData);
                                    textBox2.Text += $"Файл {fileName} расжат" + Environment.NewLine;
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Введеный пароль неверный", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Text = string.Empty;
                            textBox3.Text = string.Empty;
                            return;
                        }
                    }

                    File.Delete(openFileDialog.FileName);
                    textBox2.Text += $"Архив {Path.GetFileName(openFileDialog.FileName)} удалён." + Environment.NewLine;

                }
               
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) => textBox2.Text = string.Empty;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

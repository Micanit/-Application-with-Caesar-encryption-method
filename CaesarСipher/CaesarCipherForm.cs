using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarСipher
{
    public partial class CaesarCipherForm : Form
    {
        public CaesarCipherForm()
        {
            InitializeComponent();
        }

        private string сaesarCipher(string originalText, int step)
        {
            //Объявление переменных
            string alfabetRusUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string alfabetRusLower = alfabetRusUpper.ToLower();
            string decryptedText = "";

            if (step >= 33)
            {
                do
                {
                    step = step - 33;
                }
                while (step > 33);
            }
            else if (step <= -33)
            {
                do
                {
                    step = step + 33;
                }
                while (step < -33);
            }
            string testOriginalText = originalText.ToUpper();
            string mainAlfabet = string.Empty;

            for (int i = 0; i < originalText.Length; i++)
            {
                if (Char.IsLetter(originalText[i]) == true && (testOriginalText[i] >= 'А') && (testOriginalText[i] <= 'Я'))
                {
                    for (int j = 0; j < alfabetRusUpper.Length; j++)
                    {
                        if (alfabetRusUpper.Contains(originalText[i]))
                        {
                            mainAlfabet = alfabetRusUpper;
                        }
                        else if (alfabetRusLower.Contains(originalText[i]))
                        {
                            mainAlfabet = alfabetRusLower;
                        }
                        if (originalText[i] == mainAlfabet[j])
                        {
                            int indexOriginalText = j;
                            if (step > 0)
                            {
                                if (step + indexOriginalText > 32)
                                {
                                    decryptedText += mainAlfabet[(step + indexOriginalText) - 33];
                                }
                                else if (step + indexOriginalText <= 32)
                                {
                                    decryptedText += mainAlfabet[step + indexOriginalText];
                                }
                            }
                            else if (step < 0)
                            {
                                if (step + indexOriginalText >= 0)
                                {
                                    decryptedText += mainAlfabet[(step + indexOriginalText)];
                                }
                                else if (step + indexOriginalText < 0)
                                {
                                    decryptedText += mainAlfabet[(step + indexOriginalText) + 33] ;
                                }
                            }
                            else
                            {
                                decryptedText += originalText[i];
                            }

                        }
                    }
                }
                else
                {
                    decryptedText += originalText[i];
                }
                
            }
            return decryptedText;
        }

        //Нажатие но кнопку зашифровать
        private void encryptButton_Click(object sender, EventArgs e)
        {
            #region Валидация исходного текста
            //Проверка на наличие текста
            if (originalRichTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите пожалуйста исходный текст","Внимание");
                return;
            }
            #endregion

            #region Валидация шага шифра
            //Проверка на наличие текста
            if (stepTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите пожалуйста шаг шифра", "Внимание");
                return;
            }
            //Проверка на наличие цифр и минуса впереди
            for (int i = 1; i < stepTextBox.Text.Length; i++)
            {
                if (Char.IsNumber(stepTextBox.Text[i]) == false)
                {
                    if (stepTextBox.Text[0] != '-' || Char.IsNumber(stepTextBox.Text[0]) == false)
                    {
                        MessageBox.Show("Шаг шифра может содержать только число и знак - перед числом", "Внимание");
                        return;
                    }
                }
            }
            #endregion

            //Реализация метода
            string originalText = originalRichTextBox.Text;
            int step = Convert.ToInt32(stepTextBox.Text);
            encryptRichTextBox.Text = сaesarCipher(originalText, step);
        }
    }
}

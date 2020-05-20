using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZip.Compression.LZMA;

using System.Windows;

namespace MinesProgram
{
    public partial class Form1 : Form
    {
        bool IsClicked = false;



        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            richTextBox1.Text = "02.05.20\n                   Новое в версии 1.0.1.15.0:\n\n  - Добавлен конвертeр прог в старый код. \n  - Добавлен конвертeр прог в новый код.\n\n 03.05.20\n                   Новое в версии 1.0.1.15.1:\n\n  - Незначительные фиксы.\n\n 17.05.20\n                   Новое в версии 1.0.1.15.2:\n\n  - Проведена оптимизация кода \n  - В меню добавлен пункт: Калькулятор расхода пухи (пока что не работает). \n";
            textBox1.Text = "Введите программу";//подсказка
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Введите программу";//подсказка
            textBox2.ForeColor = Color.Gray;
            label6.Text = "Сборка 1.15.2";
            label2.Text = "Версия 1.0";
        }

        static void massiv (string[] txn)
        {
             
            //string[] txn = new string[3071];
            string[] sim1 = { "-", "=", "~" };
            string[] sim2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "[", "]", "{", "}", ",", ".", "<", ">", "?", "/", ";", ":", "|", "~" };
            int f = 0; int t = 1; int gss = 0;

            for (int i = 0; i < txn.Length; i++)
            {
                txn[0] = "_";

                if (i < 90 && i > 0)
                {



                    if (f < sim2.Length)
                    {
                        txn[i] = sim1[0] + sim2[f + 2];
                        f++;
                    }
                    if (f == sim2.Length) f = 0;





                }

                if (i > 89)
                {
                    if (t < 10)
                    {
                        if (gss < sim2.Length)
                        {
                            txn[i] = sim1[1] + t + sim2[gss];// + " " + i.ToString();
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }
                    else
                    {
                        if (gss < sim2.Length)
                        {
                            txn[i] = sim1[2] + t + sim2[gss];// + " " + i.ToString();
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }
                    
                }

            }
        }

        static void massiv2(string[] txn1)
        {
            string[] sim1 = { "-", "=", "~" };
            string[] sim2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "[", "]", "{", "}", ",", ".", "<", ">", "?", "/", ";", ":", "|", "~" };
            int f = 0; int t = 1; int gss = 0;
            for (int i = 0; i < txn1.Length; i++)
            {
                txn1[0] = "_";

                if (i < 90 && i > 0)
                {



                    if (f < sim2.Length)
                    {
                        txn1[i] = sim2[f + 2];
                        f++;
                    }
                    if (f == sim2.Length) f = 0;





                }

                if (i > 89)
                {
                    if (t < 10)
                    {
                        if (gss < sim2.Length)
                        {
                            txn1[i] =  t + sim2[gss];// + " " + i.ToString();
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }
                    else
                    {
                        if (gss < sim2.Length)
                        {
                            txn1[i] = t + sim2[gss];// + " " + i.ToString();
                            gss++;
                        }
                        if (gss == sim2.Length) { gss = 0; t++; }
                    }

                }

            
            }

        }

        static void Cut(ref string[] array, int startIndex, int numberOfElements)
        {
            string[] tempArr = new string[array.Length - numberOfElements];
            int counter = 0;
            for (int j = 0; j < startIndex; j++)
            {
                tempArr[counter++] = array[j];
            }
            for (int j = startIndex + numberOfElements; j < array.Length; j++)
            {
                tempArr[counter++] = array[j];
            }
            array = tempArr;
        }

        static string[] Delete(string[] array, int indexToDelete)
        {
            // Проверки, что наш массив не пуст и что указанный индекс существует.
            // if (array.Length == 0) return array;
            //if (array.Length <= indexToDelete) return array;

            var output = new string[array.Length - 1];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == indexToDelete) continue;
                output[counter] = array[i];
                counter++;
            }

            return output;
        }

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Раздел в разработке", "Внимание!");

        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //тут код, который нужно выполнить, если нажали кнопку Нет
            }



        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //тут код, который нужно выполнить, если нажали кнопку Нет
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            richTextBox2.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            textBox2.Visible = false;
            textBox2.Enabled = false;
            button9.Visible = false;
            button9.Enabled = false;
            richTextBox3.Visible = false;
            richTextBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
            richTextBox1.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label5.Visible = true;
            label3.Visible = true;
            richTextBox2.Visible = true;
            richTextBox2.Enabled = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            button6.Visible = true;
            button6.Enabled = true;
            textBox2.Visible = false;
            textBox2.Enabled = false;
            button9.Visible = false;
            button9.Enabled = false;
            richTextBox3.Visible = false;
            richTextBox3.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox2.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            button9.Visible = true;
            button9.Enabled = true;
            richTextBox3.Visible = true;
            richTextBox3.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //private void textBox1_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        //{
        //    textBox1.Text = null;
        //    textBox1.Text = "";
        //    textBox1.ForeColor = Color.Black;
        //}



        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите программу")
            {
                textBox1.Text = null;
                //    textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible == false && textBox1.Text == "")
            {
                textBox1.Text = "Введите программу";//подсказка
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите программу")
            {
                textBox2.Text = null;
                //    textBox1.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && textBox2.Text == "")
            {
                textBox2.Text = "Введите программу";//подсказка
                textBox2.ForeColor = Color.Gray;
            }
        }
        private void button6_Click_1(object sender, EventArgs e)// конвертация в старый код+
        {
            //
            string[] tx3 = new string[3071];
            massiv2(tx3);
            int num = 0;
            string s = textBox1.Text;
            //string s = "XQAAgABtAAAAAAAAAAACADcIzzmiHvAv8QY6keZxKaCdkxDzdXYmysNyjxmKr6tht0JRCuCJH6c1gUZ0AA==";
            //byte[] array = SevenZipHelper.Decompress(Convert.FromBase64String(s));
            if (s.Trim() != "")
            {
                byte[] array = SevenZipHelper.Decompress(Convert.FromBase64String(s));

                num = BitConverter.ToInt32(array, 0);
                // string[] array2 = Encoding.UTF8.GetString(array, num + 4, array.Length - num - 4).Split(new char[]
                //{
                //    ':'
                //});
                //int[] number = new int[110];
                int[] number = new int[16 * 12 * 16];
                string t;
                t = BitConverter.ToString(array);

                string h = Encoding.UTF8.GetString(array);
                //for (int i =0; i < array.Length; i++)
                //{
                //    number [i] = BitConverter.ToInt32(array, array.Length - num - 4);
                // }
                string[] valu = t.Split('-');

                //тестовая функция
                string[] tmp1 = new string[valu.Length];

                for (int i = 0; i < valu.Length; i++)
                {
                    tmp1[i] = Convert.ToInt32(valu[i], 16).ToString();
                }

                int g = 0;
                for (int i = 4; i < num + 4; i++)
                {
                    if (tmp1[i] == "40")
                    {
                        g += 1;
                    }
                }
                int[] number1 = new int[g];
                int gg = 0;
                for (int i = 4; i < num + 4; i++)
                {

                    if (tmp1[i] == "40" && gg <= g)
                    {
                        number1[gg] = i - 4;
                        gg++;
                    }
                    //gg++;

                }
                string f = String.Join(" ", number1);

                //Cut(ref tmp1, 0, 4);
                //

                Cut(ref valu, num + 4, array.Length - num - 4);
                Cut(ref valu, 0, 4);
                string[] tmp = new string[valu.Length];




                for (int i = 0; i < valu.Length; i++)
                {

                    //if (valu[i] == "08")
                    //{

                    tmp[i] = Convert.ToInt32(valu[i], 16).ToString();
                    /* if (tmp[i] == "1")
                     {
                         tmp[i] = "\\";
                     }
                     if (tmp[i] == "2")
                     {
                         tmp[i] = ">";
                     }
                     if (tmp[i] == "3")
                     {
                         tmp[i] = "<";
                     }
                     if (tmp[i] == "4")
                     {
                         tmp[i] = "W";
                     }
                     if (tmp[i] == "5")
                     {
                         tmp[i] = "A";
                     }
                     if (tmp[i] == "6")
                     {
                         tmp[i] = "S";
                     }
                     if (tmp[i] == "7")
                     {
                         tmp[i] = "D";
                     }
                     if (tmp[i] == "8")
                     {
                         tmp[i] = "Z0";
                     }
                     if (tmp[i] == "9")
                     {
                         tmp[i] = "w";
                     }
                     if (tmp[i] == "10")
                     {
                         tmp[i] = "a";
                     }
                     if (tmp[i] == "11")
                     {
                         tmp[i] = "s";
                     }
                     if (tmp[i] == "12")
                     {
                         tmp[i] = "d";
                     }
                     if (tmp[i] == "13")
                     {

                     }
                     if (tmp[i] == "14")
                     {
                         tmp[i] = "Z2";
                     }
                     if (tmp[i] == "15")
                     {
                         tmp[i] = "Z3";
                     }
                     if (tmp[i] == "16")
                     {
                         tmp[i] = "Z4";
                     }
                     if (tmp[i] == "17")
                     {
                         tmp[i] = "Zc";
                     }
                     if (tmp[i] == "18")
                     {
                         tmp[i] = "Ze";
                     }
                     if (tmp[i] == "19")
                     {
                         tmp[i] = "Zd";
                     }
                     if (tmp[i] == "20")
                     {
                         tmp[i] = "Zf";
                     }
                     if (tmp[i] == "21")
                     {
                         tmp[i] = "Zg";
                     }
                     if (tmp[i] == "22")
                     {
                         tmp[i] = "Zq";
                     }
                     if (tmp[i] == "23")
                     {
                         tmp[i] = "Zh";
                     }*/


                    // if (tmp[i] == "24")
                    //{
                    //tmp[i] = "G2()";
                    // }
                    // valu[i] = "Z";
                    //}


                }
                /*if (tmp[tmp.Length - 1] == "0")
                {
                    Cut(ref tmp, tmp.Length - 1, tmp.Length - 1);
                }*/
                ///richTextBox1.Text = string.Join("", tmp);//string.Join("", valu);
                //textBox1.Text = tmp[tmp.Length-1].ToString();

                //Clipboard.SetText(richTextBox1.Text);
                MessageBox.Show("Прога сконвертировалась в старый код и скопирована в буфер обмена!", "Сконвертировано!");

                //// не обратное преобразование

                int[] nums = new int[16 * 12 * 16];
                int[] codes = new int[16 * 12 * 16];
                string[] code_labels = new string[16 * 12 * 16];

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        for (int k = 0; k < 16; k++)
                        {
                            codes[i * 16 * 12 + j * 16 + k] = 0;
                            nums[i * 16 * 12 + j * 16 + k] = 0;
                            code_labels[i * 16 * 12 + j * 16 + k] = "0";
                        }
                    }
                }


                int n = BitConverter.ToInt32(array, 0);
                for (int i = 0; i < n; i++)
                {
                    codes[i] = (int)Convert.ToInt16(array[i + 4]);
                }
                string[] array2 = Encoding.UTF8.GetString(array, num + 4, array.Length - num - 4).Split(new char[]
                {
                 ':'
                });
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains("@"))
                    {
                        string[] array3 = array2[j].Split(new char[]
                        {
                            '@'
                        });
                        code_labels[j] = array3[0];
                        nums[j] = int.Parse(array3[1]);
                    }
                    else
                    {
                        code_labels[j] = array2[j];
                        nums[j] = 0;
                    }
                }
                string[] str_codes = new string[codes.Length];
                for (int i = 0; i < codes.Length; i++)
                {
                    str_codes[i] = codes[i].ToString();

                }

                // Cut(ref array2, num + 4, array.Length - num - 4);
                string[] cod = new string[tmp.Length];
                for (int i = 0; i < tmp.Length; i++)
                {
                    cod[i] = tmp[i];
                }
                /*for (int j = 0; j<tmp.Length; j++)
                {
                    if (tmp[j] == "24")
                    {
                        tmp[j] =  "G2()"+ code_labels[j];
                    }
                    
                    //if (j == 2)
                }*/




                string[] s1 = new string[tmp.Length - 1];

                int[] s100 = new int[33];
                for (int i = 0; i < s100.Length; i++)
                {
                    s100[i] = i + 1;
                }

                if (tmp.Length == 2 && tmp[1] == "0")
                {
                    for (int i = 0; i < s1.Length; i++)
                    {
                        s1[i] = tmp[i];
                    }
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (s1[j] == "24")
                        {
                            s1[j] = "G2(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "25")
                        {
                            s1[j] = "G3(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "26")
                        {
                            s1[j] = "G4(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "40")
                        {
                            s1[j] = "L(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "137")
                        {
                            s1[j] = "G5(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "139")
                        {
                            s1[j] = "G0(" + code_labels[j] + ")";
                        }
                        if (s1[j] == "140")
                        {
                            s1[j] = "G1(" + code_labels[j] + ")";
                        }


                        ////
                        if (s1[j] == "1")
                        {
                            s1[j] = "\\";
                        }
                        if (s1[j] == "2")
                        {
                            s1[j] = ">";
                        }
                        if (s1[j] == "3")
                        {
                            s1[j] = "<";
                        }
                        if (s1[j] == "4")
                        {
                            s1[j] = "W";
                        }
                        if (s1[j] == "5")
                        {
                            s1[j] = "A";
                        }
                        if (s1[j] == "6")
                        {
                            s1[j] = "S";
                        }
                        if (s1[j] == "7")
                        {
                            s1[j] = "D";
                        }
                        if (s1[j] == "8")
                        {
                            s1[j] = "Z0";
                        }
                        if (s1[j] == "9")
                        {
                            s1[j] = "w";
                        }
                        if (s1[j] == "10")
                        {
                            s1[j] = "a";
                        }
                        if (s1[j] == "11")
                        {
                            s1[j] = "s";
                        }
                        if (s1[j] == "12")
                        {
                            s1[j] = "d";
                        }
                        if (s1[j] == "13")
                        {
                            //???
                        }
                        if (s1[j] == "14")
                        {
                            s1[j] = "Z2";
                        }
                        if (s1[j] == "15")
                        {
                            s1[j] = "Z3";
                        }
                        if (s1[j] == "16")
                        {
                            s1[j] = "Z4";
                        }
                        if (s1[j] == "17")
                        {
                            s1[j] = "Zc";
                        }
                        if (s1[j] == "18")
                        {
                            s1[j] = "Ze";
                        }
                        if (s1[j] == "19")
                        {
                            s1[j] = "Zd";
                        }
                        if (s1[j] == "20")
                        {
                            s1[j] = "Zf";
                        }
                        if (s1[j] == "21")
                        {
                            s1[j] = "Zg";
                        }
                        if (s1[j] == "22")
                        {
                            s1[j] = "Zq";
                        }
                        if (s1[j] == "23")
                        {
                            s1[j] = "Zh";
                        }
                        if (s1[j] == "27")
                        {
                            s1[j] = "R0";
                        }
                        if (s1[j] == "28")
                        {
                            s1[j] = "R1";
                        }
                        if (s1[j] == "138")
                        {
                            s1[j] = "R2";
                        }
                        if (s1[j] == "29")
                        {
                            s1[j] = "C0";
                        }
                        if (s1[j] == "30")
                        {
                            s1[j] = "C8";
                        }
                        if (s1[j] == "31")
                        {
                            s1[j] = "C1";
                        }
                        if (s1[j] == "32")
                        {
                            s1[j] = "C2";
                        }
                        if (s1[j] == "33")
                        {
                            s1[j] = "C3";
                        }
                        if (s1[j] == "35")
                        {
                            s1[j] = "C5";
                        }
                        if (s1[j] == "36")
                        {
                            s1[j] = "C6";
                        }
                        if (s1[j] == "37")
                        {
                            s1[j] = "C7";
                        }
                        if (s1[j] == "38")
                        {
                            s1[j] = "M0";
                        }
                        if (s1[j] == "39")
                        {
                            s1[j] = "M1";
                        }
                        if (s1[j] == "43")
                        {
                            s1[j] = "c0";
                        }
                        if (s1[j] == "44")
                        {
                            s1[j] = "c1";
                        }
                        if (s1[j] == "45")
                        {
                            s1[j] = "c2";
                        }
                        if (s1[j] == "46")
                        {
                            s1[j] = "ck";
                        }
                        if (s1[j] == "47")
                        {
                            s1[j] = "cl";
                        }
                        if (s1[j] == "48")
                        {
                            s1[j] = "cj";
                        }
                        if (s1[j] == "49")
                        {
                            s1[j] = "cd";
                        }
                        if (s1[j] == "50")
                        {
                            s1[j] = "cm";
                        }
                        if (s1[j] == "51")
                        {
                            s1[j] = "cn";
                        }
                        if (s1[j] == "52")
                        {
                            s1[j] = "cv";
                        }
                        if (s1[j] == "53")
                        {
                            s1[j] = "ca";
                        }
                        if (s1[j] == "54")
                        {
                            s1[j] = "ci";
                        }
                        if (s1[j] == "57")
                        {
                            s1[j] = "ce";
                        }
                        if (s1[j] == "58")
                        {
                            s1[j] = "cf";
                        }
                        if (s1[j] == "59")
                        {
                            s1[j] = "cg";
                        }
                        if (s1[j] == "60")
                        {
                            s1[j] = "ch";
                        }
                        if (s1[j] == "74")
                        {
                            s1[j] = "ct";
                        }
                        if (s1[j] == "76")
                        {
                            s1[j] = "cu";
                        }
                        if (s1[j] == "77")
                        {
                            s1[j] = "cs";
                        }
                        if (s1[j] == "162")
                        {
                            s1[j] = "B1";
                        }
                        if (s1[j] == "163")
                        {
                            s1[j] = "B3";
                        }
                        if (s1[j] == "164")
                        {
                            s1[j] = "B2";
                        }
                        if (s1[j] == "165")
                        {
                            s1[j] = "VB";
                        }
                        if (s1[j] == "131")
                        {
                            s1[j] = "C9";
                        }
                        if (s1[j] == "132")
                        {
                            s1[j] = "Ca";
                        }
                        if (s1[j] == "133")
                        {
                            s1[j] = "Cb";
                        }
                        if (s1[j] == "134")
                        {
                            s1[j] = "Cc";
                        }
                        if (s1[j] == "135")
                        {
                            s1[j] = "Cd";
                        }
                        if (s1[j] == "136")
                        {
                            s1[j] = "Ce";
                        }
                        if (s1[j] == "158")
                        {
                            s1[j] = "Qig+";
                        }
                        if (s1[j] == "159")
                        {
                            s1[j] = "Qig-";
                        }
                        if (s1[j] == "160")
                        {
                            s1[j] = "gr+";
                        }
                        if (s1[j] == "161")
                        {
                            s1[j] = "gr-";
                        }
                        if (s1[j] == "120")
                        {
                            s1[j] = "VLes(" + code_labels[j] + "@" + nums[j] + ")";//s1[j] = "VLes(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (s1[j] == "119")
                        {
                            s1[j] = "VMore(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (s1[j] == "123")
                        {
                            s1[j] = "VEqua(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (s1[j] == "141")
                        {
                            s1[j] = "iggS";
                        }
                        if (s1[j] == "142")
                        {
                            s1[j] = "Build";
                        }
                        if (s1[j] == "143")
                        {
                            s1[j] = "Hea";
                        }
                        if (s1[j] == "145")
                        {
                            s1[j] = "MineS";
                        }
                        if (s1[j] == "156")
                        {
                            s1[j] = "CLeftH";
                        }
                        if (s1[j] == "157")
                        {
                            s1[j] = "CRightH";
                        }

                        if (s1[j] == "146")
                        {
                            s1[j] = "CGun";
                        }
                        if (s1[j] == "147")
                        {
                            s1[j] = "FGun";
                        }
                        if (s1[j] == "148")
                        {
                            s1[j] = "hpf";
                        }
                        if (s1[j] == "149")
                        {
                            s1[j] = "hpp";
                        }
                        if (s1[j] == "144")
                        {
                            s1[j] = "Flip";
                        }



                        ////
                        //if (j == 2)
                    }

                    richTextBox2.Text = string.Join(" ", s1);
                }
                else
                {
                    for (int i = 0; i < tmp.Length; i++)
                    {

                    }



                    for (int j = 0; j < tmp.Length; j++)
                    {
                        if (tmp[j] == "24")
                        {
                            tmp[j] = "G2(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "25")
                        {
                            tmp[j] = "G3(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "26")
                        {
                            tmp[j] = "G4(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "40")
                        {
                            tmp[j] = "L(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "137")
                        {
                            tmp[j] = "G5(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "139")
                        {
                            tmp[j] = "G0(" + code_labels[j] + ")";
                        }
                        if (tmp[j] == "140")
                        {
                            tmp[j] = "G1(" + code_labels[j] + ")";
                        }


                        ////
                        if (tmp[j] == "1")
                        {
                            tmp[j] = "\\";
                        }
                        if (tmp[j] == "2")
                        {
                            tmp[j] = ">";
                        }
                        if (tmp[j] == "3")
                        {
                            tmp[j] = "<";
                        }
                        if (tmp[j] == "4")
                        {
                            tmp[j] = "W";
                        }
                        if (tmp[j] == "5")
                        {
                            tmp[j] = "A";
                        }
                        if (tmp[j] == "6")
                        {
                            tmp[j] = "S";
                        }
                        if (tmp[j] == "7")
                        {
                            tmp[j] = "D";
                        }
                        if (tmp[j] == "8")
                        {
                            tmp[j] = "Z0";
                        }
                        if (tmp[j] == "9")
                        {
                            tmp[j] = "w";
                        }
                        if (tmp[j] == "10")
                        {
                            tmp[j] = "a";
                        }
                        if (tmp[j] == "11")
                        {
                            tmp[j] = "s";
                        }
                        if (tmp[j] == "12")
                        {
                            tmp[j] = "d";
                        }
                        if (tmp[j] == "13")
                        {

                        }
                        if (tmp[j] == "14")
                        {
                            tmp[j] = "Z2";
                        }
                        if (tmp[j] == "15")
                        {
                            tmp[j] = "Z3";
                        }
                        if (tmp[j] == "16")
                        {
                            tmp[j] = "Z4";
                        }
                        if (tmp[j] == "17")
                        {
                            tmp[j] = "Zc";
                        }
                        if (tmp[j] == "18")
                        {
                            tmp[j] = "Ze";
                        }
                        if (tmp[j] == "19")
                        {
                            tmp[j] = "Zd";
                        }
                        if (tmp[j] == "20")
                        {
                            tmp[j] = "Zf";
                        }
                        if (tmp[j] == "21")
                        {
                            tmp[j] = "Zg";
                        }
                        if (tmp[j] == "22")
                        {
                            tmp[j] = "Zq";
                        }
                        if (tmp[j] == "23")
                        {
                            tmp[j] = "Zh";
                        }

                        if (tmp[j] == "27")
                        {
                            tmp[j] = "R0";
                        }
                        if (tmp[j] == "28")
                        {
                            tmp[j] = "R1";
                        }
                        if (tmp[j] == "138")
                        {
                            tmp[j] = "R2";
                        }
                        if (tmp[j] == "29")
                        {
                            tmp[j] = "C0";
                        }
                        if (tmp[j] == "30")
                        {
                            tmp[j] = "C8";
                        }
                        if (tmp[j] == "31")
                        {
                            tmp[j] = "C1";
                        }
                        if (tmp[j] == "32")
                        {
                            tmp[j] = "C2";
                        }
                        if (tmp[j] == "33")
                        {
                            tmp[j] = "C3";
                        }
                        if (tmp[j] == "35")
                        {
                            tmp[j] = "C5";
                        }
                        if (tmp[j] == "36")
                        {
                            tmp[j] = "C6";
                        }
                        if (tmp[j] == "37")
                        {
                            tmp[j] = "C7";
                        }
                        if (tmp[j] == "38")
                        {
                            tmp[j] = "M0";
                        }
                        if (tmp[j] == "39")
                        {
                            tmp[j] = "M1";
                        }
                        if (tmp[j] == "43")
                        {
                            tmp[j] = "c0";
                        }
                        if (tmp[j] == "44")
                        {
                            tmp[j] = "c1";
                        }
                        if (tmp[j] == "45")
                        {
                            tmp[j] = "c2";
                        }


                        if (tmp[j] == "46")
                        {
                            tmp[j] = "ck";
                        }
                        if (tmp[j] == "47")
                        {
                            tmp[j] = "cl";
                        }
                        if (tmp[j] == "48")
                        {
                            tmp[j] = "cj";
                        }
                        if (tmp[j] == "49")
                        {
                            tmp[j] = "cd";
                        }
                        if (tmp[j] == "50")
                        {
                            tmp[j] = "cm";
                        }
                        if (tmp[j] == "51")
                        {
                            tmp[j] = "cn";
                        }
                        if (tmp[j] == "52")
                        {
                            tmp[j] = "cv";
                        }
                        if (tmp[j] == "53")
                        {
                            tmp[j] = "ca";
                        }
                        if (tmp[j] == "54")
                        {
                            tmp[j] = "ci";
                        }
                        if (tmp[j] == "57")
                        {
                            tmp[j] = "ce";
                        }
                        if (tmp[j] == "58")
                        {
                            tmp[j] = "cf";
                        }
                        if (tmp[j] == "59")
                        {
                            tmp[j] = "cg";
                        }
                        if (tmp[j] == "60")
                        {
                            tmp[j] = "ch";
                        }
                        if (tmp[j] == "74")
                        {
                            tmp[j] = "ct";
                        }
                        if (tmp[j] == "76")
                        {
                            tmp[j] = "cu";
                        }
                        if (tmp[j] == "77")
                        {
                            tmp[j] = "cs";
                        }
                        if (tmp[j] == "162")
                        {
                            tmp[j] = "B1";
                        }
                        if (tmp[j] == "163")
                        {
                            tmp[j] = "B3";
                        }
                        if (tmp[j] == "164")
                        {
                            tmp[j] = "B2";
                        }
                        if (tmp[j] == "165")
                        {
                            tmp[j] = "VB";
                        }
                        if (tmp[j] == "131")
                        {
                            tmp[j] = "C9";
                        }
                        if (tmp[j] == "132")
                        {
                            tmp[j] = "Ca";
                        }
                        if (tmp[j] == "133")
                        {
                            tmp[j] = "Cb";
                        }
                        if (tmp[j] == "134")
                        {
                            tmp[j] = "Cc";
                        }
                        if (tmp[j] == "135")
                        {
                            tmp[j] = "Cd";
                        }
                        if (tmp[j] == "136")
                        {
                            tmp[j] = "Ce";
                        }
                        if (tmp[j] == "158")
                        {
                            tmp[j] = "Qig+";
                        }
                        if (tmp[j] == "159")
                        {
                            tmp[j] = "Qig-";
                        }
                        if (tmp[j] == "160")
                        {
                            tmp[j] = "gr+";
                        }
                        if (tmp[j] == "161")
                        {
                            tmp[j] = "gr-";
                        }
                        if (tmp[j] == "120")
                        {
                            tmp[j] = "VLes(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (tmp[j] == "119")
                        {
                            tmp[j] = "VMore(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (tmp[j] == "123")
                        {
                            tmp[j] = "VEqua(" + code_labels[j] + "@" + nums[j] + ")";
                        }
                        if (tmp[j] == "141")
                        {
                            tmp[j] = "iggS";
                        }
                        if (tmp[j] == "142")
                        {
                            tmp[j] = "Build";
                        }
                        if (tmp[j] == "143")
                        {
                            tmp[j] = "Hea";
                        }
                        if (tmp[j] == "145")
                        {
                            tmp[j] = "MineS";
                        }
                        if (tmp[j] == "156")
                        {
                            tmp[j] = "CRightH";
                        }
                        if (tmp[j] == "157")
                        {
                            tmp[j] = "CLeftH";
                        }

                        if (tmp[j] == "146")
                        {
                            tmp[j] = "CGun";
                        }
                        if (tmp[j] == "147")
                        {
                            tmp[j] = "FGun";
                        }
                        if (tmp[j] == "148")
                        {
                            tmp[j] = "hpf";
                        }
                        if (tmp[j] == "149")
                        {
                            tmp[j] = "hpp";
                        }
                        if (tmp[j] == "144")
                        {
                            tmp[j] = "Flip";
                        }
                        if (tmp[j] == "0")
                        {
                            tmp[j] = "-";
                        }



                        ////

                        //if (j == 2)
                    }



                    string text;
                    int[] numbers = new int[16 * 12 * 16];
                    int s2 = 0;
                    text = string.Join("", tmp);
                    int length, maxLength = 0;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (tmp[i] == "-")//&& s2<number.Length)
                        {
                            length = 0;
                            for (int j = i; j < tmp.Length && tmp[j] == "-"; j++)
                            {
                                length++;

                            }
                            i += length;
                            if (length > maxLength) maxLength = length;
                            number[s2] = length;
                            s2++;



                        }


                    }
                    int[] tmp2 = new int[s2];
                    for (int i = 0; i < number.Length; i++)
                    {

                        if (i < tmp2.Length)
                        {
                            tmp2[i] = number[i];
                        }


                    }
                    int RS = 0;
                    for (int i = 0; i < tmp2.Length; i++)
                    {
                        RS = RS + tmp2[i];//-s2+1;
                    }
                    int[] g2s = new int[s2];

                    int g3 = 0;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (i == 0)
                        {
                            if (tmp[i] == "-")
                            {
                                g2s[g3] = i;
                                g3++;
                            }
                        }
                        if (i > 0)
                        {
                            if (tmp[i] == "-" && tmp[i - 1] != "-")
                            {
                                g2s[g3] = i;
                                g3++;
                            }
                        }



                    }
                    int g4 = 0; int g5 = 0; int g6 = 0; int g7 = 0;
                    string[] tmp3 = new string[tmp.Length - RS];
                    //for (int i = 0; i<g2s.Length; i++)
                    //{
                    string[] tmp6 = new string[tmp2.Length];
                    for (int i = 0; i < tmp2.Length; i++)
                    {
                        tmp6[i] = tmp2[i].ToString();
                    }

                    for (int i = 0; i < tmp6.Length; i++)
                    {
                        for (int j = 10; j < tx3.Length; j++)
                        {
                            if (tmp6[i] == (j+1).ToString())
                            {
                                tmp6[i] = tx3[j];
                            }
                        }
                        
                        if (tmp6[i] == "10"){
                            tmp6[i] = "a";
                        }
                        
                        ////
                    }

                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (g4 < g2s.Length)
                        {
                            if (tmp2[g4] != 1)
                            {
                                if (tmp2[g4] < 91)
                                    //tmp[g2s[g4]] = "-" + tmp2[g4];
                                    tmp[g2s[g4]] = "-" + tmp6[g4];
                                ////tmp = Delete(tmp, g2s[g4+1]);
                                if (tmp2[g4] >= 91 && tmp2[g4] < 910)
                                    tmp[g2s[g4]] = "=" + tmp6[g4];
                                if (tmp2[g4] >= 910)
                                    tmp[g2s[g4]] = "~" + tmp6[g4];

                            }
                            else tmp[g2s[g4]] = "_";//+ tmp2[g4];
                            g4++;
                        }



                        /*for(int j = 0; j<tmp3.Length; j++)
                        {
                            if (g4 < g2s.Length)
                            {
                                if (i != g2s[g4]&&i<tmp.Length)
                                {
                                    tmp3[j] = tmp[i];
                                    
                                }
                                else
                                {
                                    j += tmp2[g5];
                                    g5++;
                                }
                                i++;
                            }*/


                    }
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        if (g5 < g2s.Length)//&&g6<g2s[g5])
                        {
                            for (int j = 0; j < tmp2[g7] - 1; j++)
                            {
                                if (tmp2[g5] != 1)
                                {
                                    tmp = Delete(tmp, g2s[g5] - g6 + 1 + j);
                                    g6++;
                                }
                                else tmp[g2s[g5]] = "_";

                            }
                            g7++;
                        }
                        g5++;
                    }
                    // }
                    richTextBox2.Text = string.Join("", tmp);
                    /*char[] str = text.ToCharArray();
                   // string text1;

                    for (int i = 0; i <= str.Length; i++)
                    {
                        if (i != str.Length - 1)
                        {
                            if (str[i] != str[i + 1])
                            {
                                Console.Write(str[i]);
                            }
                        }
                        else
                        {
                            Console.Write(str[i]);
                        }
                    }*/





                    // richTextBox1.Text = string.Join("", number);
                }
            }

            //
            //richTextBox2.Text = textBox1.Text;
        }
        private void button9_Click(object sender, EventArgs e)// конвертация в новый код
        {
            string[] tx2 = new string[3071];
            massiv(tx2);

            

            /////
            string tx1 = ""; int xx = 0; int yy = 3072;

            for (int i = 0; i < 3073; i++)
            {
                if (i > xx && i < yy)
                {
                    //tx1 = tx1 + "if (tmp6[i] == " + "\"" + i.ToString() + "\"" +")" + "\n" + "tmp6[i] =" + "\"" + tx2[i - 1] + "\"" + ";" + "\n";
                    // tx1 = "if (tmp6[i] == " + "\"10\"";
                    //richTextBox1.Text = String.Join(";", tx1);
                    tx1 = tx1 + "text.Replace("+"\""+ tx2[i - 1]+"\""+", "+"\"" + tx2[i - 1] + ","+"\"" +");"+ "\n";
                    //tx1 = tx1 + ", " + "\"" + tx2[i - 1] + "\"";
                    // tx1 = "if (tmp6[i] == " + "\"10\"";
                    //tx1 = tx1 + "if (codes_text[i] == " + "\"" + tx2[i - 1] + "\"" + ")" + "\n" + "{" + "\n" + "      codes[z0] = 0;" + "\n" + "      z0  += " + i.ToString() + ";" + "\n" + "      g1[z1] = z0;" + "\n" + "      z1++;" + "\n" + "}" + "\n";
                    //tx1 = tx1 + "if (codes_text[i] == " + "\"" + tx2[i - 1] + "\"" + ")" + "\n" + "{" + "\n" + "      z3 +="+ i.ToString()+";"+"\n"+ "      codes_text = Delete(codes_text, i );"+"\n" + "}"+"\n";


                }

            }
            //richTextBox3.Text = textBox2.Text;
            string text;
            int[] nums = new int[16 * 12 * 16];
            string[] numsstring = new string[16 * 12 * 16];
            int[] codes = new int[16 * 12 * 16];
            string[] codes_text = new string[16 * 12 * 16];
            string[] codes_text2 = new string[16 * 12 * 16];
            string[] codes_text3 = new string[16 * 12 * 16];
            string[] codes_t = new string[16 * 12 * 16];
            string[] code_labels = new string[16 * 12 * 16];
            int num = 0;
            int num2 = 0;
            int test = 0;
            int lol = 0;
            string[] test2 = new string[16 * 12 * 16];
            string[] itog = new string[16 * 12 * 16];
            int[] newStr = new int[16 * 12 * 16];
            string[] newStr2 = new string[16 * 12 * 16];
            string[] newStr3 = new string[2];
            string[] t1 = new string[16 * 12 * 16];
            string[] t2 = new string[16 * 12 * 16];
            int[] g3 = new int[16 * 12 * 16];


            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    for (int k = 0; k < 16; k++)
                    {
                        codes[i * 16 * 12 + j * 16 + k] = 0;
                        nums[i * 16 * 12 + j * 16 + k] = 0;
                        numsstring[i * 16 * 12 + j * 16 + k] = "0";
                        code_labels[i * 16 * 12 + j * 16 + k] = "0";
                        codes_text[i * 16 * 12 + j * 16 + k] = "0";
                        codes_text2[i * 16 * 12 + j * 16 + k] = "0";
                        codes_text3[i * 16 * 12 + j * 16 + k] = "0";
                        codes_t[i * 16 * 12 + j * 16 + k] = "0";
                        test2[i * 16 * 12 + j * 16 + k] = "Z0";
                        itog[i * 16 * 12 + j * 16 + k] = "0";
                        newStr[i * 16 * 12 + j * 16 + k] = -1;
                        newStr2[i * 16 * 12 + j * 16 + k] = "0";
                        t1[i * 16 * 12 + j * 16 + k] = "-1";
                        t2[i * 16 * 12 + j * 16 + k] = "-1";
                        g3[i * 16 * 12 + j * 16 + k] = -1;
                    }
                }
            }


            text = textBox2.Text;
           // richTextBox3.Text = string.Join(";", text);
            if (text.Trim() != "")
            {
                //text = text.Replace("->", "->,");
                //text = text.Replace("-U", "-U,");
                /*
                text = text.Replace("S", "S,");
                text = text.Replace("W", "W,");
                text = text.Replace("Z0", "Z0,");
                text = text.Replace("G2", "G2,");
                // text = text.Replace("D", "D,");
                //text = text.Replace("\\", "\\,");
                text = text.Replace(">", ">,");
                text = text.Replace("<", "<,");
                text = text.Replace("Zc", "Zc,");
                text = text.Replace("Zg", "Zg,");
                text = text.Replace("Zd", "Zd,");
                text = text.Replace("c0", "c0,");
                text = text.Replace("c1", "c1,");
                text = text.Replace("cf", "cf,");
                text = text.Replace("ca", "ca,");
                text = text.Replace("cv", "cv,");
                text = text.Replace("ce", "ce,");
                text = text.Replace("cu", "cu,");
                text = text.Replace("cg", "cg,");
                text = text.Replace(")", ",)");
                text = text.Replace("}", ",}");
                text = text.Replace("_", "_,");
                text = text.Replace("HealS", "HealS,");
                /*
                 * 
                 */
                
               // text = text.Replace("_", "_,");
                text = text.Replace("\\", "\\, ");
                text = text.Replace(">", ">,");
                text = text.Replace("<", "<,");
                text = text.Replace("W", "W,");
                text = text.Replace("A", "A,");
                text = text.Replace("S", "S,");
                text = text.Replace("D", "D,");
                text = text.Replace("Z0", "Z0,");
                text = text.Replace("w", "w,");
                text = text.Replace("a", "a,");
                text = text.Replace("s", "s,");
                text = text.Replace("d", "d,");
                text = text.Replace("Z2", "Z2,");
                text = text.Replace("Z3", "Z3,");
                text = text.Replace("Z4", "Z4,");
                text = text.Replace("Zc", "Zc,");
                text = text.Replace("Ze", "Ze,");
                text = text.Replace("Zd", "Zd,");
                text = text.Replace("Zf", "Zf,");
                text = text.Replace("Zg", "Zg,");
                text = text.Replace("Zq", "Zq,");
                text = text.Replace("Zh", "Zh,");
                text = text.Replace("R0", "R0,");
                text = text.Replace("R1", "R1,");
                text = text.Replace("R2", "R2,");
                text = text.Replace("C0", "C0,");
                text = text.Replace("C8", "C8,");
                text = text.Replace("C1", "C1,");
                text = text.Replace("C2", "C2,");
                text = text.Replace("C3", "C3,");
                text = text.Replace("C5", "C5,");
                text = text.Replace("C6", "C6,");
                text = text.Replace("C7", "C7,");
                text = text.Replace("M0", "M0,");
                text = text.Replace("M1", "M1,");
                text = text.Replace("c0", "c0,");
                text = text.Replace("c1", "c1,");
                text = text.Replace("c2", "c2,");
                text = text.Replace("ck", "ck,");
                text = text.Replace("cl", "cl,");
                text = text.Replace("cj", "cj,");
                text = text.Replace("cd", "cd,");
                text = text.Replace("cm", "cm,");
                text = text.Replace("cn", "cn,");
                text = text.Replace("cv", "cv,");
                text = text.Replace("ca", "ca,");
                text = text.Replace("ci", "ci,");
                text = text.Replace("ce", "ce,");
                text = text.Replace("cf", "cf,");
                text = text.Replace("cg", "cg,");
                text = text.Replace("ch", "ch,");
                text = text.Replace("ct", "ct,");
                text = text.Replace("cu", "cu,");
                text = text.Replace("cs", "cs,");
                text = text.Replace("B1", "B1,");
                text = text.Replace("B3", "B3,");
                text = text.Replace("B2", "B2,");
                text = text.Replace("VB", "VB,");
                text = text.Replace("C9", "C9,");
                text = text.Replace("Ca", "Ca,");
                text = text.Replace("Cb", "Cb,");
                text = text.Replace("Cc", "Cc,");
                text = text.Replace("Cd", "Cd,");
                text = text.Replace("Ce", "Ce,");
                text = text.Replace("Qig+", "Qig+,");
                text = text.Replace("Qig-", "Qig-,");
                text = text.Replace("gr+", "gr+,");
                text = text.Replace("gr-", "gr-,");
                text = text.Replace("iggs", "iggs,");
                text = text.Replace("Build", "Build,");
                text = text.Replace("MineS", "MineS,");
                text = text.Replace("CLeftH", "CLeftH,");
                text = text.Replace("CRightH", "CRightH,");
                text = text.Replace("CGun", "CGun,");
                text = text.Replace("FGun", "FGun,");
                text = text.Replace("hpf", "hpf,");
                text = text.Replace("hpp", "hpp,");
                text = text.Replace("Flip", "Flip,");
                text = text.Replace("Hea", "Hea,");





                ////   
                for (int i = 0; i < tx2.Length; i++)
                    if(i < tx2.Length )
                    text = text.Replace(tx2[i], tx2[i] + ",");

                

                ////

                //text = text.Replace("L()", "L,");
                //string textres = text.Substring(text.IndexOf("L", 0));


                //codes_text = text.Split(',');
                string[] separator = { ",", ")", "(" };
                string[] separator2 = { ",", ")", "L", "(", "G2", "VEqua","VMore","VLes", "G3","G4","G5","G0","G1",/*"->", "-U",*/
                "SHeal", "_", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-a", "-b", "-c", "-d", "-e", "-f", "-g", "-h", "-i", "-j", "-k", "-l", "-m", "-n", "-o", "-p", "-q", "-r", "-s", "-t", "-u", "-v", "-w", "-x", "-y", "-z", "-A", "-B", "-C", "-D", "-E", "-F", "-G", "-H", "-I", "-J", "-K", "-L", "-M", "-N", "-O", "-P", "-Q", "-R", "_", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-a", "-b", "-c", "-d", "-e", "-f", "-g", "-h", "-i", "-j", "-k", "-l", "-m", "-n", "-o", "-p", "-q", "-r", "-s", "-t", "-u", "-v", "-w", "-x", "-y", "-z", "-A", "-B", "-C", "-D", "-E", "-F", "-G", "-H", "-I", "-J", "-K", "-L", "-M", "-N", "-O", "-P", "-Q", "-R", "-S", "-T", "-U", "-V", "-W", "-X", "-Y", "-Z", "- ", "-!", "-@", "-#", "-$", "-%", "-^", "-&", "-*", "-(", "-)", "--", "-_", "-+", "-=", "-[", "-]", "-{", "-}", "-,", "-.", "-<", "->", "-?", "-/", "-;", "-:", "-|", "-~", "=10", "=11", "=12", "=13", "=14", "=15", "=16", "=17", "=18", "=19", "=1a", "=1b", "=1c", "=1d", "=1e", "=1f", "=1g", "=1h", "=1i", "=1j", "=1k", "=1l", "=1m", "=1n", "=1o", "=1p", "=1q", "=1r", "=1s", "=1t", "=1u", "=1v", "=1w", "=1x", "=1y", "=1z", "=1A", "=1B", "=1C", "=1D", "=1E", "=1F", "=1G", "=1H", "=1I", "=1J", "=1K", "=1L", "=1M", "=1N", "=1O", "=1P", "=1Q", "=1R", "=1S", "=1T", "=1U", "=1V", "=1W", "=1X", "=1Y", "=1Z", "=1 ", "=1!", "=1@", "=1#", "=1$", "=1%", "=1^", "=1&", "=1*", "=1(", "=1)", "=1-", "=1_", "=1+", "=1=", "=1[", "=1]", "=1{", "=1}", "=1,", "=1.", "=1<", "=1>", "=1?", "=1/", "=1;", "=1:", "=1|", "=1~", "=20", "=21", "=22", "=23", "=24", "=25", "=26", "=27", "=28", "=29", "=2a", "=2b", "=2c", "=2d", "=2e", "=2f", "=2g", "=2h", "=2i", "=2j", "=2k", "=2l", "=2m", "=2n", "=2o", "=2p", "=2q", "=2r", "=2s", "=2t", "=2u", "=2v", "=2w", "=2x", "=2y", "=2z", "=2A", "=2B", "=2C", "=2D", "=2E", "=2F", "=2G", "=2H", "=2I", "=2J", "=2K", "=2L", "=2M", "=2N", "=2O", "=2P", "=2Q", "=2R", "=2S", "=2T", "=2U", "=2V", "=2W", "=2X", "=2Y", "=2Z", "=2 ", "=2!", "=2@", "=2#", "=2$", "=2%", "=2^", "=2&", "=2*", "=2(", "=2)", "=2-", "=2_", "=2+", "=2=", "=2[", "=2]", "=2{", "=2}", "=2,", "=2.", "=2<", "=2>", "=2?", "=2/", "=2;", "=2:", "=2|", "=2~", "=30", "=31", "=32", "=33", "=34", "=35", "=36", "=37", "=38", "=39", "=3a", "=3b", "=3c", "=3d", "=3e", "=3f", "=3g", "=3h", "=3i", "=3j", "=3k", "=3l", "=3m", "=3n", "=3o", "=3p", "=3q", "=3r", "=3s", "=3t", "=3u", "=3v", "=3w", "=3x", "=3y", "=3z", "=3A", "=3B", "=3C", "=3D", "=3E", "=3F", "=3G", "=3H", "=3I", "=3J", "=3K", "=3L", "=3M", "=3N", "=3O", "=3P", "=3Q", "=3R", "=3S", "=3T", "=3U", "=3V", "=3W", "=3X", "=3Y", "=3Z", "=3 ", "=3!", "=3@", "=3#", "=3$", "=3%", "=3^", "=3&", "=3*", "=3(", "=3)", "=3-", "=3_", "=3+", "=3=", "=3[", "=3]", "=3{", "=3}", "=3,", "=3.", "=3<", "=3>", "=3?", "=3/", "=3;", "=3:", "=3|", "=3~", "=40", "=41", "=42", "=43", "=44", "=45", "=46", "=47", "=48", "=49", "=4a", "=4b", "=4c", "=4d", "=4e", "=4f", "=4g", "=4h", "=4i", "=4j", "=4k", "=4l", "=4m", "=4n", "=4o", "=4p", "=4q", "=4r", "=4s", "=4t", "=4u", "=4v", "=4w", "=4x", "=4y", "=4z", "=4A", "=4B", "=4C", "=4D", "=4E", "=4F", "=4G", "=4H", "=4I", "=4J", "=4K", "=4L", "=4M", "=4N", "=4O", "=4P", "=4Q", "=4R", "=4S", "=4T", "=4U", "=4V", "=4W", "=4X", "=4Y", "=4Z", "=4 ", "=4!", "=4@", "=4#", "=4$", "=4%", "=4^", "=4&", "=4*", "=4(", "=4)", "=4-", "=4_", "=4+", "=4=", "=4[", "=4]", "=4{", "=4}", "=4,", "=4.", "=4<", "=4>", "=4?", "=4/", "=4;", "=4:", "=4|", "=4~", "=50", "=51", "=52", "=53", "=54", "=55", "=56", "=57", "=58", "=59", "=5a", "=5b", "=5c", "=5d", "=5e", "=5f", "=5g", "=5h", "=5i", "=5j", "=5k", "=5l", "=5m", "=5n", "=5o", "=5p", "=5q", "=5r", "=5s", "=5t", "=5u", "=5v", "=5w", "=5x", "=5y", "=5z", "=5A", "=5B", "=5C", "=5D", "=5E", "=5F", "=5G", "=5H", "=5I", "=5J", "=5K", "=5L", "=5M", "=5N", "=5O", "=5P", "=5Q", "=5R", "=5S", "=5T", "=5U", "=5V", "=5W", "=5X", "=5Y", "=5Z", "=5 ", "=5!", "=5@", "=5#", "=5$", "=5%", "=5^", "=5&", "=5*", "=5(", "=5)", "=5-", "=5_", "=5+", "=5=", "=5[", "=5]", "=5{", "=5}", "=5,", "=5.", "=5<", "=5>", "=5?", "=5/", "=5;", "=5:", "=5|", "=5~", "=60", "=61", "=62", "=63", "=64", "=65", "=66", "=67", "=68", "=69", "=6a", "=6b", "=6c", "=6d", "=6e", "=6f", "=6g", "=6h", "=6i", "=6j", "=6k", "=6l", "=6m", "=6n", "=6o", "=6p", "=6q", "=6r", "=6s", "=6t", "=6u", "=6v", "=6w", "=6x", "=6y", "=6z", "=6A", "=6B", "=6C", "=6D", "=6E", "=6F", "=6G", "=6H", "=6I", "=6J", "=6K", "=6L", "=6M", "=6N", "=6O", "=6P", "=6Q", "=6R", "=6S", "=6T", "=6U", "=6V", "=6W", "=6X", "=6Y", "=6Z", "=6 ", "=6!", "=6@", "=6#", "=6$", "=6%", "=6^", "=6&", "=6*", "=6(", "=6)", "=6-", "=6_", "=6+", "=6=", "=6[", "=6]", "=6{", "=6}", "=6,", "=6.", "=6<", "=6>", "=6?", "=6/", "=6;", "=6:", "=6|", "=6~", "=70", "=71", "=72", "=73", "=74", "=75", "=76", "=77", "=78", "=79", "=7a", "=7b", "=7c", "=7d", "=7e", "=7f", "=7g", "=7h", "=7i", "=7j", "=7k", "=7l", "=7m", "=7n", "=7o", "=7p", "=7q", "=7r", "=7s", "=7t", "=7u", "=7v", "=7w", "=7x", "=7y", "=7z", "=7A", "=7B", "=7C", "=7D", "=7E", "=7F", "=7G", "=7H", "=7I", "=7J", "=7K", "=7L", "=7M", "=7N", "=7O", "=7P", "=7Q", "=7R", "=7S", "=7T", "=7U", "=7V", "=7W", "=7X", "=7Y", "=7Z", "=7 ", "=7!", "=7@", "=7#", "=7$", "=7%", "=7^", "=7&", "=7*", "=7(", "=7)", "=7-", "=7_", "=7+", "=7=", "=7[", "=7]", "=7{", "=7}", "=7,", "=7.", "=7<", "=7>", "=7?", "=7/", "=7;", "=7:", "=7|", "=7~", "=80", "=81", "=82", "=83", "=84", "=85", "=86", "=87", "=88", "=89", "=8a", "=8b", "=8c", "=8d", "=8e", "=8f", "=8g", "=8h", "=8i", "=8j", "=8k", "=8l", "=8m", "=8n", "=8o", "=8p", "=8q", "=8r", "=8s", "=8t", "=8u", "=8v", "=8w", "=8x", "=8y", "=8z", "=8A", "=8B", "=8C", "=8D", "=8E", "=8F", "=8G", "=8H", "=8I", "=8J", "=8K", "=8L", "=8M", "=8N", "=8O", "=8P", "=8Q", "=8R", "=8S", "=8T", "=8U", "=8V", "=8W", "=8X", "=8Y", "=8Z", "=8 ", "=8!", "=8@", "=8#", "=8$", "=8%", "=8^", "=8&", "=8*", "=8(", "=8)", "=8-", "=8_", "=8+", "=8=", "=8[", "=8]", "=8{", "=8}", "=8,", "=8.", "=8<", "=8>", "=8?", "=8/", "=8;", "=8:", "=8|", "=8~", "=90", "=91", "=92", "=93", "=94", "=95", "=96", "=97", "=98", "=99", "=9a", "=9b", "=9c", "=9d", "=9e", "=9f", "=9g", "=9h", "=9i", "=9j", "=9k", "=9l", "=9m", "=9n", "=9o", "=9p", "=9q", "=9r", "=9s", "=9t", "=9u", "=9v", "=9w", "=9x", "=9y", "=9z", "=9A", "=9B", "=9C", "=9D", "=9E", "=9F", "=9G", "=9H", "=9I", "=9J", "=9K", "=9L", "=9M", "=9N", "=9O", "=9P", "=9Q", "=9R", "=9S", "=9T", "=9U", "=9V", "=9W", "=9X", "=9Y", "=9Z", "=9 ", "=9!", "=9@", "=9#", "=9$", "=9%", "=9^", "=9&", "=9*", "=9(", "=9)", "=9-", "=9_", "=9+", "=9=", "=9[", "=9]", "=9{", "=9}", "=9,", "=9.", "=9<", "=9>", "=9?", "=9/", "=9;", "=9:", "=9|", "=9~", "~100", "~101", "~102", "~103", "~104", "~105", "~106", "~107", "~108", "~109", "~10a", "~10b", "~10c", "~10d", "~10e", "~10f", "~10g", "~10h", "~10i", "~10j", "~10k", "~10l", "~10m", "~10n", "~10o", "~10p", "~10q", "~10r", "~10s", "~10t", "~10u", "~10v", "~10w", "~10x", "~10y", "~10z", "~10A", "~10B", "~10C", "~10D", "~10E", "~10F", "~10G", "~10H", "~10I", "~10J", "~10K", "~10L", "~10M", "~10N", "~10O", "~10P", "~10Q", "~10R", "~10S", "~10T", "~10U", "~10V", "~10W", "~10X", "~10Y", "~10Z", "~10 ", "~10!", "~10@", "~10#", "~10$", "~10%", "~10^", "~10&", "~10*", "~10(", "~10)", "~10-", "~10_", "~10+", "~10=", "~10[", "~10]", "~10{", "~10}", "~10,", "~10.", "~10<", "~10>", "~10?", "~10/", "~10;", "~10:", "~10|", "~10~", "~110", "~111", "~112", "~113", "~114", "~115", "~116", "~117", "~118", "~119", "~11a", "~11b", "~11c", "~11d", "~11e", "~11f", "~11g", "~11h", "~11i", "~11j", "~11k", "~11l", "~11m", "~11n", "~11o", "~11p", "~11q", "~11r", "~11s", "~11t", "~11u", "~11v", "~11w", "~11x", "~11y", "~11z", "~11A", "~11B", "~11C", "~11D", "~11E", "~11F", "~11G", "~11H", "~11I", "~11J", "~11K", "~11L", "~11M", "~11N", "~11O", "~11P", "~11Q", "~11R", "~11S", "~11T", "~11U", "~11V", "~11W", "~11X", "~11Y", "~11Z", "~11 ", "~11!", "~11@", "~11#", "~11$", "~11%", "~11^", "~11&", "~11*", "~11(", "~11)", "~11-", "~11_", "~11+", "~11=", "~11[", "~11]", "~11{", "~11}", "~11,", "~11.", "~11<", "~11>", "~11?", "~11/", "~11;", "~11:", "~11|", "~11~", "~120", "~121", "~122", "~123", "~124", "~125", "~126", "~127", "~128", "~129", "~12a", "~12b", "~12c", "~12d", "~12e", "~12f", "~12g", "~12h", "~12i", "~12j", "~12k", "~12l", "~12m", "~12n", "~12o", "~12p", "~12q", "~12r", "~12s", "~12t", "~12u", "~12v", "~12w", "~12x", "~12y", "~12z", "~12A", "~12B", "~12C", "~12D", "~12E", "~12F", "~12G", "~12H", "~12I", "~12J", "~12K", "~12L", "~12M", "~12N", "~12O", "~12P", "~12Q", "~12R", "~12S", "~12T", "~12U", "~12V", "~12W", "~12X", "~12Y", "~12Z", "~12 ", "~12!", "~12@", "~12#", "~12$", "~12%", "~12^", "~12&", "~12*", "~12(", "~12)", "~12-", "~12_", "~12+", "~12=", "~12[", "~12]", "~12{", "~12}", "~12,", "~12.", "~12<", "~12>", "~12?", "~12/", "~12;", "~12:", "~12|", "~12~", "~130", "~131", "~132", "~133", "~134", "~135", "~136", "~137", "~138", "~139", "~13a", "~13b", "~13c", "~13d", "~13e", "~13f", "~13g", "~13h", "~13i", "~13j", "~13k", "~13l", "~13m", "~13n", "~13o", "~13p", "~13q", "~13r", "~13s", "~13t", "~13u", "~13v", "~13w", "~13x", "~13y", "~13z", "~13A", "~13B", "~13C", "~13D", "~13E", "~13F", "~13G", "~13H", "~13I", "~13J", "~13K", "~13L", "~13M", "~13N", "~13O", "~13P", "~13Q", "~13R", "~13S", "~13T", "~13U", "~13V", "~13W", "~13X", "~13Y", "~13Z", "~13 ", "~13!", "~13@", "~13#", "~13$", "~13%", "~13^", "~13&", "~13*", "~13(", "~13)", "~13-", "~13_", "~13+", "~13=", "~13[", "~13]", "~13{", "~13}", "~13,", "~13.", "~13<", "~13>", "~13?", "~13/", "~13;", "~13:", "~13|", "~13~", "~140", "~141", "~142", "~143", "~144", "~145", "~146", "~147", "~148", "~149", "~14a", "~14b", "~14c", "~14d", "~14e", "~14f", "~14g", "~14h", "~14i", "~14j", "~14k", "~14l", "~14m", "~14n", "~14o", "~14p", "~14q", "~14r", "~14s", "~14t", "~14u", "~14v", "~14w", "~14x", "~14y", "~14z", "~14A", "~14B", "~14C", "~14D", "~14E", "~14F", "~14G", "~14H", "~14I", "~14J", "~14K", "~14L", "~14M", "~14N", "~14O", "~14P", "~14Q", "~14R", "~14S", "~14T", "~14U", "~14V", "~14W", "~14X", "~14Y", "~14Z", "~14 ", "~14!", "~14@", "~14#", "~14$", "~14%", "~14^", "~14&", "~14*", "~14(", "~14)", "~14-", "~14_", "~14+", "~14=", "~14[", "~14]", "~14{", "~14}", "~14,", "~14.", "~14<", "~14>", "~14?", "~14/", "~14;", "~14:", "~14|", "~14~", "~150", "~151", "~152", "~153", "~154", "~155", "~156", "~157", "~158", "~159", "~15a", "~15b", "~15c", "~15d", "~15e", "~15f", "~15g", "~15h", "~15i", "~15j", "~15k", "~15l", "~15m", "~15n", "~15o", "~15p", "~15q", "~15r", "~15s", "~15t", "~15u", "~15v", "~15w", "~15x", "~15y", "~15z", "~15A", "~15B", "~15C", "~15D", "~15E", "~15F", "~15G", "~15H", "~15I", "~15J", "~15K", "~15L", "~15M", "~15N", "~15O", "~15P", "~15Q", "~15R", "~15S", "~15T", "~15U", "~15V", "~15W", "~15X", "~15Y", "~15Z", "~15 ", "~15!", "~15@", "~15#", "~15$", "~15%", "~15^", "~15&", "~15*", "~15(", "~15)", "~15-", "~15_", "~15+", "~15=", "~15[", "~15]", "~15{", "~15}", "~15,", "~15.", "~15<", "~15>", "~15?", "~15/", "~15;", "~15:", "~15|", "~15~", "~160", "~161", "~162", "~163", "~164", "~165", "~166", "~167", "~168", "~169", "~16a", "~16b", "~16c", "~16d", "~16e", "~16f", "~16g", "~16h", "~16i", "~16j", "~16k", "~16l", "~16m", "~16n", "~16o", "~16p", "~16q", "~16r", "~16s", "~16t", "~16u", "~16v", "~16w", "~16x", "~16y", "~16z", "~16A", "~16B", "~16C", "~16D", "~16E", "~16F", "~16G", "~16H", "~16I", "~16J", "~16K", "~16L", "~16M", "~16N", "~16O", "~16P", "~16Q", "~16R", "~16S", "~16T", "~16U", "~16V", "~16W", "~16X", "~16Y", "~16Z", "~16 ", "~16!", "~16@", "~16#", "~16$", "~16%", "~16^", "~16&", "~16*", "~16(", "~16)", "~16-", "~16_", "~16+", "~16=", "~16[", "~16]", "~16{", "~16}", "~16,", "~16.", "~16<", "~16>", "~16?", "~16/", "~16;", "~16:", "~16|", "~16~", "~170", "~171", "~172", "~173", "~174", "~175", "~176", "~177", "~178", "~179", "~17a", "~17b", "~17c", "~17d", "~17e", "~17f", "~17g", "~17h", "~17i", "~17j", "~17k", "~17l", "~17m", "~17n", "~17o", "~17p", "~17q", "~17r", "~17s", "~17t", "~17u", "~17v", "~17w", "~17x", "~17y", "~17z", "~17A", "~17B", "~17C", "~17D", "~17E", "~17F", "~17G", "~17H", "~17I", "~17J", "~17K", "~17L", "~17M", "~17N", "~17O", "~17P", "~17Q", "~17R", "~17S", "~17T", "~17U", "~17V", "~17W", "~17X", "~17Y", "~17Z", "~17 ", "~17!", "~17@", "~17#", "~17$", "~17%", "~17^", "~17&", "~17*", "~17(", "~17)", "~17-", "~17_", "~17+", "~17=", "~17[", "~17]", "~17{", "~17}", "~17,", "~17.", "~17<", "~17>", "~17?", "~17/", "~17;", "~17:", "~17|", "~17~", "~180", "~181", "~182", "~183", "~184", "~185", "~186", "~187", "~188", "~189", "~18a", "~18b", "~18c", "~18d", "~18e", "~18f", "~18g", "~18h", "~18i", "~18j", "~18k", "~18l", "~18m", "~18n", "~18o", "~18p", "~18q", "~18r", "~18s", "~18t", "~18u", "~18v", "~18w", "~18x", "~18y", "~18z", "~18A", "~18B", "~18C", "~18D", "~18E", "~18F", "~18G", "~18H", "~18I", "~18J", "~18K", "~18L", "~18M", "~18N", "~18O", "~18P", "~18Q", "~18R", "~18S", "~18T", "~18U", "~18V", "~18W", "~18X", "~18Y", "~18Z", "~18 ", "~18!", "~18@", "~18#", "~18$", "~18%", "~18^", "~18&", "~18*", "~18(", "~18)", "~18-", "~18_", "~18+", "~18=", "~18[", "~18]", "~18{", "~18}", "~18,", "~18.", "~18<", "~18>", "~18?", "~18/", "~18;", "~18:", "~18|", "~18~", "~190", "~191", "~192", "~193", "~194", "~195", "~196", "~197", "~198", "~199", "~19a", "~19b", "~19c", "~19d", "~19e", "~19f", "~19g", "~19h", "~19i", "~19j", "~19k", "~19l", "~19m", "~19n", "~19o", "~19p", "~19q", "~19r", "~19s", "~19t", "~19u", "~19v", "~19w", "~19x", "~19y", "~19z", "~19A", "~19B", "~19C", "~19D", "~19E", "~19F", "~19G", "~19H", "~19I", "~19J", "~19K", "~19L", "~19M", "~19N", "~19O", "~19P", "~19Q", "~19R", "~19S", "~19T", "~19U", "~19V", "~19W", "~19X", "~19Y", "~19Z", "~19 ", "~19!", "~19@", "~19#", "~19$", "~19%", "~19^", "~19&", "~19*", "~19(", "~19)", "~19-", "~19_", "~19+", "~19=", "~19[", "~19]", "~19{", "~19}", "~19,", "~19.", "~19<", "~19>", "~19?", "~19/", "~19;", "~19:", "~19|", "~19~", "~200", "~201", "~202", "~203", "~204", "~205", "~206", "~207", "~208", "~209", "~20a", "~20b", "~20c", "~20d", "~20e", "~20f", "~20g", "~20h", "~20i", "~20j", "~20k", "~20l", "~20m", "~20n", "~20o", "~20p", "~20q", "~20r", "~20s", "~20t", "~20u", "~20v", "~20w", "~20x", "~20y", "~20z", "~20A", "~20B", "~20C", "~20D", "~20E", "~20F", "~20G", "~20H", "~20I", "~20J", "~20K", "~20L", "~20M", "~20N", "~20O", "~20P", "~20Q", "~20R", "~20S", "~20T", "~20U", "~20V", "~20W", "~20X", "~20Y", "~20Z", "~20 ", "~20!", "~20@", "~20#", "~20$", "~20%", "~20^", "~20&", "~20*", "~20(", "~20)", "~20-", "~20_", "~20+", "~20=", "~20[", "~20]", "~20{", "~20}", "~20,", "~20.", "~20<", "~20>", "~20?", "~20/", "~20;", "~20:", "~20|", "~20~", "~210", "~211", "~212", "~213", "~214", "~215", "~216", "~217", "~218", "~219", "~21a", "~21b", "~21c", "~21d", "~21e", "~21f", "~21g", "~21h", "~21i", "~21j", "~21k", "~21l", "~21m", "~21n", "~21o", "~21p", "~21q", "~21r", "~21s", "~21t", "~21u", "~21v", "~21w", "~21x", "~21y", "~21z", "~21A", "~21B", "~21C", "~21D", "~21E", "~21F", "~21G", "~21H", "~21I", "~21J", "~21K", "~21L", "~21M", "~21N", "~21O", "~21P", "~21Q", "~21R", "~21S", "~21T", "~21U", "~21V", "~21W", "~21X", "~21Y", "~21Z", "~21 ", "~21!", "~21@", "~21#", "~21$", "~21%", "~21^", "~21&", "~21*", "~21(", "~21)", "~21-", "~21_", "~21+", "~21=", "~21[", "~21]", "~21{", "~21}", "~21,", "~21.", "~21<", "~21>", "~21?", "~21/", "~21;", "~21:", "~21|", "~21~", "~220", "~221", "~222", "~223", "~224", "~225", "~226", "~227", "~228", "~229", "~22a", "~22b", "~22c", "~22d", "~22e", "~22f", "~22g", "~22h", "~22i", "~22j", "~22k", "~22l", "~22m", "~22n", "~22o", "~22p", "~22q", "~22r", "~22s", "~22t", "~22u", "~22v", "~22w", "~22x", "~22y", "~22z", "~22A", "~22B", "~22C", "~22D", "~22E", "~22F", "~22G", "~22H", "~22I", "~22J", "~22K", "~22L", "~22M", "~22N", "~22O", "~22P", "~22Q", "~22R", "~22S", "~22T", "~22U", "~22V", "~22W", "~22X", "~22Y", "~22Z", "~22 ", "~22!", "~22@", "~22#", "~22$", "~22%", "~22^", "~22&", "~22*", "~22(", "~22)", "~22-", "~22_", "~22+", "~22=", "~22[", "~22]", "~22{", "~22}", "~22,", "~22.", "~22<", "~22>", "~22?", "~22/", "~22;", "~22:", "~22|", "~22~", "~230", "~231", "~232", "~233", "~234", "~235", "~236", "~237", "~238", "~239", "~23a", "~23b", "~23c", "~23d", "~23e", "~23f", "~23g", "~23h", "~23i", "~23j", "~23k", "~23l", "~23m", "~23n", "~23o", "~23p", "~23q", "~23r", "~23s", "~23t", "~23u", "~23v", "~23w", "~23x", "~23y", "~23z", "~23A", "~23B", "~23C", "~23D", "~23E", "~23F", "~23G", "~23H", "~23I", "~23J", "~23K", "~23L", "~23M", "~23N", "~23O", "~23P", "~23Q", "~23R", "~23S", "~23T", "~23U", "~23V", "~23W", "~23X", "~23Y", "~23Z", "~23 ", "~23!", "~23@", "~23#", "~23$", "~23%", "~23^", "~23&", "~23*", "~23(", "~23)", "~23-", "~23_", "~23+", "~23=", "~23[", "~23]", "~23{", "~23}", "~23,", "~23.", "~23<", "~23>", "~23?", "~23/", "~23;", "~23:", "~23|", "~23~", "~240", "~241", "~242", "~243", "~244", "~245", "~246", "~247", "~248", "~249", "~24a", "~24b", "~24c", "~24d", "~24e", "~24f", "~24g", "~24h", "~24i", "~24j", "~24k", "~24l", "~24m", "~24n", "~24o", "~24p", "~24q", "~24r", "~24s", "~24t", "~24u", "~24v", "~24w", "~24x", "~24y", "~24z", "~24A", "~24B", "~24C", "~24D", "~24E", "~24F", "~24G", "~24H", "~24I", "~24J", "~24K", "~24L", "~24M", "~24N", "~24O", "~24P", "~24Q", "~24R", "~24S", "~24T", "~24U", "~24V", "~24W", "~24X", "~24Y", "~24Z", "~24 ", "~24!", "~24@", "~24#", "~24$", "~24%", "~24^", "~24&", "~24*", "~24(", "~24)", "~24-", "~24_", "~24+", "~24=", "~24[", "~24]", "~24{", "~24}", "~24,", "~24.", "~24<", "~24>", "~24?", "~24/", "~24;", "~24:", "~24|", "~24~", "~250", "~251", "~252", "~253", "~254", "~255", "~256", "~257", "~258", "~259", "~25a", "~25b", "~25c", "~25d", "~25e", "~25f", "~25g", "~25h", "~25i", "~25j", "~25k", "~25l", "~25m", "~25n", "~25o", "~25p", "~25q", "~25r", "~25s", "~25t", "~25u", "~25v", "~25w", "~25x", "~25y", "~25z", "~25A", "~25B", "~25C", "~25D", "~25E", "~25F", "~25G", "~25H", "~25I", "~25J", "~25K", "~25L", "~25M", "~25N", "~25O", "~25P", "~25Q", "~25R", "~25S", "~25T", "~25U", "~25V", "~25W", "~25X", "~25Y", "~25Z", "~25 ", "~25!", "~25@", "~25#", "~25$", "~25%", "~25^", "~25&", "~25*", "~25(", "~25)", "~25-", "~25_", "~25+", "~25=", "~25[", "~25]", "~25{", "~25}", "~25,", "~25.", "~25<", "~25>", "~25?", "~25/", "~25;", "~25:", "~25|", "~25~", "~260", "~261", "~262", "~263", "~264", "~265", "~266", "~267", "~268", "~269", "~26a", "~26b", "~26c", "~26d", "~26e", "~26f", "~26g", "~26h", "~26i", "~26j", "~26k", "~26l", "~26m", "~26n", "~26o", "~26p", "~26q", "~26r", "~26s", "~26t", "~26u", "~26v", "~26w", "~26x", "~26y", "~26z", "~26A", "~26B", "~26C", "~26D", "~26E", "~26F", "~26G", "~26H", "~26I", "~26J", "~26K", "~26L", "~26M", "~26N", "~26O", "~26P", "~26Q", "~26R", "~26S", "~26T", "~26U", "~26V", "~26W", "~26X", "~26Y", "~26Z", "~26 ", "~26!", "~26@", "~26#", "~26$", "~26%", "~26^", "~26&", "~26*", "~26(", "~26)", "~26-", "~26_", "~26+", "~26=", "~26[", "~26]", "~26{", "~26}", "~26,", "~26.", "~26<", "~26>", "~26?", "~26/", "~26;", "~26:", "~26|", "~26~", "~270", "~271", "~272", "~273", "~274", "~275", "~276", "~277", "~278", "~279", "~27a", "~27b", "~27c", "~27d", "~27e", "~27f", "~27g", "~27h", "~27i", "~27j", "~27k", "~27l", "~27m", "~27n", "~27o", "~27p", "~27q", "~27r", "~27s", "~27t", "~27u", "~27v", "~27w", "~27x", "~27y", "~27z", "~27A", "~27B", "~27C", "~27D", "~27E", "~27F", "~27G", "~27H", "~27I", "~27J", "~27K", "~27L", "~27M", "~27N", "~27O", "~27P", "~27Q", "~27R", "~27S", "~27T", "~27U", "~27V", "~27W", "~27X", "~27Y", "~27Z", "~27 ", "~27!", "~27@", "~27#", "~27$", "~27%", "~27^", "~27&", "~27*", "~27(", "~27)", "~27-", "~27_", "~27+", "~27=", "~27[", "~27]", "~27{", "~27}", "~27,", "~27.", "~27<", "~27>", "~27?", "~27/", "~27;", "~27:", "~27|", "~27~", "~280", "~281", "~282", "~283", "~284", "~285", "~286", "~287", "~288", "~289", "~28a", "~28b", "~28c", "~28d", "~28e", "~28f", "~28g", "~28h", "~28i", "~28j", "~28k", "~28l", "~28m", "~28n", "~28o", "~28p", "~28q", "~28r", "~28s", "~28t", "~28u", "~28v", "~28w", "~28x", "~28y", "~28z", "~28A", "~28B", "~28C", "~28D", "~28E", "~28F", "~28G", "~28H", "~28I", "~28J", "~28K", "~28L", "~28M", "~28N", "~28O", "~28P", "~28Q", "~28R", "~28S", "~28T", "~28U", "~28V", "~28W", "~28X", "~28Y", "~28Z", "~28 ", "~28!", "~28@", "~28#", "~28$", "~28%", "~28^", "~28&", "~28*", "~28(", "~28)", "~28-", "~28_", "~28+", "~28=", "~28[", "~28]", "~28{", "~28}", "~28,", "~28.", "~28<", "~28>", "~28?", "~28/", "~28;", "~28:", "~28|", "~28~", "~290", "~291", "~292", "~293", "~294", "~295", "~296", "~297", "~298", "~299", "~29a", "~29b", "~29c", "~29d", "~29e", "~29f", "~29g", "~29h", "~29i", "~29j", "~29k", "~29l", "~29m", "~29n", "~29o", "~29p", "~29q", "~29r", "~29s", "~29t", "~29u", "~29v", "~29w", "~29x", "~29y", "~29z", "~29A", "~29B", "~29C", "~29D", "~29E", "~29F", "~29G", "~29H", "~29I", "~29J", "~29K", "~29L", "~29M", "~29N", "~29O", "~29P", "~29Q", "~29R", "~29S", "~29T", "~29U", "~29V", "~29W", "~29X", "~29Y", "~29Z", "~29 ", "~29!", "~29@", "~29#", "~29$", "~29%", "~29^", "~29&", "~29*", "~29(", "~29)", "~29-", "~29_", "~29+", "~29=", "~29[", "~29]", "~29{", "~29}", "~29,", "~29.", "~29<", "~29>", "~29?", "~29/", "~29;", "~29:", "~29|", "~29~", "~300", "~301", "~302", "~303", "~304", "~305", "~306", "~307", "~308", "~309", "~30a", "~30b", "~30c", "~30d", "~30e", "~30f", "~30g", "~30h", "~30i", "~30j", "~30k", "~30l", "~30m", "~30n", "~30o", "~30p", "~30q", "~30r", "~30s", "~30t", "~30u", "~30v", "~30w", "~30x", "~30y", "~30z", "~30A", "~30B", "~30C", "~30D", "~30E", "~30F", "~30G", "~30H", "~30I", "~30J", "~30K", "~30L", "~30M", "~30N", "~30O", "~30P", "~30Q", "~30R", "~30S", "~30T", "~30U", "~30V", "~30W", "~30X", "~30Y", "~30Z", "~30 ", "~30!", "~30@", "~30#", "~30$", "~30%", "~30^", "~30&", "~30*", "~30(", "~30)", "~30-", "~30_", "~30+", "~30=", "~30[", "~30]", "~30{", "~30}", "~30,", "~30.", "~30<", "~30>", "~30?", "~30/", "~30;", "~30:", "~30|", "~30~", "~310", "~311", "~312", "~313", "~314", "~315", "~316", "~317", "~318", "~319", "~31a", "~31b", "~31c", "~31d", "~31e", "~31f", "~31g", "~31h", "~31i", "~31j", "~31k", "~31l", "~31m", "~31n", "~31o", "~31p", "~31q", "~31r", "~31s", "~31t", "~31u", "~31v", "~31w", "~31x", "~31y", "~31z", "~31A", "~31B", "~31C", "~31D", "~31E", "~31F", "~31G", "~31H", "~31I", "~31J", "~31K", "~31L", "~31M", "~31N", "~31O", "~31P", "~31Q", "~31R", "~31S", "~31T", "~31U", "~31V", "~31W", "~31X", "~31Y", "~31Z", "~31 ", "~31!", "~31@", "~31#", "~31$", "~31%", "~31^", "~31&", "~31*", "~31(", "~31)", "~31-", "~31_", "~31+", "~31=", "~31[", "~31]", "~31{", "~31}", "~31,", "~31.", "~31<", "~31>", "~31?", "~31/", "~31;", "~31:", "~31|", "~31~", "~320", "~321", "~322", "~323", "~324", "~325", "~326", "~327", "~328", "~329", "~32a", "~32b", "~32c", "~32d", "~32e", "~32f", "~32g", "~32h", "~32i", "~32j", "~32k", "~32l", "~32m", "~32n", "~32o", "~32p", "~32q", "~32r", "~32s", "~32t", "~32u", "~32v", "~32w", "~32x", "~32y", "~32z", "~32A", "~32B", "~32C", "~32D", "~32E", "~32F", "~32G", "~32H", "~32I", "~32J", "~32K", "~32L", "~32M", "~32N", "~32O", "~32P", "~32Q", "~32R", "~32S", "~32T", "~32U", "~32V", "~32W", "~32X", "~32Y", "~32Z", "~32 ", "~32!", "~32@", "~32#", "~32$", "~32%", "~32^", "~32&", "~32*", "~32(", "~32)", "~32-", "~32_", "~32+", "~32=", "~32[", "~32]", "~32{", "~32}", "~32,", "~32.", "~32<", "~32>", "~32?", "~32/", "~32;", "~32:", "~32|", "~32~", "~330", "~331", "~332", "~333", "~334", "~335", "~336", "~337", "~338", "~339", "~33a", "~33b", "~33c", "~33d", "~33e", "~33f", "~33g", "~33h", "~33i", "~33j", "~33k", "~33l", "~33m", "~33n", "~33o", "~33p", "~33q", "~33r", "~33s", "~33t", "~33u", "~33v", "~33w", "~33x", "~33y", "~33z", "~33A", "~33B", "~33C", "~33D", "~33E", "~33F", "~33G", "~33H", "~33I", "~33J", "~33K", "~33L", "~33M", "~33N", "~33O", "~33P", "~33Q", "~33R", "~33S", "~33T", "~33U", "~33V", "~33W", "~33X", "~33Y", "~33Z", "~33 ", "~33!", "~33@", "~33#", "~33$", "~33%", "~33^" };

                string[] separator3 = { ",", "R", "}", "{", "(", ")" };
                codes_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                codes_text2 = text.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
                codes_text3 = text.Split(separator3, StringSplitOptions.RemoveEmptyEntries);


                int z3 = 0;




                /*for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < codes_t.Length)
                    {
                        if (codes_t[i] == "L")
                        {
                            code_labels[i-test] = codes_t[i+1];

                            test++;

                        }
                        if (codes_t[i] == "Z0")
                        {
                            codes[i] = 8;
                        }
                    }

                }
                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < codes_t.Length)
                    {
                        if (codes_t[i] == "L")
                        {
                            codes_t = Delete(codes_t, i+1);

                            //if (codes_t[i + 2] != "L")
                            //  codes_t[i + 1] = codes_t[i + 2];
                            //else
                            //{ codes_t[i + 1] = codes_t[i + 2]; codes_t[i + 3] = codes_t[i + 4]; }

                        }
                    }
                }*/

                ////
                /* for (int i = 0; i < 16 * 12 * 16; i++)
                 {
                     if (i < codes_text3.Length)
                     {

                         numsstring[i] = codes_text3[i];


                     }


                 }*/





                int[] g1 = new int[16 * 12 * 16];

                int z0 = 0; int z1 = 0;


                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    //for (int j = i; j < 16 * 12 * 16; j++)
                    //{
                    if (i < codes_text.Length && z0 < codes.Length)
                    {
                        if (codes_text[i] == "L")
                        {
                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 40;
                            z0++;
                        }
                        if (codes_text[i] == "G2")
                        {

                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 24;
                            z0++;
                        }
                        if (codes_text[i] == "G3")
                        {

                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 25;
                            z0++;
                        }
                        if (codes_text[i] == "G5")
                        {

                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 137;
                            z0++;
                        }
                        if (codes_text[i] == "G0")
                        {

                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 139;
                            z0++;
                        }
                        if (codes_text[i] == "G1")
                        {

                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 140;
                            z0++;
                        }
                        if (codes_text[i] == "G4")
                        {

                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 26;
                            z0++;
                        }
                        if (codes_text[i] == "VEqua")
                        {
                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 123;
                            z0++;

                        }
                        if (codes_text[i] == "VMore")
                        {
                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 119;
                            z0++;

                        }
                        if (codes_text[i] == "VLes")
                        {
                            codes_text = Delete(codes_text, i + 1);
                            codes[z0] = 120;
                            z0++;

                        }
                        /*if (codes_text[i] == "Z0")
                        {
                            codes[z0] = 8;
                            z0++;
                        }*/

                        /*if (codes_text[i] == ">")
                        {
                            codes[z0] = 2;
                            z0++;
                        }*/
                        if (codes_text[i] == "\\")
                        {
                            codes[z0] = 1;
                            z0++;
                        }
                        if (codes_text[i] == ">")
                        {
                            codes[z0] = 2;
                            z0++;
                        }
                        if (codes_text[i] == "<")
                        {
                            codes[z0] = 3;
                            z0++;
                        }
                        if (codes_text[i] == "W")
                        {
                            codes[z0] = 4;
                            z0++;
                        }
                        if (codes_text[i] == "A")
                        {
                            codes[z0] = 5;
                            z0++;
                        }
                        if (codes_text[i] == "S")
                        {
                            codes[z0] = 6;
                            z0++;
                        }
                        if (codes_text[i] == "D")
                        {
                            codes[z0] = 7;
                            z0++;
                        }
                        if (codes_text[i] == "Z0")
                        {
                            codes[z0] = 8;
                            z0++;
                        }
                        if (codes_text[i] == "w")
                        {
                            codes[z0] = 9;
                            z0++;
                        }
                        if (codes_text[i] == "a")
                        {
                            codes[z0] = 10;
                            z0++;
                        }
                        if (codes_text[i] == "s")
                        {
                            codes[z0] = 11;
                            z0++;
                        }
                        if (codes_text[i] == "d")
                        {
                            codes[z0] = 12;
                            z0++;
                        }
                        if (codes_text[i] == "Z2")
                        {
                            codes[z0] = 14;
                            z0++;
                        }
                        if (codes_text[i] == "Z3")
                        {
                            codes[z0] = 15;
                            z0++;
                        }
                        if (codes_text[i] == "Z4")
                        {
                            codes[z0] = 16;
                            z0++;
                        }
                        if (codes_text[i] == "Zc")
                        {
                            codes[z0] = 17;
                            z0++;
                        }
                        if (codes_text[i] == "Ze")
                        {
                            codes[z0] = 18;
                            z0++;
                        }
                        if (codes_text[i] == "Zd")
                        {
                            codes[z0] = 19;
                            z0++;
                        }
                        if (codes_text[i] == "Zf")
                        {
                            codes[z0] = 20;
                            z0++;
                        }
                        if (codes_text[i] == "Zg")
                        {
                            codes[z0] = 21;
                            z0++;
                        }
                        if (codes_text[i] == "Zq")
                        {
                            codes[z0] = 22;
                            z0++;
                        }
                        if (codes_text[i] == "Zh")
                        {
                            codes[z0] = 23;
                            z0++;
                        }
                        if (codes_text[i] == "R0")
                        {
                            codes[z0] = 27;
                            z0++;
                        }
                        if (codes_text[i] == "R1")
                        {
                            codes[z0] = 28;
                            z0++;
                        }
                        if (codes_text[i] == "R2")
                        {
                            codes[z0] = 138;
                            z0++;
                        }
                        if (codes_text[i] == "C0")
                        {
                            codes[z0] = 29;
                            z0++;
                        }
                        if (codes_text[i] == "C8")
                        {
                            codes[z0] = 30;
                            z0++;
                        }
                        if (codes_text[i] == "C1")
                        {
                            codes[z0] = 31;
                            z0++;
                        }
                        if (codes_text[i] == "C2")
                        {
                            codes[z0] = 32;
                            z0++;
                        }
                        if (codes_text[i] == "C3")
                        {
                            codes[z0] = 33;
                            z0++;
                        }
                        if (codes_text[i] == "C5")
                        {
                            codes[z0] = 35;
                            z0++;
                        }
                        if (codes_text[i] == "C6")
                        {
                            codes[z0] = 36;
                            z0++;
                        }
                        if (codes_text[i] == "C7")
                        {
                            codes[z0] = 37;
                            z0++;
                        }
                        if (codes_text[i] == "M0")
                        {
                            codes[z0] = 38;
                            z0++;
                        }
                        if (codes_text[i] == "M1")
                        {
                            codes[z0] = 39;
                            z0++;
                        }
                        if (codes_text[i] == "c0")
                        {
                            codes[z0] = 43;
                            z0++;
                        }
                        if (codes_text[i] == "c1")
                        {
                            codes[z0] = 44;
                            z0++;
                        }
                        if (codes_text[i] == "c2")
                        {
                            codes[z0] = 45;
                            z0++;
                        }
                        if (codes_text[i] == "ck")
                        {
                            codes[z0] = 46;
                            z0++;
                        }
                        if (codes_text[i] == "cl")
                        {
                            codes[z0] = 47;
                            z0++;
                        }
                        if (codes_text[i] == "cj")
                        {
                            codes[z0] = 48;
                            z0++;
                        }
                        if (codes_text[i] == "cd")
                        {
                            codes[z0] = 49;
                            z0++;
                        }
                        if (codes_text[i] == "cm")
                        {
                            codes[z0] = 50;
                            z0++;
                        }
                        if (codes_text[i] == "cn")
                        {
                            codes[z0] = 51;
                            z0++;
                        }
                        if (codes_text[i] == "cv")
                        {
                            codes[z0] = 52;
                            z0++;
                        }
                        if (codes_text[i] == "ca")
                        {
                            codes[z0] = 53;
                            z0++;
                        }
                        if (codes_text[i] == "ci")
                        {
                            codes[z0] = 54;
                            z0++;
                        }
                        if (codes_text[i] == "ce")
                        {
                            codes[z0] = 57;
                            z0++;
                        }
                        if (codes_text[i] == "cf")
                        {
                            codes[z0] = 58;
                            z0++;
                        }
                        if (codes_text[i] == "cg")
                        {
                            codes[z0] = 59;
                            z0++;
                        }
                        if (codes_text[i] == "ch")
                        {
                            codes[z0] = 60;
                            z0++;
                        }
                        if (codes_text[i] == "ct")
                        {
                            codes[z0] = 74;
                            z0++;
                        }
                        if (codes_text[i] == "cu")
                        {
                            codes[z0] = 76;
                            z0++;
                        }
                        if (codes_text[i] == "cs")
                        {
                            codes[z0] = 77;
                            z0++;
                        }
                        if (codes_text[i] == "B1")
                        {
                            codes[z0] = 162;
                            z0++;
                        }
                        if (codes_text[i] == "B3")
                        {
                            codes[z0] = 163;
                            z0++;
                        }
                        if (codes_text[i] == "B2")
                        {
                            codes[z0] = 164;
                            z0++;
                        }
                        if (codes_text[i] == "VB")
                        {
                            codes[z0] = 165;
                            z0++;
                        }
                        if (codes_text[i] == "C9")
                        {
                            codes[z0] = 131;
                            z0++;
                        }
                        if (codes_text[i] == "Ca")
                        {
                            codes[z0] = 132;
                            z0++;
                        }
                        if (codes_text[i] == "Cb")
                        {
                            codes[z0] = 133;
                            z0++;
                        }
                        if (codes_text[i] == "Cc")
                        {
                            codes[z0] = 134;
                            z0++;
                        }
                        if (codes_text[i] == "Cd")
                        {
                            codes[z0] = 135;
                            z0++;
                        }
                        if (codes_text[i] == "Ce")
                        {
                            codes[z0] = 136;
                            z0++;
                        }
                        if (codes_text[i] == "Qig+")
                        {
                            codes[z0] = 158;
                            z0++;
                        }
                        if (codes_text[i] == "Qig-")
                        {
                            codes[z0] = 159;
                            z0++;
                        }
                        if (codes_text[i] == "gr+")
                        {
                            codes[z0] = 160;
                            z0++;
                        }
                        if (codes_text[i] == "gr-")
                        {
                            codes[z0] = 161;
                            z0++;
                        }
                        if (codes_text[i] == "iggs")
                        {
                            codes[z0] = 141;
                            z0++;
                        }
                        if (codes_text[i] == "Build")
                        {
                            codes[z0] = 142;
                            z0++;
                        }
                        if (codes_text[i] == "Hea")
                        {
                            codes[z0] = 143;
                            z0++;
                        }
                        if (codes_text[i] == "MineS")
                        {
                            codes[z0] = 145;
                            z0++;
                        }
                        if (codes_text[i] == "CLeftH")
                        {
                            codes[z0] = 156;
                            z0++;
                        }
                        if (codes_text[i] == "CRightH")
                        {
                            codes[z0] = 157;
                            z0++;
                        }
                        if (codes_text[i] == "CGun")
                        {
                            codes[z0] = 146;
                            z0++;
                        }
                        if (codes_text[i] == "FGun")
                        {
                            codes[z0] = 147;
                            z0++;
                        }
                        if (codes_text[i] == "hpf")
                        {
                            codes[z0] = 148;
                            z0++;
                        }
                        if (codes_text[i] == "hpp")
                        {
                            codes[z0] = 149;
                            z0++;
                        }
                        if (codes_text[i] == "Flip")
                        {
                            codes[z0] = 144;
                            z0++;
                        }

                        /*if (codes_text[i] == "->")
                        {

                            codes[z0] = 0;
                            z0 += 84;
                            g1[z1] = z0;
                            z1++;
                            //i += 84;
                        }
                        if (codes_text[i] == "-U")
                        {
                            codes[z0] = 0;
                            z0 += 56;
                            g1[z1] = z0;
                            z1++;
                        }*/

                        ////

                        for (int j = 0; j < tx2.Length; j++)
                        {
                            if(codes_text[i] == tx2[j])
                            {
                                codes[z0] = 0;
                                z0 += j;
                                g1[z1] = z0;
                                z1++;
                            }                         
                        }

                        
                        ////
                    }
                    // }

                }


                for (int i = 0; i < 16 * 12 * 16; i++)
                {

                    if (i < codes_text.Length)
                    {
                        for(int j = 0; j < tx2.Length; j++)
                        {
                            if ( codes_text[i] == tx2[j])
                            {
                                z3 += j;
                                codes_text = Delete(codes_text, i);
                            }
                        }

                        

                        codes_t[z3] = codes_text[i];
                        //codes_t[z3 - 1] = "0";
                        z3++;

                    }

                }
                string[] text4 = new string[codes_text.Length];
                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < codes_text.Length && i < text4.Length)
                    {
                        text4[i] = codes_text[i];
                    }
                }


                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < text4.Length && i < codes_text2.Length)
                    {
                        if (codes_text2[i] == text4[i])
                        {
                            if (text4[i] != "L" && text4[i] != "VEqua" && text4[i] != "G2" && text4[i] != "G3" && text4[i] != "G2" && text4[i] != "G4" && text4[i] != "G5" && text4[i] != "G0" && text4[i] != "G1" && text4[i] != "VLes" && text4[i] != "VMore")
                            {
                                codes_text2 = Delete(codes_text2, i);
                                text4 = Delete(text4, i);
                                i = 0;
                            }

                            //codes_text2 = Delete(code_labels[i]);
                        }
                    }

                }

                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    //if (i < codes_text2.Length)
                    //{
                    if (i < codes_text2.Length)
                        code_labels[i] = codes_text2[i];


                    //}


                }
                /* for (int i = 0; i < 16 * 12 * 16; i++)
                 {
                     if (i < codes_text.Length)
                     {
                         if (codes_t[i] == "L")
                         {
                             codes_t = Delete(codes_t, i + 1);

                         }
                         if (codes_text[i] == "G2")
                         {

                             codes_t = Delete(codes_t, i + 1);

                         }
                     }


                 }*/

                /* for (int i = 0; i < 16 * 12 * 16; i++)
                 {
                     if (i < codes_text3.Length)
                     {
                         if (codes_text[i] != "R" )
                         {
                             code_labels[i] = "0";
                         }
                         else code_labels[i] = codes_text3[i];
                     }

                 }*/
                int z4 = 0;
                /* for (int i = 0; i < 16 * 12 * 16; i++)
                 {
                     if (i < codes_text2.Length)
                     {
                         if (codes_text[i] != "L" && codes_text[i] != "G2" && codes_text[i] != "R" && codes_text[i] != "VEqual")
                         //if (codes_t[i] != "L" && codes_t[i] != "G2" && codes_t[i] != "R" && codes_t[i] != "VEqual")
                         {
                             //code_labels[z4] = "0";

                             code_labels[i] = "0";
                             //z4++;
                         }
                         else
                         //for (int j = 0; j < g1.Length; j++)
                         //if (g1[j] != 0&&g1[j]<codes_text2.Length)
                         //   if (i < g1[j])
                         //     i += g1[j];
                         {
                             //code_labels[z4] = codes_text2[i];
                             code_labels[i] = codes_text2[i];
                             //z4++;
                         }

                     }
                     //z4++;

                 }*/
                int zz = 0; int zz1 = 0; int p = 0;

                for (int i = 0; i < 16 * 12 * 16; i++)
                {

                    //for (int j= 0; j<16*12*16;j++)
                    if (codes_t[i] == "0")//&&code_labels[i]!="0")
                    {

                        //code_labels[g1[i]] = code_labels[i];
                        //code_labels[i] = "0";
                        //g1[i]++;
                    }
                    if (codes_t[i] == "L")
                    {
                        g3[p] = i;
                        p++;
                        /*for (int j = 0; j < 16 * 12 * 16; j++)
                        {


                            if (i > g1[j] && codes_t[g1[j]] == "-U")
                            {
                                zz += 56;
                                zz1 += 1;
                                //code_labels[i - zz1] = code_labels[i - zz];
                                code_labels[i] = code_labels[i - zz];
                                code_labels[i - zz] = "0";
                                //code_labels[i - zz - 1] = "0";
                                //p++; i++;


                            }

                            if (i > g1[j] && codes_t[g1[j]] == "->")
                            {

                                zz += 84;
                                zz1 += 1;
                                code_labels[i - zz1] = code_labels[i - zz];
                                code_labels[i - zz] = "0";
                               // code_labels[i - zz - 1] = "0";

                                //p++; i++;
                            }



                        }*/
                        //code_labels[i+1] = code_labels[i - 83];
                    }
                }

                int g4 = 0; int g5 = 0;
                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    /*if(g3[i] != -1)
                    //{
                        if (g3[g4] > g1[i])
                        {
                        if (codes_t[g1[i]] == "->")
                        {
                            code_labels[g3[g4]] = code_labels[g3[g4] - 85];
                            code_labels[g3[g4] - 85] = "0";

                            //g5--; i++;
                        }
                        else { i++; g4++; }
                        }
                    }*/
                    //for(int j = 0; j < 16 * 12 * 16; j++)
                    //{

                    if (codes_t[i] == "L")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }

                    if (codes_t[i] == "VEqua")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "VMore")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "VLes")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "G2")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "G3")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "G4")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "G5")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "G0")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    if (codes_t[i] == "G1")
                    {
                        if (i != g5)
                        {
                            code_labels[i] = codes_text2[g5];
                            //code_labels[i] = code_labels[g5];
                            //code_labels[g5] = "0";
                            g5++; g4++;
                        }
                        else { g5++; }
                    }
                    //}

                }
                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (codes_t[i] != "L" && codes_t[i] != "VEqua" && codes_t[i] != "VMore" && codes_t[i] != "VLes" && codes_t[i] != "G2" && codes_t[i] != "G3" && codes_t[i] != "G4" && codes_t[i] != "G5" && codes_t[i] != "G0" && codes_t[i] != "G1")
                    {
                        code_labels[i] = "0";

                    }

                    //if (codes_t[i] != "VEqual")
                    //{
                    //    code_labels[i] = "0";

                    //}
                }
                //code_labels[i] = code_labels[i];




                /* for (int i = 0; i < 16 * 12 * 16; i++)
                 {
                     if (i < codes_text.Length)
                     {
                         if (codes_text[i] == "L")
                         {
                             codes_text = Delete(codes_text, i + 2);
                             codes[i] = 40;

                         }


                     }
                 }*/
                /*for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < codes_text2.Length)
                    {
                        if (codes_text[i] != "L" && codes_text[i] != "G2" && codes_text[i] != "R")
                        {
                            numsstring[i] = "0";
                        }
                        else numsstring[i] = codes_text3[i];
                    }

                }*/

                /*for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < codes_text.Length)
                    {
                        if (codes_text[i] == "L")
                        {
                            codes[i] = 40;

                        }
                    }

                }*/

                ////


                for (int i = 0; i < 16 * 12 * 16; i++)
                {
                    if (i < codes_t.Length)
                    {
                        if (codes_t[i] == "L")
                        {
                            codes[i] = 40;

                        }
                        /*if (codes_t[i] == "Z0")
                        {
                            codes[i] = 8;

                        }
                        if (codes_t[i] == "Hea")
                        {
                            codes[i] = 143;

                        }*/
                        if (codes_t[i] == "VEqua")
                        {
                            codes[i] = 123;
                        }
                        if (codes_t[i] == "VMore")
                        {
                            codes[i] = 119;
                        }
                        if (codes_t[i] == "VLes")
                        {
                            codes[i] = 120;
                        }
                        if (codes_t[i] == "G2")
                        {
                            codes[i] = 24;

                        }
                        if (codes_t[i] == "G3")
                        {
                            codes[i] = 25;

                        }
                        if (codes_t[i] == "G4")
                        {
                            codes[i] = 26;

                        }
                        if (codes_t[i] == "G5")
                        {
                            codes[i] = 137;

                        }
                        if (codes_t[i] == "G0")
                        {
                            codes[i] = 139;

                        }
                        if (codes_t[i] == "G1")
                        {
                            codes[i] = 140;

                        }
                        if (codes_t[i] == "\\")
                        {
                            codes[i] = 1;
                        }
                        if (codes_t[i] == ">")
                        {
                            codes[i] = 2;
                        }
                        if (codes_t[i] == "<")
                        {
                            codes[i] = 3;
                        }
                        if (codes_t[i] == "W")
                        {
                            codes[i] = 4;
                        }
                        if (codes_t[i] == "A")
                        {
                            codes[i] = 5;
                        }
                        if (codes_t[i] == "S")
                        {
                            codes[i] = 6;
                        }
                        if (codes_t[i] == "D")
                        {
                            codes[i] = 7;
                        }
                        if (codes_t[i] == "Z0")
                        {
                            codes[i] = 8;
                        }
                        if (codes_t[i] == "w")
                        {
                            codes[i] = 9;
                        }
                        if (codes_t[i] == "a")
                        {
                            codes[i] = 10;
                        }
                        if (codes_t[i] == "s")
                        {
                            codes[i] = 11;
                        }
                        if (codes_t[i] == "d")
                        {
                            codes[i] = 12;
                        }
                        if (codes_t[i] == "Z2")
                        {
                            codes[i] = 14;
                        }
                        if (codes_t[i] == "Z3")
                        {
                            codes[i] = 15;
                        }
                        if (codes_t[i] == "Z4")
                        {
                            codes[i] = 16;
                        }
                        if (codes_t[i] == "Zc")
                        {
                            codes[i] = 17;
                        }
                        if (codes_t[i] == "Ze")
                        {
                            codes[i] = 18;
                        }
                        if (codes_t[i] == "Zd")
                        {
                            codes[i] = 19;
                        }
                        if (codes_t[i] == "Zf")
                        {
                            codes[i] = 20;
                        }
                        if (codes_t[i] == "Zg")
                        {
                            codes[i] = 21;
                        }
                        if (codes_t[i] == "Zq")
                        {
                            codes[i] = 22;
                        }
                        if (codes_t[i] == "Zh")
                        {
                            codes[i] = 23;
                        }
                        if (codes_t[i] == "R0")
                        {
                            codes[i] = 27;
                        }
                        if (codes_t[i] == "R1")
                        {
                            codes[i] = 28;
                        }
                        if (codes_t[i] == "R2")
                        {
                            codes[i] = 138;
                        }
                        if (codes_t[i] == "C0")
                        {
                            codes[i] = 29;
                        }
                        if (codes_t[i] == "C8")
                        {
                            codes[i] = 30;
                        }
                        if (codes_t[i] == "C1")
                        {
                            codes[i] = 31;
                        }
                        if (codes_t[i] == "C2")
                        {
                            codes[i] = 32;
                        }
                        if (codes_t[i] == "C3")
                        {
                            codes[i] = 33;
                        }
                        if (codes_t[i] == "C5")
                        {
                            codes[i] = 35;
                        }
                        if (codes_t[i] == "C6")
                        {
                            codes[i] = 36;
                        }
                        if (codes_t[i] == "C7")
                        {
                            codes[i] = 37;
                        }
                        if (codes_t[i] == "M0")
                        {
                            codes[i] = 38;
                        }
                        if (codes_t[i] == "M1")
                        {
                            codes[i] = 39;
                        }
                        if (codes_t[i] == "c0")
                        {
                            codes[i] = 43;
                        }
                        if (codes_t[i] == "c1")
                        {
                            codes[i] = 44;
                        }
                        if (codes_t[i] == "c2")
                        {
                            codes[i] = 45;
                        }
                        if (codes_t[i] == "ck")
                        {
                            codes[i] = 46;
                        }
                        if (codes_t[i] == "cl")
                        {
                            codes[i] = 47;
                        }
                        if (codes_t[i] == "cj")
                        {
                            codes[i] = 48;
                        }
                        if (codes_t[i] == "cd")
                        {
                            codes[i] = 49;
                        }
                        if (codes_t[i] == "cm")
                        {
                            codes[i] = 50;
                        }
                        if (codes_t[i] == "cn")
                        {
                            codes[i] = 51;
                        }
                        if (codes_t[i] == "cv")
                        {
                            codes[i] = 52;
                        }
                        if (codes_t[i] == "ca")
                        {
                            codes[i] = 53;
                        }
                        if (codes_t[i] == "ci")
                        {
                            codes[i] = 54;
                        }
                        if (codes_t[i] == "ce")
                        {
                            codes[i] = 57;
                        }
                        if (codes_t[i] == "cf")
                        {
                            codes[i] = 58;
                        }
                        if (codes_t[i] == "cg")
                        {
                            codes[i] = 59;
                        }
                        if (codes_t[i] == "ch")
                        {
                            codes[i] = 60;
                        }
                        if (codes_t[i] == "ct")
                        {
                            codes[i] = 74;
                        }
                        if (codes_t[i] == "cu")
                        {
                            codes[i] = 76;
                        }
                        if (codes_t[i] == "cs")
                        {
                            codes[i] = 77;
                        }
                        if (codes_t[i] == "B1")
                        {
                            codes[i] = 162;
                        }
                        if (codes_t[i] == "B3")
                        {
                            codes[i] = 163;
                        }
                        if (codes_t[i] == "B2")
                        {
                            codes[i] = 164;
                        }
                        if (codes_t[i] == "VB")
                        {
                            codes[i] = 165;
                        }
                        if (codes_t[i] == "C9")
                        {
                            codes[i] = 131;
                        }
                        if (codes_t[i] == "Ca")
                        {
                            codes[i] = 132;
                        }
                        if (codes_t[i] == "Cb")
                        {
                            codes[i] = 133;
                        }
                        if (codes_t[i] == "Cc")
                        {
                            codes[i] = 134;
                        }
                        if (codes_t[i] == "Cd")
                        {
                            codes[i] = 135;
                        }
                        if (codes_t[i] == "Ce")
                        {
                            codes[i] = 136;
                        }
                        if (codes_t[i] == "Qig+")
                        {
                            codes[i] = 158;
                        }
                        if (codes_t[i] == "Qig-")
                        {
                            codes[i] = 159;
                        }
                        if (codes_t[i] == "gr+")
                        {
                            codes[i] = 160;
                        }
                        if (codes_t[i] == "gr-")
                        {
                            codes[i] = 161;
                        }
                        if (codes_t[i] == "iggs")
                        {
                            codes[i] = 141;
                        }
                        if (codes_t[i] == "Build")
                        {
                            codes[i] = 142;
                        }
                        if (codes_t[i] == "Hea")
                        {
                            codes[i] = 143;
                        }
                        if (codes_t[i] == "MineS")
                        {
                            codes[i] = 145;
                        }
                        if (codes_t[i] == "CLeftH")
                        {
                            codes[i] = 156;
                        }
                        if (codes_t[i] == "CRightH")
                        {
                            codes[i] = 157;
                        }
                        if (codes_t[i] == "CGun")
                        {
                            codes[i] = 146;
                        }
                        if (codes_t[i] == "FGun")
                        {
                            codes[i] = 147;
                        }
                        if (codes_t[i] == "hpf")
                        {
                            codes[i] = 148;
                        }
                        if (codes_t[i] == "hpp")
                        {
                            codes[i] = 149;
                        }
                        if (codes_t[i] == "Flip")
                        {
                            codes[i] = 144;
                        }

                        //else codes[i] = 0;
                    }

                }


                //var newStr = code_labels.Where(tmp => tmp.IndexOf("@") >= 0);
                string[] line = { "@" };
                int s2 = 0;
                for (int j = 0; j < code_labels.Length; j++)
                {
                    if (j < newStr.Length)
                    {
                        if (code_labels[j].IndexOf(line[0]) > 0)
                        {
                            newStr[s2] = j;
                            newStr2[s2] = code_labels[j];
                        }
                        s2++;
                    }
                }
                for (int i = 0; i < newStr2.Length; i++)
                {
                    //if (i < code_labels.Length)
                    //{
                    //if (i < newStr3.Length)
                    // {
                    if (newStr2[i] != "0")
                    {
                        newStr3 = newStr2[i].Split('@');
                        t1[i] = newStr3[0];
                        t2[i] = newStr3[1];
                    }
                    //

                    //}
                    //}
                }
                for (int i = 0; i < code_labels.Length; i++)
                {
                    if (i < t1.Length)
                    {
                        if (t1[i] != "-1")
                        {
                            code_labels[i] = t1[i];
                        }
                    }
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i < t2.Length)
                    {
                        if (t2[i] != "-1")
                        {
                            nums[i] = int.Parse(t2[i]);
                        }
                    }
                }

                /////

                for (int i = 0; i < codes.Length; i++)
                {
                    if (codes[i] != 0)
                    {
                        num = i;
                    }
                }
                if (num == 0)
                {
                    num = 1;
                }
                for (int j = 0; j < code_labels.Length; j++)
                {
                    if (code_labels[j] != "0" || nums[j] != 0)
                    {
                        num2 = j;
                    }
                }
                if (num2 == 0)
                {
                    num2 = 1;
                }
                string[] array = new string[num2 + 1];
                Array.Copy(code_labels, array, num2 + 1);
                for (int k = 0; k < array.Length; k++)
                {
                    if (nums[k] != 0)
                    {
                        string[] array2 = array;
                        int num3 = k;
                        array2[num3] = array2[num3] + "@" + nums[k];
                    }
                }
                string s = string.Join(":", array);
                byte[] array3 = new byte[num + 1];
                for (int l = 0; l < array3.Length; l++)
                {
                    array3[l] = Convert.ToByte(codes[l]);
                }
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                byte[] bytes2 = BitConverter.GetBytes(array3.Length);
                byte[] array4 = new byte[bytes2.Length + array3.Length + bytes.Length];
                Buffer.BlockCopy(bytes2, 0, array4, 0, bytes2.Length);
                Buffer.BlockCopy(array3, 0, array4, bytes2.Length, array3.Length);
                Buffer.BlockCopy(bytes, 0, array4, bytes2.Length + array3.Length, bytes.Length);

                string result;

                result = Convert.ToBase64String(SevenZipHelper.Compress(array4));

                //richTextBox3.Text = string.Join(";", codes_text);

                richTextBox3.Text = string.Join(";", text);
                //richTextBox2.Text = string.Join(";", t2);

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Раздел в разработке", "Внимание!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

// №5а Дано слово и словарь,предоставляющий набор слов.Необходимо подсчитать количество слов в словаре,
// которые можно составить из букв исходного слова
// а) Разрешается использовать не все буквы исходного слова
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NewtonPolynomial
{
    public partial class MainForm : Form
    {
        //Словарь
        Dictionary ListOfWords;
        List<string> Table = new List<string>();
        // Конструктор формы
        public MainForm()
        {
            ListOfWords = new Dictionary();

            InitializeComponent();
        }



        // Настройка при загрузке формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            DictionaryGridView.ColumnCount = 1;
            DictionaryGridView.RowCount = 1;
            
    }



        //добавление слов в словарь
        private void butAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i=0;(flag)&&(i< WordBox.Text.Length);i++)
            {
                flag = Char.IsLetter(WordBox.Text[i]);
            };
            if ((flag) && (WordBox.Text.Length != 0))
            {
                DictionaryGridView.Rows.Add(WordBox.Text);
                Table.Add(WordBox.Text.ToLower());
                WordBox.Clear();
            }
            else
                MessageBox.Show("Введено недопустимое значение!",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //поиск слов в словаре
        private void butFind_Click(object sender, EventArgs e)
        {
            SetInterfaceState(false);
            if (ListOfWords.InputData(Table,WordBox.Text.ToLower()))
            {
                ListOfWords.Run();
                SetInterfaceState(true);
                CountBox.Text = Convert.ToString(ListOfWords.Count);
            }
            else
            {
                MessageBox.Show("Нехватка данных!",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SetInterfaceState(true); // разблокировка интерфейса
            }
        }
        //блокировка/разблокировка кнопок и строку ввода
        private void SetInterfaceState(bool state)
        {
            List<string> Table = new List<string>();
            FindWordsButton.Enabled = state;
            AddWordButton.Enabled = state;
            ClearButton.Enabled = state;
            inputDataGroupBox.Enabled = state;
        }
        //кнопка очистка
        private void ClearBut_Click(object sender, EventArgs e)
        {
            CountBox.Clear();
            WordBox.Clear();
            DictionaryGridView.Rows.Clear();
            //dataGridView1.DataSource = null;

        }
    }
}
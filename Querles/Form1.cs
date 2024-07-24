using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Querles
{
    internal static class Queries
    {
        public static string QuerlesPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Querles.xml");
    }

    internal record QueriesModel(string DayWeek, int DayMonth, string Month, string Year);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXMLIfNotExists();
        }

        public static void CreateXMLIfNotExists()
        {
            if (!File.Exists(Queries.QuerlesPath))
            {
                XDocument document = new();
                XElement queries = new("queries");
                document.Add(queries);
                document.Save(Queries.QuerlesPath);
            }
        }

        public void AddQueries(string dayWeek, int dayMonth, string month, string year)
        {
            XDocument document = XDocument.Load(Queries.QuerlesPath);

            string result = $"{GetDayWeekText(dayWeek)} {GetDayMonthText(dayMonth)} {month} {GetYearText(year)}";

            XElement query = new("query",
                new XElement("day", dayWeek),
                new XElement("dayMonth", dayMonth),
                new XElement("Month", month),
                new XElement("year", year),
                new XElement("result", result)
            );

            document.Root?.Add(query);
            document.Save(Queries.QuerlesPath);

            MessageBox.Show(result);
        }

        private string GetDayWeekText(string dayWeek)
        {
            return dayWeek switch
            {
                "�����" => "���� ����",
                "���" => "���� ����",
                "�����" => "������ ����",
                "�����" => "������ ����",
                "�����" => "������ ����",
                "����" => "����� ����",
                _ => "�� ����"
            };
        }

        private string GetDayMonthText(int dayMonth)
        {
            return dayMonth switch
            {
                1 => "��� ��� ����",
                2 => "��� ���� ����",
                3 => "����� ���� ����",
                4 => "����� ���� ����",
                5 => "����� ���� ����",
                6 => "���� ���� ����",
                7 => "���� ���� ����",
                8 => "����� ���� ����",
                9 => "���� ���� ����",
                10 => "���� ���� ����",
                11 => "��� ��� ���� ����",
                12 => "���� ��� ���� ����",
                13 => "����� ��� ���� ����",
                14 => "����� ��� ���� ����",
                15 => "����� ��� ���� ����",
                16 => "���� ��� ���� ����",
                17 => "���� ��� ���� ����",
                18 => "����� ��� ���� ����",
                19 => "���� ��� ���� ����",
                20 => "����� ���� ����",
                21 => "����� ���� ���� ����",
                22 => "����� ������ ���� ����",
                23 => "����� ������ ���� ����",
                24 => "����� ������ ���� ����",
                25 => "����� ������ ���� ����",
                26 => "����� ����� ���� ����",
                27 => "����� ����� ���� ����",
                28 => "����� ������ ���� ����",
                29 => "����� ����� ���� ����",
                30 => "������ ���� ����",
                _ => "�� ����"
            };
        }

        private string GetYearText(string year)
        {
            return year switch
            {
                "���''�" => "��� ���� ����� ���� ���� ������� ������ ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������� ������ ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������� ����� ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������� ����� ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������� ������ ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������� ����� ������ �����",
                "��''�" => "��� ���� ����� ���� ���� ������ ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������ ���� ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������ ������ ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������ ������ ������ �����",
                "���''�" => "��� ���� ����� ���� ���� ������ ������ ������ �����",
                _ => "�� ����"
            };
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxDayMonth.Text, out int dayMonth))
            {
                AddQueries(comboBoxDayWeek.Text, dayMonth, comboBoxMonth.Text, comboBoxYear.Text);
            }
            else
            {
                MessageBox.Show("��� ��� ���� ���� ���� �����.");
            }
        }
    }
}

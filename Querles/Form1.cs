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
                "ראשון" => "באחד בשבת",
                "שני" => "בשני בשבת",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "שישי" => "בשישי בשבת",
                _ => "לא ידוע"
            };
        }

        private string GetDayMonthText(int dayMonth)
        {
            return dayMonth switch
            {
                1 => "יום אחד לירח",
                2 => "שני ימים לירח",
                3 => "שלושה ימים לירח",
                4 => "ארבעה ימים לירח",
                5 => "חמישה ימים לירח",
                6 => "שישה ימים לירח",
                7 => "שבעה ימים לירח",
                8 => "שמונה ימים לירח",
                9 => "תשעה ימים לירח",
                10 => "עשרה ימים לירח",
                11 => "אחד עשר ימים לירח",
                12 => "שנים עשר ימים לירח",
                13 => "שלושה עשר ימים לירח",
                14 => "ארבעה עשר ימים לירח",
                15 => "חמישה עשר ימים לירח",
                16 => "שישה עשר ימים לירח",
                17 => "שבעה עשר ימים לירח",
                18 => "שמונה עשר ימים לירח",
                19 => "תשעה עשר ימים לירח",
                20 => "עשרים ימים לירח",
                21 => "עשרים ואחד ימים לירח",
                22 => "עשרים ושתיים ימים לירח",
                23 => "עשרים ושלושה ימים לירח",
                24 => "עשרים וארבעה ימים לירח",
                25 => "עשרים וחמישה ימים לירח",
                26 => "עשרים ושישה ימים לירח",
                27 => "עשרים ושבעה ימים לירח",
                28 => "עשרים ושמונה ימים לירח",
                29 => "עשרים ותשעה ימים לירח",
                30 => "שלושים ימים לירח",
                _ => "לא ידוע"
            };
        }

        private string GetYearText(string year)
        {
            return year switch
            {
                "תשפ''ד" => "שנת חמשת אלפים ושבע מאות ושמונים וארבעה לבריאת העולם",
                "תשפ''ה" => "שנת חמשת אלפים ושבע מאות ושמונים וחמישה לבריאת העולם",
                "תשפ''ו" => "שנת חמשת אלפים ושבע מאות ושמונים ושישה לבריאת העולם",
                "תשפ''ז" => "שנת חמשת אלפים ושבע מאות ושמונים ושבעה לבריאת העולם",
                "תשפ''ח" => "שנת חמשת אלפים ושבע מאות ושמונים ושמונה לבריאת העולם",
                "תשפ''ט" => "שנת חמשת אלפים ושבע מאות ושמונים ותשעה לבריאת העולם",
                "תש''צ" => "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם",
                "תשצ''א" => "שנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם",
                "תשצ''ב" => "שנת חמשת אלפים ושבע מאות ותשעים ושניים לבריאת העולם",
                "תשצ''ג" => "שנת חמשת אלפים ושבע מאות ותשעים ושלושה לבריאת העולם",
                "תשצ''ד" => "שנת חמשת אלפים ושבע מאות ותשעים וארבעה לבריאת העולם",
                _ => "לא ידוע"
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
                MessageBox.Show("אנא בחר מספר חוקי ליום החודש.");
            }
        }
    }
}

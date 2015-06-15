using CathedraUniversity.Forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraUniversity.Forms.Service
{
    public partial class FormSheduleData : Form
    {
        private DatabaseDataContext myDatabase = new DatabaseDataContext();

        public FormSheduleData()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSheduleData_Load(object sender, EventArgs e)
        {
            schoolYearBindingSource.DataSource = myDatabase.SchoolYear;
            int i = 0;
            foreach (SchoolYear sy in schoolYearBindingSource)
            {
                if (sy.ID == Settings.SchoolYearId)
                {
                    schoolYearBindingSource.Position = i;
                    break;
                }
                i++;
            }

            string[] semestrNames = Enum.GetNames(typeof(Semestr));
            foreach (string s in semestrNames) comboBoxSemestr.Items.Add(s);
            comboBoxSemestr.Text = semestrNames[1]; // Весенний
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SchoolYear sy = (SchoolYear)schoolYearBindingSource.Current;
            Semestr semestr = (Semestr)Enum.Parse(typeof(Semestr), comboBoxSemestr.Text);

            List<string> ls = new List<string>();

            var q = from cif in myDatabase.CourseInWork
                where
                    cif.SchoolYear.ID == sy.ID &&
                    cif.Semestr == (short?) semestr &&
                    cif.FormStudy == radioButtonOchniki.Checked 
                orderby cif.Course.ID, cif.ID  
                select cif;

            // File.WriteAllLines("shedule.txt", ls);

            ls.Add("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">");
            ls.Add("<html>");
            ls.Add(" <head>");
            ls.Add("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\">");
            ls.Add("  <title>Распределение учебной нагрузки</title>");
            ls.Add(" </head>");
            ls.Add(" <body>");
            ls.Add("<p align=\"center\">Для составления расписания занятий со студентами представить в учебный отдел к _______________ 20 __ г.</p>");
            ls.Add("<p align=\"right\"><b>Кафедра АСУ</b></p>");
            ls.Add("<h1 align=\"center\">РАСПРЕДЕЛЕНИЕ</h1>");
            string s = String.Format("учебной нагрузки для {0} на {1} семестр {2} учебного года", radioButtonOchniki.Checked ? "очников" : "заочников", semestr.ToString().ToLower(), sy.Years);
            ls.Add("<p align=\"center\">" + s + "</p>");
            ls.Add("<table border=\"1\">");
            ls.Add("<thead>");
            ls.Add("<tr>");
            ls.Add("<td><b>Дисциплина</b></td>");
            ls.Add("<td><b>Вид занятий</b></td>");
            ls.Add("<td><b>Номера учебных групп</b></td>");
            ls.Add("<td><b>Ученое звание, должность, фамилия и инициалы преподавателя</b></td>");
            ls.Add("<td><b>Номера лабораторий</b></td>");
            ls.Add("<td><b>Примечание</b></td>");
            ls.Add("</tr>");
            ls.Add("<tr>");
            ls.Add("<td align=\"center\">1</td>");
            ls.Add("<td align=\"center\">2</td>");
            ls.Add("<td align=\"center\">3</td>");
            ls.Add("<td align=\"center\">4</td>");
            ls.Add("<td align=\"center\">5</td>");
            ls.Add("<td align=\"center\">6</td>");
            ls.Add("</tr>");
            ls.Add("</thead>");
            ls.Add("<tbody>");
            int counter = 1;
            //HtmlTableRow oldhtr = new HtmlTableRow();
            //List<HtmlTableRow> lhtr = new List<HtmlTableRow>();


            foreach (CourseInWork cif in q)
            {
                //string s = String.Format("{0}, {1}, {2}, {3}, {4}",
                //    licf.CourseInWork.Course.Name,
                //    licf.LoadInCoursePlan.SortLoad.ShortName,
                //    licf.Employee.ShortName,
                //    licf.Groups,
                //    licf.ClassRoom.Number
                //    );
                //ls.Add(s);

                int rowspan = cif.LoadInCoursePlan.Count(p => p.SortLoad.IsClass);
                if (rowspan > 0)
                {

                    string rs = "";

                    rs += "<tr id=\"datarow\">";
                    // if (RowSpan > 0)

                    // Пробегаемся по списку видов нагрузки


                    rs += String.Format("<td rowspan=\"{0}\">{1}</td>", rowspan, counter++ + ". " + cif.Course.Name);

                    bool isfirstline = true;
                    foreach (var licp in cif.LoadInCoursePlan.Where(p => p.SortLoad.IsClass))
                    {
                        if (!isfirstline) rs += "</tr>"; else isfirstline = false;

                        rs += "<td>" + licp.SortLoad.ShortName + "</td>";
                        rs += "<td>" + cif.Groups + "</td>";

                        string emps = "";
                        foreach (LoadInCourseFact licf in licp.LoadInCourseFact)
                        {
                            if (!String.IsNullOrEmpty(emps)) emps += ", ";
                            emps += licf.Employee.ShortName;
                        }
                        rs += "<td>" + emps + "</td>";
                        rs += "<td>" + licp.LoadInCourseFact.First().ClassRoom.Number + "</td>";
                        rs += "<td></td>";
                        rs += "</tr>";
                    }
                    ls.Add(rs);
                }
            }

            //foreach (CourseInWork ciw in q)
            //{
            //    HtmlTableRow htr = new HtmlTableRow(ciw.Course.Name,
            //    ciw.LectHours, ciw.LabHours, ciw.UprHours, 
            //    ciw.Groups,
            //    ciw.Employee.ShortName,
            //    ciw.Room);

            //    if (lhtr.Count > 0 && oldhtr.Course != "" && (oldhtr.Course != htr.Course || oldhtr.Groups != htr.Groups))
            //    {
            //        lhtr[0].Course = counter + ". " + lhtr[0].Course;
            //        counter++;
            //        for (int i = 0; i < lhtr.Count; i++)
            //        {
            //            HtmlTableRow r = lhtr[i];
            //            if (i == 0)
            //                ls.Add(r.TableRow(lhtr.Count));
            //            else
            //                ls.Add(r.TableRow(0));
            //        }
            //        lhtr.Clear();
            //    }
            //    if ((ciw.LabHours > 0) || (ciw.LectHours > 0) || (ciw.UprHours > 0))
            //    {
            //        if (oldhtr.Course == htr.Course &&
            //            oldhtr.Groups == htr.Groups &&
            //            (oldhtr.LectHours == 0 || oldhtr.LectHours == null) &&
            //            (htr.LectHours == 0 || htr.LectHours == null) &&
            //            oldhtr.LabHours > 0 &&
            //            htr.LabHours > 0)
            //        {
            //            oldhtr.Employee += ", " + htr.Employee;
            //        }
            //        else
            //            lhtr.Add(htr);
            //        oldhtr = htr;
            //    }
            //}
            //if (oldhtr.Course != "")
            //{
            //    if (lhtr.Count > 0)
            //    {
            //        lhtr[0].Course = counter + ". " + lhtr[0].Course;
            //        for (int i = 0; i < lhtr.Count; i++)
            //        {
            //            HtmlTableRow r = lhtr[i];
            //            if (i == 0)
            //                ls.Add(r.TableRow(lhtr.Count));
            //            else
            //                ls.Add(r.TableRow(0));
            //        }
            //    }
            //}

            ls.Add("</tbody>");
            ls.Add("</table>");
            ls.Add(" </body>");
            ls.Add("</html>");

            File.WriteAllLines("Shedule.html", ls.ToArray(), Encoding.GetEncoding(1251));
            Process.Start("Shedule.html");
            Close();
            MessageBox.Show(@"Формирование завершено!");
        }

        //public class HtmlTableRow
        //{
        //    public string Course = "";
        //    public decimal? LectHours;
        //    public decimal? LabHours;
        //    public decimal? UprHours;
        //    public string Groups;
        //    public string Employee;
        //    public string Room;

        //    public HtmlTableRow()
        //    {
        //    }

        //    public HtmlTableRow(string ACourse, decimal? ALectHours, decimal? ALabHours, decimal? AUprHours, string AGroups, string AEmployee, string ARoom)
        //    {
        //        Course = ACourse;
        //        LectHours = ALectHours;
        //        LabHours = ALabHours;
        //        UprHours = AUprHours;
        //        Groups = AGroups;
        //        Employee = AEmployee;
        //        Room = ARoom;
        //    }

        //    public string VidNagruzki
        //    {
        //        get
        //        {
        //            string vz = "";
        //            if (LectHours > 0) vz = "лекции";
        //            if (LabHours > 0) vz = vz + (String.IsNullOrEmpty(vz) ? " " : ", ") + "лаб.раб.";
        //            if (UprHours > 0) vz = vz + (String.IsNullOrEmpty(vz) ? " " : ", ") + "упражнения";
        //            return vz;
        //        }
        //    }

        //    public string TableRow(int RowSpan)
        //    {
        //        string rs = "";
        //        rs += "<tr id=\"datarow\">";

        //        if (RowSpan > 0)
        //            rs += String.Format("<td rowspan=\"{0}\">{1}</td>", RowSpan, Course);

        //        rs += "<td>" + VidNagruzki + "</td>";

        //        rs += "<td>" + Groups + "</td>";

        //        rs += "<td>" + Employee + "</td>";

        //        rs += "<td>" + Room + "</td>";

        //        rs += "<td></td>";

        //        rs += "</tr>";

        //        return rs;
        //    }
        //}
    }
}

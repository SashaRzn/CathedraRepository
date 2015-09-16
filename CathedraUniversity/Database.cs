using System.Security.Cryptography;
using CathedraUniversity.Forms.Classes;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace CathedraUniversity
{
    partial class DatabaseDataContext
    {
    }

	partial class CourseInWork
	{
        /// <summary>
        /// Общее количество запланированных часов
        /// </summary>
		public decimal TotalPlanHours
		{
			get
			{
				decimal totalCountHours = 0;
				foreach (LoadInCoursePlan loadPlan in this.LoadInCoursePlan)
				{
					totalCountHours += loadPlan.CountHours;
				}
				return totalCountHours;
			}
		}

        /// <summary>
        /// Общее количество распределенных часов
        /// </summary>
        public decimal TotalDistributeHours
        {
            get
            {
                decimal totalCountHours = 0;

                foreach (LoadInCoursePlan loadPlan in this.LoadInCoursePlan)
                {
                    if (loadPlan.ByGroups == true)
                    {
                        if (loadPlan.LoadInCourseFact.Count() == this.GroupInCourse.Count())
                        {
                            totalCountHours += loadPlan.CountHours;
                        }
                    }
                    else
                    {
                        foreach (LoadInCourseFact loadFact in loadPlan.LoadInCourseFact)
                        {
                            totalCountHours += loadFact.CountHours;
                        }
                    }
                }
                return totalCountHours;                
            }
        }

		/// <summary>
		/// Метод, возвращающий количество часов распределенных по указанному
		/// виду нагрузки
		/// </summary>
		/// <param name="sortLoadId">Вид нагрузки</param>
		/// <returns>Количество часов</returns>
		public decimal DistributedHoursOnLoad(int sortLoadId)
		{
			decimal distributedHours = 0;

			foreach (LoadInCoursePlan loadPlan in this.LoadInCoursePlan)
			{
				if (loadPlan.SortLoadID == sortLoadId)
				{
  					foreach (LoadInCourseFact loadFact in loadPlan.LoadInCourseFact)
					{
						distributedHours += loadFact.CountHours;
					}
                    if (loadPlan.ByGroups == true)
                    {
                        distributedHours = distributedHours / this._GroupInCourse.Count;
                    }
				}
			}
			return distributedHours;
		}

		/// <summary>
		/// Возвращает группы, назначенные на курс
		/// </summary>
		public string Groups
		{
			get
			{
			    string rs = "";
				foreach (GroupInCourse groupInCourse in this.GroupInCourse)
				{
				    if (!String.IsNullOrEmpty(rs)) rs += ", ";
				    rs += groupInCourse.GroupInSemestr.Group.Group1;
				}
				return rs;
			}
		}

		public string SemestrString
		{
			get
			{
				if (this.Semestr == null) return "";
				if (Semestr == 1) return "Осенний";
				else return "Весенний";
			}
		}


		/// <summary>
		/// Свойство, возвращающее true - если лабораторные работы нужно делить
		/// или false - если не нужно
		/// </summary>
		public bool IsDivisionLab
		{
			get
			{
				bool isDivision = false;
				if (this.GroupInCourse.Count > 1)
				{
					isDivision = true;
				}
				else
				{
					int countStudents = 0;
					GroupInSemestr groupInSemestr = GroupInCourse[0].GroupInSemestr;
                    if (groupInSemestr.QuantityBudget != null) //&& groupInSemestr.QuantityCommercial != null)
                    {
						countStudents += (int)groupInSemestr.QuantityBudget;
					}
					if (groupInSemestr.QuantityCommercial != null)
					{
						countStudents += (int)groupInSemestr.QuantityCommercial;
					}

					if (countStudents > 15)
					{
						isDivision = true;
					}
				}
				return isDivision;
			}
		}
	}


	partial class LoadInCourseFact
	{
		public string CourseName
		{
			get
			{
				return this.CourseInWork.Course.Name;
			}
		}

		public string CourseSemestr
		{
			get
			{
				return this.CourseInWork.SemestrString;
			}
		}

		public string Groups
		{
			get
			{
				if (GroupInCourseID != null)
				{
					return this.GroupInCourse.GroupInSemestr.GroupName;
				}
				else
				{
					return this.CourseInWork.Groups;
				}		
			}
		}


		/// <summary>
		/// Нагрузка в часах
		/// </summary>
		public string WorkLoad
		{
			get
			{
				
				return "Нагрузка";
			}
		}


		public string SortLoadName
		{
			get
			{
				return this.LoadInCoursePlan.SortLoad.Name;
			}
		}

		public string ClassRoomNumber
		{
			get
			{
                if (this.ClassRoom != null)
                {
                    return this.ClassRoom.Number;
                }
                else
                {
                    return "";
                }
				
			}
		}

	    public string EmployeeFactFio
	    {
	        get { return Employee1.ShortName; }
	    }

	    public string EmployeeFormFio
	    {
            get { return Employee.ShortName;  }
	    }

	    public bool FactFormDiffers
	    {
	        get
	        {
	            if (Employee != null && Employee1 != null)
	                return Employee.Id != Employee1.Id;
	            else
	                return false;
	        }
	        set
	        {
	            
	        }


	    }
	}


	partial class Post
	{
		public int NameLength
		{
			get { return Name.Length; }
		}

		/// <summary>
		/// Количество часов нагрузки на единицу ставки в заданному учебном году
		/// </summary>
		/// <param name="schoolYearId"></param>
		/// <returns></returns>
		public int RateInHoursInSchoolYear(int schoolYearId)
		{
			if (schoolYearId == 0) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == schoolYearId) return Utils.SafeInt(ps.RateInHours);
			}
			return 0;
		}

		/// <summary>
		/// Коэффициент нагрузки в заданном учебном году
		/// </summary>
		/// <param name="ASchoolYear"></param>
		/// <returns></returns>
		public decimal KInSchoolYear(SchoolYear ASchoolYear)
		{
			if (ASchoolYear == null) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == ASchoolYear.ID) return Utils.SafeDecimal(ps.K);
			}
			return 0;
		}

		/// <summary>
		/// Базовый оклад в заданном учебном году
		/// </summary>
		/// <param name="ASchoolYear"></param>
		/// <returns></returns>
		public decimal BaseSalaryInSchoolYear(SchoolYear ASchoolYear)
		{
			if (ASchoolYear == null) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == ASchoolYear.ID) return Utils.SafeDecimal(ps.BaseSalary);
			}
			return 0;
		}

		/// <summary>
		/// Должностной оклад в заданном учебном году
		/// </summary>
		/// <param name="ASchoolYear"></param>
		/// <returns></returns>
		public decimal PostSalaryInSchoolYear(SchoolYear ASchoolYear)
		{
			if (ASchoolYear == null) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == ASchoolYear.ID) return Utils.SafeDecimal(ps.PostSalary1);
			}
			return 0;
		}

		/// <summary>
		/// Доплата за степень в заданном учебном году
		/// </summary>
		/// <param name="ASchoolYear"></param>
		/// <returns></returns>
		public decimal GradeSurchargeInSchoolYear(SchoolYear ASchoolYear)
		{
			if (ASchoolYear == null) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == ASchoolYear.ID) return Utils.SafeDecimal(ps.GradeSurcharge);
			}
			return 0;
		}

		/// <summary>
		/// Доплата за должность в заданном учебном году
		/// </summary>
		/// <param name="ASchoolYear"></param>
		/// <returns></returns>
		public decimal PostSurchargeInSchoolYear(SchoolYear ASchoolYear)
		{
			if (ASchoolYear == null) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == ASchoolYear.ID) return Utils.SafeDecimal(ps.PostSurcharge);
			}
			return 0;
		}

		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0}", this.Name);
		}
	}

	partial class Employee
	{
		public string ShortName
		{
			get { return this.ToString(); }
		}

		public override string ToString()
		{
			string[] _fio = this.Fio.Split(' ');
			string _f = "", _i = "", _o = "";
			if (_fio.Length >= 1) _f = _fio[0];
			if (_fio.Length >= 2) _i = _fio[1][0] + ".";
			if (_fio.Length >= 3) _o = _fio[2][0] + ".";

			return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0} {1} {2}{3}",
				this.Post.ShortName,
				_f, _i, _o);
		}

		public decimal countHoursInPochFond
		{
			get
			{
				decimal countHours = 0;

				int currentSchoolYear = Settings.SchoolYearId;
				List<LoadInCourseFact> loadFacts = (from e in this.LoadInCourseFact
													where e.PochFond == true && e.CourseInWork.SchoolYearID == currentSchoolYear
													select e).ToList();
				if (loadFacts.Count > 0)
				{
					countHours = (from c in loadFacts
								  select c.CountHours).Sum();
				}

				return countHours;
			}
		}

		public int pochFondLimit
		{
			get
			{
				int pochFondLimit = 0;

				int currentSchoolYear = Settings.SchoolYearId;
				Rate rate = (from c in this.Rate
							 where c.SchoolYearID == currentSchoolYear
							 select c).SingleOrDefault();
				if (rate != null)
				{
					pochFondLimit = rate.PochFondLimit;
				}

				return pochFondLimit;

			}
		}

		/// <summary>
		/// Формальная нагрузка в часах
		/// </summary>
		public decimal WorkloadForm
		{
			get
			{
				decimal workloadFrom = 0;
				int schoolYearId = Settings.SchoolYearId;
				foreach (LoadInCourseFact loadFact in this.LoadInCourseFact)
				{
					if (loadFact.CourseInWork != null)
					{
						if (loadFact.CourseInWork.SchoolYearID == schoolYearId)
						{
							workloadFrom += loadFact.CountHours;
						}
					}
				}


				//using (DatabaseDataContext context = new DatabaseDataContext())
				//{
				//	List<LoadInCourseFact> loadFacts = (from e in context.LoadInCourseFact
				//										where e.EmployeeFormID == this.Id && e.CourseInWork.SchoolYearID == schoolYearId
				//										select e).ToList();
				//	if (loadFacts.Count > 0)
				//	{
				//		workloadFrom = (from w in loadFacts
				//						select w.CountHours).Sum();
				//	}

				//}
				return workloadFrom;
			}
		}

		/// <summary>
		/// Ставка по формальной нагрузке
		/// </summary>
		public decimal RateForm
		{
			get
			{
				decimal rateForm = 0;
				int schoolYearId = Settings.SchoolYearId;

				foreach (Rate r in this.Rate)
				{
					if (r.SchoolYear.ID == schoolYearId)
					{
						rateForm += r.Rate1 == null ? 0 : (decimal)r.Rate1;
					}
				}
				return rateForm;
			}
		}

		/// <summary>
		/// Фактическая нагрузка в часах
		/// </summary>
		public decimal WorkloadFact
		{
			get
			{
				decimal workloadFact = 0;
				int schoolYearId = Settings.SchoolYearId;
				foreach (LoadInCourseFact loadFact in this.LoadInCourseFact1)
				{
					if (loadFact.CourseInWork != null)
					{
						if (loadFact.CourseInWork.SchoolYearID == schoolYearId)
						{
							workloadFact += loadFact.CountHours;
						}
					}
				}

				//using (DatabaseDataContext context = new DatabaseDataContext())
				//{
				//	List<LoadInCourseFact> loadFacts = (from e in context.LoadInCourseFact
				//										where e.EmployeeFactID == this.Id && e.CourseInWork.SchoolYearID == schoolYearId
				//										select e).ToList();
				//	if (loadFacts.Count > 0)
				//	{
				//		workloadFact = (from w in loadFacts
				//						select w.CountHours).Sum();
				//	}

				//}

				return workloadFact;
			}
		}

		/// <summary>
		/// Ставка по фактической нагрузке
		/// </summary>
		public decimal? RateFact
		{
			get
			{
				int schoolYearId = Settings.SchoolYearId;
				if (this.Post.RateInHoursInSchoolYear(schoolYearId) == null)
					return null;
				else if (this.Post.RateInHoursInSchoolYear(schoolYearId) == 0)
					return null;
				else
					return Math.Round(WorkloadFact / (decimal)this.Post.RateInHoursInSchoolYear(schoolYearId), 3);
			}
		}

		/// <summary>
		/// Лимит почасового фонда
		/// </summary>
		public int PochFondLimit
		{
			get
			{
				int limit = 0;
				int schoolYearId = Settings.SchoolYearId;
				foreach (Rate r in this.Rate)
				{
					if (r.SchoolYear.ID == schoolYearId)
					{
						limit = r.PochFondLimit;
						break;
					}
				}
				return limit;
			}
		}

		
		public decimal? RateFormByHours
		{
			get
			{
				int schoolYearId = Settings.SchoolYearId;
				if (this.Post.RateInHoursInSchoolYear(schoolYearId) == null)
					return null;
				else if (this.Post.RateInHoursInSchoolYear(schoolYearId) == 0)
					return null;
				else
					return Math.Round(this.WorkloadForm / (decimal)this.Post.RateInHoursInSchoolYear(schoolYearId), 3);
			}
		}


		/// <summary>
		/// Количество часов по ставке
		/// </summary>
		public decimal RateInHours
		{
			get
			{
				int schoolYearId = Settings.SchoolYearId;
				decimal? rateInHours = this.Post.RateInHoursInSchoolYear(schoolYearId);
				if (rateInHours == null) rateInHours = 0;
				return Math.Round(this.RateForm * (decimal)rateInHours, 3);
			}
		}


		public bool IsOverload
		{
			get
			{
				decimal rateFormByHours = this.RateFormByHours == null ? 0 : (decimal)this.RateFormByHours;
				decimal highBound = RateForm + RateForm * Settings.LoadPercent / (decimal)100;
				if (rateFormByHours > highBound)
					return true;
				else
					return false;
			}
		}


		public bool IsUnderload
		{
			get
			{
				decimal rateFormByHours = this.RateFormByHours == null ? 0 : (decimal)this.RateFormByHours;
				decimal lowBound = RateForm - RateForm * Settings.LoadPercent / (decimal)100;
				if (rateFormByHours < lowBound)
					return true;
				else
					return false;

			}
		}


		/// <summary>
		/// Признак перегрузки по почасовому фонду 
		/// </summary>
		public bool IsPochFondOverload
		{
			get
			{
				return this.countHoursInPochFond > this.PochFondLimit;
			}
		}


		public decimal Overload
		{
			get
			{
				int schoolYearId = Settings.SchoolYearId;
				decimal overload = this.WorkloadForm - this.Post.RateInHoursInSchoolYear(schoolYearId) * this.RateForm;
				if (overload > 0)
					return overload;
				else
					return 0;
			}
		}


		public decimal Underload
		{
			get
			{
				int schoolYearId = Settings.SchoolYearId;
				decimal underload = this.Post.RateInHoursInSchoolYear(schoolYearId) * this.RateForm - this.WorkloadForm;
				if (underload > 0)
					return underload;
				else
					return 0;
			}
		}

		/// <summary>
		/// Фактическая нагрузка в часах, на других преподавателях
		/// </summary>
		public decimal WorkloadFactTutor
		{
			get
			{
				decimal workloadFact = 0;
				//foreach (CourseInWork ACourseInWork in this.Employee.CourseInWork)
				//{
				//	if (ACourseInWork.Fact != null && ACourseInWork.SchoolYear.ID == this.SchoolYear.ID)
				//	{
				//		if (ACourseInWork.Fact == (short)WorkloadType.Фактическая)
				//		{
				//			var q = from ciw in this.SchoolYear.CourseInWork
				//					where ciw.Semestr == ACourseInWork.Semestr &&
				//						ciw.CourseID == ACourseInWork.CourseID
				//					select ciw;
				//			List<CourseInWork> coursesToFind = q.ToList<CourseInWork>();
				//			// CourseInWork ciwTwin = ACourseInWork.GetTwin(coursesToFind);
				//			CourseInWork ciwTwin = ACourseInWork.GetTwin();
				//			if (ciwTwin != null && iCathedra_Settings.PochFondKod != ciwTwin.EmployeeID)
				//			{
				//				workloadFact += (decimal)ACourseInWork.AllHours;
				//			}
				//		}
				//	}
				//}
				return workloadFact;
			}
		}

		/// <summary>
		/// Фактическая нагрузка почасовой фонд
		/// </summary>
		public decimal WorkloadFactPochFond
		{
			get
			{
				decimal workloadFact = 0;
				//foreach (CourseInWork ACourseInWork in this.Employee.CourseInWork)
				//{
				//	if (ACourseInWork.Fact != null && ACourseInWork.SchoolYear.ID == this.SchoolYear.ID)
				//	{
				//		if (ACourseInWork.Fact == (short)WorkloadType.Фактическая)
				//		{
				//			var q = from ciw in this.SchoolYear.CourseInWork
				//					where ciw.Semestr == ACourseInWork.Semestr &&
				//						ciw.CourseID == ACourseInWork.CourseID
				//					select ciw;
				//			List<CourseInWork> coursesToFind = q.ToList<CourseInWork>();
				//			// CourseInWork ciwTwin = ACourseInWork.GetTwin(coursesToFind);
				//			CourseInWork ciwTwin = ACourseInWork.GetTwin();
				//			if (ciwTwin != null && ciwTwin.EmployeeID == iCathedra_Settings.PochFondKod)
				//			{
				//				workloadFact += (decimal)ACourseInWork.AllHours;
				//			}
				//		}
				//	}
				//}
				return workloadFact;
			}
		}

        //private string GetHoursRow(decimal? AValue, string ADesc, CourseInWork ATwin)
        //{
        //    if (Utils.SafeDecimal(AValue) != 0)
        //    {
        //        string _rs = "";
        //        _rs += ("                    " + ADesc + " - ").PadRight(40) + Utils.SafeDecimal(AValue).ToString();
        //        if (ATwin != null)
        //        {
        //            if (ATwin.Fact == (short)WorkloadType.Формальная)
        //                _rs += " (формально " + ATwin.Employee.ShortName.Trim() + ")";
        //            else if (ATwin.Fact == (short)WorkloadType.Фактическая)
        //                _rs += " (фактически " + ATwin.Employee.ShortName.Trim() + ")";
        //        }
        //        _rs += "\n";
        //        return _rs;
        //    }
        //    else
        //        return "";
        //}

        public string GetEmployeeInfo(SchoolYear sy)
        {
            string returnString = "";

            returnString += "=======================================================================\r\n";
            returnString += "Данные по состоянию на " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "\r\n";
            returnString += "=======================================================================\r\n";
            returnString += ("ФИО: ").PadRight(40) + Fio + "\r\n";
            returnString += ("Должность: ").PadRight(40) + Post.Name + "\r\n";
            returnString += ("Учебный год: ").PadRight(40) + sy.Years + "\r\n";
            returnString += ("Ставка по коммерческому набору: ").PadRight(40) + this.RateForm + "\r\n";
            returnString += ("Часов нагрузки согласно ставке:").PadRight(40) + this.RateInHours + "\r\n";
            returnString += "\r\n";

            #region Формальная нагрузка
            returnString += "============================================================\r\n";

            //var q = (from lf in this.LoadInCourseFact
            //    where lf.CourseInWork.SchoolYearID == sy.ID
            //    group lf by CourseInWork
            //    into grouping
            //    orderby grouping.Key. Course.Name
            //    select grouping);                


            var q = from licf in this.LoadInCourseFact
                where licf.CourseInWork.SchoolYearID == sy.ID
                group licf by new { licf.CourseInWorkID, licf.CourseInWork }
                into grouping
                orderby grouping.Key.CourseInWork.Semestr, grouping.Key.CourseInWorkID, grouping.Key.CourseInWork.Groups
                select grouping;

            short semestr = 0;
            decimal itogoSemestr = 0;
            decimal itogo = 0;
            foreach (var course in q)
            {
                if (semestr != course.Key.CourseInWork.Semestr)
                {
                    if (semestr == (short)Semestr.Осенний)
                    {
                        returnString += ("Итого по семестру:").PadRight(40) + itogoSemestr + "\r\n";
                        itogoSemestr = 0;
                    }
                    semestr = (short)course.Key.CourseInWork.Semestr;
                    returnString += "\r\n" + ((Semestr)semestr).ToString() + " семестр\r\n";
                }
                returnString += course.Key.CourseInWork.Course.Name + ", гр." + course.Key.CourseInWork.Groups + "\r\n";
                foreach (LoadInCourseFact licf in course.Key.CourseInWork.LoadInCourseFact.Where(p => p.EmployeeFormID == Id))
                {
                    string addstr = "";
                    // Проверяем, кто является владельцем курса
                    if (licf.CourseInWork.Employee != null && Id != licf.CourseInWork.Employee.Id)
                        addstr += "(ответственный - " + licf.CourseInWork.Employee.ShortName + ")";
                    returnString += String.Format("                    {0} - {1} {2}\r\n",
                        licf.SortLoadName, licf.CountHours, addstr);

                    itogo += licf.CountHours;
                    itogoSemestr += licf.CountHours;
                }
            }
            returnString += ("Итого по семестру:").PadRight(40) + itogoSemestr + "\r\n";
            returnString += ("ИТОГО:").PadRight(40) + itogo + "\r\n\r\n";
            #endregion

            #region Фактическая нагрузка
            returnString += "============================================================\r\n";
            returnString += "Дополнительная информация:\r\n";

            var q2 = (from ciw in CourseInWork
                where ciw.SchoolYearID == sy.ID
                select ciw);
            foreach (CourseInWork ciw in q2)
            {
                foreach (LoadInCourseFact licf in ciw.LoadInCourseFact)
                {
                    if (licf.EmployeeFormID != Id)
                        returnString += String.Format("   {0}, {1}, {2}, {3} - {4} закреплена за {5}\r\n", 
                            ciw.Course.Name,
                            licf.SortLoadName,
                            licf.CourseSemestr,
                            licf.Groups,
                            licf.CountHours,
                            licf.EmployeeFormFio
                            );
                }
            }

            //q = from ciw in this.Employee.CourseInWork
            //    where ciw.SchoolYear.ID == this.SchoolYear.ID &&
            //        (ciw.Fact == (short?)WorkloadType.Фактическая || ciw.Fact == (short?)WorkloadType.Фактическая_и_формальная)
            //    orderby ciw.Semestr, ciw.Course.ID, ciw.Group.Group1
            //    group ciw by new { Semestr = ciw.Semestr, Course = ciw.Course, Group1 = ciw.Group, Group2 = ciw.Group2, Group3 = ciw.Group3, Group4 = ciw.Group4 };

            //semestr = 0;
            //itogoSemestr = 0;
            //itogo = 0;
            //foreach (var course in q)
            //{
            //    if (semestr != course.Key.Semestr)
            //    {
            //        if (semestr == (short)Semestr.Осенний)
            //        {
            //            returnString += ("Итого по семестру:").PadRight(40) + itogoSemestr.ToString() + "\n";
            //            itogoSemestr = 0;
            //        }
            //        semestr = (short)course.Key.Semestr;
            //        returnString += "\n" + ((Semestr)semestr).ToString() + " семестр\n";
            //    }
            //    string group = "";
            //    if (course.Key.Group1 != null) group += course.Key.Group1.Group1;
            //    if (course.Key.Group2 != null) group += "," + course.Key.Group2.Group1;
            //    returnString += course.Key.Course.Name + ", гр." + group + "\n";
            //    foreach (CourseInWork ciw in course)
            //    {
            //        returnString += GetHoursRow(ciw.LectHours, "лекции", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.KonsHours, "консультации", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.ZachHours, "зачет", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.EkzHours, "экзамен", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.IzHours, "ИЗ", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.UprHours, "упражнения", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.LabHours, "лаб.раб.", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.KontrRabHours, "контр.раб.", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.KrHours, "КР", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.KpHours, "КП", ciw.GetTwin(CoursesToFind));
            //        returnString += GetHoursRow(ciw.ProchHours, "", ciw.GetTwin(CoursesToFind));

            //        itogo += ciw.AllHours;
            //        itogoSemestr += ciw.AllHours;
            //    }
            //}
            //returnString += ("Итого по семестру:").PadRight(40) + itogoSemestr.ToString() + "\n";
            //returnString += ("ИТОГО:").PadRight(40) + itogo.ToString() + "\n\n";
            #endregion

            #region Фактическая нагрузка, оплата из фондов
            //returnString += "============================================================\n";
            //returnString += "Фактическая нагрузка с оплатой из фондов:\n";
            //q = from ciw in this.Employee.CourseInWork
            //    where ciw.SchoolYear.ID == this.SchoolYear.ID &&
            //        (ciw.Fact == (short?)WorkloadType.Фактическая)
            //    orderby ciw.Semestr, ciw.Course.ID, ciw.Group.Group1
            //    group ciw by new { Semestr = ciw.Semestr, Course = ciw.Course, Group1 = ciw.Group, Group2 = ciw.Group2, Group3 = ciw.Group3, Group4 = ciw.Group4 };

            ////  select ciw).ToList<CourseInWork>();

            //foreach (var course in q)
            //{
            //    if (semestr != course.Key.Semestr)
            //    {
            //        if (semestr == (short)Semestr.Осенний)
            //        {
            //            returnString += ("Итого по семестру:").PadRight(40) + itogoSemestr.ToString() + "\n";
            //            itogoSemestr = 0;
            //        }
            //        semestr = (short)course.Key.Semestr;
            //        returnString += "\n" + ((Semestr)semestr).ToString() + " семестр\n";
            //    }
            //    string group = "";
            //    if (course.Key.Group1 != null) group += course.Key.Group1.Group1;
            //    if (course.Key.Group2 != null) group += "," + course.Key.Group2.Group1;
            //    returnString += course.Key.Course.Name + ", гр." + group + "\n";
            //    foreach (CourseInWork ciw in course)
            //    {
            //        returnString += getHoursRow(ciw.LectHours, "лекции");
            //        returnString += getHoursRow(ciw.KonsHours, "консультации");
            //        returnString += getHoursRow(ciw.ZachHours, "зачет");
            //        returnString += getHoursRow(ciw.EkzHours, "экзамен");
            //        returnString += getHoursRow(ciw.IzHours, "ИЗ");
            //        returnString += getHoursRow(ciw.UprHours, "упражнения");
            //        returnString += getHoursRow(ciw.LabHours, "лаб.раб.");
            //        returnString += getHoursRow(ciw.KontrRabHours, "контр.раб.");
            //        returnString += getHoursRow(ciw.KrHours, "КР");
            //        returnString += getHoursRow(ciw.KpHours, "КП");
            //        returnString += getHoursRow(ciw.ProchHours, "");

            //        itogo += ciw.AllHours;
            //        itogoSemestr += ciw.AllHours;
            //    }
            //}
            //returnString += ("Итого по семестру:").PadRight(40) + itogoSemestr.ToString() + "\n";
            //returnString += ("ИТОГО:").PadRight(40) + itogo.ToString() + "\n\n";
            #endregion

            return returnString;
        }

	}

	partial class SchoolYear
	{
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0}", this.Years);
		}
	}

	partial class Course
	{

		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0}", this.Name);
		}
	}

	partial class Rate
	{
		private const decimal NDFL = 13;

		/// <summary>
		/// Ставка, скорректированная с учетом занимаемой должности
		/// </summary>
		public decimal CorrectedRate
		{
			get
			{
				decimal correctedRate = 0;
				if (this.Post == null) return 0;
				correctedRate = Utils.SafeDecimal(this.Rate1) *
					this.Post.KInSchoolYear(this.SchoolYear);
				return Math.Round(correctedRate, 4);
			}
		}

		/// <summary>
		/// Налог (в процентах)
		/// </summary>
		private decimal nalog
		{
			get
			{
				decimal nalog = NDFL;
				if (this.IsTradeUnionMember != null) if ((bool)this.IsTradeUnionMember) nalog = nalog + 1;
				return nalog;
			}
		}

		/// <summary>
		/// Базовый оклад
		/// </summary>
		public decimal BaseSalary
		{
			get
			{
				if (this.Post == null) return 0;
				decimal baseSalary = Utils.SafeDecimal(this.Rate1) *
					this.Post.BaseSalaryInSchoolYear(SchoolYear) *
					(1 - nalog / 100);
				return Math.Round(baseSalary, 2);
			}
		}

		/// <summary>
		/// Должностной оклад
		/// </summary>
		public decimal PostSalary
		{
			get
			{
				if (this.Post == null) return 0;
				decimal postSalary = Utils.SafeDecimal(this.Rate1) *
					this.Post.PostSalaryInSchoolYear(SchoolYear) *
					(1 - nalog / 100);
				return Math.Round(postSalary, 2);
			}
		}

		/// <summary>
		/// Доплата за степень
		/// </summary>
		public decimal GradeSurcharge
		{
			get
			{
				if (this.Post == null) return 0;
				decimal gradeSurcharge = Utils.SafeDecimal(this.Rate1) *
					this.Post.GradeSurchargeInSchoolYear(SchoolYear) *
					(1 - nalog / 100);
				return Math.Round(gradeSurcharge, 2);
			}
		}

		/// <summary>
		/// Доплата за должность
		/// </summary>
		public decimal PostSurcharge
		{
			get
			{
				if (this.Post == null) return 0;
				decimal postSurcharge = Utils.SafeDecimal(this.Rate1) *
					this.Post.PostSurchargeInSchoolYear(SchoolYear) *
					(1 - nalog / 100);
				return Math.Round(postSurcharge, 2);
			}
		}
	}

	partial class Group
	{
		public override string ToString()
		{
			return this.Group1;
		}
	}

	partial class GroupInSemestr
	{
		public string GroupName
		{
			get
			{
				return this.Group.Group1;
			}
		}
	}

    partial class SortLoad
    {
        public string ShortName
        {
            get
            {
                if (Id == 1) return "лекции";
                else if (Id == 7) return "лаб.раб.";
                else if (Id == 6) return "упр.";
                else return Name;
            }
        }
    }


}

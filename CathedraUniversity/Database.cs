using CathedraUniversity.Forms.Classes;
using System;
using System.Text;
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
                foreach (LoadInCourseFact loadFact in this.LoadInCourseFact)
                {
                    totalCountHours += loadFact.CountHours;
                }
                return totalCountHours;
                //foreach (LoadInCoursePlan loadPlan in this.LoadInCoursePlan)
                //{
                //    foreach (LoadInCourseFact loadFact in loadPlan.LoadInCourseFact)
                //    {
                //        totalCountHours += loadFact.CountHours;
                //    }
                //}
                //return totalCountHours;
                
            }
        }

		/// <summary>
		/// Возвращает группы, назначенные на курс
		/// </summary>
		public string Groups
		{
			get
			{
				StringBuilder sb = new StringBuilder(50);
				foreach (GroupInCourse groupInCourse in this.GroupInCourse)
				{
					sb.Insert(sb.Length, groupInCourse.GroupInSemestr.Group.Group1 + " ");
				}
				return sb.ToString();
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
		/// <param name="ASchoolYear"></param>
		/// <returns></returns>
		public int RateInHoursInSchoolYear(SchoolYear ASchoolYear)
		{
			if (ASchoolYear == null) return 0;
			foreach (PostSalary ps in this.PostSalary)
			{
				if (ps.SchoolYearID == ASchoolYear.ID) return Utils.SafeInt(ps.RateInHours);
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


}

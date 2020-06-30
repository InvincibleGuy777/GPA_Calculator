using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_Plus
{
    public class InfoVo
    {
        private string courseName;
        private double credit;
        private double grade;
        /// <summary>
        /// 课程名
        /// </summary>
        public string CourseName {
            get
            {
                return courseName;
            }
            set { courseName = value; }
        }
        /// <summary>
        /// 学分
        /// </summary>
        public double Credit {
            get
            {
                return credit;
            }
            set { credit = value; }
        }
        /// <summary>
        /// 成绩
        /// </summary>
        public double Grade {
            get
            {
                return grade;
            }
            set { grade = value; }
        }
    }
}

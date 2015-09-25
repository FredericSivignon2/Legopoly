using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
    public class JobBase
    {
        protected Grade[] grades;
        public int GradeNumber { get; set; } = 0;

        public string Name { get; protected set; }

        public string GradeName
        {
            get
            {
                if (grades == null)
                    return string.Empty;

                return this.grades[this.GradeNumber].Name;
            }
        }
    }
}

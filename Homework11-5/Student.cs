using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11_5
{
    public class Student
    {
        public string FIO { get; set; }
        public string Group { get; set; }
        public double IncomePerFamilyMember { get; set; }
        public Pol Pol { get; set; }
        public FormOfEducation FormOfEducation { get; set;}


        public string GetStudentInfo()
        {
            return $"FIO: {FIO}\nGroup: {Group}\nIncomePerFamilyMember: {IncomePerFamilyMember}\n" +
                $"Pol: {Pol}\nFormOfEducation: {FormOfEducation}";
        }
        
    }
}

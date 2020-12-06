

using System.Linq;
using web_demo.Entities;

namespace web_demo.Data
{
    public class DatabaseInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();


            if (!context.InstitutionTypes.Any())
            {
                 var institutionTypes = new InstitutionType[]
                 {
                    new InstitutionType{Name="Primary school"},
                    new InstitutionType{Name="Secondary school"},
                    new InstitutionType{Name="University"},

                };
                foreach (InstitutionType institutionType in institutionTypes)
                {
                    context.InstitutionTypes.Add(institutionType);
                }
                context.SaveChanges();
            }

            if (!context.AcademicPeriods.Any())
            {
                var academicPeriods = new AcademicPeriod[]
                {
                    new AcademicPeriod{Name="2020/2021 First term"},
                    new AcademicPeriod{Name="2020/2021 Second term"},
                    new AcademicPeriod{Name="2020/2021 Third term"},
                    new AcademicPeriod{Name="2020/2021 First Semester"},
                    new AcademicPeriod{Name="2020/2021 Second Semester"},

               };
                foreach (AcademicPeriod academicPeriod in academicPeriods)
                {
                    context.AcademicPeriods.Add(academicPeriod);
                }
                context.SaveChanges();
            }


            if (!context.UserTypes.Any())
            {
                var userTypes = new UserType[]
                {
                    new UserType{Name="Teacher"},
                    new UserType{Name="School Administrator"},
                    new UserType{Name="State Administrator"},
                    new UserType{Name="Ministry Administrator"},
                    new UserType{Name="Administrator"},

               };
                foreach (UserType userType in userTypes)
                {
                    context.UserTypes.Add(userType);
                }
                context.SaveChanges();
            }

            if (!context.AcademicAssessmentTypes.Any())
            {
                var academicAssessmentTypes = new AcademicAssessmentType[]
                {
                    new AcademicAssessmentType{Name="Examinations"},
                    new AcademicAssessmentType{Name="Tests"},
                    new AcademicAssessmentType{Name="Assignment"},
                    new AcademicAssessmentType{Name="Classwork"},

                };
                foreach (AcademicAssessmentType academicAssessmentType in academicAssessmentTypes)
                {
                    context.AcademicAssessmentTypes.Add(academicAssessmentType);
                }
                context.SaveChanges();
            }


            if (!context.Subjects.Any())
            {
                var subjects = new Subject[]
                {
                        new Subject{Name="Mathematics"},
                        new Subject{Name="English Language"},
                        new Subject{Name="Physics"},
                        new Subject{Name="Chemistry"},
                        new Subject{Name="Biology"},
                        new Subject{Name="Further Mathematics"},

                };
                foreach (Subject subject in subjects)
                {
                    context.Subjects.Add(subject);
                }
                context.SaveChanges();
            }



            if (!context.Classes.Any())
            {
                var classes = new Class[]
                {
                    new Class{Name="Junior Secondary School 3", Code="JSS1"},
                    new Class{Name="Senior Secondary School 3", Code="SSS1"},
                    new Class{Name="Level 1", Code="100 Level"},

                };
                foreach (Class c in classes)
                {
                    context.Classes.Add(c);
                }
                context.SaveChanges();
            }


            if (!context.States.Any())
            {
                var states = new State[]
                {
                    new State{Name="Lagos State Ministry of Education"},
                    new State{Name="Ondo State Ministry of Education"},
                    new State{Name="Edo State Ministry of Education"},
                    new State{Name="Kano State Ministry of Education"},
                    new State{Name="Abia State Ministry of Education"},
                    new State{Name="Anambra State Ministry of Education"},

                };
                foreach (State state in states)
                {
                    context.States.Add(state);
                }
                context.SaveChanges();
            }


            if (!context.Schools.Any())
            {
                var schools = new School[]
                {
                    new School{Name="University Of Lagos",Address="Lagos",ContactNumber="09099017735", StateId=1, EmailAddress="gcl@lagosstate.gov.ng",InstitutionTypeId = 3},
                    new School{Name="Government College Ikorodu",Address="Ikorodu, Lagos",ContactNumber="09099017735", StateId=1, EmailAddress="gcl@lagosstate.gov.ng",InstitutionTypeId = 2},
                    new School{Name="Government College Ikorodu",Address="Ikorodu, Lagos",ContactNumber="09099017735", StateId=1, EmailAddress="gcl@lagosstate.gov.ng",InstitutionTypeId = 2},
                    new School{Name="Lagos State Model College, Igbonla",Address="Igbonla, Lagos",ContactNumber="08022342761", StateId=1,InstitutionTypeId = 2},
                    new School{Name="Citadel International College, Ikare Akoko",Address="Ikare Akoko, Ondo",ContactNumber="08022342761", StateId=2,InstitutionTypeId = 2},
                    new School{Name="Government Secondary School Sharada Bata",Address="Bata, Kano",ContactNumber="09099017735", StateId=4, EmailAddress="gsss@kanostate.gov.ng",InstitutionTypeId = 2},
                    new School{Name="Government Junior Secondary School, Kwalli",Address="Kwalli, Kano",ContactNumber="08022342761", StateId=4,InstitutionTypeId = 2},
                    new School{Name="AGUATA HIGH SCH. AGUATA",Address="AGUATA , Anambra",ContactNumber="08988298029", StateId=6,InstitutionTypeId = 2}
                };
                foreach (School school in schools)
                {
                    context.Schools.Add(school);
                }
                context.SaveChanges();
            }

                
        }
    }
}

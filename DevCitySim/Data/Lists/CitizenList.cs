using System;
using System.Collections.Generic;
using DevCitySim.Data.Classes;

namespace DevCitySim.Data.Lists
{
    internal class CitizenList
    {
        private List<Citizen> citizenList = new List<Citizen>
        {
            new Citizen { Id = 1, Name = "Jane Doe", DateOfBirth = DateTime.Parse("12:20 24-10-2001"), Job = "Software Developer" },
            new Citizen { Id = 2, Name = "Doety Jane", DateOfBirth = DateTime.Parse("12:20 24-10-2001"), Job = "Software Developer" },
            new Citizen { Id = 3, Name = "John Smith", DateOfBirth = DateTime.Parse("14:30 15-06-1990"), Job = "Data Scientist" },
            new Citizen { Id = 4, Name = "Emily Brown", DateOfBirth = DateTime.Parse("10:15 02-12-1988"), Job = "Graphic Designer" },
            new Citizen { Id = 5, Name = "Michael Johnson", DateOfBirth = DateTime.Parse("08:45 22-07-1995"), Job = "Software Developer" },
            new Citizen { Id = 6, Name = "Olivia Williams", DateOfBirth = DateTime.Parse("18:00 09-11-1992"), Job = "Marketing Manager" },
            new Citizen { Id = 7, Name = "Lucas Miller", DateOfBirth = DateTime.Parse("21:10 03-04-1985"), Job = "Software Developer" },
            new Citizen { Id = 8, Name = "Sophia Davis", DateOfBirth = DateTime.Parse("16:40 14-09-1993"), Job = "HR Specialist" },
            new Citizen { Id = 9, Name = "Daniel Martinez", DateOfBirth = DateTime.Parse("12:00 17-01-1980"), Job = "Project Manager" },
            new Citizen { Id = 10, Name = "Isabella Garcia", DateOfBirth = DateTime.Parse("09:50 28-05-2002"), Job = "Software Developer" },
            new Citizen { Id = 11, Name = "Ethan Hernandez", DateOfBirth = DateTime.Parse("13:30 19-08-1987"), Job = "Electrical Engineer" },
            new Citizen { Id = 12, Name = "Mia Wilson", DateOfBirth = DateTime.Parse("11:15 10-03-1991"), Job = "Teacher" },
            new Citizen { Id = 13, Name = "James Thomas", DateOfBirth = DateTime.Parse("20:50 05-05-1998"), Job = "Software Developer" },
            new Citizen { Id = 14, Name = "Ava Anderson", DateOfBirth = DateTime.Parse("07:35 25-12-1994"), Job = "Financial Analyst" },
            new Citizen { Id = 15, Name = "Alexander Lee", DateOfBirth = DateTime.Parse("15:20 06-06-1989"), Job = "Software Developer" },
            new Citizen { Id = 16, Name = "Charlotte White", DateOfBirth = DateTime.Parse("22:05 30-07-1996"), Job = "Architect" },
            new Citizen { Id = 17, Name = "Mason Lewis", DateOfBirth = DateTime.Parse("06:25 12-02-1983"), Job = "Civil Engineer" },
            new Citizen { Id = 18, Name = "Ella Walker", DateOfBirth = DateTime.Parse("23:40 03-01-1990"), Job = "Software Developer" },
            new Citizen { Id = 19, Name = "Liam Hall", DateOfBirth = DateTime.Parse("04:55 17-11-2000"), Job = "Doctor" },
            new Citizen { Id = 20, Name = "Amelia Allen", DateOfBirth = DateTime.Parse("18:20 08-04-1984"), Job = "Lawyer" }
        };

        public List<Citizen> GetCitizensList()
        {
            return citizenList;
        }
    }
}

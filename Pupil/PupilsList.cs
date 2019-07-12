using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil
{
    public class PupilsList
    {
        private const int Pupils = 1;

        private Pupil[] pupilsList;

        public PupilsList()
        {
            this.pupilsList = new Pupil[PupilsList.Pupils];
        }

        public void Execute()
        {
            for (int i = 0; i < PupilsList.Pupils; i++)
            {
                this.pupilsList[i] = this.GetNewPupil();
            }

            for (int i = 0; i < PupilsList.Pupils; i++)
            {
                this.DisplayPupilInfo();
            }


        }

        private string GetPupilName()
        {
            string name = string.Empty;

            while (true)
            {
                Console.Write("Enter name: ");

                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                    break;
            }

            return name;
        }
        private string GetPupilSurname()
        {

            string surname = string.Empty;

            while (true)
            {
                Console.Write("Enter surname: ");

                surname = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(surname))
                    break;
            }

            return surname;
        }

        private int GetSchoolNumber()
        {
            int schoolNumber;

            while (true)
            {
                Console.Write("Enter school number: ");

                if (int.TryParse(Console.ReadLine(), out schoolNumber))
                    break;
            }

            return schoolNumber;
        }

        public int GetBirthYear()
        {
            int birthYear;

            while (true)
            {
                Console.Write("Enter birth year: ");

                if (int.TryParse(Console.ReadLine(), out birthYear))
                    break;
            }

            return birthYear;
        }

        public string GetClassID()
        {
            string classID = string.Empty;

            while (true)
            {
                Console.Write("Enter class ID: ");

                classID = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(classID))
                    break;
            }

            return classID;
        }
        private Pupil GetNewPupil()
        {
            Pupil newPupil = new Pupil(GetPupilName(), GetPupilSurname(), GetBirthYear());

            newPupil.SchoolNumber = GetSchoolNumber();
            newPupil.ClassID = GetClassID();

            return newPupil;
        }

        private void DisplayPupilInfo()
        {
            Pupil selectedPupil = new Pupil();

            Console.Clear();

            Console.WriteLine(new string('-', 60));
            Console.WriteLine(String.Format("{0, -3} {1, -10} {2, -10} {3, -10} {4, -5} {5, -8} {6, -7}", "#", "Name", "Surname", "BirthYear", "Age", "School", "Class"));
            Console.WriteLine(new string('-', 60));

            for (int i = 0; i < PupilsList.Pupils; i++)
            {
                selectedPupil = pupilsList[i];

                Console.WriteLine(String.Format("{0, -3} {1, -10} {2, -10} {3, -10} {4, -5} {5, -8} {6, -7}", i + 1, selectedPupil.Name, selectedPupil.Surname, selectedPupil.BirthYear, selectedPupil.Age, selectedPupil.SchoolNumber, selectedPupil.ClassID));
            }
        }
    }
}
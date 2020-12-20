using System;


namespace Task_1
{
    class Program
    {
        static void Main()
        {
            string firstName_1 = "Дмитрий";
            string lastName_1 = "Киверин";
            string patronymic_1 = "Александрович";

            string firstName_2 = "Татьяна";
            string lastName_2 = "Черкасова";
            string patronymic_2 = "Павловна";

            string firstName_3 = "Игорь";
            string lastName_3 = "Конев";
            string patronymic_3 = "Георгиевич";

            Console.WriteLine(GetFullName(firstName_1, lastName_1, patronymic_1));
            Console.WriteLine(GetFullName(firstName_2, lastName_2, patronymic_2));
            Console.WriteLine(GetFullName(firstName_3, lastName_3, patronymic_3));
            Console.ReadLine();
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
        }
    }
}

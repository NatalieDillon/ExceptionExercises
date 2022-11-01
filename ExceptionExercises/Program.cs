using System;

namespace ExceptionExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CakeDivision();

            
        }

        public static void ReadDiary()
        {
            string fileName = @"Files\DiaryEvents.csv";
            List<DiaryRecord> diaryRecords = Diary.ReadDiaryEvents(fileName);
            foreach (var entry in diaryRecords)
            {
                Console.WriteLine(entry);
            }
        }

        public static void CakeDivision()
        {
            int pizzaSlices = 32;
            Console.WriteLine("Please enter the number of children");
            int children = Convert.ToInt32(Console.ReadLine());
            int slices = pizzaSlices / children;
            Console.WriteLine($"Each child will get {slices} slices");
        }
    }
}

using System;

namespace Program6_3 {
    internal class Program {
        static void Main() {
            int[] students = new int[5]; // Marks for each student (?/60)
            InputAllMarks(ref students); // Calls InputAllMarks, selfexplanitory
            Console.WriteLine();

            float[] perc = new float[5]; // Percentage for each student
            for (int i = 0; i < 5; i++) {
                // For each student, convert the marks to a percentage
                perc[i] = ConvToPercent(students[i]);
            }
            (float, float) avgmarks = AvgMarks(students,perc); // Makes tuple avgmarks
            OutputMarks(students,perc,avgmarks); // Outputs all of the marks
        }
        static void InputAllMarks(ref int[] students) { 
            for (int i = 0; i < 5; i++) { // For each one, ask for the mark
                Console.Write("Enter mark for student {0}: ",i + 1);
                students[i] = int.Parse(Console.ReadLine());
            }
        }
        static float ConvToPercent(int score) {
            float ans = score / 60f; // Gets the mark and divides it by 60
            return (float.Parse(Math.Round(ans,2).ToString())*100); // returns the answer * 100
        }
        static (float,float) AvgMarks(int[] marks, float[] perc) {
            int totalmarks = 0;
            float totalperc = 0f;
            // Gets the total marks and percentage
            for (int i = 0; i < 5; i++) {
                totalmarks += marks[i];
                totalperc += perc[i];
            } 
            // Divides them by 5
            float avgmark = totalmarks / 5f;
            float avgperc = totalperc / 5f;
            // Returns those values as a tuple
            return (avgmark,avgperc);
        }
        static void OutputMarks(int[] marks,float[] perc,(float,float) avgmarks) {
            for (int i = 0; i < 5; i++) {
                // For each one says the student num, their marks and their percentage
                Console.WriteLine("Student {0}:",i+1);
                Console.WriteLine("  Marks: {0}/60",marks[i]);
                Console.WriteLine("  Percentage: {0}%",perc[i]);
                Console.WriteLine();
            }
            // Then shows the average for it all
            Console.WriteLine("Class Averages:");
            Console.WriteLine("  Marks: {0}/60",avgmarks.Item1);
            Console.WriteLine("  Percentage: {0}%",avgmarks.Item2);
        }
    }
}

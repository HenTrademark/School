using System;

namespace HumanTimeFormat {
    internal class Program {
        public static string formatDuration(int seconds) {
            if (seconds == 0) { return "now"; }
            int[] duration = new int[5];
            duration[0] =    seconds / 31536000; // Years
            duration[1] =   (seconds % 31536000) / 86400; // Days
            duration[2] =  ((seconds % 31536000) % 86400) / 3600; // Hours
            duration[3] = (((seconds % 31536000) % 86400) % 3600) / 60; // Minutes
            duration[4] = (((seconds % 31536000) % 86400) % 3600) % 60; // Seconds

            // Formulating a string
            string[] str = new string[0];
            if (duration[0] != 0) {
                Array.Resize(ref str,str.Length + 1);
                if (duration[0] == 1) { str[str.Length - 1] = duration[0].ToString() + " year"; }
                else { str[str.Length - 1] = duration[0].ToString() + " years"; }
            }
            if (duration[1] != 0) {
                Array.Resize(ref str,str.Length + 1);
                if (duration[1] == 1) { str[str.Length - 1] = duration[1].ToString() + " day"; }
                else { str[str.Length - 1] = duration[1].ToString() + " days"; }
            }
            if (duration[2] != 0) {
                Array.Resize(ref str,str.Length + 1);
                if (duration[2] == 1) { str[str.Length - 1] = duration[2].ToString() + " hour"; }
                else { str[str.Length - 1] = duration[2].ToString() + " hours"; }
            }
            if (duration[3] != 0) {
                Array.Resize(ref str,str.Length + 1);
                if (duration[3] == 1) { str[str.Length - 1] = duration[3].ToString() + " minute"; }
                else { str[str.Length - 1] = duration[3].ToString() + " minutes"; }
            }
            if (duration[4] != 0) {
                Array.Resize(ref str,str.Length + 1);
                if (duration[4] == 1) { str[str.Length - 1] = duration[4].ToString() + " second"; }
                else { str[str.Length - 1] = duration[4].ToString() + " seconds"; }
            }

            if (str.Length == 1) { return str[0]; }
            else if (str.Length == 2) { return str[0] + " and " + str[1]; }
            else {
                string[] strings = new string[str.Length-1];
                for (int i = 0; i < strings.Length; i++) { strings[i] = str[i]; }
                string final = String.Join(", ",strings);
                return final + " and " + str[str.Length-1]; 
            }
        }
        static void Main(string[] args) {
            Console.WriteLine(formatDuration(3662));
        }
    }
}

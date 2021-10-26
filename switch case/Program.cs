using System;

namespace switch_case {
    class Program {
        static void Main(string[] args) {
            
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {
                case 1:
                    day = "Segunda";
                    break;
                case 2:
                    day = "Terça-Feira";
                    break;
                case 3:
                    day = "Quarta-Feira";
                    break;
                case 4:
                    day = "Quint-Feira";
                    break;
                case 5:
                    day = "Sexta-Feira";
                    break;
                case 6:
                    day = "Sábado";
                    break;
                case 7:
                    day = "Domingo";
                    break;
                default:
                    day = "Inavalido";
                    break;
            }
            Console.WriteLine("Day: " + day);
        }
    }
}

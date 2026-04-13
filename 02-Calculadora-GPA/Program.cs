using System;

namespace CalculadoraGPA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Informações do Aluno
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            // Créditos de cada curso
            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            // Valores das Notas (Escala de 4 pontos)
            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            // Cálculo do total de horas de crédito
            int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            // Cálculo do total de pontos de notas (Créditos * Nota)
            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            // Cálculo do GPA (Média Global)
            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            // Lógica para extrair dígitos decimais para formatação manual
            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            // Exibição do Boletim
            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

            Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

            // Resultado Final
            Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
            
            // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

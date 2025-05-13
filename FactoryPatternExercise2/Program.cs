namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool succsess = false;
            do {
                Console.WriteLine("What grade are you in?");
                string? classInput = Console.ReadLine();
                IGrade? grade = GradeDataBase.GetGrade(classInput);
                if (grade == null) {
                    continue;
                }
                
                succsess = true;
                Console.WriteLine("The required Classes are");
                foreach (string classes in grade.requiredClasses) {
                    Console.WriteLine(classes);
                }
            } while (!succsess);
        }
    }
}

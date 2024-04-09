namespace Challenge_1._Les_conditions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type a minimum integer number: ");
        string saisiUtilisateurminimum = Console.ReadLine();
        Console.Write("Type a maximum integer number: ");
        string saisiUtilisateurmaximum = Console.ReadLine();

        int nombreminimum = Convert.ToInt32(saisiUtilisateurminimum);
        int nombremaximum = Convert.ToInt32(saisiUtilisateurmaximum);

        Console.Write("Type an integer number between 0 and 100: ");
        string saisiUtilisateur = Console.ReadLine();
        int nombre = Convert.ToInt32(saisiUtilisateur);

        if (nombre >= 0 && nombre <= 100)
        {
            Console.WriteLine("Resulting integer:" + nombre);
                }
        else if (nombre > 100)
        {
            Console.WriteLine("You have entered " + nombre + " which is greater than 100 which is the maximum");
        }
        else 
        {
            Console.WriteLine("You have entered " + nombre +" which is lower than 0 which is the minimum");
        }



    }
}

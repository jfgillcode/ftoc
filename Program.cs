using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.Write(@"Veuillez entrer l'option désirée :

    1 - Convertir des degrés Fahrenheit en degrés Celsius
    2 - Convertir des degrés Celsius en degrés Fahrenheit
    3 - Quitter

Votre choix (1, 2 ou 3) : ");

        string choixUtilisateur = Console.ReadLine();

        if (int.TryParse(choixUtilisateur, out int choixNumerique))
        {
            if (choixNumerique == 1)
            {
                Console.Clear();
                Console.WriteLine("Veuillez entrer la température en degrés Fahrenheit :");
                int temperatureFahrenheit = Convert.ToInt32(Console.ReadLine());
                double temperatureCelsius = (temperatureFahrenheit - 32) * 5.0 / 9.0;
                Console.WriteLine($"La température en degrés Celsius est : {temperatureCelsius:F1}°C");
                return;
            }
            else if (choixNumerique == 2)
            {
                Console.Clear();
                Console.WriteLine("Veuillez entrer la température en degrés Celsius :");
                int temperatureCelsius = Convert.ToInt32(Console.ReadLine());
                double temperatureFahrenheit = (temperatureCelsius * 9.0 / 5.0) + 32;
                Console.WriteLine($"La température en degrés Fahrenheit est : {temperatureFahrenheit:F1}°F");
                return; 
            }
            else if (choixNumerique == 3)
            {
                Console.WriteLine("Au revoir !");
                return;
            }
            else
            {
                Console.WriteLine("Choix invalide. Veuillez entrer 1, 2 ou 3");
            }
        }
        else
        {
            Console.WriteLine("Saisie invalide. Veuillez entrer un nombre.");
        }


        Console.ReadKey();
    }
}
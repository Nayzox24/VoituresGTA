namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] garage = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        for (int b = 0; b < garage.Length; b++)
        {
            Console.WriteLine((b + 1).ToString() +". "+ garage[b]);
        }
        Console.WriteLine("Saisisez le numéro du vehicule souhaiter remplacer");
        int reponse = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Par quel autre vehicule voulez vous le remplacer donnez moi son nom");
        string Reponse = Console.ReadLine();
        garage[(reponse - 1)] = Reponse;
        for (int i = 0; i < garage.Length; i++)
        {
            Console.WriteLine((i+ 1).ToString() + ". " + garage[i]);
        }
    }
}
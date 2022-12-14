### Questions RPI

```C#
// Décrire le fonctionnement des enums en C#
enum LesJoursDeLaSemaine{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}

LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;

/* Ils permettent de définir un ensemble de constantes liées entre elles. La dernière ligne retrouve certaines constantes dans l'enum, en l'occurence Samedi ou Dimanche.*/
```

#### Les Tableaux

```C#
    int[] Tableau; // declaration
    Tab = new int[10]; // Initialisation

    int[] Tableau = new int[] {34, 45, 1, 34, 43 }; //
```

#### Les tableaux multidimensionnels

```C#
    int [,] Tableau = new int[1, 2];
    int [,,] Tableau = new int[1, 2, 3];


    int[][] Tableau = new int[3][];
    Tableau[0] = new int[] {45, 2};
    Tableau[1] = new int[] {34, 34, 4, 67};

    //Expliquez la différence entre ces syntaxes
    /* La façon d'instancier les tableaux est différente, car dans le 1er cas une taille 
	fixe est définie, contrairement au 2ème cas*/
    
    //Tentez de parcourir des tableaux multidimensionnels avec des boucles for

	for (int i = 0; i < Tableau.Length-1; i++)
    {
        for (int j = 0; j < Tableau[i].Length; j++)
        {
            Console.WriteLine(Tableau[i][j]);
            Console.ReadKey();
        }
    }
```
////Snack 1 Istruzioni condizionali
//Console.Write("Inserisci un numero: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("Inserisci un numero: ");
//int num2 = int.Parse(Console.ReadLine());

//if (num1 < num2)
//{
//    Console.WriteLine($"il numero piu piccolo e': {num1}");
//}
//else
//{
//    Console.WriteLine($"il numero piu piccolo e': {num2}");
//}


////Snack 2 Istruzioni condizionali

//Console.Write("Inserisci la prima parola: ");

//string parola1 = Console.ReadLine();

//Console.Write("Inserisci la prima parola: ");
//string parola2 = Console.ReadLine();

//if (parola1.Length < parola2.Length)
//{
//    Console.WriteLine($"La parola piu' corta e': {parola1}");
//}

//else
//{
//    Console.WriteLine($"La parola piu' corta e': {parola2}");
//}


//Snack 3 Ciclo for
int somma = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Inserisci il numero: ");
    int numero = int.Parse(Console.ReadLine());

    somma += numero;
}
Console.WriteLine("La somma di tutti i numeri inseriti è: " + somma);




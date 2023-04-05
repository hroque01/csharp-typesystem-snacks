//Istruzioni condizionali

//Permette all'utente di scrivere un numero
Console.Write("Inserisci il primo numero: ");
    
//Permette di prendere e assegnare la stringa num1 dalla console
string num1 = Console.ReadLine();

Console.Write("Inserisci il secondo numero: ");
    string num2 = Console.ReadLine();

//SE la lunghezza di num1 e' minore della lunghezza di num2 prendi il valore di num1
if (num1.Length<num2.Length)
{
    Console.WriteLine($"La parola piu' corta e': {num1}");
} 

else //altrimenti prendi il valore di num2
{
    Console.WriteLine($"La parola piu' corta e': {num2}");
}


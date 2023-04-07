////Snack 1 Istruzioni condizionali
//int num1, num2;
//bool isNum1Valid, isNum2Valid;

//do
//{
//    Console.Write("Inserisci il primo numero: ");
//    isNum1Valid = int.TryParse(Console.ReadLine(), out num1);
//    if (!isNum1Valid)
//    {
//        Console.WriteLine("Il valore inserito non è un numero intero valido. Riprova.");
//    }
//} while (!isNum1Valid);

//do
//{
//    Console.Write("Inserisci il secondo numero: ");
//    isNum2Valid = int.TryParse(Console.ReadLine(), out num2);
//    if (!isNum2Valid)
//    {
//        Console.WriteLine("Il valore inserito non è un numero intero valido. Riprova.");
//    }
//} while (!isNum2Valid);

//if (num1 < num2)
//{
//    Console.WriteLine($"Il numero più piccolo è: {num1}");
//}
//else
//{
//    Console.WriteLine($"Il numero più piccolo è: {num2}");
//}


////Snack 2 Istruzioni condizionali

//Console.Write("Inserisci la prima parola: ");

//string parola1 = Console.ReadLine();

//Console.Write("Inserisci la prima parola: ");
//string parola2 = Console.ReadLine();

//if (parola1.Length < parola2.Length)
//{
//    Console.WriteLine($"La parola piu' corta e': {parola1}");
//    Console.WriteLine($"La parola piu' lunga e': {parola2}");
//}

//else if
//{
//    Console.WriteLine($"La parola piu' corta e': {parola2}");
//    Console.WriteLine($"La parola piu' lunga e': {parola1}");
//}
//else
//{
//    Console.WriteLine("Le parole sono lunghe uguali");
//}


////Snack 3 Ciclo for
//int somma = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Inserisci il numero: ");
//    int numero = int.Parse(Console.ReadLine());

//    somma += numero;
//}
//Console.WriteLine("La somma di tutti i numeri inseriti è: " + somma);


////Snack 4 Ciclo for
//int somma = 0;
//for (int i = 2; i < 11; i++)
//{
//    Console.WriteLine(i);
//    somma += i;

//}
//Console.WriteLine("La somma di tutti i numeri inseriti è: " + somma);

//int mediana = somma / 9;
//Console.WriteLine("La mediana di tutti i numeri inseriti è: " + mediana);


////Snack 5 Operatore Modulo
//int num;
//bool isNumValid;

//do
//{
//    Console.Write("Inserisci un numero: ");
//    isNumValid = int.TryParse(Console.ReadLine(), out num);

//    if (!isNumValid)
//    {
//        Console.WriteLine("Il valore inserito non è un numero intero valido. Riprova.");
//    }
//} while (!isNumValid);

//if (num % 2 == 0)
//{
//    Console.WriteLine("Il valore inserito è pari");
//}
//else
//{
//    Console.WriteLine("Il valore inserito è dispari");
//}


////Snack 6 Array
//string[] invitati = { "Davide", "Andrea", "Igor", "Romina", "Vale", "Marco" };

//Console.Write("Inserisci il tuo nome: ");
//string persona = Console.ReadLine();

//if (invitati.Contains(persona))
//{
//    Console.WriteLine("Puoi entrare alla festa");
//}
//else
//{
//    Console.WriteLine("Non puoi entrare alla festa");
//}


////Snack 7 Array
//int[] numeriDispari = new int[0];

//for (int i = 0; i < 6; i++)
//{
//    Console.Write("Inserisci i numeri: ");
//    int numero = int.Parse(Console.ReadLine());

//    if (numero % 2 != 0)
//    {
//        Array.Resize(ref numeriDispari, numeriDispari.Length + 1);
//        numeriDispari[numeriDispari.Length - 1] = numero;
//    }
//}

//Console.WriteLine("Numeri dispari inseriti:");
//foreach (int numero in numeriDispari)
//{
//    Console.Write(numero + " ");
//}

////Snack 8 Array
//int[] numeriInteri = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int somma = 0;
//for (int i = 0; i < numeriInteri.Length; i++) {
//    if (i % 2 != 0)
//    {
//        somma += numeriInteri[i];
//    }
//}               
//Console.WriteLine(somma);


////Snack 9 Ciclo While
//int[] numeri = new int[0];
//int somma = 0;

//while (somma < 50)
//{
//    Console.WriteLine("Inserisci un numero:");
//    int numero = int.Parse(Console.ReadLine());
//    somma += numero;

//    Array.Resize(ref numeri, numeri.Length + 1);
//    numeri[numeri.Length - 1] = numero;
//}

//Console.WriteLine("Somma degli elementi:");
//Console.WriteLine(somma);
//Console.WriteLine("Numeri inseriti nell'array:");
//foreach (int numero in numeri)
//{
//    Console.Write(numero + " ");
//}


////Snack 10 Random
//Console.Write("Inserisci un numero: ");
//int n = int.Parse(Console.ReadLine());

//Random numRandom = new Random();

//for (int i = 0; i < n; i++)
//{
//    int[] array = new int[10];
//    for (int num = 0; num < 10; num++)
//    {
//        array[num] = numRandom.Next(1, 101);
//    }
//    Console.WriteLine("Array #" + (i + 1) + ": " + string.Join(", ", array));
//}

//Snack 11 Funzioni
static void Main(string[] args)
{
    Console.Write("Inserisci la prima parola: ");
    string parola1 = Console.ReadLine();

    Console.Write("Inserisci la seconda parola: ");
    string parola2 = Console.ReadLine();

    if (HannoLaStessaLunghezza(parola1, parola2))
    {
        Console.WriteLine(parola1);
        Console.WriteLine(parola2);
    }
    else
    {
        Console.WriteLine(ParolaPiuLunga(parola1, parola2));
    }
}

static bool HannoLaStessaLunghezza(string parola1, string parola2)
{
    return parola1.Length == parola2.Length;
}

static string ParolaPiuLunga(string parola1, string parola2)
{
    if (parola1.Length > parola2.Length)
    {
        return parola1;
    }
    else
    {
        return parola2;
    }
}

//Snack 12 funzioni
static void Main(string[] args)
{
    Console.Write("Inserisci un numero intero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (Epari(numero))
    {
        Console.WriteLine("{0} è un numero pari.", numero);
    }
    else
    {
        Console.WriteLine("{0} è un numero dispari.", numero);
    }
}

static bool Epari(int numero)
{
    return numero % 2 == 0;
}
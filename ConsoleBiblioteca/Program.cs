
Utente utentePrimo = new Utente("01", "Federico", "Martelloni", 5);

Console.WriteLine($"{utentePrimo.Denominazione} creato");

Utente utenteSecondo = new Utente("02", "Gabriele", "Martelloni", 2);

Console.WriteLine($"{utenteSecondo.Denominazione} creato");

Libro libroBellissimo = new Libro("01", "Come insegnare C#", "Bill Gates");
Console.WriteLine($"{libroBellissimo.Descrizione()} creato");

libroBellissimo.Prestito(utentePrimo);
libroBellissimo.Prestito(utenteSecondo);

libroBellissimo.Restituzione();

libroBellissimo.Prestito(utenteSecondo);


class Libro {
    private string id;
    private string titolo;
    private string autore;
    Utente? utente;
    public Utente? Utente {
        get{return utente;}
        set{utente=value;
            if (utente == null){
                    OnRestituzione();
                }
        }
    }
    public event Action NewMessage;

    public Libro (string id,string titolo,string autore)
    {
        this.id = id;
        this.titolo = titolo;
        this.autore = autore;
        
    }

    public string Descrizione(){
        return $"{this.titolo} di {this.autore}";
    }

    public void Prestito(Utente prestatoA){
        if(this.utente == null){
            this.utente = prestatoA;
            Console.WriteLine("Prestito avvenuto con successo");
        }else{
            Console.WriteLine($"Il libro {this.Descrizione()} è già dato in prestito a {this.utente.Denominazione}");
        }

    }

    public void Restituzione(){
        this.utente = null;
        Console.WriteLine("Libro restituito");
    }

    public void OnRestituzione(){
        if(NewMessage != null){
            NewMessage();
        }
    }
}
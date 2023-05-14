class Utente {
    private string id;
    public string Id { 
        get 
        {
            return id;
        } 
        set 
        {
            id=value;
        } 
    }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int AnnoIscrizione { get; set; }

    public string Denominazione { 
        get 
        {
            return $"{this.Nome} {this.Cognome}";
        }
    }

    public Utente (string id, string nome,string cognome,int annoIscrizione){
        this.Id = id;
        this.Nome = nome;
        this.Cognome = cognome;
        this.AnnoIscrizione = annoIscrizione;
    }

}
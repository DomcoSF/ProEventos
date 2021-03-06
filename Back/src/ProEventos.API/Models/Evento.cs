using System.ComponentModel.DataAnnotations;

namespace ProEventos.API.Models
{
    public class Evento
    {
        [Key]
        public int EventId {get;set;}
        public string Local {get;set;}
        public string DataEvento {get;set;}
        public string Tema {get;set;}
        public int QtdPessoas{get;set;}
        public string Lote {get;set;}
        public string ImagemURL{get;set;}  
    }
}
using System.Collections.Generic;

public class Livro {
     public int Id { get; set; }
     public string Nome { get; set; }

     public List<Livro> ListaLivros()
     {
         var v_ListaLivros = new List<Livro>();
         
         for (int i = 1; i <= 100; i++) {
             var v_Livro = new Livro() {
                 Id = i,
                 Nome = "Livro " + i,
             };
             
             v_ListaLivros.Add(v_Livro);
         }

         return v_ListaLivros;
     }
 }
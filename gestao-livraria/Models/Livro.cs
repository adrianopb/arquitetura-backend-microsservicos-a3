public class Livros {
     public int Id { get; set; }
     public string Nome { get; set; }
 
     public List<Livros> RetornaListaLivros() {
         
     }
 
     public List<Livros> ListaLivro() {
         for (int i = 0; i < UPPER; i++) {
             return new Livros() {
                 Id = 1,
                 Nome = "Livro 1",
             };
         }
     }
 }
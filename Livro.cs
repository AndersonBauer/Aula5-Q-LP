class Livro{
    public string titulo;
    public string autor;
    public int ano;
    public int paginas;

    public void Informacoes(){
        Console.WriteLine($"Autor: {autor}\nTitulo: {titulo}\nAno: {ano}\nNumero de paginas: {paginas}");
    }
    public bool TemMaisDe300Paginas(){
        return paginas > 300;
    }
}
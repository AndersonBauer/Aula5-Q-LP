Livro livro1 = new Livro();
livro1.titulo = "The Witcher";
livro1.autor = "Mary Beard";
livro1.ano = 2015;
livro1.paginas = 560;

livro1.Informacoes();

Livro livro2 = new Livro();
livro2.titulo = "Artes da Guerra";
livro2.autor = "Sun Tzu";
livro2.ano = 400;
livro2.paginas = 128;

livro2.Informacoes();

if(livro2.TemMaisDe300Paginas()){
    Console.WriteLine($"O livro {livro2.titulo} tem mais de 300 paginas.");
}else{
    Console.WriteLine($"O livro {livro2.titulo} não tem mais de 300 paginas.");
}
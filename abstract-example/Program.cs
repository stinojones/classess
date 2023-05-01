// See https://aka.ms/new-console-template for more information


Book fablehaven = new Book("Fablehaven", "Brandon Mull");
fablehaven.Display();

Book bom = new Book("Book of Mormon", "Mormon");
bom.Display();

Console.WriteLine(bom.IsAvailable());
bom.CheckOut();
bom.Display();

bom.Return();
bom.Display();

Console.WriteLine(bom.HasAuthor("Mormon"));

Console.WriteLine(bom.HasAuthor("Smith"));

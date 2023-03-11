// Template method (metoda szablonowa) - wzozec definiujący szkielet algorytmu w klasie bazowej
//      pozwalający w podklasach nadisać pewne jego algorytmy, np. algorytm generowania raportu do pliku
//      w róznych możliwych formtach

using Template_Method;

var pdfGenerator = new PdfGenerator();
var csvGenerator = new CsvGenerator();

Console.WriteLine("*** PDF ***");
pdfGenerator.GenerateReport();

Console.WriteLine("*** CSV ***");
csvGenerator.GenerateReport();

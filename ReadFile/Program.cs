

//HVILKE PROBLEMSTILLINGER KUNNE MAN STØDE PÅ I DETTE STYKKE KODE?
//HVAD KAN VI GØRE FOR AT LØSE DEM?

Console.WriteLine("Please insert the file path:");
var filepath = Console.ReadLine();

string[] lines = File.ReadAllLines(filepath);
        
// Perform operations with the file data
foreach (string line in lines) {
    Console.WriteLine(line);
}
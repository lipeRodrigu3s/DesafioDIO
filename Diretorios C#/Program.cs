var path = Path.Combine(Environment.CurrentDirectory,"Lugares");
var Dirlugares =  Directory.CreateDirectory(path);

var DirRd =  Dirlugares.CreateSubdirectory("Rio doce");
var DirPa = Dirlugares.CreateSubdirectory("Paulista");
var DirRc =Dirlugares.CreateSubdirectory("Recife");

DirRd.CreateSubdirectory("Rua Dois");
DirRd.CreateSubdirectory("Pizzaria Aquarios");
DirRd.CreateSubdirectory("Gol de Placa");

DirPa.CreateSubdirectory("Igreja do amor");
DirPa.CreateSubdirectory("Pastel de Bia");
DirPa.CreateSubdirectory("Ap de Rud");

DirRc.CreateSubdirectory("13 de Maio");
DirRc.CreateSubdirectory("Boa Vista");
DirRc.CreateSubdirectory("cidade");











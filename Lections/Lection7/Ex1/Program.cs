// Директории

string path = "C:/Users/п/Desktop/Учеба";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); // Время создания папок
FileInfo[] fi = di.GetFiles(); // Показывает все файлы

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
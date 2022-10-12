// Создайте функцию, которая отвечает на вопрос «Вы играете на банджо?».
// Если ваше имя начинается с буквы «R» или строчной «r», вы играете на банджо!
// Функция принимает имя в качестве единственного аргумента и возвращает одну из следующих строк:
// name + " plays banjo" 
// name + " does not play banjo"

void Banjo(string name)
{
    if(name.ToLower()[0] == 'r') Console.WriteLine($"{name} играет на банджо");
    else Console.WriteLine($"{name} не играет на банджо");
}

string name = "Mabbit";
Console.WriteLine("Вы играете на банджо?");
Banjo(name);
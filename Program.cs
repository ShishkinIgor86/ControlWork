// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите элементы массива через запятую, отделять элементы массива пробелом. Enter - окончание ввода: ");
string[] array=Console.ReadLine().Split(", ").ToArray();
string[] array1= new string[array.Length];
int j=0;
for (int i=0;i<array.Length;i++){
if (array[i].Length<=3){ 
        array1[j]=array[i];
        j++;
}
}
Array.Resize(ref array1,j);
Console.Write("["+String.Join(", ",array)+"]"+" -> ");
Console.Write("["+String.Join(", ",array1)+"]");

# Блок-схема алгоритма 
![Блок-схема](https://github.com/mllefox/FinalTask/raw/main/Diagram.png)

# Решение: 
Создаем локальную функцию FilterArray
```sh
string[] FilterArray(string[] array)
```
Создаем пустой массив без размера
```sh
List<string> newArray = new List<string>()
```
С помощью цикла проходимся по массиву
```sh
for (int i = 0; i < array.Length; i++)
```
 И отбираем элементы, длина которых меньше или равна 3
 ```sh
if (array[i].Length <= 3)
```
  добавляя их в новый массив newArray с помощью функции:
```sh
newArray.Add(array[i]);
```
Возвращаем новый массив с помощью функции:
```sh
return newArray.ToArray();
```

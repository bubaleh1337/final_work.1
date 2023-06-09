# Решение итогового задания к теме "Итоги блока. Выбор специализации".

## **Задание**

![task](https://user-images.githubusercontent.com/52395752/227785464-83e6a1e6-6548-48ce-8b20-74755d0945ab.jpg)

## **Моё решение:**

[Решение](https://github.com/bubaleh1337/final_work.1/blob/main/task/Program.cs)

**Описание методов в коде:**

1. Метод Prompt - метод, запрашивающий элементы в виде строк у пользователя.

2. Метод GetArray - метод, заполняющий массив теми строками, что ввёл пользователь. Также здесь задаётся рандомный размер массива от 3 до 5 включительно.

3. Метод PrintArray - метод для вывода какого-либо массива.

4. Метод FindElement принимает строковый массив. В данном методе происходит создание нового неопределённого массива, который копирует первый исходный массив. Создаётся счётчик, который будет использоваться для перебора позиций второго массива. Создаём цикл foreach, который будет перебирать элементы первого массива и, если длина элемента меньше или равняется 3, то во второй массив под индексом count, который увеличивается на 1, кладётся элемент из исходного массива. Выйдя из цикла происходит проверка: если на первой позиции массива нет элемента, что означает полностью пустой массив, мы выводим пустые скобки, в любом другом случае печатается массив.

**Описание кода:**

Очищаем консоль. Создаём строковый массив, заполняя его с помощью метода GetArray, в котором уже происходит вывод запроса введения строки у пользователя на каждую позицию, которые определяется рандомно. После всех запросов на каждую позицию создаётся отступ на новую строку для удобства чтения. Далее печатается весь исходный массив для показа выведенного, и, с помощью метода FindElement, выводятся на экран все строки, имеющие в себе не больше 3-х символов, в обратном случае выводятся пустые скобки.

**Блок-схема метода FindElement:**

![diagram](https://user-images.githubusercontent.com/52395752/227787403-30e843f0-891f-4e73-bc85-bd5317528a10.png)

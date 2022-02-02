# Контрольная работа

Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[1, 2, 3, 4] -> [2, 4]
[1, 3, 4, 5, 7, 1, 3] -> [4]
[2, -4, 6] -> [2, -4, 6]
[1, 3, 5] -> []

## Решение

### Для решения задачи были созданы функции:
- **FillArray** для заполнения массива
- **PrintArray** для печати массива
- **EvenCounter** для подсчета количества четных элементов в массиве
- **GenerateNewArray** для создания нового массива, состоящего из четных элементов исходного массива

### Алгоритм решения:
- создаем массив
- наполняем массив случайными числами
- выводим исходный массив на печать
- создаем новый массив размером, равным количеству четных элементов в исходном массиве
- наполняем новый массив четными элементами
- выводим новый массив на печать

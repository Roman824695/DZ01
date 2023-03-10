# Задача
**Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

## Алгоритм выполнения задания:

1. _*Создать репозиторий на GitHub.*_
2. _*Нарисовать блок-схему алгоритма.*_
3. _*Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).*_
4. _*Написать программу, решающую поставленную задачу.*_
5. _*Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах).*_

## Блок схема решения задачи:

![Ошибка](TNT.jpg)

## Описание алгоритма решения задачи:

* _*Пользователь указывает сколько элементов (N) он хочет задать и заполняет стартовый массив элементами в цикле N-раз.*_
* _*Далее проходим по стартовому массиву в цикле и проверяем, подходит ли элемент условию "длина символов <= 3".*_
* _*Если элемент подходит под данное условие, то мы добавляем его в новый массив, используя при этом дополнительный счетчик, чтобы элементы в новом массиве заполнялись последовательно (без пропусков).*_

## Решение задачи на C#
_*В папке Задача, файл Program.cs  решение задачи на C#.*_

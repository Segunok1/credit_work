# Итоговая проверочная работа.

* Создать репозиторий в GitHub.
* Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод).
* Снабдить репозиторий оформленным текстoвым описанием решения (файл README.MD).
* Написать программу, решающую поставленную задачу
* Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

--------------------------------------------------------------------------
## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

--------------------------------------------------------------------------

## Примеры.

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [" "]

___________________________________________________________________________

# Решение.
Ссылка на файл Program.cs -> https://github.com/Segunok1/credit_work/blob/master/task/Program.cs


1. Объявляем два массива строк **string[] initialArray**, **string[] sortedArray** и переменную **int count**.
2. Создаём метод **void PerebArray** в котором при помощи цикла **for** перебирается каждый эемент массива **initialArray.Length**.
3. Внутри цикла **for** с мощью конструкции **if (initialArray[i].Length <= 3)** создаем условие для проверки длинны каждого перебранного эемента массива.
4. Если эемент перебранного массива подходит под условие, то мы записываем его в массив **sortedArray[count] = initialArray[i]** и увеличиваем преременную **count++**. Спомощью переменной count заполняем второй массива  **string[] sortedArray** и тем самым избавляемся от пробелов.
5. **Спомощью метода void PrintArray** выводим созданный массива на консоль.

___________________________________________________________________________


# Блок схема алгоритма.

Ссылка на файл ->https://github.com/Segunok1/credit_work/blob/master/%D0%B1%D0%BB%D0%BE%D0%BA%20%D1%81%D1%85%D0%B5%D0%BC%D0%B0.drawio.svg

























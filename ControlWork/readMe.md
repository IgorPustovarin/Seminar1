*ControlWork*
# Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.
# **Первоначально было две разных блок-схемы**
* Планировалось, что будет отдельный метод, который считает количество символов в слове и считать сколько вообще таких слов в массиве. Второй метод должен создать массив заданной длины и заполнить его.
1. В итоге в был найден такой оператор как Array.Resize который увеличивает длину существующего одномерного массива.
2. Задача была решена одним методом, который на вход принимает сформированный массив, с помощью цикла проверяет все его элементы на удовлетворение условиям. При совпадении увеличивает длину нового массива добавляет новый элемент. Затем выводит все на экран. 


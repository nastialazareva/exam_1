# Exam Task

### Было дано:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

*__Алгоритм, соданный в расширении draw.io, располагается в папке по названием "Algoritm_exam_1", а его реализация: exam_task/Program.cs__*

### Решение:
1. Для начала мы объявляем первый и второй массив **(arr_1 и arr_2 соответственно)**. 

2. Далее мы описываем метод **(ArrayCut)**. В него вкладываем цикл **(for)**, который равен длине масива. Внутри первого цикла вводим второй цикл **(for)**, в котором мы делаем проверку условия **(длина строки <= 3)**. 

В случае, если это - истина, то тогда элемент первого массива складывается в **count** *(нужен для того, чтобы складывать по очереди элементы из первого массива во второй)* элемента второго массива.

3. Далее идет увеличение count на 1 и цикл идет дальше, увеличивая i на 1 до конца цикла.

4. После завершенного цикла мы вводим новый метод PrintArrray, где распечатываем уже новый массив по заданным параметрам, где все строки <= 3. Для этого мы используем снова цикл **(for)**, равный длине массива.
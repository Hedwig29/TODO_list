﻿using System.Text;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;
        // В этом задании вам нужно создать список дел.
        // Исплоьзуйте массив или лист для хранения списка дел.
        // При запуске программа должна выводить меню на экран и ждать дальнейших действий пользователя.
        // После выполнения действия программа должна снова выводить меню и ждать дальнейших действий пользователя.
        // Все действия должны выполняться до тех пор, пока пользователь не выберет пункт "Выход".


        List<string> toDoList = new List<string>();

        while (true)
        {
           
            if (toDoList.Count > 0)
            {
                Console.WriteLine("To-do List:");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine("- " + toDoList[i]);
                }

            }
            else
            {
                Console.WriteLine("На данный момент в вашем списке нет задач.");
            }


            Console.WriteLine("Список дел:");
            Console.WriteLine("Выберите действия:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Выход");
            string choice;
            choice = (Console.ReadLine());
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите задачу: ");
                    string task = Console.ReadLine();
                    toDoList.Add(task);

                    Console.WriteLine("Задача добавлена успешно");
                    break;
                case "2":
                    if (toDoList.Count > 0)
                    {
                        Console.WriteLine("Введите номер задачи, которую вы хотите удалить:");

                        for (int i = 0; i < toDoList.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
                        }
                    }
                    int taskNum = int.Parse(Console.ReadLine());
                    taskNum--;

                    if (taskNum >= 0 && taskNum < toDoList.Count)
                    {
                        toDoList.RemoveAt(taskNum);
                        Console.Clear();
                        Console.WriteLine("Задача удалена успешно!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Неверный номер задачи.");
                    }
                    break;
                case "3":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда,повторите попытку");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;



            }
            




            // Выводим список задач

            // Выводим меню

            // Считываем выбор пользователя

            // Обрабатываем выбор пользователя


            // 1. Добавить задачу
            // Считываем задачу
            // Добавляем задачу


            // 2. Удалить задачу
            // Считываем номер задачи
            // Удаляем задачу
            // Если ввод некорректный, выводим сообщение об ошибке

            // 3. Выход
            // Выходим из программы

            // Ввод за пределами меню
            // Выводим сообщение об ошибке

        }
    }
}
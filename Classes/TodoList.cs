using AppInterfaces.Intefaces;
using System;

namespace AppInterfaces.Classes
{
    class TodoList : IDisplayable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
        public void Display()
        {
            for (var i = 0; i < Todos.Length; i++)
            {
                Console.WriteLine(Todos[i]);
            }
        }
        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPBasedTodoApp
{
    public class TodoItem
    {
       
        public string action;
        public bool done;
    }

  
    public class TodoList
    {
        public List<TodoItem> Items { get; } = new List<TodoItem>();

        public void Add(TodoItem item)
        {
            Items.Add(item);
        }


        public List<TodoItem> getTodos()
        {
            return Items.Where(t => !t.done).ToList();
        }

        
        public void MarkActionDone(string action)
        {
            var item = Items.FirstOrDefault(t => t.action == action);
            if (item != null) item.done = true;
        }


        public override string ToString()
        {
            var open = getTodos().Select(t => t.action);
            return string.Join(Environment.NewLine, open);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var tl = new TodoList();
            tl.Add(new TodoItem { action = "Grocery", done = false });
            tl.Add(new TodoItem { action = "Gym", done = false });
            tl.MarkActionDone("Gym");

            foreach (var todo in tl.getTodos())
                Console.WriteLine(todo.action);
 

        }
    }
}

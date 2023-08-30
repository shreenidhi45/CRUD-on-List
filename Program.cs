namespace CRUDOperations
{
    internal class Program
    {
        
            
            static List<string> items = new List<string>();

            // Create
            static void AddItem(string item)
            {
                items.Add(item);
            }

            // Read
            static void GetItems()
            {
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }

            // Update 
            static void EditItem(int index, string item)
            {
                items[index] = item;
            }

            // Delete
            static void RemoveItem(int index)
            {
                items.RemoveAt(index);
            }

            static void Main(string[] args)
            {
                // Create 
                AddItem("Item 1");
                AddItem("Item 2");

                // Read
                GetItems();

                // Update
                EditItem(0, "Rohit");

                // Delete
                RemoveItem(1);

                // Read again
                GetItems();
            }
        }
    }
    
namespace ToDoApp.Models;

public class TodoItemRepository
{
    public static List<Todolitem> items = new List<Todolitem>()
    {
       new Todolitem{Id=1,Name="Item 1",},
            new Todolitem{Id=2,Name="Item 2"},
            new Todolitem{Id=3,Name="Item 3"},
            new Todolitem{Id=4,Name="Item 4"},
            
       
    };

    public static void AddItem(Todolitem item)
    {
        if (items.Count > 0)
        {
            var itemMax = items.Max(s => s.Id);
            item.Id = itemMax + 1;
            items.Add(item);
        }
        else
        {
            item.Id = 1;
            items.Add(item);
        }
      
    }
    public static List<Todolitem> GetItems()
    {
        var sortedItem=items
            .OrderBy(s=>s.IsCompleted)
            .ThenByDescending(s=>s.Id)
            .ToList();
        return sortedItem;
    }

    public static void Removeitem(Todolitem item)
        => items.Remove(item);

    //public static List<Todolitem> GetitemByCity(string city)
    //{
    //   // return items.Where(s => s.LocatedCity.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
    //}

    public static Todolitem? GetitemById(int id)
    {
        var item = items.FirstOrDefault(s => s.Id == id);
        if (item != null)
        {
            return new Todolitem
            {
                Id = item.Id,
                Name = item.Name,
                
            };
        }
        return null;
    }
    public static void Updateitem(int Id, Todolitem item)
    {
        if (Id != item.Id) return;
        var itemToUpdate = items.FirstOrDefault(s => s.Id == Id);
        if (itemToUpdate != null)
        {
            
            itemToUpdate.Name = item.Name;
          
        }
    }

    public static void Deleteitem(int Id)
    {
        var itemToDelete = items.FirstOrDefault(s => s.Id == Id);

        if (itemToDelete != null)
        {
            items.Remove(itemToDelete);
        }
    }

    public static List<Todolitem> Searchitem(string itemFilter)
    {
        return items.Where(s => s.Name.Contains(itemFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static void Additem(Todolitem entity)
    {
        var Id = items.Max(s => s.Id);
        entity.Id = Id + 1;
        items.Add(entity);

    }
}

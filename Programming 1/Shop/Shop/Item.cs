//=============================================================================
// Program's Item class
//=============================================================================

namespace Shop
{
    
    
    
    public class Item
    {
        private string Name;
        private int Cost;

        public Item()
        {
            Name = " ";
            Cost = 0;
        }
        public Item(string name, int cost)
        {
             Name = name;
             Cost= cost;
        }  
        
       
        public string GetName()
        {
            return Name;
        }

        
        public int GetCost()
        {
            return Cost;
        }
        public void SetName(string _name)
        {
            Name= _name;

        }
        public void SetCost(int _cost)
        {
            Cost= _cost;
        }


    }
    // TODO: Write a class called Item that contains 2 data members:
    //       A string called name and an int called cost.
    //       This class should have a default constructor that sets name to ""
    //       and cost to 0.
    //       It should also have an overloaded constructor that accepts 2
    //       parameters - a string and an int.
    //
    //       Write getters/accessors for each data member. They should be called
    //       GetName and GetCost.
    //
    //       Write setters/mutators for each data member. They should be called
    //       SetName and SetCost.

}

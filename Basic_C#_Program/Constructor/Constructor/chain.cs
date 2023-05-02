using System;
namespace Constructor
{
    public class chain
    {
       public string Name
        { get; set; }

        public int Id
        { get; set; }

        public chain( int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }


        public chain() : this(14567, "Jason ")
        {

        }

    }
    
}

using System;

namespace SSFInventory.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string CatgNumber{ get; set; }
        public string CatgName { get; set; }
        public int Storeid { get; set; }
        public string CatgDesc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifedBy { get; set; }
        public DateTime ModifedDate { get; set; }
        public int LockedBy { get; set; }
        public DateTime LockedDate { get; set; }

    }
}

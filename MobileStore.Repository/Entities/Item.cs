
using System.Collections.Generic;

namespace MobileStore.Domain.Entities
{
    public class Item : BaseEntity
    {
        public ItemType Type { get; set; }
        public string TypeId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string ManufacturerId { get; set; }
        public int Total { get; set; }
        public int Cost { get; set; }
        public ICollection<Photo> Images { get; set; }
    }
}

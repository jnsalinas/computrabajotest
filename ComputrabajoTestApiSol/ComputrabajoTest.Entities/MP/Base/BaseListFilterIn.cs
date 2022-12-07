using System;
using ComputrabajoTest.Entities.VM;

namespace ComputrabajoTest.Entities.MP.Base
{
    //generic structure for filter entities
	public class BaseListFilterIn
    {
        public List<ItemFilterVM> ListItemFilters { get; set; } = new List<ItemFilterVM>();
        public int? Page { get; set; }
        public int? ToShow { get; set; }
    }
}


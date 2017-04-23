using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FoodNavigator___Model.Cloud_Model
{
    public class CloudLoadJson
    {
        public class Selection
        {
            public string location { get; set; }
            public string type { get; set; }
            public int radius { get; set; }
            public string transport { get; set; }
            public int foodIndex { get; set; }
            public int typeIndex { get; set; }
        }

        public class Informations
        {
            public List<Selection> selection { get; set; }
            public bool Errors { get; set; }
        }

    }
}

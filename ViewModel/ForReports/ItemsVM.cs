using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmAssistant.ViewModel
{
    public class ItemsVM
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string GenericName { get; set; }
        public string ManufacturerName { get; set; }
    }
}
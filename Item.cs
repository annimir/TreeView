using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewTree
{
    public class Item
    {
        protected int id_Item;
        protected string item_Name;
        protected int item_Type;
        protected int attribute_Indicator;
        protected string attribute_Name;
        protected string description;
        protected int worth;

        public int ID_Item
        {
            get
            {
                return id_Item;
            }
            set
            {
                if (value > 0)
                {
                    id_Item = value;
                }
                else
                {
                    throw new Exception("Неверное значение");
                }
            }
        }
        public string Item_Name 
        {
            get
            {
                return item_Name;
            }
            set
            {
                item_Name = value;
            }
        }
        public int Item_Type
        {
            get
            {
                return item_Type;
            }
            set
            {
                if (value > 0)
                {
                    item_Type = value;
                }
                else
                {
                    throw new Exception("Неверное значение");
                }
            }
        }
        public int Attribute_Indicator
        {
            get
            {
                return attribute_Indicator;
            }
            set
            {              
                attribute_Indicator = value;

            }
        }
        public string Attribute_Name
        {
            get
            {
                return attribute_Name;
            }
            set
            {
                attribute_Name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public int Worth
        {
            get
            {
                return worth;
            }
            set
            {
                if (value > 0)
                {
                    worth = value;
                }
                else
                {
                    throw new Exception("Неверное значение");
                }
            }
        }

        public Item()
        {
            id_Item = 0;
            item_Name = null;
            item_Type = 0;
            attribute_Indicator = 0;
            attribute_Name = null;
            description = null;
            worth = 0;
        }

        public Item(int id, string name, int type, int attIndicator, string attName, string desc, int cost)
        {
            id_Item = id;
            item_Name = name;
            item_Type = type;
            attribute_Indicator = attIndicator;
            attribute_Name = attName;
            description = desc;
            worth = cost;
        }
    }
}

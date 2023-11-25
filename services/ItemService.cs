﻿using cafe_pos_system.Contracts;
using cafe_pos_system.DB;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.services
{
    public class ItemService : IItem
    {
        private ItemDB itemDB = new ItemDB();
        public void DeleteItemById(int id)
        {
            itemDB.DeleteItemById(id);
        }

        public Item GetByItemById(int id)
        {
            return itemDB.GetByItemById(id);
        }

        public List<Item> GetItem()
        {
            return itemDB.GetItem();
        }

        public void InsertItem(Item item)
        {
            itemDB.InsertItem(item);
        }

        public void UpdateItem(Item item)
        {
            itemDB.UpdateItem(item);
        }
    }
}

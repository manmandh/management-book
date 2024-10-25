﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Book.Module.BusinessObjects.book_main
{

    [DefaultProperty("id")
]
    public partial class Inventory : DevExpress.Persistent.BaseImpl.BaseObject
    {
        short fid;
        public short id
        {
            get { return fid; }
            set { SetPropertyValue<short>(nameof(id), ref fid, value); }
        }
        Products fproduct_id;
        [Association(@"InventoryReferencesProducts")]
        public Products product_id
        {
            get { return fproduct_id; }
            set { SetPropertyValue<Products>(nameof(product_id), ref fproduct_id, value); }
        }
        Warehouse fwarehouse_id;
        [Association(@"InventoryReferencesWarehouse")]
        public Warehouse warehouse_id
        {
            get { return fwarehouse_id; }
            set { SetPropertyValue<Warehouse>(nameof(warehouse_id), ref fwarehouse_id, value); }
        }
        short fstock_quantity;
        public short stock_quantity
        {
            get { return fstock_quantity; }
            set { SetPropertyValue<short>(nameof(stock_quantity), ref fstock_quantity, value); }
        }
    }

}

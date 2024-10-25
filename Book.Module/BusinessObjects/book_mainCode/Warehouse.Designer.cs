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

    [DefaultProperty("id")]
    public partial class Warehouse : DevExpress.Persistent.BaseImpl.BaseObject
    {
        short fid;
        public short id
        {
            get { return fid; }
            set { SetPropertyValue<short>(nameof(id), ref fid, value); }
        }
        string fname;
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        short fcapacity;
        public short capacity
        {
            get { return fcapacity; }
            set { SetPropertyValue<short>(nameof(capacity), ref fcapacity, value); }
        }
        string faddress;
        public string address
        {
            get { return faddress; }
            set { SetPropertyValue<string>(nameof(address), ref faddress, value); }
        }
        DateTime fcreated_at;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime created_at
        {
            get { return fcreated_at; }
            set { SetPropertyValue<DateTime>(nameof(created_at), ref fcreated_at, value); }
        }
        DateTime fupdated_at;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime updated_at
        {
            get { return fupdated_at; }
            set { SetPropertyValue<DateTime>(nameof(updated_at), ref fupdated_at, value); }
        }
        [Association(@"InventoryReferencesWarehouse"), Aggregated]
        public XPCollection<Inventory> Inventories { get { return GetCollection<Inventory>(nameof(Inventories)); } }
        [Association(@"PurchasesReferencesWarehouse"), Aggregated]
        public XPCollection<Purchases> PurchasesCollection { get { return GetCollection<Purchases>(nameof(PurchasesCollection)); } }
    }

}

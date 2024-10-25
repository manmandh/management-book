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
    public partial class Purchase_Details : DevExpress.Persistent.BaseImpl.BaseObject
    {
        short fid;
        public short id
        {
            get { return fid; }
            set { SetPropertyValue<short>(nameof(id), ref fid, value); }
        }
        Purchases fpurchase_id;
        [Association(@"Purchase_DetailsReferencesPurchases")]
        public Purchases purchase_id
        {
            get { return fpurchase_id; }
            set { SetPropertyValue<Purchases>(nameof(purchase_id), ref fpurchase_id, value); }
        }
        Products fproduct_id;
        [Association(@"Purchase_DetailsReferencesProducts")]
        public Products product_id
        {
            get { return fproduct_id; }
            set { SetPropertyValue<Products>(nameof(product_id), ref fproduct_id, value); }
        }
        short fquantity;
        public short quantity
        {
            get { return fquantity; }
            set { SetPropertyValue<short>(nameof(quantity), ref fquantity, value); }
        }
        double funit_cost;
        public double unit_cost
        {
            get { return funit_cost; }
            set { SetPropertyValue<double>(nameof(unit_cost), ref funit_cost, value); }
        }
        double ftotal_money;
        public double total_money
        {
            get { return ftotal_money; }
            set { SetPropertyValue<double>(nameof(total_money), ref ftotal_money, value); }
        }
    }

}

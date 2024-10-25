using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Book.Module.BusinessObjects.book_main
{

    public partial class Purchases
    {
        public Purchases(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

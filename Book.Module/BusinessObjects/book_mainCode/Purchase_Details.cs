using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Book.Module.BusinessObjects.book_main
{

    public partial class Purchase_Details
    {
        public Purchase_Details(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

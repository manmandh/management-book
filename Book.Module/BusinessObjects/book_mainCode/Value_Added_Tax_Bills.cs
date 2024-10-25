using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Book.Module.BusinessObjects.book_main
{

    public partial class Value_Added_Tax_Bills
    {
        public Value_Added_Tax_Bills(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

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
    public partial class Employees : DevExpress.Persistent.BaseImpl.BaseObject
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
        string femail;
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>(nameof(email), ref femail, value); }
        }
        string fpassword;
        public string password
        {
            get { return fpassword; }
            set { SetPropertyValue<string>(nameof(password), ref fpassword, value); }
        }
        decimal fphone;
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")]
        public decimal phone
        {
            get { return fphone; }
            set { SetPropertyValue<decimal>(nameof(phone), ref fphone, value); }
        }
        string fposition;
        public string position
        {
            get { return fposition; }
            set { SetPropertyValue<string>(nameof(position), ref fposition, value); }
        }
        string fdepartment;
        public string department
        {
            get { return fdepartment; }
            set { SetPropertyValue<string>(nameof(department), ref fdepartment, value); }
        }
        string faddress;
        public string address
        {
            get { return faddress; }
            set { SetPropertyValue<string>(nameof(address), ref faddress, value); }
        }
        DateTime fdob;
        public DateTime dob
        {
            get { return fdob; }
            set { SetPropertyValue<DateTime>(nameof(dob), ref fdob, value); }
        }
        string fnote;
        public string note
        {
            get { return fnote; }
            set { SetPropertyValue<string>(nameof(note), ref fnote, value); }
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
        [Association(@"PurchasesReferencesEmployees"), Aggregated]
        public XPCollection<Purchases> PurchasesCollection { get { return GetCollection<Purchases>(nameof(PurchasesCollection)); } }
        [Association(@"BillsReferencesEmployees"), Aggregated]
        public XPCollection<Bills> BillsCollection { get { return GetCollection<Bills>(nameof(BillsCollection)); } }
    }

}
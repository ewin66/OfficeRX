﻿using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.SystemModule;

namespace RX2_Office.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Sales")]
    [ListViewAutoFilterRowAttribute(true)]
    
    [ImageName("burn")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class CustomerRelease : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CustomerRelease(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
        // Fields...
        private string _Note;
        private DateTime _AquiredDate;
        private string _AquiredBy;
        private string _ReleasedBy;
        private DateTime _ReleasedDate;
        private Customer _Customer;

        [Association("Customer-CustomerRelease")]
        public Customer Customer
        {
            get
            {
                return _Customer;
            }
            set
            {
                SetPropertyValue("Customer", ref _Customer, value);
            }
        }

        public DateTime ReleasedDate
        {
            get
            {
                return _ReleasedDate;
            }
            set
            {
                SetPropertyValue("ReleasedDate", ref _ReleasedDate, value);
            }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ReleasedBy
        {
            get
            {
                return _ReleasedBy;
            }
            set
            {
                SetPropertyValue("ReleasedBy", ref _ReleasedBy, value);
            }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AquiredBy
        {
            get
            {
                return _AquiredBy;
            }
            set
            {
                SetPropertyValue("AquiredBy", ref _AquiredBy, value);
            }
        }

        public DateTime AquiredDate
        {
            get
            {
                return _AquiredDate;
            }
            set
            {
                SetPropertyValue("AquiredDate", ref _AquiredDate, value);
            }
        }

        [Size(256)]
        public string Note
        {
            get
            {
                return _Note;
            }
            set
            {
                SetPropertyValue("Note", ref _Note, value);
            }
        }



       
    }
}
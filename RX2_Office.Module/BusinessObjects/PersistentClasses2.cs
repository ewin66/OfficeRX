﻿using System;
using DevExpress.Xpo;

namespace RX2_Office.Module.BusinessObjects
{

    public class PersistentClasses2 : XPObject
    {
        public PersistentClasses2()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PersistentClasses2(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}
﻿using DevExpress;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Templates;
using System.Collections.Generic;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Win.Core;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;
using DevExpress.XtraEditors;
using DevExpress.Persistent.BaseImpl;
using RX2_Office.Module;


namespace RX2_Office.Module.Win.Controllers.Shipping
{
    public partial class Receipt : PopupFormBase
    {
        protected override XafLayoutControl BottomPanel
        {
            get { return bottomPanel; }
        }
        protected override PanelControl ViewSitePanel
        {
            get { return viewSitePanel; }
        }
        protected override ViewSiteManager ViewSiteManager
        {
            get { return viewSiteManager; }
        }
        protected override FormStateModelSynchronizer FormStateModelSynchronizer
        {
            get { return formStateModelSynchronizer; }
        }
        public override ICollection<IActionContainer> GetContainers()
        {
            return actionContainersManager.GetContainers();
        }
        public override IActionContainer DefaultContainer
        {
            get { return actionContainersManager.DefaultContainer; }
        }
        public ButtonsContainer ButtonsContainer
        {
            get { return buttonsContainer; }
        }
        public ButtonsContainer DiagnosticContainer
        {
            get { return diagnosticContainer; }
        }
        public override object ViewSiteControl
        {
            get { return viewSitePanel; }
        }
        public override DevExpress.XtraBars.BarManager BarManager
        {
            get { return xafBarManager; }
        }
        public Receipt()
        {
            InitializeComponent();
            NewReceipt();

        }

       

        private void NewReceipt()
        {

            int nextSequence = 0;

           // int nextSequence = DistributedIdGeneratorHelper.Generate(Session.DataLayer, this.GetType().FullName, "ReceiptID");
            txtReceiptID.Text = string.Format("{0:D6}", nextSequence);
            txtReceiverDt.Text = System.DateTime.Now.ToString();
            txtReceivedBy.Text = SecuritySystem.CurrentUserName;





        }

    }
}
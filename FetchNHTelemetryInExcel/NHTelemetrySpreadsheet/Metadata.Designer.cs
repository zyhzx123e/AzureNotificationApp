﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace NHTelemetrySpreadsheet {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(1)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class Metadata : Microsoft.Office.Tools.Excel.WorksheetBase {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        internal Microsoft.Office.Tools.Excel.Controls.TextBox txtSubscriptionID;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button btnFetchMetrics;
        
        internal Microsoft.Office.Tools.Excel.Controls.DateTimePicker datePickerFromDate;
        
        internal Microsoft.Office.Tools.Excel.Controls.DateTimePicker datePickerToDate;
        
        internal Microsoft.Office.Tools.Excel.Controls.ComboBox cmbMetricRollup;
        
        internal Microsoft.Office.Tools.Excel.Controls.CheckedListBox lstMetricName;
        
        internal Microsoft.Office.Tools.Excel.Controls.TextBox txtNamespace;
        
        internal Microsoft.Office.Tools.Excel.Controls.TextBox txtNotificationHub;
        
        internal Microsoft.Office.Tools.Excel.Controls.TextBox txtCertPath;
        
        internal Microsoft.Office.Tools.Excel.Controls.TextBox txtCertPassword;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Metadata(global::Microsoft.Office.Tools.Excel.Factory factory, global::System.IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "Sheet1", "Sheet1") {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            Globals.Metadata = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.txtSubscriptionID = new Microsoft.Office.Tools.Excel.Controls.TextBox(Globals.Factory, this.ItemProvider, this.HostContext, "3C927D339324FB342E93B41A329FDA9A647F93", "3C927D339324FB342E93B41A329FDA9A647F93", this, "txtSubscriptionID");
            this.btnFetchMetrics = new Microsoft.Office.Tools.Excel.Controls.Button(Globals.Factory, this.ItemProvider, this.HostContext, "4EF4D29B64DA3F447EF4A69E48FA078680F7A4", "4EF4D29B64DA3F447EF4A69E48FA078680F7A4", this, "btnFetchMetrics");
            this.datePickerFromDate = new Microsoft.Office.Tools.Excel.Controls.DateTimePicker(Globals.Factory, this.ItemProvider, this.HostContext, "5CFA5737A5F09D541E55B1FD5FF85F5D92EA45", "5CFA5737A5F09D541E55B1FD5FF85F5D92EA45", this, "datePickerFromDate");
            this.datePickerToDate = new Microsoft.Office.Tools.Excel.Controls.DateTimePicker(Globals.Factory, this.ItemProvider, this.HostContext, "6F18EBA76614C664EB96B2B16E3171D7D17746", "6F18EBA76614C664EB96B2B16E3171D7D17746", this, "datePickerToDate");
            this.cmbMetricRollup = new Microsoft.Office.Tools.Excel.Controls.ComboBox(Globals.Factory, this.ItemProvider, this.HostContext, "718010C7F74F53744CE7B3567A1BF6050E7047", "718010C7F74F53744CE7B3567A1BF6050E7047", this, "cmbMetricRollup");
            this.lstMetricName = new Microsoft.Office.Tools.Excel.Controls.CheckedListBox(Globals.Factory, this.ItemProvider, this.HostContext, "94224F0E599658941349B3229B7EDD2978EEF9", "94224F0E599658941349B3229B7EDD2978EEF9", this, "lstMetricName");
            this.txtNamespace = new Microsoft.Office.Tools.Excel.Controls.TextBox(Globals.Factory, this.ItemProvider, this.HostContext, "19D60D1DC12A9414C061B4F81B402E4B1FC561", "19D60D1DC12A9414C061B4F81B402E4B1FC561", this, "txtNamespace");
            this.txtNotificationHub = new Microsoft.Office.Tools.Excel.Controls.TextBox(Globals.Factory, this.ItemProvider, this.HostContext, "147F20FF2163F7149361A8D7137BE7CAA9AD41", "147F20FF2163F7149361A8D7137BE7CAA9AD41", this, "txtNotificationHub");
            this.txtCertPath = new Microsoft.Office.Tools.Excel.Controls.TextBox(Globals.Factory, this.ItemProvider, this.HostContext, "1479529E711D481456C1AD6415E1A252A16D81", "1479529E711D481456C1AD6415E1A252A16D81", this, "txtCertPath");
            this.txtCertPassword = new Microsoft.Office.Tools.Excel.Controls.TextBox(Globals.Factory, this.ItemProvider, this.HostContext, "18B64D8F01240C147761A6701D6D6CB14B90C1", "18B64D8F01240C147761A6701D6D6CB14B90C1", this, "txtCertPassword");
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            // 
            // txtSubscriptionID
            // 
            this.txtSubscriptionID.Name = "txtSubscriptionID";
            // 
            // btnFetchMetrics
            // 
            this.btnFetchMetrics.BackColor = System.Drawing.SystemColors.Control;
            this.btnFetchMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchMetrics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFetchMetrics.Name = "btnFetchMetrics";
            this.btnFetchMetrics.Text = "Get Metrics Data";
            this.btnFetchMetrics.UseVisualStyleBackColor = false;
            // 
            // datePickerFromDate
            // 
            this.datePickerFromDate.Name = "datePickerFromDate";
            // 
            // datePickerToDate
            // 
            this.datePickerToDate.Name = "datePickerToDate";
            // 
            // cmbMetricRollup
            // 
            this.cmbMetricRollup.Items.AddRange(new object[] {
                        "Rollup by 1 Day\t  (P1D)",
                        "Rollup by 1 Hour\t  (PT1H)",
                        "Rollup by 5 Minutes (PT5M)"});
            this.cmbMetricRollup.Name = "cmbMetricRollup";
            // 
            // lstMetricName
            // 
            this.lstMetricName.Items.AddRange(new object[] {
                        "All Registration Operations\t(registration.all)",
                        "Incoming Messages\t\t(incoming) ",
                        "All Successful Notifications\t(outgoing.allpns.success)",
                        "WNS Successful Notifications\t(outgoing.wns.success)",
                        "WNS Errors\t\t\t(outgoing.wns.pnserror)",
                        "APNS Successful Notifications \t(outgoing.apns.success)",
                        "APNS Errors \t\t\t(outgoing.apns.pnserror)",
                        "GCM Successful Notifications\t(outgoing.gcm.success)",
                        "GCM Errors \t\t\t(outgoing.gcm.pnserror)"});
            this.lstMetricName.Name = "lstMetricName";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Name = "txtNamespace";
            // 
            // txtNotificationHub
            // 
            this.txtNotificationHub.Name = "txtNotificationHub";
            // 
            // txtCertPath
            // 
            this.txtCertPath.Name = "txtCertPath";
            // 
            // txtCertPassword
            // 
            this.txtCertPassword.Name = "txtCertPassword";
            this.txtSubscriptionID.BindingContext = this.BindingContext;
            this.btnFetchMetrics.BindingContext = this.BindingContext;
            this.datePickerFromDate.BindingContext = this.BindingContext;
            this.datePickerToDate.BindingContext = this.BindingContext;
            this.cmbMetricRollup.BindingContext = this.BindingContext;
            this.lstMetricName.BindingContext = this.BindingContext;
            this.txtNamespace.BindingContext = this.BindingContext;
            this.txtNotificationHub.BindingContext = this.BindingContext;
            this.txtCertPath.BindingContext = this.BindingContext;
            this.txtCertPassword.BindingContext = this.BindingContext;
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
    }
    
    internal sealed partial class Globals {
        
        private static Metadata _Metadata;
        
        internal static Metadata Metadata {
            get {
                return _Metadata;
            }
            set {
                if ((_Metadata == null)) {
                    _Metadata = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
    }
}

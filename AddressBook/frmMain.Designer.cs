namespace AddressBook
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.搜索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.图标toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trvGroup = new System.Windows.Forms.TreeView();
            this.lvContact = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.imgSamllIcon = new System.Windows.Forms.ImageList(this.components);
            this.imgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.查看ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.删除DToolStripMenuItem,
            this.修改MToolStripMenuItem,
            this.toolStripMenuItem1,
            this.搜索SToolStripMenuItem});
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.lToolStripMenuItem.Text = "联系人(&C)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增NToolStripMenuItem.Text = "新增(&N)";
            this.新增NToolStripMenuItem.Click += new System.EventHandler(this.新增NToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            // 
            // 修改MToolStripMenuItem
            // 
            this.修改MToolStripMenuItem.Name = "修改MToolStripMenuItem";
            this.修改MToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改MToolStripMenuItem.Text = "修改(&M)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 搜索SToolStripMenuItem
            // 
            this.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem";
            this.搜索SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.搜索SToolStripMenuItem.Text = "搜索(S)";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图标ToolStripMenuItem,
            this.详细信息ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 图标ToolStripMenuItem
            // 
            this.图标ToolStripMenuItem.Name = "图标ToolStripMenuItem";
            this.图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.图标ToolStripMenuItem.Text = "图标";
            this.图标ToolStripMenuItem.Click += new System.EventHandler(this.图标ToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.tsbtnSearch,
            this.tsbtnView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::AddressBook.Properties.Resources.filenew;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(68, 36);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.ToolTipText = "新增联系人";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = global::AddressBook.Properties.Resources.edit;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(68, 36);
            this.tsbtnEdit.Text = "修改";
            this.tsbtnEdit.ToolTipText = "修改联系人";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = global::AddressBook.Properties.Resources.editdelete;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(68, 36);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.ToolTipText = "删除联系人";
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Image = global::AddressBook.Properties.Resources.find;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(68, 36);
            this.tsbtnSearch.Text = "搜索";
            this.tsbtnSearch.ToolTipText = "搜索联系人";
            // 
            // tsbtnView
            // 
            this.tsbtnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图标toolStripMenuItem2,
            this.详细信息ToolStripMenuItem1});
            this.tsbtnView.Image = global::AddressBook.Properties.Resources.view_text;
            this.tsbtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnView.Name = "tsbtnView";
            this.tsbtnView.Size = new System.Drawing.Size(77, 36);
            this.tsbtnView.Text = "查看";
            this.tsbtnView.ToolTipText = "查看联系人";
            // 
            // 图标toolStripMenuItem2
            // 
            this.图标toolStripMenuItem2.Name = "图标toolStripMenuItem2";
            this.图标toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.图标toolStripMenuItem2.Text = "图标";
            this.图标toolStripMenuItem2.Click += new System.EventHandler(this.图标toolStripMenuItem2_Click);
            // 
            // 详细信息ToolStripMenuItem1
            // 
            this.详细信息ToolStripMenuItem1.Name = "详细信息ToolStripMenuItem1";
            this.详细信息ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.详细信息ToolStripMenuItem1.Text = "详细信息";
            this.详细信息ToolStripMenuItem1.Click += new System.EventHandler(this.详细信息ToolStripMenuItem1_Click);
            // 
            // trvGroup
            // 
            this.trvGroup.HideSelection = false;
            this.trvGroup.ImageIndex = 0;
            this.trvGroup.ImageList = this.imgTree;
            this.trvGroup.Location = new System.Drawing.Point(0, 62);
            this.trvGroup.Name = "trvGroup";
            this.trvGroup.SelectedImageIndex = 0;
            this.trvGroup.Size = new System.Drawing.Size(153, 360);
            this.trvGroup.TabIndex = 2;
            this.trvGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvGroup_AfterSelect);
            // 
            // lvContact
            // 
            this.lvContact.LargeImageList = this.imgLargeIcon;
            this.lvContact.Location = new System.Drawing.Point(154, 62);
            this.lvContact.Name = "lvContact";
            this.lvContact.Size = new System.Drawing.Size(453, 360);
            this.lvContact.SmallImageList = this.imgSamllIcon;
            this.lvContact.TabIndex = 3;
            this.lvContact.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslUserName,
            this.tsslCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.AutoSize = false;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(200, 17);
            this.tsslStatus.Text = "就绪";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslUserName
            // 
            this.tsslUserName.AutoSize = false;
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(100, 17);
            this.tsslUserName.Text = "Admin";
            this.tsslUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslCount
            // 
            this.tsslCount.AutoSize = false;
            this.tsslCount.Name = "tsslCount";
            this.tsslCount.Size = new System.Drawing.Size(100, 17);
            this.tsslCount.Text = "共 个联系人";
            this.tsslCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "users.ico");
            // 
            // imgSamllIcon
            // 
            this.imgSamllIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSamllIcon.ImageStream")));
            this.imgSamllIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSamllIcon.Images.SetKeyName(0, "user.ico");
            // 
            // imgLargeIcon
            // 
            this.imgLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLargeIcon.ImageStream")));
            this.imgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLargeIcon.Images.SetKeyName(0, "user.ico");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 446);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvContact);
            this.Controls.Add(this.trvGroup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录管理器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改MToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 搜索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.TreeView trvGroup;
        private System.Windows.Forms.ListView lvContact;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslCount;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnView;
        private System.Windows.Forms.ToolStripMenuItem 图标toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.ImageList imgSamllIcon;
        private System.Windows.Forms.ImageList imgLargeIcon;
    }
}
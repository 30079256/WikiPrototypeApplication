namespace WikiPrototypeApplication
{
    partial class FormWikiPrototype
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxStructure = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelStructure = new System.Windows.Forms.Label();
            this.LabelDefinition = new System.Windows.Forms.Label();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ListViewDataStructures = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.statusStripFeedback = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelFeedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(67, 59);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(169, 20);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBox_Leave);
            this.TextBoxName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxName_MouseDoubleClick);
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(68, 85);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(169, 20);
            this.TextBoxCategory.TabIndex = 2;
            this.TextBoxCategory.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxCategory.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TextBoxStructure
            // 
            this.TextBoxStructure.Location = new System.Drawing.Point(68, 111);
            this.TextBoxStructure.Name = "TextBoxStructure";
            this.TextBoxStructure.Size = new System.Drawing.Size(169, 20);
            this.TextBoxStructure.TabIndex = 3;
            this.TextBoxStructure.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxStructure.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(67, 140);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(169, 139);
            this.TextBoxDefinition.TabIndex = 4;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 62);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 88);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(49, 13);
            this.LabelCategory.TabIndex = 6;
            this.LabelCategory.Text = "Category";
            // 
            // LabelStructure
            // 
            this.LabelStructure.AutoSize = true;
            this.LabelStructure.Location = new System.Drawing.Point(11, 114);
            this.LabelStructure.Name = "LabelStructure";
            this.LabelStructure.Size = new System.Drawing.Size(50, 13);
            this.LabelStructure.TabIndex = 7;
            this.LabelStructure.Text = "Structure";
            // 
            // LabelDefinition
            // 
            this.LabelDefinition.AutoSize = true;
            this.LabelDefinition.Location = new System.Drawing.Point(12, 140);
            this.LabelDefinition.Name = "LabelDefinition";
            this.LabelDefinition.Size = new System.Drawing.Size(51, 13);
            this.LabelDefinition.TabIndex = 8;
            this.LabelDefinition.Text = "Definition";
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(456, 309);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 9;
            this.ButtonOpen.Text = "LOAD";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(15, 290);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 10;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(96, 290);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 11;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(177, 290);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 12;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ListViewDataStructures
            // 
            this.ListViewDataStructures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCategory});
            this.ListViewDataStructures.HideSelection = false;
            this.ListViewDataStructures.Location = new System.Drawing.Point(271, 21);
            this.ListViewDataStructures.MultiSelect = false;
            this.ListViewDataStructures.Name = "ListViewDataStructures";
            this.ListViewDataStructures.Size = new System.Drawing.Size(244, 263);
            this.ListViewDataStructures.TabIndex = 0;
            this.ListViewDataStructures.UseCompatibleStateImageBehavior = false;
            this.ListViewDataStructures.View = System.Windows.Forms.View.Details;
            this.ListViewDataStructures.DoubleClick += new System.EventHandler(this.ButtonDelete_Click);
            this.ListViewDataStructures.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDataStructures_MouseClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(149, 21);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 13;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(12, 23);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(131, 20);
            this.TextBoxSearch.TabIndex = 14;
            this.TextBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBox_Leave);
            this.TextBoxSearch.MouseEnter += new System.EventHandler(this.TextBox_Enter);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(375, 309);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 15;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // statusStripFeedback
            // 
            this.statusStripFeedback.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelFeedback});
            this.statusStripFeedback.Location = new System.Drawing.Point(0, 341);
            this.statusStripFeedback.Name = "statusStripFeedback";
            this.statusStripFeedback.Size = new System.Drawing.Size(543, 22);
            this.statusStripFeedback.TabIndex = 16;
            // 
            // ToolStripStatusLabelFeedback
            // 
            this.ToolStripStatusLabelFeedback.Name = "ToolStripStatusLabelFeedback";
            this.ToolStripStatusLabelFeedback.Size = new System.Drawing.Size(0, 17);
            // 
            // FormWikiPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 363);
            this.Controls.Add(this.statusStripFeedback);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ListViewDataStructures);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.LabelDefinition);
            this.Controls.Add(this.LabelStructure);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxStructure);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.TextBoxName);
            this.Name = "FormWikiPrototype";
            this.Text = "Wiki Prototype Application";
            this.Load += new System.EventHandler(this.FormWikiPrototype_Load);
            this.statusStripFeedback.ResumeLayout(false);
            this.statusStripFeedback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxStructure;
        private System.Windows.Forms.TextBox TextBoxDefinition;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelStructure;
        private System.Windows.Forms.Label LabelDefinition;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ListView ListViewDataStructures;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.StatusStrip statusStripFeedback;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelFeedback;
    }
}


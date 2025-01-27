namespace HardkorowyKodsu
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableNamesGrid = new DataGridView();
            TableNamesPanel = new Panel();
            TableNamesGridRefreshButton = new Button();
            TablesAndViewsLabel = new Label();
            TableColumnsGrid = new DataGridView();
            TableDataSplitContainer = new SplitContainer();
            SelectedTableViewDetailsLabel = new Label();
            TableDetailsGrid = new DataGridView();
            SelectedTableViewColumnsLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)TableNamesGrid).BeginInit();
            TableNamesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableColumnsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableDataSplitContainer).BeginInit();
            TableDataSplitContainer.Panel1.SuspendLayout();
            TableDataSplitContainer.Panel2.SuspendLayout();
            TableDataSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableDetailsGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableNamesGrid
            // 
            TableNamesGrid.AccessibleDescription = "A grid control showing data of selected view or table.";
            TableNamesGrid.AccessibleName = "Data View Grid";
            TableNamesGrid.AllowUserToAddRows = false;
            TableNamesGrid.AllowUserToDeleteRows = false;
            TableNamesGrid.AllowUserToOrderColumns = true;
            TableNamesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableNamesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableNamesGrid.Location = new Point(0, 32);
            TableNamesGrid.MultiSelect = false;
            TableNamesGrid.Name = "TableNamesGrid";
            TableNamesGrid.ReadOnly = true;
            TableNamesGrid.RowTemplate.ReadOnly = true;
            TableNamesGrid.Size = new Size(407, 506);
            TableNamesGrid.TabIndex = 0;
            TableNamesGrid.CurrentCellChanged += TableNamesGrid_CurrentCellChanged;
            TableNamesGrid.SelectionChanged += TableNamesGrid_SelectionChanged;
            // 
            // TableNamesPanel
            // 
            TableNamesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableNamesPanel.Controls.Add(TableNamesGridRefreshButton);
            TableNamesPanel.Controls.Add(TablesAndViewsLabel);
            TableNamesPanel.Controls.Add(TableNamesGrid);
            TableNamesPanel.Location = new Point(3, 3);
            TableNamesPanel.Name = "TableNamesPanel";
            TableNamesPanel.Size = new Size(410, 541);
            TableNamesPanel.TabIndex = 1;
            // 
            // TableNamesGridRefreshButton
            // 
            TableNamesGridRefreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TableNamesGridRefreshButton.Location = new Point(332, 3);
            TableNamesGridRefreshButton.Name = "TableNamesGridRefreshButton";
            TableNamesGridRefreshButton.Size = new Size(75, 23);
            TableNamesGridRefreshButton.TabIndex = 2;
            TableNamesGridRefreshButton.Text = "Refresh";
            TableNamesGridRefreshButton.UseVisualStyleBackColor = true;
            TableNamesGridRefreshButton.Click += TableNamesGridRefreshButton_Click;
            // 
            // TablesAndViewsLabel
            // 
            TablesAndViewsLabel.AutoSize = true;
            TablesAndViewsLabel.Location = new Point(3, 7);
            TablesAndViewsLabel.Name = "TablesAndViewsLabel";
            TablesAndViewsLabel.Size = new Size(98, 15);
            TablesAndViewsLabel.TabIndex = 1;
            TablesAndViewsLabel.Text = "Tables and Views:";
            // 
            // TableColumnsGrid
            // 
            TableColumnsGrid.AccessibleDescription = "A grid control showing data of selected view or table.";
            TableColumnsGrid.AccessibleName = "Data View Grid";
            TableColumnsGrid.AllowUserToAddRows = false;
            TableColumnsGrid.AllowUserToDeleteRows = false;
            TableColumnsGrid.AllowUserToOrderColumns = true;
            TableColumnsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableColumnsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableColumnsGrid.Location = new Point(3, 29);
            TableColumnsGrid.Name = "TableColumnsGrid";
            TableColumnsGrid.ReadOnly = true;
            TableColumnsGrid.RowTemplate.ReadOnly = true;
            TableColumnsGrid.Size = new Size(405, 225);
            TableColumnsGrid.TabIndex = 0;
            // 
            // TableDataSplitContainer
            // 
            TableDataSplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableDataSplitContainer.Location = new Point(419, 3);
            TableDataSplitContainer.Name = "TableDataSplitContainer";
            TableDataSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // TableDataSplitContainer.Panel1
            // 
            TableDataSplitContainer.Panel1.Controls.Add(SelectedTableViewDetailsLabel);
            TableDataSplitContainer.Panel1.Controls.Add(TableDetailsGrid);
            // 
            // TableDataSplitContainer.Panel2
            // 
            TableDataSplitContainer.Panel2.Controls.Add(SelectedTableViewColumnsLabel);
            TableDataSplitContainer.Panel2.Controls.Add(TableColumnsGrid);
            TableDataSplitContainer.Size = new Size(412, 541);
            TableDataSplitContainer.SplitterDistance = 280;
            TableDataSplitContainer.TabIndex = 2;
            // 
            // SelectedTableViewDetailsLabel
            // 
            SelectedTableViewDetailsLabel.AutoSize = true;
            SelectedTableViewDetailsLabel.Location = new Point(3, 7);
            SelectedTableViewDetailsLabel.Name = "SelectedTableViewDetailsLabel";
            SelectedTableViewDetailsLabel.Size = new Size(149, 15);
            SelectedTableViewDetailsLabel.TabIndex = 1;
            SelectedTableViewDetailsLabel.Text = "Selected table/view details:";
            // 
            // TableDetailsGrid
            // 
            TableDetailsGrid.AllowUserToAddRows = false;
            TableDetailsGrid.AllowUserToDeleteRows = false;
            TableDetailsGrid.AllowUserToOrderColumns = true;
            TableDetailsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDetailsGrid.Location = new Point(0, 32);
            TableDetailsGrid.Name = "TableDetailsGrid";
            TableDetailsGrid.ReadOnly = true;
            TableDetailsGrid.RowTemplate.ReadOnly = true;
            TableDetailsGrid.Size = new Size(412, 248);
            TableDetailsGrid.TabIndex = 0;
            // 
            // SelectedTableViewColumnsLabel
            // 
            SelectedTableViewColumnsLabel.AutoSize = true;
            SelectedTableViewColumnsLabel.Location = new Point(3, 11);
            SelectedTableViewColumnsLabel.Name = "SelectedTableViewColumnsLabel";
            SelectedTableViewColumnsLabel.Size = new Size(158, 15);
            SelectedTableViewColumnsLabel.TabIndex = 1;
            SelectedTableViewColumnsLabel.Text = "Selected table/view columns";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.92928F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.07072F));
            tableLayoutPanel1.Controls.Add(TableDataSplitContainer, 1, 0);
            tableLayoutPanel1.Controls.Add(TableNamesPanel, 0, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9125671F));
            tableLayoutPanel1.Size = new Size(834, 547);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 571);
            Controls.Add(tableLayoutPanel1);
            Name = "MainView";
            Text = "Hardkorowy Kodsu";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)TableNamesGrid).EndInit();
            TableNamesPanel.ResumeLayout(false);
            TableNamesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TableColumnsGrid).EndInit();
            TableDataSplitContainer.Panel1.ResumeLayout(false);
            TableDataSplitContainer.Panel1.PerformLayout();
            TableDataSplitContainer.Panel2.ResumeLayout(false);
            TableDataSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TableDataSplitContainer).EndInit();
            TableDataSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TableDetailsGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TableNamesGrid;
        private Panel TableNamesPanel;
        private DataGridView TableColumnsGrid;
        private TextBox TableDataGridSearchBox;
        private SplitContainer TableDataSplitContainer;
        private DataGridView TableDetailsGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private Label TablesAndViewsLabel;
        private Button TableNamesGridRefreshButton;
        private Label SelectedTableViewDetailsLabel;
        private Label SelectedTableViewColumnsLabel;
    }
}

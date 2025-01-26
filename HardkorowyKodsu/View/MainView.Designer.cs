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
            TableNamesGridSearchBox = new TextBox();
            TableColumnsGrid = new DataGridView();
            TableDataGridSearchBox = new TextBox();
            TableDataSplitContainer = new SplitContainer();
            TableDetailsGrid = new DataGridView();
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
            TableNamesGrid.AllowUserToOrderColumns = true;
            TableNamesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableNamesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableNamesGrid.Location = new Point(0, 35);
            TableNamesGrid.Name = "TableNamesGrid";
            TableNamesGrid.Size = new Size(407, 503);
            TableNamesGrid.TabIndex = 0;
            TableNamesGrid.SelectionChanged += TableNamesGrid_SelectionChanged;
            // 
            // TableNamesPanel
            // 
            TableNamesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableNamesPanel.Controls.Add(TableNamesGridSearchBox);
            TableNamesPanel.Controls.Add(TableNamesGrid);
            TableNamesPanel.Location = new Point(3, 3);
            TableNamesPanel.Name = "TableNamesPanel";
            TableNamesPanel.Size = new Size(410, 541);
            TableNamesPanel.TabIndex = 1;
            // 
            // TableNamesGridSearchBox
            // 
            TableNamesGridSearchBox.Dock = DockStyle.Top;
            TableNamesGridSearchBox.Location = new Point(0, 0);
            TableNamesGridSearchBox.Name = "TableNamesGridSearchBox";
            TableNamesGridSearchBox.Size = new Size(410, 23);
            TableNamesGridSearchBox.TabIndex = 1;
            // 
            // TableColumnsGrid
            // 
            TableColumnsGrid.AccessibleDescription = "A grid control showing data of selected view or table.";
            TableColumnsGrid.AccessibleName = "Data View Grid";
            TableColumnsGrid.AllowUserToOrderColumns = true;
            TableColumnsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableColumnsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableColumnsGrid.Location = new Point(3, 29);
            TableColumnsGrid.Name = "TableColumnsGrid";
            TableColumnsGrid.Size = new Size(405, 225);
            TableColumnsGrid.TabIndex = 0;
            // 
            // TableDataGridSearchBox
            // 
            TableDataGridSearchBox.Dock = DockStyle.Top;
            TableDataGridSearchBox.Location = new Point(0, 0);
            TableDataGridSearchBox.Name = "TableDataGridSearchBox";
            TableDataGridSearchBox.Size = new Size(412, 23);
            TableDataGridSearchBox.TabIndex = 1;
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
            TableDataSplitContainer.Panel1.Controls.Add(TableDetailsGrid);
            // 
            // TableDataSplitContainer.Panel2
            // 
            TableDataSplitContainer.Panel2.Controls.Add(TableDataGridSearchBox);
            TableDataSplitContainer.Panel2.Controls.Add(TableColumnsGrid);
            TableDataSplitContainer.Size = new Size(412, 541);
            TableDataSplitContainer.SplitterDistance = 280;
            TableDataSplitContainer.TabIndex = 2;
            // 
            // TableDetailsGrid
            // 
            TableDetailsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDetailsGrid.Dock = DockStyle.Fill;
            TableDetailsGrid.Location = new Point(0, 0);
            TableDetailsGrid.Name = "TableDetailsGrid";
            TableDetailsGrid.Size = new Size(412, 280);
            TableDetailsGrid.TabIndex = 0;
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
        private TextBox TableNamesGridSearchBox;
        private DataGridView TableColumnsGrid;
        private TextBox TableDataGridSearchBox;
        private SplitContainer TableDataSplitContainer;
        private DataGridView TableDetailsGrid;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

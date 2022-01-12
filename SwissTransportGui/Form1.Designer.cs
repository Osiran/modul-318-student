using System.Windows.Forms;

namespace SwissTransportGui
{
    partial class Form1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.fromStation = new System.Windows.Forms.TextBox();
            this.toStation = new System.Windows.Forms.TextBox();
            this.tableConnections = new System.Windows.Forms.DataGridView();
            this.stationName = new System.Windows.Forms.TextBox();
            this.trainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(292, 60);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Suche";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fromStation
            // 
            this.fromStation.Location = new System.Drawing.Point(130, 83);
            this.fromStation.Name = "fromStation";
            this.fromStation.Size = new System.Drawing.Size(100, 23);
            this.fromStation.TabIndex = 1;
            // 
            // toStation
            // 
            this.toStation.Location = new System.Drawing.Point(407, 83);
            this.toStation.Name = "toStation";
            this.toStation.Size = new System.Drawing.Size(100, 23);
            this.toStation.TabIndex = 2;
            // 
            // tableConnections
            // 
            this.tableConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainName,
            this.Category,
            this.Number,
            this.Operator,
            this.To,
            this.Stop});
            this.tableConnections.Location = new System.Drawing.Point(52, 213);
            this.tableConnections.Name = "tableConnections";
            this.tableConnections.RowTemplate.Height = 25;
            this.tableConnections.Size = new System.Drawing.Size(663, 195);
            this.tableConnections.TabIndex = 3;
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(52, 184);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(100, 23);
            this.stationName.TabIndex = 4;
            // 
            // trainName
            // 
            this.trainName.DataPropertyName = "Name";
            this.trainName.HeaderText = "Zugname";
            this.trainName.Name = "trainName";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Zug Typ";
            this.Category.Name = "Category";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Zugnummer";
            this.Number.Name = "Number";
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "Firma";
            this.Operator.Name = "Operator";
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "Nach";
            this.To.Name = "To";
            // 
            // Stop
            // 
            this.Stop.DataPropertyName = "Stop";
            this.Stop.HeaderText = "Ankunftszeit";
            this.Stop.Name = "Stop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.tableConnections);
            this.Controls.Add(this.toStation);
            this.Controls.Add(this.fromStation);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchButton;
        private TextBox fromStation;
        private TextBox toStation;
        private DataGridView tableConnections;
        private TextBox stationName;
        private DataGridViewTextBoxColumn trainName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Operator;
        private DataGridViewTextBoxColumn To;
        private DataGridViewTextBoxColumn Stop;
    }
}
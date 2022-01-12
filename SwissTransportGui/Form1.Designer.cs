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
            this.arrivalName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(364, 95);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(171, 31);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Suche";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fromStation
            // 
            this.fromStation.Location = new System.Drawing.Point(235, 146);
            this.fromStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromStation.Name = "fromStation";
            this.fromStation.Size = new System.Drawing.Size(114, 27);
            this.fromStation.TabIndex = 1;
            // 
            // toStation
            // 
            this.toStation.Location = new System.Drawing.Point(549, 146);
            this.toStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toStation.Name = "toStation";
            this.toStation.Size = new System.Drawing.Size(114, 27);
            this.toStation.TabIndex = 2;
            // 
            // tableConnections
            // 
            this.tableConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableConnections.Location = new System.Drawing.Point(12, 284);
            this.tableConnections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableConnections.Name = "tableConnections";
            this.tableConnections.RowHeadersWidth = 51;
            this.tableConnections.RowTemplate.Height = 25;
            this.tableConnections.Size = new System.Drawing.Size(890, 303);
            this.tableConnections.TabIndex = 3;
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(12, 245);
            this.stationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(218, 27);
            this.stationName.TabIndex = 4;
            // 
            // arrivalName
            // 
            this.arrivalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalName.Location = new System.Drawing.Point(684, 245);
            this.arrivalName.Name = "arrivalName";
            this.arrivalName.Size = new System.Drawing.Size(218, 27);
            this.arrivalName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.arrivalName);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.tableConnections);
            this.Controls.Add(this.toStation);
            this.Controls.Add(this.fromStation);
            this.Controls.Add(this.searchButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private TextBox arrivalName;
    }
}
﻿
namespace GraphMaker
{
    partial class FormGraphMaker
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
            this.groupBoxInputs = new System.Windows.Forms.GroupBox();
            this.buttonCreateGraph = new System.Windows.Forms.Button();
            this.textBoxYAxisName = new System.Windows.Forms.TextBox();
            this.labelYAxisName = new System.Windows.Forms.Label();
            this.textBoxXAxisName = new System.Windows.Forms.TextBox();
            this.labelXAxisName = new System.Windows.Forms.Label();
            this.textBoxGraphTitle = new System.Windows.Forms.TextBox();
            this.labelGraphTitle = new System.Windows.Forms.Label();
            this.textBoxCategories = new System.Windows.Forms.TextBox();
            this.labelCategories = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.groupBoxDataRepresentation = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.labelXAxisLabel = new System.Windows.Forms.Label();
            this.labelYAxisLabel = new System.Windows.Forms.Label();
            this.labelChartTitleLabel = new System.Windows.Forms.Label();
            this.groupBoxInputs.SuspendLayout();
            this.groupBoxDataRepresentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputs
            // 
            this.groupBoxInputs.Controls.Add(this.buttonCreateGraph);
            this.groupBoxInputs.Controls.Add(this.textBoxYAxisName);
            this.groupBoxInputs.Controls.Add(this.labelYAxisName);
            this.groupBoxInputs.Controls.Add(this.textBoxXAxisName);
            this.groupBoxInputs.Controls.Add(this.labelXAxisName);
            this.groupBoxInputs.Controls.Add(this.textBoxGraphTitle);
            this.groupBoxInputs.Controls.Add(this.labelGraphTitle);
            this.groupBoxInputs.Controls.Add(this.textBoxCategories);
            this.groupBoxInputs.Controls.Add(this.labelCategories);
            this.groupBoxInputs.Controls.Add(this.textBoxData);
            this.groupBoxInputs.Controls.Add(this.labelData);
            this.groupBoxInputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInputs.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInputs.Name = "groupBoxInputs";
            this.groupBoxInputs.Size = new System.Drawing.Size(319, 457);
            this.groupBoxInputs.TabIndex = 0;
            this.groupBoxInputs.TabStop = false;
            this.groupBoxInputs.Text = "User Input";
            // 
            // buttonCreateGraph
            // 
            this.buttonCreateGraph.Location = new System.Drawing.Point(114, 415);
            this.buttonCreateGraph.Name = "buttonCreateGraph";
            this.buttonCreateGraph.Size = new System.Drawing.Size(105, 23);
            this.buttonCreateGraph.TabIndex = 10;
            this.buttonCreateGraph.Text = "Create Graph";
            this.buttonCreateGraph.UseVisualStyleBackColor = true;
            this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
            // 
            // textBoxYAxisName
            // 
            this.textBoxYAxisName.Location = new System.Drawing.Point(6, 342);
            this.textBoxYAxisName.Name = "textBoxYAxisName";
            this.textBoxYAxisName.Size = new System.Drawing.Size(307, 20);
            this.textBoxYAxisName.TabIndex = 9;
            // 
            // labelYAxisName
            // 
            this.labelYAxisName.AutoSize = true;
            this.labelYAxisName.Location = new System.Drawing.Point(6, 326);
            this.labelYAxisName.Name = "labelYAxisName";
            this.labelYAxisName.Size = new System.Drawing.Size(134, 13);
            this.labelYAxisName.TabIndex = 8;
            this.labelYAxisName.Text = "Enter the Y variable Name:";
            // 
            // textBoxXAxisName
            // 
            this.textBoxXAxisName.Location = new System.Drawing.Point(6, 297);
            this.textBoxXAxisName.Name = "textBoxXAxisName";
            this.textBoxXAxisName.Size = new System.Drawing.Size(307, 20);
            this.textBoxXAxisName.TabIndex = 7;
            // 
            // labelXAxisName
            // 
            this.labelXAxisName.AutoSize = true;
            this.labelXAxisName.Location = new System.Drawing.Point(6, 275);
            this.labelXAxisName.Name = "labelXAxisName";
            this.labelXAxisName.Size = new System.Drawing.Size(134, 13);
            this.labelXAxisName.TabIndex = 6;
            this.labelXAxisName.Text = "Enter the X variable Name:";
            // 
            // textBoxGraphTitle
            // 
            this.textBoxGraphTitle.Location = new System.Drawing.Point(6, 246);
            this.textBoxGraphTitle.Name = "textBoxGraphTitle";
            this.textBoxGraphTitle.Size = new System.Drawing.Size(307, 20);
            this.textBoxGraphTitle.TabIndex = 5;
            // 
            // labelGraphTitle
            // 
            this.labelGraphTitle.AutoSize = true;
            this.labelGraphTitle.Location = new System.Drawing.Point(6, 224);
            this.labelGraphTitle.Name = "labelGraphTitle";
            this.labelGraphTitle.Size = new System.Drawing.Size(102, 13);
            this.labelGraphTitle.TabIndex = 4;
            this.labelGraphTitle.Text = "Enter the graph title:";
            // 
            // textBoxCategories
            // 
            this.textBoxCategories.Location = new System.Drawing.Point(6, 149);
            this.textBoxCategories.Multiline = true;
            this.textBoxCategories.Name = "textBoxCategories";
            this.textBoxCategories.Size = new System.Drawing.Size(307, 66);
            this.textBoxCategories.TabIndex = 3;
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Location = new System.Drawing.Point(6, 127);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(278, 13);
            this.labelCategories.TabIndex = 2;
            this.labelCategories.Text = "Enter the associated category names (comma separated):";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(6, 52);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(307, 66);
            this.textBoxData.TabIndex = 1;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(6, 30);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(283, 13);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Enter the data within the box (Comma or space separated):";
            // 
            // groupBoxDataRepresentation
            // 
            this.groupBoxDataRepresentation.Controls.Add(this.labelChartTitleLabel);
            this.groupBoxDataRepresentation.Controls.Add(this.labelYAxisLabel);
            this.groupBoxDataRepresentation.Controls.Add(this.labelXAxisLabel);
            this.groupBoxDataRepresentation.Controls.Add(this.pictureBox1);
            this.groupBoxDataRepresentation.Controls.Add(this.dataGridViewData);
            this.groupBoxDataRepresentation.Location = new System.Drawing.Point(325, 0);
            this.groupBoxDataRepresentation.Name = "groupBoxDataRepresentation";
            this.groupBoxDataRepresentation.Size = new System.Drawing.Size(463, 450);
            this.groupBoxDataRepresentation.TabIndex = 1;
            this.groupBoxDataRepresentation.TabStop = false;
            this.groupBoxDataRepresentation.Text = "Data Output";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 276);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(451, 107);
            this.dataGridViewData.TabIndex = 0;
            // 
            // labelXAxisLabel
            // 
            this.labelXAxisLabel.AutoSize = true;
            this.labelXAxisLabel.Location = new System.Drawing.Point(393, 428);
            this.labelXAxisLabel.Name = "labelXAxisLabel";
            this.labelXAxisLabel.Size = new System.Drawing.Size(35, 13);
            this.labelXAxisLabel.TabIndex = 2;
            this.labelXAxisLabel.Text = "label1";
            // 
            // labelYAxisLabel
            // 
            this.labelYAxisLabel.AutoSize = true;
            this.labelYAxisLabel.Location = new System.Drawing.Point(6, 133);
            this.labelYAxisLabel.Name = "labelYAxisLabel";
            this.labelYAxisLabel.Size = new System.Drawing.Size(35, 13);
            this.labelYAxisLabel.TabIndex = 3;
            this.labelYAxisLabel.Text = "label2";
            // 
            // labelChartTitleLabel
            // 
            this.labelChartTitleLabel.AutoSize = true;
            this.labelChartTitleLabel.Location = new System.Drawing.Point(218, 133);
            this.labelChartTitleLabel.Name = "labelChartTitleLabel";
            this.labelChartTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.labelChartTitleLabel.TabIndex = 4;
            this.labelChartTitleLabel.Text = "label3";
            // 
            // FormGraphMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.groupBoxDataRepresentation);
            this.Controls.Add(this.groupBoxInputs);
            this.Name = "FormGraphMaker";
            this.Text = "Graph Maker";
            this.groupBoxInputs.ResumeLayout(false);
            this.groupBoxInputs.PerformLayout();
            this.groupBoxDataRepresentation.ResumeLayout(false);
            this.groupBoxDataRepresentation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxCategories;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Button buttonCreateGraph;
        private System.Windows.Forms.TextBox textBoxYAxisName;
        private System.Windows.Forms.Label labelYAxisName;
        private System.Windows.Forms.TextBox textBoxXAxisName;
        private System.Windows.Forms.Label labelXAxisName;
        private System.Windows.Forms.TextBox textBoxGraphTitle;
        private System.Windows.Forms.Label labelGraphTitle;
        private System.Windows.Forms.GroupBox groupBoxDataRepresentation;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelChartTitleLabel;
        private System.Windows.Forms.Label labelYAxisLabel;
        private System.Windows.Forms.Label labelXAxisLabel;
    }
}


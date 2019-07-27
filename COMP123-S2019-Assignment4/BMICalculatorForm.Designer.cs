namespace COMP123_S2019_Assignment4
{
    partial class BMICalculatorForm
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
            this.InputTabelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.UnitGroupBox = new System.Windows.Forms.GroupBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMIDisplayTextBox = new System.Windows.Forms.TextBox();
            this.BMIDisplayLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.InputTabelLayoutPanel.SuspendLayout();
            this.UnitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTabelLayoutPanel
            // 
            this.InputTabelLayoutPanel.ColumnCount = 2;
            this.InputTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputTabelLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
            this.InputTabelLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.InputTabelLayoutPanel.Controls.Add(this.UnitLabel, 0, 0);
            this.InputTabelLayoutPanel.Controls.Add(this.UnitGroupBox, 1, 0);
            this.InputTabelLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.InputTabelLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
            this.InputTabelLayoutPanel.Location = new System.Drawing.Point(13, 69);
            this.InputTabelLayoutPanel.Name = "InputTabelLayoutPanel";
            this.InputTabelLayoutPanel.RowCount = 3;
            this.InputTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.09392F));
            this.InputTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.49171F));
            this.InputTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.41437F));
            this.InputTabelLayoutPanel.Size = new System.Drawing.Size(279, 183);
            this.InputTabelLayoutPanel.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(142, 140);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(134, 38);
            this.WeightTextBox.TabIndex = 4;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 135);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(133, 48);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitLabel
            // 
            this.UnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitLabel.Location = new System.Drawing.Point(3, 0);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(133, 78);
            this.UnitLabel.TabIndex = 0;
            this.UnitLabel.Text = "Choose your units:";
            this.UnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitGroupBox
            // 
            this.UnitGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitGroupBox.Location = new System.Drawing.Point(142, 3);
            this.UnitGroupBox.Name = "UnitGroupBox";
            this.UnitGroupBox.Size = new System.Drawing.Size(134, 72);
            this.UnitGroupBox.TabIndex = 1;
            this.UnitGroupBox.TabStop = false;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(0, 43);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(83, 29);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(0, 18);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(98, 29);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 78);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(133, 57);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(142, 87);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(134, 38);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // CalculatorLabel
            // 
            this.CalculatorLabel.AutoSize = true;
            this.CalculatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorLabel.Location = new System.Drawing.Point(37, 19);
            this.CalculatorLabel.Name = "CalculatorLabel";
            this.CalculatorLabel.Size = new System.Drawing.Size(226, 37);
            this.CalculatorLabel.TabIndex = 1;
            this.CalculatorLabel.Text = "BMI Calculator";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(13, 259);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(279, 40);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate your BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BMIDisplayTextBox
            // 
            this.BMIDisplayTextBox.Enabled = false;
            this.BMIDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BMIDisplayTextBox.Location = new System.Drawing.Point(121, 316);
            this.BMIDisplayTextBox.Multiline = true;
            this.BMIDisplayTextBox.Name = "BMIDisplayTextBox";
            this.BMIDisplayTextBox.Size = new System.Drawing.Size(168, 60);
            this.BMIDisplayTextBox.TabIndex = 4;
            // 
            // BMIDisplayLabel
            // 
            this.BMIDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIDisplayLabel.AutoSize = true;
            this.BMIDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BMIDisplayLabel.Location = new System.Drawing.Point(12, 336);
            this.BMIDisplayLabel.Name = "BMIDisplayLabel";
            this.BMIDisplayLabel.Size = new System.Drawing.Size(99, 25);
            this.BMIDisplayLabel.TabIndex = 5;
            this.BMIDisplayLabel.Text = "Your BMI:";
            this.BMIDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 382);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(98, 47);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BMIDisplayLabel);
            this.Controls.Add(this.BMIDisplayTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CalculatorLabel);
            this.Controls.Add(this.InputTabelLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculatorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.InputTabelLayoutPanel.ResumeLayout(false);
            this.InputTabelLayoutPanel.PerformLayout();
            this.UnitGroupBox.ResumeLayout(false);
            this.UnitGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel InputTabelLayoutPanel;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Label CalculatorLabel;
        private System.Windows.Forms.GroupBox UnitGroupBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BMIDisplayTextBox;
        private System.Windows.Forms.Label BMIDisplayLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}


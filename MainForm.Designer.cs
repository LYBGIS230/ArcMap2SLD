﻿namespace ArcGIS_SLD_Converter
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtXsdFilePath = new System.Windows.Forms.TextBox();
            this.chkValidate = new System.Windows.Forms.CheckBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtSLDSavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSaveSingleFile = new System.Windows.Forms.CheckBox();
            this.rbVisibleLayer = new System.Windows.Forms.RadioButton();
            this.rbAllLayer = new System.Windows.Forms.RadioButton();
            this.cbIncludeLayerName = new System.Windows.Forms.CheckBox();
            this.btStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtXsdFilePath);
            this.groupBox1.Controls.Add(this.chkValidate);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Controls.Add(this.txtSLDSavePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(756, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本设置";
            // 
            // txtXsdFilePath
            // 
            this.txtXsdFilePath.Location = new System.Drawing.Point(155, 87);
            this.txtXsdFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtXsdFilePath.Name = "txtXsdFilePath";
            this.txtXsdFilePath.ReadOnly = true;
            this.txtXsdFilePath.Size = new System.Drawing.Size(484, 22);
            this.txtXsdFilePath.TabIndex = 5;
            this.txtXsdFilePath.Visible = false;
            // 
            // chkValidate
            // 
            this.chkValidate.AutoSize = true;
            this.chkValidate.Location = new System.Drawing.Point(11, 89);
            this.chkValidate.Margin = new System.Windows.Forms.Padding(4);
            this.chkValidate.Name = "chkValidate";
            this.chkValidate.Size = new System.Drawing.Size(127, 21);
            this.chkValidate.TabIndex = 4;
            this.chkValidate.Text = "SLD自定义文件";
            this.chkValidate.UseVisualStyleBackColor = true;
            this.chkValidate.CheckedChanged += new System.EventHandler(this.chkValidate_CheckedChanged);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(648, 32);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 31);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "...";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtSLDSavePath
            // 
            this.txtSLDSavePath.Location = new System.Drawing.Point(155, 35);
            this.txtSLDSavePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLDSavePath.Name = "txtSLDSavePath";
            this.txtSLDSavePath.ReadOnly = true;
            this.txtSLDSavePath.Size = new System.Drawing.Size(484, 22);
            this.txtSLDSavePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SLD保存路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSaveSingleFile);
            this.groupBox2.Controls.Add(this.rbVisibleLayer);
            this.groupBox2.Controls.Add(this.rbAllLayer);
            this.groupBox2.Controls.Add(this.cbIncludeLayerName);
            this.groupBox2.Location = new System.Drawing.Point(16, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(756, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "转换图层设置";
            // 
            // cbSaveSingleFile
            // 
            this.cbSaveSingleFile.AutoSize = true;
            this.cbSaveSingleFile.Location = new System.Drawing.Point(284, 27);
            this.cbSaveSingleFile.Margin = new System.Windows.Forms.Padding(4);
            this.cbSaveSingleFile.Name = "cbSaveSingleFile";
            this.cbSaveSingleFile.Size = new System.Drawing.Size(113, 21);
            this.cbSaveSingleFile.TabIndex = 8;
            this.cbSaveSingleFile.Text = "单个SLD文件";
            this.cbSaveSingleFile.UseVisualStyleBackColor = true;
            this.cbSaveSingleFile.CheckedChanged += new System.EventHandler(this.cbSaveSingleFile_CheckedChanged);
            // 
            // rbVisibleLayer
            // 
            this.rbVisibleLayer.AutoSize = true;
            this.rbVisibleLayer.Location = new System.Drawing.Point(284, 89);
            this.rbVisibleLayer.Margin = new System.Windows.Forms.Padding(4);
            this.rbVisibleLayer.Name = "rbVisibleLayer";
            this.rbVisibleLayer.Size = new System.Drawing.Size(85, 21);
            this.rbVisibleLayer.TabIndex = 7;
            this.rbVisibleLayer.Text = "可视图层";
            this.rbVisibleLayer.UseVisualStyleBackColor = true;
            this.rbVisibleLayer.CheckedChanged += new System.EventHandler(this.rbVisibleLayer_CheckedChanged);
            // 
            // rbAllLayer
            // 
            this.rbAllLayer.AutoSize = true;
            this.rbAllLayer.Checked = true;
            this.rbAllLayer.Location = new System.Drawing.Point(8, 89);
            this.rbAllLayer.Margin = new System.Windows.Forms.Padding(4);
            this.rbAllLayer.Name = "rbAllLayer";
            this.rbAllLayer.Size = new System.Drawing.Size(85, 21);
            this.rbAllLayer.TabIndex = 6;
            this.rbAllLayer.TabStop = true;
            this.rbAllLayer.Text = "所有图层";
            this.rbAllLayer.UseVisualStyleBackColor = true;
            this.rbAllLayer.CheckedChanged += new System.EventHandler(this.rbAllLayer_CheckedChanged);
            // 
            // cbIncludeLayerName
            // 
            this.cbIncludeLayerName.AutoSize = true;
            this.cbIncludeLayerName.Checked = true;
            this.cbIncludeLayerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeLayerName.Location = new System.Drawing.Point(11, 27);
            this.cbIncludeLayerName.Margin = new System.Windows.Forms.Padding(4);
            this.cbIncludeLayerName.Name = "cbIncludeLayerName";
            this.cbIncludeLayerName.Size = new System.Drawing.Size(100, 21);
            this.cbIncludeLayerName.TabIndex = 5;
            this.cbIncludeLayerName.Text = "包含图层名";
            this.cbIncludeLayerName.UseVisualStyleBackColor = true;
            this.cbIncludeLayerName.CheckedChanged += new System.EventHandler(this.cbIncludeLayerName_CheckedChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(672, 580);
            this.btStart.Margin = new System.Windows.Forms.Padding(4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(100, 31);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "开始转换";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Location = new System.Drawing.Point(16, 396);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(756, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息显示";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(11, 22);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(737, 135);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MXD转换SLD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtSLDSavePath;
        private System.Windows.Forms.TextBox txtXsdFilePath;
        private System.Windows.Forms.CheckBox chkValidate;
        private System.Windows.Forms.CheckBox cbIncludeLayerName;
        private System.Windows.Forms.CheckBox cbSaveSingleFile;
        private System.Windows.Forms.RadioButton rbVisibleLayer;
        private System.Windows.Forms.RadioButton rbAllLayer;
        private System.Windows.Forms.RichTextBox txtMessage;
    }
}
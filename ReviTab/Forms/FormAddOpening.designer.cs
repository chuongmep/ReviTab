﻿/*
 * Created by SharpDevelop.
 * User: Giovanni.Brogiolo
 * Date: 26/10/2018
 * Time: 2:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ReviTab
{
    partial class FormAddOpening
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.ok_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.checkBoxEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxMidPoint = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(38, 207);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(90, 29);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseCompatibleTextRendering = true;
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.Ok_btnClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Offset";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(13, 29);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(261, 21);
            this.comboBoxCategory.Sorted = true;
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategorySelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Opening Family";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(157, 207);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 29);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseCompatibleTextRendering = true;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(12, 74);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 7;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(173, 74);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.Location = new System.Drawing.Point(12, 105);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(104, 24);
            this.checkBoxStart.TabIndex = 11;
            this.checkBoxStart.Text = "Start Point";
            this.checkBoxStart.UseCompatibleTextRendering = true;
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.Click += new System.EventHandler(this.CheckBoxStart_Click);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.Location = new System.Drawing.Point(205, 105);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(104, 24);
            this.checkBoxEnd.TabIndex = 12;
            this.checkBoxEnd.Text = "End Point";
            this.checkBoxEnd.UseCompatibleTextRendering = true;
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            this.checkBoxEnd.Click += new System.EventHandler(this.CheckBoxEnd_Click);

            // 
            // checkBoxMidPoint
            // 
            this.checkBoxMidPoint.Checked = true;
            this.checkBoxMidPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidPoint.Location = new System.Drawing.Point(105, 105);
            this.checkBoxMidPoint.Name = "checkBoxMidPoint";
            this.checkBoxMidPoint.Size = new System.Drawing.Size(73, 24);
            this.checkBoxMidPoint.TabIndex = 13;
            this.checkBoxMidPoint.Text = "Mid Point";
            this.checkBoxMidPoint.UseCompatibleTextRendering = true;
            this.checkBoxMidPoint.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 248);
            this.Controls.Add(this.checkBoxMidPoint);
            this.Controls.Add(this.checkBoxEnd);
            this.Controls.Add(this.checkBoxStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ok_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Instance By Face";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.CheckBox checkBoxMidPoint;
        private System.Windows.Forms.CheckBox checkBoxEnd;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ok_btn;


    }
}
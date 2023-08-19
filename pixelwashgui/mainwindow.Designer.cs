﻿namespace pixelwashgui
{
    partial class mainwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.openfile = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.lengthtrack = new System.Windows.Forms.TrackBar();
            this.randomnesstrack = new System.Windows.Forms.TrackBar();
            this.randomness = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.randomnessvalue = new System.Windows.Forms.TextBox();
            this.lengthvalue = new System.Windows.Forms.TextBox();
            this.anglevalue = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.angletrack = new System.Windows.Forms.TrackBar();
            this.executebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.sortingvalue = new System.Windows.Forms.TextBox();
            this.sorting = new System.Windows.Forms.TextBox();
            this.sortingtrack = new System.Windows.Forms.TrackBar();
            this.functionvalue = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.TextBox();
            this.functiontrack = new System.Windows.Forms.TrackBar();
            this.staticpic = new System.Windows.Forms.PictureBox();
            this.preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthtrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomnesstrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortingtrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functiontrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.openfile.ForeColor = System.Drawing.Color.White;
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 1;
            this.openfile.Text = "open file";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openfile_MouseClick);
            // 
            // savefile
            // 
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.savefile.ForeColor = System.Drawing.Color.White;
            this.savefile.Location = new System.Drawing.Point(93, 12);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(75, 23);
            this.savefile.TabIndex = 2;
            this.savefile.Text = "save file";
            this.savefile.UseVisualStyleBackColor = false;
            this.savefile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savefile_MouseClick);
            // 
            // lengthtrack
            // 
            this.lengthtrack.Location = new System.Drawing.Point(12, 130);
            this.lengthtrack.Maximum = 500;
            this.lengthtrack.Name = "lengthtrack";
            this.lengthtrack.Size = new System.Drawing.Size(156, 45);
            this.lengthtrack.SmallChange = 50;
            this.lengthtrack.TabIndex = 3;
            this.lengthtrack.TickFrequency = 50;
            this.lengthtrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.lengthtrack.ValueChanged += new System.EventHandler(this.lengthtrack_ValueChanged);
            // 
            // randomnesstrack
            // 
            this.randomnesstrack.Location = new System.Drawing.Point(12, 60);
            this.randomnesstrack.Maximum = 100;
            this.randomnesstrack.Name = "randomnesstrack";
            this.randomnesstrack.Size = new System.Drawing.Size(156, 45);
            this.randomnesstrack.SmallChange = 10;
            this.randomnesstrack.TabIndex = 4;
            this.randomnesstrack.TickFrequency = 10;
            this.randomnesstrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.randomnesstrack.ValueChanged += new System.EventHandler(this.randomnesstrack_ValueChanged);
            // 
            // randomness
            // 
            this.randomness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.randomness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randomness.ForeColor = System.Drawing.Color.White;
            this.randomness.Location = new System.Drawing.Point(12, 41);
            this.randomness.Name = "randomness";
            this.randomness.Size = new System.Drawing.Size(75, 13);
            this.randomness.TabIndex = 5;
            this.randomness.Text = "randomness";
            this.randomness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // length
            // 
            this.length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.length.ForeColor = System.Drawing.Color.White;
            this.length.Location = new System.Drawing.Point(12, 111);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(75, 13);
            this.length.TabIndex = 6;
            this.length.Text = "length";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // randomnessvalue
            // 
            this.randomnessvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.randomnessvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randomnessvalue.ForeColor = System.Drawing.Color.White;
            this.randomnessvalue.Location = new System.Drawing.Point(93, 41);
            this.randomnessvalue.Name = "randomnessvalue";
            this.randomnessvalue.Size = new System.Drawing.Size(75, 13);
            this.randomnessvalue.TabIndex = 7;
            this.randomnessvalue.Text = "0";
            this.randomnessvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lengthvalue
            // 
            this.lengthvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.lengthvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthvalue.ForeColor = System.Drawing.Color.White;
            this.lengthvalue.Location = new System.Drawing.Point(93, 111);
            this.lengthvalue.Name = "lengthvalue";
            this.lengthvalue.Size = new System.Drawing.Size(75, 13);
            this.lengthvalue.TabIndex = 8;
            this.lengthvalue.Text = "0";
            this.lengthvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anglevalue
            // 
            this.anglevalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.anglevalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anglevalue.ForeColor = System.Drawing.Color.White;
            this.anglevalue.Location = new System.Drawing.Point(93, 181);
            this.anglevalue.Name = "anglevalue";
            this.anglevalue.Size = new System.Drawing.Size(75, 13);
            this.anglevalue.TabIndex = 11;
            this.anglevalue.Text = "0";
            this.anglevalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angle
            // 
            this.angle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.angle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.angle.ForeColor = System.Drawing.Color.White;
            this.angle.Location = new System.Drawing.Point(12, 181);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(75, 13);
            this.angle.TabIndex = 10;
            this.angle.Text = "angle";
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angletrack
            // 
            this.angletrack.Location = new System.Drawing.Point(12, 200);
            this.angletrack.Maximum = 359;
            this.angletrack.Name = "angletrack";
            this.angletrack.Size = new System.Drawing.Size(156, 45);
            this.angletrack.SmallChange = 15;
            this.angletrack.TabIndex = 9;
            this.angletrack.TickFrequency = 45;
            this.angletrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.angletrack.ValueChanged += new System.EventHandler(this.angletrack_ValueChanged);
            // 
            // executebutton
            // 
            this.executebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.executebutton.ForeColor = System.Drawing.Color.White;
            this.executebutton.Location = new System.Drawing.Point(12, 391);
            this.executebutton.Name = "executebutton";
            this.executebutton.Size = new System.Drawing.Size(75, 23);
            this.executebutton.TabIndex = 12;
            this.executebutton.Text = "execute";
            this.executebutton.UseVisualStyleBackColor = false;
            this.executebutton.Click += new System.EventHandler(this.executebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.updatebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updatebutton.Location = new System.Drawing.Point(93, 391);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 13;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // sortingvalue
            // 
            this.sortingvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.sortingvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sortingvalue.ForeColor = System.Drawing.Color.White;
            this.sortingvalue.Location = new System.Drawing.Point(93, 251);
            this.sortingvalue.Name = "sortingvalue";
            this.sortingvalue.Size = new System.Drawing.Size(75, 13);
            this.sortingvalue.TabIndex = 16;
            this.sortingvalue.Text = "hue";
            this.sortingvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sorting
            // 
            this.sorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.sorting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sorting.ForeColor = System.Drawing.Color.White;
            this.sorting.Location = new System.Drawing.Point(12, 251);
            this.sorting.Name = "sorting";
            this.sorting.Size = new System.Drawing.Size(75, 13);
            this.sorting.TabIndex = 15;
            this.sorting.Text = "sorting";
            this.sorting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sortingtrack
            // 
            this.sortingtrack.Location = new System.Drawing.Point(12, 270);
            this.sortingtrack.Maximum = 5;
            this.sortingtrack.Minimum = 1;
            this.sortingtrack.Name = "sortingtrack";
            this.sortingtrack.Size = new System.Drawing.Size(156, 45);
            this.sortingtrack.SmallChange = 15;
            this.sortingtrack.TabIndex = 14;
            this.sortingtrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sortingtrack.Value = 1;
            this.sortingtrack.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // functionvalue
            // 
            this.functionvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.functionvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.functionvalue.ForeColor = System.Drawing.Color.White;
            this.functionvalue.Location = new System.Drawing.Point(93, 321);
            this.functionvalue.Name = "functionvalue";
            this.functionvalue.Size = new System.Drawing.Size(75, 13);
            this.functionvalue.TabIndex = 19;
            this.functionvalue.Text = "random";
            this.functionvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // function
            // 
            this.function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.function.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.function.ForeColor = System.Drawing.Color.White;
            this.function.Location = new System.Drawing.Point(12, 321);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(75, 13);
            this.function.TabIndex = 18;
            this.function.Text = "function";
            this.function.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // functiontrack
            // 
            this.functiontrack.Location = new System.Drawing.Point(12, 340);
            this.functiontrack.Maximum = 7;
            this.functiontrack.Minimum = 1;
            this.functiontrack.Name = "functiontrack";
            this.functiontrack.Size = new System.Drawing.Size(156, 45);
            this.functiontrack.SmallChange = 15;
            this.functiontrack.TabIndex = 17;
            this.functiontrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.functiontrack.Value = 1;
            this.functiontrack.ValueChanged += new System.EventHandler(this.functiontrack_ValueChanged);
            // 
            // staticpic
            // 
            this.staticpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.staticpic.Image = global::pixelwashgui.Properties.Resources._34042825;
            this.staticpic.Location = new System.Drawing.Point(12, 420);
            this.staticpic.Name = "staticpic";
            this.staticpic.Size = new System.Drawing.Size(156, 156);
            this.staticpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staticpic.TabIndex = 20;
            this.staticpic.TabStop = false;
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.preview.ImageLocation = "";
            this.preview.Location = new System.Drawing.Point(174, 12);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(878, 564);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1064, 588);
            this.Controls.Add(this.functionvalue);
            this.Controls.Add(this.function);
            this.Controls.Add(this.functiontrack);
            this.Controls.Add(this.sortingvalue);
            this.Controls.Add(this.sorting);
            this.Controls.Add(this.sortingtrack);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.executebutton);
            this.Controls.Add(this.anglevalue);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.angletrack);
            this.Controls.Add(this.lengthvalue);
            this.Controls.Add(this.randomnessvalue);
            this.Controls.Add(this.length);
            this.Controls.Add(this.randomness);
            this.Controls.Add(this.randomnesstrack);
            this.Controls.Add(this.lengthtrack);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.staticpic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainwindow";
            this.Text = "pixelwash";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthtrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomnesstrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortingtrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functiontrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.TrackBar lengthtrack;
        private System.Windows.Forms.TrackBar randomnesstrack;
        private System.Windows.Forms.TextBox randomness;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox randomnessvalue;
        private System.Windows.Forms.TextBox lengthvalue;
        private System.Windows.Forms.TextBox anglevalue;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TrackBar angletrack;
        private System.Windows.Forms.Button executebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox sortingvalue;
        private System.Windows.Forms.TextBox sorting;
        private System.Windows.Forms.TrackBar sortingtrack;
        private System.Windows.Forms.TextBox functionvalue;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TrackBar functiontrack;
        private System.Windows.Forms.PictureBox staticpic;
    }
}

